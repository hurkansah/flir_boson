# flir_boson

Ros package for Flir Boson &amp; Boson+ thermal camera with dynamic reconfiguration

Based on https://github.com/astuff/flir_boson_usb

ROS package combined with Boson SDK package(https://flir.netx.net/file/asset/46046/original/attachment) so the camera parameters like in GUI can be changable with using Dynamic Reconfiguration.
Also you can change additional settings with using this repo and SDK Document(https://flir.netx.net/file/asset/12950/original/attachment)


To Run repo

```
cd flir_boson
source devel/setup.bas
```


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