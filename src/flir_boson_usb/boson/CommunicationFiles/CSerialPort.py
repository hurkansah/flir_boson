# -*- coding: utf-8 -*-
"""
Serial port supported by C serial library (DLL files)
"""

import ctypes, os, sys
import _ctypes
import serial
try:
    import serial.tools.list_ports as portList
    HAS_SERIAL_LIST = True
except ImportError:
    print("Serial port list not available!")
    HAS_SERIAL_LIST = False
from .PortBase import PortBase

class CSerialPort(PortBase):
    def __init__(self, portID, baudrate=None, dllPath=None):
        if baudrate == None:
            baudrate = 921600
        super().__init__(baudrate=int(baudrate))
        self.portOpen = False
        self.readBufferSize = 2048
        self.__library = None
        self.__dllHandle = None
        if (not "posix" in os.name):
            dll_name = "FSLP_64.dll"
        else:
            dll_name = "FSLP_64.so"

        if dllPath:
            loadpath = os.path.join(dllPath, dll_name)
        else:
            loadpath = os.path.join(os.path.dirname(__file__), "FSLP_Files", dll_name)
        try:
            self.__library = ctypes.cdll.LoadLibrary(loadpath)
            self.__dllHandle = self.__library._handle
            self.camsend = self.__library.__getattr__("FSLP_send_to_camera")
            self.camread = self.__library.__getattr__("FSLP_read_frame")
            self.camunframed = self.__library.__getattr__("FSLP_read_unframed")
            self.port_open = self.__library.__getattr__("FSLP_open_port")
            self.port_close = self.__library.__getattr__("FSLP_close_port")
            self.lookup_port_name = self.__library.__getattr__("FSLP_lookup_port_id")
        except OSError as e:
            print("dllPath = {!s}".format(dllPath))
            print("filePath = {!s}".format(os.path.dirname(__file__)))
            print("loadpath = {!s}".format(loadpath))
            print("dllName = {!s}".format(dll_name))
            raise e
        self.setPortID(portID)

    def open(self):
        ret = self.port_open(ctypes.c_int(self.portID),ctypes.c_int(int(self.baudrate)))
        if ret == 0:
            self.portOpen = True
            print("Serial port open")
        else:
            raise IOError("Failed to open port #{:d} with error {:d}!".format(self.portID, ret))

    def close(self):
        if self.portOpen:
            self.port_close(ctypes.c_int32(self.portID))
        self.portOpen = False
        print("Serial port close")

    def isOpen(self):
        return self.portOpen

    def isAvailable(self):
        if HAS_SERIAL_LIST:
            return self.portName in [portFromList[0] for portFromList in portList.comports()]
        else:
            return None

    def setPortID(self, portID):
        try:
            portNum = int(portID)
            if os.name == 'nt':
                self.portName = "COM{:d}".format(portNum +1)
            else:
                if portNum >= 16 :
                    self.portName = "/dev/ttyACM{:d}".format(portNum - 16)
                else:
                    self.portName = "/dev/ttyUSB{:d}".format(portNum)
        except ValueError:
            portBuffer = (ctypes.c_uint8*16)()
            for i, dat in enumerate(portID.encode('ascii')):
                portBuffer[i] = dat
            portNum = int(self.lookup_port_name(portBuffer, len(portID)))
            self.portName = portID
        if portNum < 0:
            raise IOError("Failed to set port ID. Port {:s} unknown".format(portID))
        self.portID = portNum

    def write(self, channel_ID, sendBytes, sendBuffer):
        self.camsend(ctypes.c_int32(self.portID), channel_ID, sendBytes, sendBuffer)

    def read(self, channel_ID, start_byte_ms, receiveBytes):
        receiveBuffer = (ctypes.c_uint8*self.readBufferSize)(*[0xFF]*self.readBufferSize)
        self.camread(ctypes.c_int32(self.portID), channel_ID, start_byte_ms, ctypes.byref(receiveBytes), receiveBuffer)
        return receiveBuffer

    def readUnframed(self, start_byte_ms, receiveBytes):
        receiveBuffer = (ctypes.c_uint8*self.readBufferSize)(*[0xFF]*self.readBufferSize)
        self.camunframed(ctypes.c_int32(self.portID), start_byte_ms, ctypes.byref(receiveBytes), receiveBuffer)
        return receiveBuffer

    def __exit__(self, *args):
        self.close()
        if self.__library != None:
            del self.__library
        if not "posix" in os.name and self.__dllHandle != None:
            _ctypes.FreeLibrary(self.__dllHandle)
