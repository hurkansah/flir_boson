# -*- coding: utf-8 -*-
"""
Serial port supported by Python serial library
"""

import serial
try:
    import serial.tools.list_ports as portList
    HAS_SERIAL_LIST = True
except ImportError:
    print("Serial port list not available!")
    HAS_SERIAL_LIST = False
from .PortBase import PortBase

class PySerialPort(PortBase):
    def __init__(self, portID, baudrate=None, port=None):
        if baudrate == None:
            baudrate = 921600
        super().__init__(str(portID), int(baudrate))
        if port:
            self.port = port
        else:
            self.port = serial.Serial()

    def open(self):
        self.port.port = self.portID
        self.port.baudrate = self.baudrate
        self.port.parity = 'N'
        self.port.stopbits = 1
        self.port.bytesize = 8
        self.port.timeout = 10
        self.port.open()
        if self.port.isOpen():
            print("Serial port open")
        else:
            raise IOError("Failed to open serial port {:s}!".format(self.portID))

    def close(self):
        if self.port.isOpen():
            self.port.close()
        print("Serial port close")

    def isOpen(self):
        return self.port.isOpen()

    def isAvailable(self):
        if HAS_SERIAL_LIST:
            return self.portID in [portFromList[0] for portFromList in portList.comports()]
        else:
            return None

    def write(self, data):
        self.port.write(data)

    def read(self, numberOfBytes):
        return self.port.read(numberOfBytes)
