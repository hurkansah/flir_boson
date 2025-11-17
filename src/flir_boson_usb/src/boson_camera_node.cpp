#include <chrono>
#include <memory>
#include <string>

// ROS2
#include "rclcpp/rclcpp.hpp"
#include <rclcpp/qos.hpp>
#include "sensor_msgs/msg/image.hpp"
#include "sensor_msgs/msg/camera_info.hpp"
#include "camera_info_manager/camera_info_manager.hpp"
#include "cv_bridge/cv_bridge.h"
#include "sensor_msgs/image_encodings.hpp"

// OpenCV
#include <opencv2/opencv.hpp>

#include <algorithm>

// V4L2 + system headers
#include <linux/videodev2.h>
#include <sys/ioctl.h>
#include <sys/mman.h>
#include <fcntl.h>
#include <unistd.h>
#include <cerrno>
#include <cstring>

class BosonCameraNode : public rclcpp::Node
{
public:
  BosonCameraNode(const rclcpp::NodeOptions & options = rclcpp::NodeOptions())
  : Node("boson_camera", options),
    camera_info_manager_(this, "Boson640")
  {
    // --- Parameters ---
    frame_id_        = declare_parameter<std::string>("frame_id", "boson_camera");
    dev_path_        = declare_parameter<std::string>("dev", "/dev/video4");
    frame_rate_      = declare_parameter<double>("frame_rate", 30.0);
    sensor_type_str_ = declare_parameter<std::string>("sensor_type", "Boson_640");
    video_mode_str_  = declare_parameter<std::string>("video_mode", "RAW16");
    camera_info_url_ = declare_parameter<std::string>("camera_info_url", "");

    RCLCPP_INFO(get_logger(), "frame_id: %s", frame_id_.c_str());
    RCLCPP_INFO(get_logger(), "dev: %s", dev_path_.c_str());
    RCLCPP_INFO(get_logger(), "frame_rate (param): %.2f", frame_rate_);
    RCLCPP_INFO(get_logger(), "sensor_type: %s", sensor_type_str_.c_str());
    RCLCPP_INFO(get_logger(), "video_mode: %s", video_mode_str_.c_str());
    RCLCPP_INFO(get_logger(), "camera_info_url: %s", camera_info_url_.c_str());

    // --- Video mode enum ---
    if (video_mode_str_ == "YUV" || video_mode_str_ == "yuv") {
      video_mode_ = VideoMode::YUV;
      video_mode_str_ = "YUV";
    } else {
      video_mode_ = VideoMode::RAW16;
      video_mode_str_ = "RAW16";
    }

    // --- Sensor type and nominal resolution ---
    if (sensor_type_str_ == "Boson_320" || sensor_type_str_ == "boson_320") {
      width_  = 320;
      height_ = 256;
      camera_info_manager_.setCameraName("Boson320");
    } else {
      width_  = 640;
      height_ = 512;
      camera_info_manager_.setCameraName("Boson640");
    }

    // --- Load camera info if URL provided ---
    if (!camera_info_url_.empty()) {
      if (!camera_info_manager_.loadCameraInfo(camera_info_url_)) {
        RCLCPP_WARN(get_logger(), "Failed to load camera_info from URL: %s",
                    camera_info_url_.c_str());
      } else {
        RCLCPP_INFO(get_logger(), "Loaded camera_info from: %s",
                    camera_info_url_.c_str());
      }
    }

    // --- Publishers ---
    image_pub_ = this->create_publisher<sensor_msgs::msg::Image>(
    "image_raw",rclcpp::QoS(rclcpp::KeepLast(1)).reliable());
    camera_info_pub_ = create_publisher<sensor_msgs::msg::CameraInfo>(
        "/camera_info", rclcpp::SensorDataQoS());

    // --- Open camera (single V4L2 buffer like ROS1) ---
    if (!openCamera()) {
      RCLCPP_FATAL(get_logger(), "Failed to open Boson camera");
      throw std::runtime_error("BosonCameraNode::openCamera() failed");
    }

    // --- Pre-allocate image buffers ---
    if (video_mode_ == VideoMode::RAW16) {
      raw16_.create(height_, width_, CV_16UC1);

      image_msg_raw16_.header.frame_id = frame_id_;
      image_msg_raw16_.height = height_;
      image_msg_raw16_.width  = width_;
      image_msg_raw16_.encoding = sensor_msgs::image_encodings::MONO16;
      image_msg_raw16_.is_bigendian = false;
      image_msg_raw16_.step = width_ * 2;
      image_msg_raw16_.data.resize(static_cast<size_t>(width_) * height_ * 2);
    } else {
      y8_.create(height_, width_, CV_8UC1);

      image_msg_y8_.header.frame_id = frame_id_;
      image_msg_y8_.height = height_;
      image_msg_y8_.width  = width_;
      image_msg_y8_.encoding = sensor_msgs::image_encodings::MONO8;
      image_msg_y8_.is_bigendian = false;
      image_msg_y8_.step = width_;
      image_msg_y8_.data.resize(static_cast<size_t>(width_) * height_);
    }

    // --- Create timer (ROS1-style capture at frame_rate) ---
    double fr = frame_rate_;
    if (fr <= 0.0) {
      fr = 30.0;
    }
    auto period = std::chrono::duration<double>(1.0 / fr);
    capture_timer_ = this->create_wall_timer(
        std::chrono::duration_cast<std::chrono::nanoseconds>(period),
        std::bind(&BosonCameraNode::captureAndPublish, this));
  }

  ~BosonCameraNode() override
  {
    capture_timer_.reset();
    closeCamera();
  }

private:
  enum class VideoMode { RAW16, YUV };
  enum class YuvFormat { PACKED_YUYV, PLANAR_420, UNKNOWN };

  // Open V4L2 device, configure format and mmap one buffer
  bool openCamera()
  {
    // Open device
    fd_ = open(dev_path_.c_str(), O_RDWR);
    if (fd_ < 0) {
      RCLCPP_ERROR(get_logger(),
                   "OPEN error on %s: %s",
                   dev_path_.c_str(), std::strerror(errno));
      return false;
    }

    // Query capabilities
    std::memset(&cap_, 0, sizeof(cap_));
    if (ioctl(fd_, VIDIOC_QUERYCAP, &cap_) < 0) {
      RCLCPP_ERROR(get_logger(), "VIDIOC_QUERYCAP error: %s", std::strerror(errno));
      return false;
    }
    if (!(cap_.capabilities & V4L2_CAP_VIDEO_CAPTURE)) {
      RCLCPP_ERROR(get_logger(), "Device does not support video capture");
      return false;
    }
    if (!(cap_.capabilities & V4L2_CAP_STREAMING)) {
      RCLCPP_ERROR(get_logger(), "Device does not support streaming I/O");
      return false;
    }

    // Configure pixel format and resolution
    std::memset(&format_, 0, sizeof(format_));
    format_.type = V4L2_BUF_TYPE_VIDEO_CAPTURE;

    if (video_mode_ == VideoMode::RAW16) {
      format_.fmt.pix.pixelformat = V4L2_PIX_FMT_Y16;
      format_.fmt.pix.width       = width_;
      format_.fmt.pix.height      = height_;
      RCLCPP_INFO(get_logger(), "Requesting V4L2 format RAW16 (Y16)");
    } else {
      format_.fmt.pix.pixelformat = V4L2_PIX_FMT_YUYV;
      format_.fmt.pix.width       = width_;
      format_.fmt.pix.height      = height_;
      RCLCPP_INFO(get_logger(), "Requesting V4L2 format YUV (YUYV / YUV420)");
    }

    if (ioctl(fd_, VIDIOC_S_FMT, &format_) < 0) {
      RCLCPP_ERROR(get_logger(),
                   "VIDIOC_S_FMT error: %s",
                   std::strerror(errno));
      return false;
    }

    // Read back effective format
    if (ioctl(fd_, VIDIOC_G_FMT, &format_) < 0) {
      RCLCPP_WARN(get_logger(), "VIDIOC_G_FMT error: %s", std::strerror(errno));
    }

    width_  = format_.fmt.pix.width;
    height_ = format_.fmt.pix.height;
    bytes_per_line_ = format_.fmt.pix.bytesperline;
    if (bytes_per_line_ == 0) {
      if (video_mode_ == VideoMode::RAW16) {
        bytes_per_line_ = width_ * 2;
      } else {
        bytes_per_line_ = width_ * 2;
      }
    }

    pixfmt_ = format_.fmt.pix.pixelformat;

    RCLCPP_INFO(get_logger(),
                "Active V4L2 format: %dx%d, bytes_per_line=%d, pixelformat=0x%X",
                width_, height_, bytes_per_line_, pixfmt_);

    // Classify YUV format (if used)
    if (video_mode_ == VideoMode::YUV) {
      if (pixfmt_ == V4L2_PIX_FMT_YUYV || pixfmt_ == V4L2_PIX_FMT_UYVY) {
        yuv_format_ = YuvFormat::PACKED_YUYV;
        RCLCPP_INFO(get_logger(), "Detected YUV format: packed 4:2:2 (YUYV/UYVY)");
      } else if (pixfmt_ == V4L2_PIX_FMT_YUV420 ||
                 pixfmt_ == V4L2_PIX_FMT_YVU420 ||
                 pixfmt_ == V4L2_PIX_FMT_YUV420M ||
                 pixfmt_ == V4L2_PIX_FMT_YVU420M) {
        yuv_format_ = YuvFormat::PLANAR_420;
        RCLCPP_INFO(get_logger(), "Detected YUV format: planar 4:2:0 (YUV420/YVU420)");
      } else {
        yuv_format_ = YuvFormat::UNKNOWN;
        RCLCPP_WARN(get_logger(),
                    "Unknown YUV pixel format 0x%X, using best-effort Y extraction",
                    pixfmt_);
      }
    }

    // Request a single MMAP buffer (ROS1-style)
    std::memset(&reqbuf_, 0, sizeof(reqbuf_));
    reqbuf_.type   = V4L2_BUF_TYPE_VIDEO_CAPTURE;
    reqbuf_.memory = V4L2_MEMORY_MMAP;
    reqbuf_.count  = 1;

    if (ioctl(fd_, VIDIOC_REQBUFS, &reqbuf_) < 0) {
      RCLCPP_ERROR(get_logger(),
                   "VIDIOC_REQBUFS error: %s",
                   std::strerror(errno));
      return false;
    }

    // Describe the single buffer and mmap it
    std::memset(&bufferinfo_, 0, sizeof(bufferinfo_));
    bufferinfo_.type   = V4L2_BUF_TYPE_VIDEO_CAPTURE;
    bufferinfo_.memory = V4L2_MEMORY_MMAP;
    bufferinfo_.index  = 0;

    if (ioctl(fd_, VIDIOC_QUERYBUF, &bufferinfo_) < 0) {
      RCLCPP_ERROR(get_logger(),
                   "VIDIOC_QUERYBUF error: %s",
                   std::strerror(errno));
      return false;
    }

    buffer_length_ = bufferinfo_.length;
    buffer_start_ = mmap(
        nullptr,
        bufferinfo_.length,
        PROT_READ | PROT_WRITE,
        MAP_SHARED,
        fd_,
        bufferinfo_.m.offset);

    if (buffer_start_ == MAP_FAILED) {
      RCLCPP_ERROR(get_logger(), "mmap failed: %s", std::strerror(errno));
      return false;
    }

    // Optional: clear the buffer once
    std::memset(buffer_start_, 0, bufferinfo_.length);

    // Activate streaming
    int type = bufferinfo_.type;
    if (ioctl(fd_, VIDIOC_STREAMON, &type) < 0) {
      RCLCPP_ERROR(get_logger(), "VIDIOC_STREAMON error: %s", std::strerror(errno));
      return false;
    }

    RCLCPP_INFO(get_logger(),
                "Boson camera opened on %s (%dx%d, mode=%s)",
                dev_path_.c_str(), width_, height_,
                (video_mode_ == VideoMode::RAW16 ? "RAW16" : "YUV"));

    return true;
  }

  // Stop streaming and unmap buffer
  void closeCamera()
  {
    if (fd_ >= 0) {
      int type = V4L2_BUF_TYPE_VIDEO_CAPTURE;
      ioctl(fd_, VIDIOC_STREAMOFF, &type);

      if (buffer_start_ && buffer_start_ != MAP_FAILED) {
        munmap(buffer_start_, buffer_length_);
      }

      close(fd_);
      fd_ = -1;
    }
  }

  // Timer callback: queue buffer, dequeue, convert and publish
  void captureAndPublish()
  {
    if (fd_ < 0) {
      return;
    }

    // Queue the buffer
    if (ioctl(fd_, VIDIOC_QBUF, &bufferinfo_) < 0) {
      RCLCPP_ERROR(get_logger(), "VIDIOC_QBUF error: %s", std::strerror(errno));
      return;
    }

    // Dequeue the buffer (blocking until a frame is ready)
    if (ioctl(fd_, VIDIOC_DQBUF, &bufferinfo_) < 0) {
      RCLCPP_ERROR(get_logger(), "VIDIOC_DQBUF error: %s", std::strerror(errno));
      return;
    }

    rclcpp::Time stamp = get_clock()->now();
    uint8_t* src_base = static_cast<uint8_t*>(buffer_start_);

    if (video_mode_ == VideoMode::RAW16) {
      // RAW16: image is width x height x 2 bytes, tightly packed
      const size_t bytes = static_cast<size_t>(width_) * height_ * 2;

      image_msg_raw16_.header.stamp = stamp;
      image_msg_raw16_.header.frame_id = frame_id_;
      std::memcpy(image_msg_raw16_.data.data(), src_base, bytes);

      image_pub_->publish(image_msg_raw16_);

      auto ci = camera_info_manager_.getCameraInfo();
      ci.header = image_msg_raw16_.header;
      camera_info_pub_->publish(ci);
    } else {
      // YUV: extract luma and publish mono8
      extractYFromYuv(src_base, stamp);
    }
  }

  // Extract Y channel from YUV buffer and publish mono8 image
  void extractYFromYuv(uint8_t* src_base, const rclcpp::Time& stamp)
  {
    // Interpret V4L2 buffer as YUV and convert to mono8.
    // For Boson 640 in 4:2:0: luma plane is (height + height/2) x width.
    if (yuv_format_ == YuvFormat::PLANAR_420) {
      int luma_height = height_ + height_ / 2;
      int luma_width  = width_;

      cv::Mat yuv(luma_height, luma_width, CV_8UC1, src_base);
      cv::Mat gray;
      cv::cvtColor(yuv, gray, cv::COLOR_YUV2GRAY_I420);

      if (gray.size() != cv::Size(width_, height_)) {
        gray = gray(cv::Rect(0, 0, width_, height_));
      }

      image_msg_y8_.header.stamp = stamp;
      image_msg_y8_.header.frame_id = frame_id_;
      const size_t bytes = static_cast<size_t>(width_) * height_;
      std::memcpy(image_msg_y8_.data.data(), gray.data, bytes);

      image_pub_->publish(image_msg_y8_);

      auto ci = camera_info_manager_.getCameraInfo();
      ci.header = image_msg_y8_.header;
      camera_info_pub_->publish(ci);
    } else if (yuv_format_ == YuvFormat::PACKED_YUYV) {
      // Packed YUV 4:2:2 (YUYV/UYVY): take Y from each pixel
      image_msg_y8_.header.stamp = stamp;
      image_msg_y8_.header.frame_id = frame_id_;

      for (int i = 0; i < height_; ++i) {
        uint8_t* src_row = src_base + i * bytes_per_line_;
        uint8_t* dst_row = image_msg_y8_.data.data() + i * width_;

        if (pixfmt_ == V4L2_PIX_FMT_YUYV) {
          for (int x = 0; x < width_; ++x) {
            dst_row[x] = src_row[2 * x];
          }
        } else { // V4L2_PIX_FMT_UYVY
          for (int x = 0; x < width_; ++x) {
            dst_row[x] = src_row[2 * x + 1];
          }
        }
      }

      image_pub_->publish(image_msg_y8_);

      auto ci = camera_info_manager_.getCameraInfo();
      ci.header = image_msg_y8_.header;
      camera_info_pub_->publish(ci);
    } else {
      // Unknown YUV format: copy first width bytes of each line as best-effort
      image_msg_y8_.header.stamp = stamp;
      image_msg_y8_.header.frame_id = frame_id_;

      for (int i = 0; i < height_; ++i) {
        uint8_t* src_row = src_base + i * bytes_per_line_;
        uint8_t* dst_row = image_msg_y8_.data.data() + i * width_;
        std::memcpy(dst_row, src_row, std::min(width_, bytes_per_line_));
      }

      image_pub_->publish(image_msg_y8_);

      auto ci = camera_info_manager_.getCameraInfo();
      ci.header = image_msg_y8_.header;
      camera_info_pub_->publish(ci);
    }
  }

  // --- ROS2 publishers and camera info ---
  rclcpp::Publisher<sensor_msgs::msg::Image>::SharedPtr image_pub_;
  rclcpp::Publisher<sensor_msgs::msg::CameraInfo>::SharedPtr camera_info_pub_;
  camera_info_manager::CameraInfoManager camera_info_manager_;

  // --- V4L2 state ---
  int fd_{-1};
  int width_{640};
  int height_{512};
  int bytes_per_line_{0};
  uint32_t pixfmt_{0};

  struct v4l2_capability cap_;
  struct v4l2_format format_;
  struct v4l2_requestbuffers reqbuf_;
  struct v4l2_buffer bufferinfo_;

  void*  buffer_start_{nullptr};
  size_t buffer_length_{0};

  // --- Image buffers ---
  cv::Mat raw16_;
  cv::Mat y8_;
  sensor_msgs::msg::Image image_msg_raw16_;
  sensor_msgs::msg::Image image_msg_y8_;

  // --- Parameters ---
  std::string frame_id_;
  std::string dev_path_;
  double frame_rate_{30.0};
  std::string sensor_type_str_;
  std::string camera_info_url_;
  std::string video_mode_str_;
  VideoMode video_mode_{VideoMode::RAW16};
  YuvFormat yuv_format_{YuvFormat::UNKNOWN};

  // --- Timer (ROS1-style capture) ---
  rclcpp::TimerBase::SharedPtr capture_timer_;
};

int main(int argc, char * argv[])
{
  rclcpp::init(argc, argv);
  auto node = std::make_shared<BosonCameraNode>();
  rclcpp::spin(node);
  rclcpp::shutdown();
  return 0;
}
