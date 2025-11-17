cmake_minimum_required(VERSION 3.10)
project(flir_boson_usb)

# C++ standard
if(NOT CMAKE_CXX_STANDARD)
  set(CMAKE_CXX_STANDARD 14)
endif()

# Ament + depend.
find_package(ament_cmake REQUIRED)
find_package(ament_cmake_python REQUIRED)
find_package(rclcpp REQUIRED)
find_package(sensor_msgs REQUIRED)
find_package(cv_bridge REQUIRED)
find_package(camera_info_manager REQUIRED)
find_package(OpenCV REQUIRED)

include_directories(
  include
  ${OpenCV_INCLUDE_DIRS}
)

add_executable(boson_camera_node
  src/boson_camera_node.cpp
)

ament_target_dependencies(boson_camera_node
  rclcpp
  sensor_msgs
  cv_bridge
  camera_info_manager
  OpenCV
)

target_link_libraries(boson_camera_node
  ${OpenCV_LIBRARIES}
)

install(TARGETS boson_camera_node
  DESTINATION lib/${PROJECT_NAME}
)

install(DIRECTORY
  launch
  DESTINATION share/${PROJECT_NAME}
)

install(DIRECTORY
  config
  DESTINATION share/${PROJECT_NAME}
)

install(DIRECTORY
  scripts/boson
  DESTINATION lib/${PROJECT_NAME}
)

install(
  PROGRAMS
    scripts/camera_conf_node.py
  DESTINATION lib/${PROJECT_NAME}
)

ament_package()
