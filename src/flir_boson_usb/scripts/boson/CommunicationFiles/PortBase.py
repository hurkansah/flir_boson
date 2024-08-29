# -*- coding: utf-8 -*-
"""
Physical layer of camera SDK base class
"""

class PortBase():
    def __init__(self, portID=None, baudrate=None):
        self.portID = portID
        self.baudrate = baudrate

    def open(self):
        raise Exception("Open not implemented")

    def close(self):
        raise Exception("Close not implemented")

    def isOpen(self):
        raise Exception("IsOpen not implemented")

    def isAvailable(self):
        raise Exception("IsAvailable not implemented")

    def setPortID(self, portID):
        self.portID = portID

    def setPortBaudrate(baudrate):
        self.baudrate = baudrate

    def __enter__(self):
        self.open()

    def __exit__(self, *args):
        self.close()
