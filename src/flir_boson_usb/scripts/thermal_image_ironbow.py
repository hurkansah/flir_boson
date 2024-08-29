#!/usr/bin/env python3

import rospy
from sensor_msgs.msg import Image
from cv_bridge import CvBridge, CvBridgeError
import cv2

def image_callback(msg):
    bridge = CvBridge()
    try:
        # Convert ROS Image message to OpenCV image
        cv_image = bridge.imgmsg_to_cv2(msg, desired_encoding='passthrough')
        
        # Apply the COLORMAP_PLASMA colormap
        colored_image = cv2.applyColorMap(cv_image, cv2.COLORMAP_INFERNO)
        
        # Display the image
        cv2.imshow("Thermal Camera with COLORMAP_PLASMA", colored_image)
        cv2.waitKey(1)
    except CvBridgeError as e:
        rospy.logerr("CvBridge Error: {0}".format(e))

def main():
    rospy.init_node('thermal_image_listener', anonymous=True)
    rospy.Subscriber("/flir_boson/image_raw", Image, image_callback)
    rospy.spin()
    cv2.destroyAllWindows()

if __name__ == '__main__':
    main()

