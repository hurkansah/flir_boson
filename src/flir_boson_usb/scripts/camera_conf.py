#!/usr/bin/env python3
import sys
import os

from boson import *

import rospy
from dynamic_reconfigure.server import Server
from flir_boson_usb.cfg import CameraConfig

def callback(config, level):
    rospy.loginfo(f"Reconfigure Request: {config}")
    try:
        myCam = CamAPI.pyClient(manualport="/dev/ttyACM0")
        myCam.agcSetPercentPerBin(config['PercentPerBin'])
        myCam.agcSetLinearPercent(config['LinearPercent'])
        myCam.agcSetOutlierCut(config['OutlierCut'])
        myCam.agcSetMaxGain(config['MaxGain'])
        myCam.agcSetdf(config['DF'])
        myCam.agcSetGamma(config['Gamma'])
        myCam.agcSetDetailHeadroom(config['DetailHeadroom'])
        myCam.agcSetd2br(config['d2br'])
        myCam.agcSetSigmaR(config['SigmaR'])
        myCam.agcSetOutlierCutBalance(config['OutlierCutBalance'])
    except Exception as e:
        rospy.logerr(f"Failed to set camera parameters: {e}")
    return config
    

def main():
    rospy.init_node("camera_conf", anonymous=False)
    srv = Server(CameraConfig, callback)
    rospy.spin()

if __name__ == "__main__":
    main()

