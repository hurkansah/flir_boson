# -*- coding: utf-8 -*-
"""
Common FSLP - common interface to get right FLSP
"""

import sys
import os
from os.path import dirname
from enum import IntEnum

class FSLP_TYPE_E(IntEnum):
    FSLP_DLL_SERIAL = 0
    FSLP_PY_SERIAL = 1
    FSLP_I2C = 2

class CommonFslp(object):
    @staticmethod
    def getFslp(portName, baudrate=None, fslpType=FSLP_TYPE_E.FSLP_DLL_SERIAL, extPath=None):
        fslp = None
        if extPath not in sys.path:
            sys.path.append(extPath)
        if FSLP_TYPE_E.FSLP_DLL_SERIAL == fslpType:
            from .CSerialFslp import CSerialFslp
            if extPath is None:
                extPath = os.path.join(dirname(dirname(__file__)), "FSLP_Files")
            fslp = CSerialFslp(portName, baudrate, extPath)
            print("C serial FSLP load")
        elif FSLP_TYPE_E.FSLP_PY_SERIAL == fslpType:
            from .PySerialFslp import PySerialFslp
            fslp = PySerialFslp(portName, baudrate)
            print("Python serial FSLP load")
        elif FSLP_TYPE_E.FSLP_I2C == fslpType:
            from .I2CFslp import I2CFslp
            fslp = I2CFslp(portName, baudrate)
            print("I2C FSLP load")
        else:
            raise Exception("Unknown FSLP type")
        return fslp
