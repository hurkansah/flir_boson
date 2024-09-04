# flir_boson
![5823291001685526150](https://github.com/user-attachments/assets/3f96f0c2-acf3-4fcf-bc41-927cf51fc043)

Ros package for Flir Boson &amp; Boson+ thermal camera with dynamic reconfiguration. It is tested with ROS Noetic and Flir Boson+

Based on https://github.com/astuff/flir_boson_usb

ROS package combined with Boson SDK package(https://flir.netx.net/file/asset/46046/original/attachment) so the camera parameters like in GUI can be changable with using Dynamic Reconfiguration.
Also you can change additional settings with using this repo and SDK Document(https://flir.netx.net/file/asset/12950/original/attachment)

Requisation:
sudo apt-get update
sudo apt-get install v4l-utils
sudo apt-get install python3-opencv
sudo chmod a+rwx /dev/ttyACM0

To Run repo

First be sure all .py files in scripts are executable (chmod +x)
```
cd flir_boson
catkin build
source devel/setup.bash
```
![76002131-0ac2-43e9-8ecf-79a44db368d8](https://github.com/user-attachments/assets/7f812c83-d3d6-4735-8b5e-70dca742a80e)
* In First Terminal (to run camera and get output )
```
roslaunch flir_boson_usb flir_boson.launch 
```
check line 6 if it is not work
```
  <!-- the linux file descriptor location for the camera -->
  <arg name="dev" default="/dev/video0"/>
because if you have more than one camera (for laptop esp) video input can be different 
try <arg name="dev" default="/dev/video2"/> for laptops or <arg name="dev" default="/dev/video1"/>
```

* In Second Terminal ( Optional if you want to see video output)
```
rosrun flir_boson_usb thermal_image_listener.py 
or (with ironbow color palette)
rosrun flir_boson_usb thermal_image_ironbow.py 
```

* You can run FFC with this command
```
rosrun flir_boson_usb doFFC.py 
```
![left-0036](https://github.com/user-attachments/assets/581fc966-151e-4809-8ea8-e9128283f97a)

