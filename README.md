# ROS/ROS2 package for Flir Boson & Boson+ 
ROS package for Flir Boson & Boson+ thermal camera with dynamic reconfiguration. It is tested with ROS Noetic and Flir Boson+.

For the **ROS2 version**, please see the [`ros2` branch](https://github.com/hurkansah/flir_boson/tree/ros2).

Demo video:  
https://www.youtube.com/watch?v=U2WxlCpZ90o
Based on https://github.com/astuff/flir_boson_usb

ROS package combined with Boson SDK package(https://flir.netx.net/file/asset/46046/original/attachment) so the camera parameters like in GUI for 8-bit image can be changable with using Dynamic Reconfiguration. Also, you can set thermal image output to 16 bit raw thermal image.
Also you can change additional settings with using this repo and SDK Document(https://flir.netx.net/file/asset/12950/original/attachment)

Prerequisite:
```
sudo apt-get update
sudo apt-get install v4l-utils
sudo apt-get install python3-opencv
sudo chmod a+rwx /dev/ttyACM0
```

Recompile FSLP_64.so file for the target system (here presumably aarch64. If x86_64 is used, add flag "-m64" into gcc command lines):

```
cd <../boson/FSLP_Files>
mkdir obj
gcc -g -fPIC  -shared -c -o obj/flirCRC_Linux64.o src/flirCRC.c -I./src/inc
gcc -g -fPIC  -shared -c -o obj/FSLP_Linux64.o src/FSLP.c -I./src/inc
gcc -g -fPIC  -shared -c -o obj/flirChannels_Linux64.o src/flirChannels.c -I./src/
gcc -g -fPIC  -shared -c -o obj/timeoutLogic_Linux64.o src/timeoutLogic.c -I./src/inc
gcc -g -fPIC  -shared -c -o obj/serialPort_Linux64.o src/linux/serial.c -I./src/inc
gcc -g -fPIC  -shared -c -o obj/serialPortAdapter_Linux64.o src/linux/serialPortAdapter.c -I./src/inc
gcc -g -fPIC  -shared -o FSLP_64.so obj/flirCRC_Linux64.o obj/FSLP_Linux64.o obj/flirChannels_Linux64.o obj/timeoutLogic_Linux64.o obj/serialPort_Linux64.o obj/serialPortAdapter_Linux64.o 
```
check the file afterward to be sure it is correctly compiled:
```
file FSLP_64.so
```
It should says: 
```
FSLP_64.so: ELF 64-bit LSB shared object, ARM aarch64, version 1 (SYSV), dynamically linked
```

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


## Known issues

1. Failed to set camera parameters: Failed to open port #16 with error 255

Serial connection is not allowed. To do that, add "dialout" to the current groups:
```
sudo usermod -a -G dialout $USER
```
and log out.

2. ERROR: OPEN. Invalid Video Device
Camera is not connected. Check cable
