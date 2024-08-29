# -*- coding: utf-8 -*-
"""
FSLP - FLIR Serial Line Protocol base class
"""

class FslpBase():
    def __init__(self, port):
        self.port = port

    def sendToCamera(self, data, dataSize, expectedReceiveBytes):
        raise Exception("SendToCamera not implemented")

    def sendFrame(self, channelID, data, dataSize):
        raise Exception("SendFrame not implemented")

    def readFrame(self, channelID, expectedReceiveBytes):
        raise Exception("ReadFrame not implemented")

    def pollDebug(self, channelID):
        raise Exception("PollDebug not implemented")

    def dumpUnframed(self):
        raise Exception("DumpUnframed not implemented")

    def setTimeout(self, timeout):
        pass

    def unsetTimeout(self):
        pass
