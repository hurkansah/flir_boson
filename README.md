# FLIR Boson ROS2 Driver

ROS2 driver for FLIR Boson / Boson+ thermal cameras.  
Provides RAW16 image streaming via V4L2 and full AGC parameter control through the Boson SDK.

**For the ROS1 version, see the [`main` branch](https://github.com/hurkansah/flir_boson/tree/main).**  
This branch contains the **ROS2 implementation** only.

---

## Features

- RAW16 thermal image stream (`/image_raw`, 640×512, mono16) or YUV for 8-bit output
- `sensor_msgs/Image` + `CameraInfo` publishing
- Integrated Boson SDK (FSLP) for runtime AGC control
- ROS2 parameter interface (`camera_conf_node`)
- Works on Jetson Xavier (aarch64) — requires rebuilding `FSLP_64.so`
- Compatible with Foxy, Humble

---

## Build (colcon)

```bash
cd ~/flir_ws/src
git clone https://github.com/hurkansah/flir_boson.git
cd ~/flir_ws
colcon build --packages-select flir_boson_usb --symlink-install
source install/setup.bash
```

Make all Python scripts executable:

```bash
chmod +x flir_boson_usb/flir_boson_usb/scripts/*.py
```

---

## Running

```bash
sudo chmod 777 /dev/ttyACM0 
ros2 launch flir_boson_usb boson.launch.py
```

Published topics:

- `/image_raw` — RAW16 thermal image  
- `/camera_info` — Camera calibration  
- `/camera_conf` — AGC parameter interface

---

## Selecting the correct V4L2 device

List all connected video devices:

```bash
v4l2-ctl --list-devices
```

Example:

```
FLIR Boson:
    /dev/video2
```

Then launch using the detected device:

```bash
ros2 launch flir_boson_usb boson.launch.py dev:=/dev/video2
```

---

## Rebuilding `FSLP_64.so` (Boson SDK) for Jetson aarch64

```bash
cd flir_boson_usb/flir_boson_usb/scripts/boson/FSLP_Files
mkdir -p obj

gcc -g -fPIC -shared -c -o obj/flirCRC_Linux64.o          src/flirCRC.c           -I./src/inc
gcc -g -fPIC -shared -c -o obj/FSLP_Linux64.o             src/FSLP.c              -I./src/inc
gcc -g -fPIC -shared -c -o obj/flirChannels_Linux64.o     src/flirChannels.c      -I./src/inc
gcc -g -fPIC -shared -c -o obj/timeoutLogic_Linux64.o     src/timeoutLogic.c      -I./src/inc
gcc -g -fPIC -shared -c -o obj/serialPort_Linux64.o       src/linux/serial.c      -I./src/inc
gcc -g -fPIC -shared -c -o obj/serialPortAdapter_Linux64.o src/linux/serialPortAdapter.c -I./src/inc

gcc -g -fPIC -shared -o FSLP_64.so     obj/flirCRC_Linux64.o     obj/FSLP_Linux64.o     obj/flirChannels_Linux64.o     obj/timeoutLogic_Linux64.o     obj/serialPort_Linux64.o     obj/serialPortAdapter_Linux64.o
```

---

## Runtime AGC Parameters (via `camera_conf_node`, only for YUV (8-bit))

List and modify parameters:

```bash
ros2 param list /camera_conf
ros2 param get  /camera_conf MaxGain
ros2 param set  /camera_conf MaxGain 2.0
```
or you can use:
```bash
ros2 run rqt_reconfigure rqt_reconfigure
```
Supported parameters:

- OutlierCut  
- MaxGain  
- DF  
- Gamma  
- PercentPerBin  
- LinearPercent  
- DetailHeadroom  
- d2br  
- SigmaR  
- OutlierCutBalance  

Each parameter is forwarded directly to the Boson via SDK calls.

---

## Viewing the thermal image

```bash
ros2 run rqt_image_view rqt_image_view
```

Select `/image_raw`.  
The image is **mono16**; you may apply normalization or colormaps depending on your visualization pipeline.

---

## License

MIT License  
Copyright © 2025 Hürkan Şahin
