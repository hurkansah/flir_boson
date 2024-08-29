# -*- coding: utf-8 -*-
"""
FSLP communication by serial port - custom C serial library is used
"""

import ctypes, os, sys
import _ctypes
from .FslpBase import FslpBase
from .CSerialPort import CSerialPort

class CSerialFslp(FslpBase):
    def __init__(self, portID, baudrate=None, dllPath=None):
        super().__init__(CSerialPort(portID, baudrate, dllPath))
        self.__default_timeout_ms = 1000
        self.current_timeout_ms = self.__default_timeout_ms

    def sendToCamera(self, data, dataSize, expectedReceiveBytes):
        if self.port.isOpen():
            sendBuffer = (ctypes.c_uint8*dataSize)()
            for i, dataByte in enumerate(data):
                sendBuffer[i] = dataByte
            sendBytes = ctypes.c_uint16(dataSize)
            receiveBytes = ctypes.c_uint16(expectedReceiveBytes)
            channel_ID = ctypes.c_uint8(0x00)
            start_byte_ms = ctypes.c_uint16(1000)
            self.port.write(channel_ID, sendBytes, sendBuffer)
            receiveBuffer = self.port.read(channel_ID, start_byte_ms, receiveBytes)
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes = bytearray(returnBuffer)
            return returnBytes
        else:
            raise Exception("Port is not open")

    def sendFrame(self, channelID, data, dataSize):
        if self.port.isOpen():
            sendBuffer = (ctypes.c_uint8*dataSize)()
            for i, dataByte in enumerate(data):
                sendBuffer[i] = dataByte
            sendBytes = ctypes.c_uint16(dataSize)
            channel_ID = ctypes.c_uint8(channelID)
            self.port.write(channel_ID, sendBytes, sendBuffer)
        else:
            raise Exception("Port is not open")

    def readFrame(self, channelID, expectedReceiveBytes):
        if self.port.isOpen():
            receiveBytes = ctypes.c_uint16(expectedReceiveBytes)
            channel_ID = ctypes.c_uint8(channelID)
            start_byte_ms = ctypes.c_uint16(self.current_timeout_ms)
            receiveBuffer = self.port.read(channel_ID, start_byte_ms, receiveBytes)
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes = bytearray(returnBuffer)
            return returnBytes
        else:
            raise Exception("Port is not open")

    def pollDebug(self, channelID):
        if self.port.isOpen():
            receiveBytes = ctypes.c_uint16(0)
            channel_ID = ctypes.c_uint8(channelID)
            start_byte_ms = ctypes.c_uint16(25)
            receiveBuffer = self.port.read(channel_ID, start_byte_ms, receiveBytes)
            if receiveBytes.value == 0:
                return bytearray()
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes = bytearray(returnBuffer)
            return returnBytes
        else:
            raise Exception("Port is not open")

    def dumpUnframed(self):
        if self.port.isOpen():
            receiveBytes = ctypes.c_uint16(0)
            start_byte_ms = ctypes.c_uint16(25)
            receiveBuffer = self.port.readUnframed(start_byte_ms, receiveBytes)
            if receiveBytes.value == 0:
                return bytearray()
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes =  bytearray(returnBuffer)
            return returnBytes
        else:
            raise Exception("Port is not open")

    def setTimeout(self, timeout):
        '''
        Set the timeout for an FSLP command to respond with the first byte.
        Allowable range is 1 to 65535 ms.
        '''
        if timeout == abs(int(timeout )) and timeout <= 65535:
            self.current_timeout_ms = timeout
        else:
            raise ValueError("timeout={} is not an integer number of milliseconds between 1-65535".format(timeout))

    def unsetTimeout(self):
        '''
        Set the timeout for FSLP command back to default value.
        '''
        self.current_timeout_ms = self.__default_timeout_ms
