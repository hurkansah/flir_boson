#!/usr/bin/env python3

import rospy
from sensor_msgs.msg import Image
from cv_bridge import CvBridge
import cv2

def image_callback(msg):
    # Convert ROS Image message to OpenCV image
    bridge = CvBridge()
    cv_image = bridge.imgmsg_to_cv2(msg, desired_encoding='passthrough')
    
    # Display the image
    cv2.imshow("Thermal Camera", cv_image)
    cv2.waitKey(1)

def main():
    # Initialize the ROS node
    rospy.init_node('thermal_camera_viewer', anonymous=True)
    
    # Subscribe to the thermal camera image topic
    rospy.Subscriber("/flir_boson/image_raw", Image, image_callback)
    
    # Keep the node running
    rospy.spin()
    
    # Close OpenCV windows
    cv2.destroyAllWindows()

if __name__ == '__main__':
    main()

