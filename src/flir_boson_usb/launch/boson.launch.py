from launch import LaunchDescription
from launch_ros.actions import Node
from ament_index_python.packages import get_package_share_directory
import os

def generate_launch_description():
    pkg_dir = get_package_share_directory('flir_boson_usb')
    calib_file = os.path.join(pkg_dir, 'config', 'Boson640.yaml')

    return LaunchDescription([

        # --- BOSON CAMERA NODE (C++) ---
        Node(
            package='flir_boson_usb',
            executable='boson_camera_node',
            name='boson_camera',
            parameters=[
                {'frame_id': 'boson_camera'},
                {'dev': '/dev/video0'},
                {'frame_rate': 60.0},
                {'video_mode': 'RAW16'},      # RAW16 veya YUV
                {'zoom_enable': False},
                {'sensor_type': 'Boson_640'},
                {'camera_info_url': f'file://{calib_file}'},
            ],
            output='screen'
        ),

        # --- CAMERA CONF NODE (Python) ---
        Node(
            package='flir_boson_usb',
            executable='camera_conf_node.py',
            name='camera_conf',
            output='screen',
        )
    ])
