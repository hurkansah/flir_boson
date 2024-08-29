#  /////////////////////////////////////////////////////
#  // DO NOT EDIT.  This is a machine generated file. //
#  /////////////////////////////////////////////////////


from .Client_Dispatcher import *
from .Serializer_Struct import *
from .Serializer_BuiltIn import *
from .EnumTypes import *

def fixSpecialBytes(seqnum):
    seqbytes = bytearray([0x00,0x00,0x00,0x00])
    UINT_32ToByte(seqnum,seqbytes,0)
    seqbytes = seqbytes.replace(b'\x8E',b'\x8F')
    seqbytes = seqbytes.replace(b'\x9E',b'\x9F')
    seqbytes = seqbytes.replace(b'\xAE',b'\xAF')
    newseqnum = byteToUINT_32(seqbytes,0)
    #if newseqnum != seqnum:
        #print("seqfix: 0x{:08X} -> 0x{:08X}".format(seqnum,newseqnum))
    return newseqnum

class Packager():
    def __init__(self, fslp):
        self.__commandCount = 0
        self.fslp = fslp
    # Begin Module: TLinear
    def CLIENT_pkg_TLinear_SetControl(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003E0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: TLinear

    def CLIENT_pkg_TLinear_GetControl(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003E0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: TLinear

    def CLIENT_pkg_TLinear_GetLUT(self, mode, offset):
        # Create bytearray object for inputs
        sendBytes = 6
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, a, b
        INT_32ToByte(mode.value,sendData,outPtr)
        outPtr += 4
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, a, b
        UINT_16ToByte(offset,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003E0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read a from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        a = byteToFLOATArray(receiveData,inPtr,16)
        inPtr+=64
        # end of a handling
        
        # read b from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        b = byteToFLOATArray(receiveData,inPtr,16)
        inPtr+=64
        # end of b handling
        
        return returnCode, a, b
        
    #End of Module: TLinear

    def CLIENT_pkg_TLinear_RefreshLUT(self, mode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(mode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003E0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: TLinear

    # Begin Module: agc
    def CLIENT_pkg_agc_SetPercentPerBin(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetPercentPerBin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetLinearPercent(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetLinearPercent(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetOutlierCut(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetOutlierCut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetDrOut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetMaxGain(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetMaxGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_Setdf(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_Getdf(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetGamma(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetGamma(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetFirstBin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetLastBin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetDetailHeadroom(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetDetailHeadroom(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_Setd2br(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_Getd2br(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetSigmaR(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetSigmaR(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetUseEntropy(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetUseEntropy(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0009001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetROI(self, roi):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write roi to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ROI_TToByte(roi,sendData,outPtr)
        outPtr += 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read roi from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        roi = byteToFLR_ROI_T(receiveData,inPtr)
        inPtr+=8
        # end of roi handling
        
        return returnCode, roi
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetMaxGainApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetSigmaRApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetOutlierCutBalance(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetOutlierCutBalance(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetOutlierCutApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read percentHigh from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        percentHigh = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of percentHigh handling
        
        # read percentLow from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        percentLow = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of percentLow handling
        
        return returnCode, percentHigh, percentLow
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetTfThresholds(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090030, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read tf_thresholdMin from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        tf_thresholdMin = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of tf_thresholdMin handling
        
        # read tf_thresholdMax from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        tf_thresholdMax = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of tf_thresholdMax handling
        
        return returnCode, tf_thresholdMin, tf_thresholdMax
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetTfThresholds(self, tf_thresholdMin, tf_thresholdMax):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write tf_thresholdMin to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(tf_thresholdMin,sendData,outPtr)
        outPtr += 2
        
        # write tf_thresholdMax to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(tf_thresholdMax,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090031, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090032, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read mode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        mode = FLR_AGC_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of mode handling
        
        return returnCode, mode
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetMode(self, mode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(mode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090033, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetHighTempAlarmValues(self, lowGain, highGain, pixPopulation):
        # Create bytearray object for inputs
        sendBytes = 12
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write lowGain to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(lowGain,sendData,outPtr)
        outPtr += 4
        
        # write highGain to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(highGain,sendData,outPtr)
        outPtr += 4
        
        # write pixPopulation to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(pixPopulation,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090034, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetContrast(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090040, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read contrast from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        contrast = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of contrast handling
        
        return returnCode, contrast
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetContrast(self, contrast):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write contrast to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(contrast,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090041, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetBrightnessBias(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090042, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read brightnessBias from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        brightnessBias = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of brightnessBias handling
        
        return returnCode, brightnessBias
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetBrightnessBias(self, brightnessBias):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write brightnessBias to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(brightnessBias,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090043, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetBrightness(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090044, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read brightness from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        brightness = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of brightness handling
        
        return returnCode, brightness
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetBrightness(self, brightness):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write brightness to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(brightness,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090045, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_SetMaxGainForLowGain(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090046, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: agc

    def CLIENT_pkg_agc_GetMaxGainForLowGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00090047, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: agc

    # Begin Module: boson
    def CLIENT_pkg_boson_GetCameraSN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetCameraPN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 20
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_BOSON_PARTNUMBER_T(receiveData,inPtr)
        inPtr+=20
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSensorSN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_RunFFC(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCTempThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCTempThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCFrameThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCFrameThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCInProgress(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_Reboot(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCMode(self, ffcMode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ffcMode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(ffcMode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ffcMode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ffcMode = FLR_BOSON_FFCMODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of ffcMode handling
        
        return returnCode, ffcMode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetGainMode(self, gainMode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write gainMode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(gainMode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read gainMode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        gainMode = FLR_BOSON_GAINMODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of gainMode handling
        
        return returnCode, gainMode
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteDynamicHeaderToFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_ReadDynamicHeaderFromFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_RestoreFactoryDefaultsFromFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_RestoreFactoryBadPixelsFromFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteBadPixelsToFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSoftwareRev(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetBadPixelLocation(self, row, col):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write row to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(row,sendData,outPtr)
        outPtr += 4
        
        # write col to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(col,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005002D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_lookupFPATempDegCx10(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050030, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_lookupFPATempDegKx10(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050031, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteLensNvFfcToFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050033, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteLensGainToFlash(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050035, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetLensNumber(self, lensNumber):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write lensNumber to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(lensNumber,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050038, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetLensNumber(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050039, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read lensNumber from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        lensNumber = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of lensNumber handling
        
        return returnCode, lensNumber
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetTableNumber(self, tableNumber):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write tableNumber to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(tableNumber,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005003A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTableNumber(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005003B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read tableNumber from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        tableNumber = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of tableNumber handling
        
        return returnCode, tableNumber
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSensorPN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 32
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005003F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read sensorPN from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        sensorPN = byteToFLR_BOSON_SENSOR_PARTNUMBER_T(receiveData,inPtr)
        inPtr+=32
        # end of sensorPN handling
        
        return returnCode, sensorPN
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetGainSwitchParams(self, parm_struct):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write parm_struct to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte(parm_struct,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050040, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainSwitchParams(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050041, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read parm_struct from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        parm_struct = byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of parm_struct handling
        
        return returnCode, parm_struct
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSwitchToHighGainFlag(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050042, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read switchToHighGainFlag from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        switchToHighGainFlag = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of switchToHighGainFlag handling
        
        return returnCode, switchToHighGainFlag
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSwitchToLowGainFlag(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050043, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read switchToLowGainFlag from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        switchToLowGainFlag = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of switchToLowGainFlag handling
        
        return returnCode, switchToLowGainFlag
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetCLowToHighPercent(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050044, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read cLowToHighPercent from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        cLowToHighPercent = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of cLowToHighPercent handling
        
        return returnCode, cLowToHighPercent
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetMaxNUCTables(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050045, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read maxNUCTables from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        maxNUCTables = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of maxNUCTables handling
        
        return returnCode, maxNUCTables
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetMaxLensTables(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050046, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read maxLensTables from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        maxLensTables = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of maxLensTables handling
        
        return returnCode, maxLensTables
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFfcWaitCloseFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005004E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFfcWaitCloseFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005004F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_CheckForTableSwitch(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050050, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetDesiredTableNumber(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050052, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read desiredTableNumber from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        desiredTableNumber = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of desiredTableNumber handling
        
        return returnCode, desiredTableNumber
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFfcStatus(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050054, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ffcStatus from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ffcStatus = FLR_BOSON_FFCSTATUS_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of ffcStatus handling
        
        return returnCode, ffcStatus
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFfcDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050055, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ffcDesired from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ffcDesired = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of ffcDesired handling
        
        return returnCode, ffcDesired
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSwRevInHeader(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050056, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetLastFFCFrameCount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005005D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read frameCount from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        frameCount = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of frameCount handling
        
        return returnCode, frameCount
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetLastFFCTempDegKx10(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005005E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read temp from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        temp = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of temp handling
        
        return returnCode, temp
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTableSwitchDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005005F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read tableSwitchDesired from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        tableSwitchDesired = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of tableSwitchDesired handling
        
        return returnCode, tableSwitchDesired
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetOverTempThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050061, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read temperatureInC from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        temperatureInC = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of temperatureInC handling
        
        return returnCode, temperatureInC
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetLowPowerMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050062, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read lowPowerMode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        lowPowerMode = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of lowPowerMode handling
        
        return returnCode, lowPowerMode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetOverTempEventOccurred(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050063, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read overTempEventOccurred from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        overTempEventOccurred = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of overTempEventOccurred handling
        
        return returnCode, overTempEventOccurred
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetPermitThermalShutdownOverride(self, permitThermalShutdownOverride):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write permitThermalShutdownOverride to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(permitThermalShutdownOverride.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050064, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetPermitThermalShutdownOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050065, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read permitThermalShutdownOverride from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        permitThermalShutdownOverride = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of permitThermalShutdownOverride handling
        
        return returnCode, permitThermalShutdownOverride
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetMyriadTemp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050068, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read myriadTemp from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        myriadTemp = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of myriadTemp handling
        
        return returnCode, myriadTemp
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCNucTableNumberLens0(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005006D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read nvFFCNucTableNumberLens0 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        nvFFCNucTableNumberLens0 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of nvFFCNucTableNumberLens0 handling
        
        return returnCode, nvFFCNucTableNumberLens0
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCNucTableNumberLens1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005006F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read nvFFCNucTableNumberLens1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        nvFFCNucTableNumberLens1 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of nvFFCNucTableNumberLens1 handling
        
        return returnCode, nvFFCNucTableNumberLens1
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCFPATempDegKx10Lens0(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050071, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read nvFFCFPATempDegKx10Lens0 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        nvFFCFPATempDegKx10Lens0 = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of nvFFCFPATempDegKx10Lens0 handling
        
        return returnCode, nvFFCFPATempDegKx10Lens0
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCFPATempDegKx10Lens1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050073, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read nvFFCFPATempDegKx10Lens1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        nvFFCFPATempDegKx10Lens1 = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of nvFFCFPATempDegKx10Lens1 handling
        
        return returnCode, nvFFCFPATempDegKx10Lens1
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCWarnTimeInSecx10(self, ffcWarnTime):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ffcWarnTime to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(ffcWarnTime,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050074, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCWarnTimeInSecx10(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050075, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ffcWarnTime from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ffcWarnTime = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of ffcWarnTime handling
        
        return returnCode, ffcWarnTime
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetOverTempEventCounter(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050076, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read overTempEventCounter from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        overTempEventCounter = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of overTempEventCounter handling
        
        return returnCode, overTempEventCounter
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetOverTempTimerInSec(self, overTempTimerInSec):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write overTempTimerInSec to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(overTempTimerInSec,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050077, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetOverTempTimerInSec(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050078, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read overTempTimerInSec from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        overTempTimerInSec = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of overTempTimerInSec handling
        
        return returnCode, overTempTimerInSec
        
    #End of Module: boson

    def CLIENT_pkg_boson_UnloadCurrentLensCorrections(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050079, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetTimeForQuickFFCsInSecs(self, timeForQuickFFCsInSecs):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write timeForQuickFFCsInSecs to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(timeForQuickFFCsInSecs,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005007A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTimeForQuickFFCsInSecs(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005007B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read timeForQuickFFCsInSecs from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        timeForQuickFFCsInSecs = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of timeForQuickFFCsInSecs handling
        
        return returnCode, timeForQuickFFCsInSecs
        
    #End of Module: boson

    def CLIENT_pkg_boson_ReloadCurrentLensCorrections(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005007C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetBootTimestamps(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005007F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read FirstLight from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        FirstLight = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of FirstLight handling
        
        # read StartInit from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        StartInit = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of StartInit handling
        
        # read BosonExecDone from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        BosonExecDone = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of BosonExecDone handling
        
        # read Timestamp4 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        Timestamp4 = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of Timestamp4 handling
        
        return returnCode, FirstLight, StartInit, BosonExecDone, Timestamp4
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetExtSyncMode(self, mode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(mode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050098, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetExtSyncMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00050099, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read mode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        mode = FLR_BOSON_EXT_SYNC_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of mode handling
        
        return returnCode, mode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetLastCommand(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0005009A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read sequenceNum from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        sequenceNum = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of sequenceNum handling
        
        # read cmdID from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        cmdID = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of cmdID handling
        
        return returnCode, sequenceNum, cmdID
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSensorHostCalVersion(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A0, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read version from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        version = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of version handling
        
        return returnCode, version
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetDesiredStartupTableNumber(self, table):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(table,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetDesiredStartupTableNumber(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A2, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read table from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        table = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of table handling
        
        return returnCode, table
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetNvFFCMeanValueLens0(self, meanValue):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write meanValue to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(meanValue,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCMeanValueLens0(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A4, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read meanValue from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        meanValue = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of meanValue handling
        
        return returnCode, meanValue
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetNvFFCMeanValueLens1(self, meanValue):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write meanValue to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(meanValue,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A5, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetNvFFCMeanValueLens1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A6, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read meanValue from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        meanValue = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of meanValue handling
        
        return returnCode, meanValue
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetInvertImage(self, invertImage):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write invertImage to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(invertImage.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A7, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetInvertImage(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A8, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read invertImage from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        invertImage = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of invertImage handling
        
        return returnCode, invertImage
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetRevertImage(self, revertImage):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write revertImage to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(revertImage.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500A9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetRevertImage(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500AA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read revertImage from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        revertImage = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of revertImage handling
        
        return returnCode, revertImage
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTimeStamp(self, timeStampType):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write timeStampType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, timeStamp
        INT_32ToByte(timeStampType.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500AB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read timeStamp from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        timeStamp = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of timeStamp handling
        
        return returnCode, timeStamp
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetISPFrameCount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500AC, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ispFrameCount from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ispFrameCount = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of ispFrameCount handling
        
        return returnCode, ispFrameCount
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteUserBadPixelsToAllTables(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500AD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_WriteFactoryBadPixelsToAllTables(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500AE, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTempDiodeStatus(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read status from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        status = FLR_BOSON_TEMP_DIODE_STATUS_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of status handling
        
        return returnCode, status
        
    #End of Module: boson

    def CLIENT_pkg_boson_ClearFactoryBadPixelsInDDR(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B2, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFfcWaitOpenFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFfcWaitOpenFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B4, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFfcWaitOpenFlagSettleFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B5, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFfcWaitOpenFlagSettleFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500B6, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetTauExtFfcCompatibilityMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500BA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetTauExtFfcCompatibilityMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500BB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetInitialTableSelectionTempOffset(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500C7, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetInitialTableSelectionTempOffset(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500C8, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetImageValid(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500C9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetCurrentTableType(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_BOSON_TABLETYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainSwitchFrameThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetGainSwitchFrameThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CC, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainSwitchHysteresisTime(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetGainSwitchHysteresisTime(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CE, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainSwitchDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500CF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetGainSwitchRadiometricParams(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500D2, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read parm_struct from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        parm_struct = byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of parm_struct handling
        
        return returnCode, parm_struct
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetGainSwitchRadiometricParams(self, parm_struct):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write parm_struct to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte(parm_struct,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500D3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetSaturationOverrideMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500D8, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSaturationOverrideMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500D9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetSaturationOverrideValue(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetSaturationOverrideValue(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetffcHighLowGainThresholdMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DC, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetffcHighLowGainThresholdMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCTempThresholdLowGain(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DE, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCTempThresholdLowGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500DF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    def CLIENT_pkg_boson_SetFFCFrameThresholdLowGain(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500E0, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: boson

    def CLIENT_pkg_boson_GetFFCFrameThresholdLowGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000500E1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: boson

    # Begin Module: bpr
    def CLIENT_pkg_bpr_GetState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_SetState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetStats(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 20
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read threeby from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        threeby = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of threeby handling
        
        # read fiveby from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        fiveby = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of fiveby handling
        
        # read rows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        rows = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of rows handling
        
        # read budget from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        budget = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of budget handling
        
        # read used from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        used = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of used handling
        
        return returnCode, threeby, fiveby, rows, budget, used
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetDisplayMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_BPR_DISPLAY_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_SetDisplayMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetDisplayModeMinValue(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_SetDisplayModeMinValue(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetDisplayModeMaxValue(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00030009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_SetDisplayModeMaxValue(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0003000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetWorkBufIndex(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0003000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_SetWorkBufIndex(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0003000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: bpr

    def CLIENT_pkg_bpr_GetWorkBufStats(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 20
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0003000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read threeby from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        threeby = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of threeby handling
        
        # read fiveby from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        fiveby = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of fiveby handling
        
        # read rows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        rows = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of rows handling
        
        # read budget from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        budget = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of budget handling
        
        # read used from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        used = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of used handling
        
        return returnCode, threeby, fiveby, rows, budget, used
        
    #End of Module: bpr

    # Begin Module: capture
    def CLIENT_pkg_capture_SingleFrame(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00070001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: capture

    def CLIENT_pkg_capture_Frames(self, data):
        # Create bytearray object for inputs
        sendBytes = 10
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_CAPTURE_SETTINGS_TToByte(data,sendData,outPtr)
        outPtr += 10
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00070002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: capture

    def CLIENT_pkg_capture_SingleFrameWithSrc(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00070003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: capture

    def CLIENT_pkg_capture_SingleFrameToFile(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00070004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: capture

    def CLIENT_pkg_capture_GetStatus(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 24
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00070005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read status from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        status = byteToFLR_CAPTURE_STATUS_T(receiveData,inPtr)
        inPtr+=24
        # end of status handling
        
        return returnCode, status
        
    #End of Module: capture

    # Begin Module: colorLut
    def CLIENT_pkg_colorLut_SetControl(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: colorLut

    def CLIENT_pkg_colorLut_GetControl(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: colorLut

    def CLIENT_pkg_colorLut_SetId(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: colorLut

    def CLIENT_pkg_colorLut_GetId(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_COLORLUT_ID_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: colorLut

    def CLIENT_pkg_colorLut_SetOutlineColor(self, red, green, blue):
        # Create bytearray object for inputs
        sendBytes = 3
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write red to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(red,sendData,outPtr)
        outPtr += 1
        
        # write green to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(green,sendData,outPtr)
        outPtr += 1
        
        # write blue to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(blue,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: colorLut

    def CLIENT_pkg_colorLut_GetOutlineColor(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 3
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000B0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read red from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        red = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of red handling
        
        # read green from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        green = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of green handling
        
        # read blue from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        blue = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of blue handling
        
        return returnCode, red, green, blue
        
    #End of Module: colorLut

    # Begin Module: dummy
    def CLIENT_pkg_dummy_BadCommand(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xDEADBEEF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dummy

    # Begin Module: dvo
    def CLIENT_pkg_dvo_SetAnalogVideoState(self, analogVideoState):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write analogVideoState to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(analogVideoState.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetAnalogVideoState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read analogVideoState from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        analogVideoState = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of analogVideoState handling
        
        return returnCode, analogVideoState
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetOutputFormat(self, format):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write format to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(format.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetOutputFormat(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read format from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        format = FLR_DVO_OUTPUT_FORMAT_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of format handling
        
        return returnCode, format
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetOutputYCbCrSettings(self, settings):
        # Create bytearray object for inputs
        sendBytes = 12
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write settings to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_DVO_YCBCR_SETTINGS_TToByte(settings,sendData,outPtr)
        outPtr += 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetOutputYCbCrSettings(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read settings from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        settings = byteToFLR_DVO_YCBCR_SETTINGS_T(receiveData,inPtr)
        inPtr+=12
        # end of settings handling
        
        return returnCode, settings
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetOutputRGBSettings(self, settings):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write settings to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_DVO_RGB_SETTINGS_TToByte(settings,sendData,outPtr)
        outPtr += 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetOutputRGBSettings(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read settings from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        settings = byteToFLR_DVO_RGB_SETTINGS_T(receiveData,inPtr)
        inPtr+=8
        # end of settings handling
        
        return returnCode, settings
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_ApplyCustomSettings(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetDisplayMode(self, displayMode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write displayMode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(displayMode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetDisplayMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read displayMode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        displayMode = FLR_DVO_DISPLAY_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of displayMode handling
        
        return returnCode, displayMode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetType(self, tap):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write tap to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(tap.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetType(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read tap from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        tap = FLR_DVO_TYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of tap handling
        
        return returnCode, tap
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetVideoStandard(self, videoStandard):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write videoStandard to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(videoStandard.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060011, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetVideoStandard(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read videoStandard from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        videoStandard = FLR_DVO_VIDEO_STANDARD_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of videoStandard handling
        
        return returnCode, videoStandard
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetCheckVideoDacPresent(self, checkVideoDacPresent):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write checkVideoDacPresent to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(checkVideoDacPresent.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetCheckVideoDacPresent(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read checkVideoDacPresent from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        checkVideoDacPresent = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of checkVideoDacPresent handling
        
        return returnCode, checkVideoDacPresent
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetCustomLcdConfig(self, id, config):
        # Create bytearray object for inputs
        sendBytes = 52
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(id.value,sendData,outPtr)
        outPtr += 4
        
        # write config to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_DVO_LCD_CONFIG_TToByte(config,sendData,outPtr)
        outPtr += 48
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetCustomLcdConfig(self, id):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 48
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, config
        INT_32ToByte(id.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read config from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        config = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr)
        inPtr+=48
        # end of config handling
        
        return returnCode, config
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetLCDConfig(self, id):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(id.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetLCDConfig(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read id from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        id = FLR_DVO_LCD_CONFIG_ID_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of id handling
        
        return returnCode, id
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetClockInfo(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 80
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read horizontalSyncWidth from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        horizontalSyncWidth = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of horizontalSyncWidth handling
        
        # read verticalSyncWidth from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        verticalSyncWidth = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of verticalSyncWidth handling
        
        # read clocksPerRowPeriod from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        clocksPerRowPeriod = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of clocksPerRowPeriod handling
        
        # read horizontalFrontPorch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        horizontalFrontPorch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of horizontalFrontPorch handling
        
        # read horizontalBackPorch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        horizontalBackPorch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of horizontalBackPorch handling
        
        # read frontTelemetryPixels from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        frontTelemetryPixels = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of frontTelemetryPixels handling
        
        # read rearTelemetryPixels from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        rearTelemetryPixels = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of rearTelemetryPixels handling
        
        # read videoColumns from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        videoColumns = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of videoColumns handling
        
        # read validColumns from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        validColumns = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of validColumns handling
        
        # read telemetryRows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        telemetryRows = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of telemetryRows handling
        
        # read videoRows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        videoRows = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of videoRows handling
        
        # read validRows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        validRows = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of validRows handling
        
        # read verticalFrontPorch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        verticalFrontPorch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of verticalFrontPorch handling
        
        # read verticalBackPorch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        verticalBackPorch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of verticalBackPorch handling
        
        # read rowPeriodsPerFrame from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        rowPeriodsPerFrame = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of rowPeriodsPerFrame handling
        
        # read clocksPerFrame from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        clocksPerFrame = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of clocksPerFrame handling
        
        # read clockRateInMHz from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        clockRateInMHz = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of clockRateInMHz handling
        
        # read frameRateInHz from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        frameRateInHz = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of frameRateInHz handling
        
        # read validOnRisingEdge from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        validOnRisingEdge = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of validOnRisingEdge handling
        
        # read dataWidthInBits from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None
        dataWidthInBits = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of dataWidthInBits handling
        
        return returnCode, horizontalSyncWidth, verticalSyncWidth, clocksPerRowPeriod, horizontalFrontPorch, horizontalBackPorch, frontTelemetryPixels, rearTelemetryPixels, videoColumns, validColumns, telemetryRows, videoRows, validRows, verticalFrontPorch, verticalBackPorch, rowPeriodsPerFrame, clocksPerFrame, clockRateInMHz, frameRateInHz, validOnRisingEdge, dataWidthInBits
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetAllCustomLcdConfigs(self, config0, config1):
        # Create bytearray object for inputs
        sendBytes = 96
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write config0 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_DVO_LCD_CONFIG_TToByte(config0,sendData,outPtr)
        outPtr += 48
        
        # write config1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_DVO_LCD_CONFIG_TToByte(config1,sendData,outPtr)
        outPtr += 48
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetAllCustomLcdConfigs(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 96
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read config0 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        config0 = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr)
        inPtr+=48
        # end of config0 handling
        
        # read config1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        config1 = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr)
        inPtr+=48
        # end of config1 handling
        
        return returnCode, config0, config1
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetOutputIr16Format(self, format):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write format to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(format.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetOutputIr16Format(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read format from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        format = FLR_DVO_OUTPUT_IR16_FORMAT_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of format handling
        
        return returnCode, format
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetLcdClockRate(self, clockRate):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write clockRate to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(clockRate.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetLcdClockRate(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0006001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read clockRate from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        clockRate = FLR_DVO_LCD_CLOCK_RATE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of clockRate handling
        
        return returnCode, clockRate
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_SetLcdVideoFrameRate(self, framerate):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write framerate to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(framerate,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: dvo

    def CLIENT_pkg_dvo_GetLcdVideoFrameRate(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00060021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read framerate from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        framerate = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of framerate handling
        
        return returnCode, framerate
        
    #End of Module: dvo

    # Begin Module: fileOps
    def CLIENT_pkg_fileOps_Dir(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read dirent from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        dirent = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of dirent handling
        
        return returnCode, dirent
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Cd(self, path):
        # Create bytearray object for inputs
        sendBytes = 128
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, pwd
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read pwd from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        pwd = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of pwd handling
        
        return returnCode, pwd
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Md(self, path):
        # Create bytearray object for inputs
        sendBytes = 128
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Fopen(self, path, mode):
        # Create bytearray object for inputs
        sendBytes = 256
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, id
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, id
        UCHARArrayToByte(mode,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read id from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        id = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of id handling
        
        return returnCode, id
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Fclose(self, id):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Fread(self, id, length):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 132
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, buf, ret
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        # write length to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, buf, ret
        UINT_32ToByte(length,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read buf from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        buf = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of buf handling
        
        # read ret from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        ret = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of ret handling
        
        return returnCode, buf, ret
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Fwrite(self, id, length, buf):
        # Create bytearray object for inputs
        sendBytes = 136
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, ret
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        # write length to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, ret
        UINT_32ToByte(length,sendData,outPtr)
        outPtr += 4
        
        # write buf to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, ret
        UCHARArrayToByte(buf,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read ret from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        ret = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of ret handling
        
        return returnCode, ret
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Ftell(self, id):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, offset
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read offset from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        offset = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of offset handling
        
        return returnCode, offset
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Fseek(self, id, offset, origin):
        # Create bytearray object for inputs
        sendBytes = 12
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write origin to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(origin,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Ftruncate(self, id, length):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(id,sendData,outPtr)
        outPtr += 4
        
        # write length to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(length,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00160009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Rmdir(self, path):
        # Create bytearray object for inputs
        sendBytes = 128
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0016000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Rm(self, path):
        # Create bytearray object for inputs
        sendBytes = 128
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0016000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_Rename(self, oldpath, newpath):
        # Create bytearray object for inputs
        sendBytes = 256
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write oldpath to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(oldpath,128,sendData,outPtr)
        outPtr += 128
        
        # write newpath to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(newpath,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0016000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: fileOps

    def CLIENT_pkg_fileOps_GetFileSize(self, path):
        # Create bytearray object for inputs
        sendBytes = 128
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, fileLength
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0016000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read fileLength from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        fileLength = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of fileLength handling
        
        return returnCode, fileLength
        
    #End of Module: fileOps

    # Begin Module: flashIO
    def CLIENT_pkg_flashIO_SetProtectionState(self, protectionState):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write protectionState to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(protectionState.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00300001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: flashIO

    def CLIENT_pkg_flashIO_GetProtectionState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00300002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read protectionState from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        protectionState = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of protectionState handling
        
        return returnCode, protectionState
        
    #End of Module: flashIO

    # Begin Module: flashMapFs
    def CLIENT_pkg_flashMapFs_GetHeaderVersion(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00340005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: flashMapFs

    # Begin Module: gao
    def CLIENT_pkg_gao_SetGainState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetGainState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetFfcState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetFfcState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetTempCorrectionState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetTempCorrectionState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetIConstL(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetIConstL(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetIConstM(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetIConstM(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetAveragerState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetAveragerState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetNumFFCFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetNumFFCFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetAveragerThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000011, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetTestRampState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetTestRampState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetSffcState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetSffcState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetNucType(self, nucType):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write nucType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(nucType.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetNucType(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000024, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read nucType from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        nucType = FLR_GAO_NUC_TYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of nucType handling
        
        return returnCode, nucType
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetFfcZeroMeanState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetFfcZeroMeanState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsPopThreshold(self, threshold):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write threshold to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(threshold,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000002B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsPopThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000002C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read threshold from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        threshold = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of threshold handling
        
        return returnCode, threshold
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsCloseThreshold(self, threshold):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write threshold to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(threshold,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000002D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsCloseThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000002E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read threshold from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        threshold = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of threshold handling
        
        return returnCode, threshold
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsTooFewQuit(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000002F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsTooFewQuit(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000030, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsTooFew(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000031, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsTooFew(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000032, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsMinCorrection(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000033, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsMinCorrection(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000034, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsDamping(self, data):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(data,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000035, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsDamping(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000036, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsFrameHysteresis(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000037, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsFrameHysteresis(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000038, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsBadDamping(self, data):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(data,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000039, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsBadDamping(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsNumGoodDampingThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsNumGoodDampingThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsFfcDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetAveragerDesiredState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsThDamp(self, thDamp):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write thDamp to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thDamp,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000003F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsThDamp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000040, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read thDamp from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        thDamp = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of thDamp handling
        
        return returnCode, thDamp
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsThException(self, thException):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write thException to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thException,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000041, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsThException(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000042, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read thException from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        thException = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of thException handling
        
        return returnCode, thException
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsThBad(self, thBad):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write thBad to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thBad,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000043, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsThBad(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000044, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read thBad from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        thBad = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of thBad handling
        
        return returnCode, thBad
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsThBadInitial(self, thBadInitial):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write thBadInitial to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thBadInitial,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000045, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsThBadInitial(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000046, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read thBadInitial from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        thBadInitial = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of thBadInitial handling
        
        return returnCode, thBadInitial
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetRnsThAllowedExceptions(self, thAllowedExceptions):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write thAllowedExceptions to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thAllowedExceptions,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000004A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsThAllowedExceptions(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000004B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read thAllowedExceptions from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        thAllowedExceptions = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of thAllowedExceptions handling
        
        return returnCode, thAllowedExceptions
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetRnsFramesExceptionLimitReached(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000004C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read framesReached from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        framesReached = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of framesReached handling
        
        return returnCode, framesReached
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetAppliedClip(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000004D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    def CLIENT_pkg_gao_SetAppliedClipEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0000004F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: gao

    def CLIENT_pkg_gao_GetAppliedClipEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00000050, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: gao

    # Begin Module: imageStats
    def CLIENT_pkg_imageStats_GetTotalHistPixelsInROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read totalPixelsInROI from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        totalPixelsInROI = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of totalPixelsInROI handling
        
        return returnCode, totalPixelsInROI
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetPopBelowLowToHighThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read popBelowLowToHighThresh from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        popBelowLowToHighThresh = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of popBelowLowToHighThresh handling
        
        return returnCode, popBelowLowToHighThresh
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetPopAboveHighToLowThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read popAboveHighToLowThresh from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        popAboveHighToLowThresh = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of popAboveHighToLowThresh handling
        
        return returnCode, popAboveHighToLowThresh
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_SetROI(self, roi):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write roi to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ROI_TToByte(roi,sendData,outPtr)
        outPtr += 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read roi from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        roi = byteToFLR_ROI_T(receiveData,inPtr)
        inPtr+=8
        # end of roi handling
        
        return returnCode, roi
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetFirstBin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read firstBin from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        firstBin = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of firstBin handling
        
        return returnCode, firstBin
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetLastBin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read lastBin from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        lastBin = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of lastBin handling
        
        return returnCode, lastBin
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetMean(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read mean from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        mean = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of mean handling
        
        return returnCode, mean
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetFirstBinInROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read firstBinInROI from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        firstBinInROI = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of firstBinInROI handling
        
        return returnCode, firstBinInROI
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetLastBinInROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read lastBinInROI from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        lastBinInROI = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of lastBinInROI handling
        
        return returnCode, lastBinInROI
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetMeanInROI(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read meanInROI from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        meanInROI = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of meanInROI handling
        
        return returnCode, meanInROI
        
    #End of Module: imageStats

    def CLIENT_pkg_imageStats_GetImageStats(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 6
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001D000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read meanIntensity from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        meanIntensity = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of meanIntensity handling
        
        # read peakIntensity from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        peakIntensity = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of peakIntensity handling
        
        # read baseIntensity from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        baseIntensity = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of baseIntensity handling
        
        return returnCode, meanIntensity, peakIntensity, baseIntensity
        
    #End of Module: imageStats

    # Begin Module: isotherm
    def CLIENT_pkg_isotherm_GetEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0046, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read isothermEnable from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        isothermEnable = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of isothermEnable handling
        
        return returnCode, isothermEnable
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetEnable(self, isothermEnable):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write isothermEnable to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(isothermEnable.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0047, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetTemps(self, table, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5):
        # Create bytearray object for inputs
        sendBytes = 24
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        # write thIsoT1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(thIsoT1,sendData,outPtr)
        outPtr += 4
        
        # write thIsoT2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(thIsoT2,sendData,outPtr)
        outPtr += 4
        
        # write thIsoT3 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(thIsoT3,sendData,outPtr)
        outPtr += 4
        
        # write thIsoT4 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(thIsoT4,sendData,outPtr)
        outPtr += 4
        
        # write thIsoT5 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(thIsoT5,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0048, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetTemps(self, table):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 20
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0049, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read thIsoT1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        thIsoT1 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of thIsoT1 handling
        
        # read thIsoT2 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        thIsoT2 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of thIsoT2 handling
        
        # read thIsoT3 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        thIsoT3 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of thIsoT3 handling
        
        # read thIsoT4 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        thIsoT4 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of thIsoT4 handling
        
        # read thIsoT5 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None
        thIsoT5 = byteToINT_32(receiveData,inPtr)
        inPtr+=4
        # end of thIsoT5 handling
        
        return returnCode, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetIsoColorValues(self, table, region0, region1, region2, region3, region4, region5):
        # Create bytearray object for inputs
        sendBytes = 124
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        # write region0 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region0,sendData,outPtr)
        outPtr += 20
        
        # write region1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region1,sendData,outPtr)
        outPtr += 20
        
        # write region2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region2,sendData,outPtr)
        outPtr += 20
        
        # write region3 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region3,sendData,outPtr)
        outPtr += 20
        
        # write region4 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region4,sendData,outPtr)
        outPtr += 20
        
        # write region5 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_COLORS_TToByte(region5,sendData,outPtr)
        outPtr += 20
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetIsoColorValues(self, table):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 120
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, region0, region1, region2, region3, region4, region5
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read region0 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region0 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region0 handling
        
        # read region1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region1 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region1 handling
        
        # read region2 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region2 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region2 handling
        
        # read region3 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region3 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region3 handling
        
        # read region4 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region4 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region4 handling
        
        # read region5 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region5 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr)
        inPtr+=20
        # end of region5 handling
        
        return returnCode, region0, region1, region2, region3, region4, region5
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetRegionMode(self, table, region0, region1, region2, region3, region4, region5):
        # Create bytearray object for inputs
        sendBytes = 28
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        # write region0 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region0.value,sendData,outPtr)
        outPtr += 4
        
        # write region1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region1.value,sendData,outPtr)
        outPtr += 4
        
        # write region2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region2.value,sendData,outPtr)
        outPtr += 4
        
        # write region3 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region3.value,sendData,outPtr)
        outPtr += 4
        
        # write region4 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region4.value,sendData,outPtr)
        outPtr += 4
        
        # write region5 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(region5.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetRegionMode(self, table):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 24
        
        # write table to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, region0, region1, region2, region3, region4, region5
        INT_32ToByte(table.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read region0 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region0 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region0 handling
        
        # read region1 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region1 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region1 handling
        
        # read region2 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region2 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region2 handling
        
        # read region3 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region3 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region3 handling
        
        # read region4 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region4 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region4 handling
        
        # read region5 from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None, None, None
        region5 = FLR_ISOTHERM_REGION_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of region5 handling
        
        return returnCode, region0, region1, region2, region3, region4, region5
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetUnit(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read unit from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        unit = FLR_ISOTHERM_UNIT_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of unit handling
        
        return returnCode, unit
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetUnit(self, unit):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write unit to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(unit.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F004F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetSettingsLowGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 164
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0050, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read settings from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        settings = byteToFLR_ISOTHERM_SETTINGS_T(receiveData,inPtr)
        inPtr+=164
        # end of settings handling
        
        return returnCode, settings
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetSettingsLowGain(self, settings):
        # Create bytearray object for inputs
        sendBytes = 164
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write settings to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_SETTINGS_TToByte(settings,sendData,outPtr)
        outPtr += 164
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0051, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetSettingsHighGain(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 164
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0052, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read settings from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        settings = byteToFLR_ISOTHERM_SETTINGS_T(receiveData,inPtr)
        inPtr+=164
        # end of settings handling
        
        return returnCode, settings
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetSettingsHighGain(self, settings):
        # Create bytearray object for inputs
        sendBytes = 164
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write settings to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ISOTHERM_SETTINGS_TToByte(settings,sendData,outPtr)
        outPtr += 164
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0053, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_SetColorLutId(self, colorLutIdLowGain, colorLutIdHighGain):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write colorLutIdLowGain to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(colorLutIdLowGain.value,sendData,outPtr)
        outPtr += 4
        
        # write colorLutIdHighGain to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(colorLutIdHighGain.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0054, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: isotherm

    def CLIENT_pkg_isotherm_GetColorLutId(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x003F0055, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read colorLutIdLowGain from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        colorLutIdLowGain = FLR_COLORLUT_ID_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of colorLutIdLowGain handling
        
        # read colorLutIdHighGain from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        colorLutIdHighGain = FLR_COLORLUT_ID_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of colorLutIdHighGain handling
        
        return returnCode, colorLutIdLowGain, colorLutIdHighGain
        
    #End of Module: isotherm

    # Begin Module: jffs2
    def CLIENT_pkg_jffs2_Mount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00170001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: jffs2

    def CLIENT_pkg_jffs2_Unmount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00170002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: jffs2

    def CLIENT_pkg_jffs2_GetState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00170007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read state from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        state = FLR_JFFS2_STATE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of state handling
        
        return returnCode, state
        
    #End of Module: jffs2

    # Begin Module: lagrange
    # Begin Module: lfsr
    def CLIENT_pkg_lfsr_SetApplyOffsetEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetApplyOffsetEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetMaxIterations(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetMaxIterations(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetDf(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetDf(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetLambda1(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetLambda1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetLambda2(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetLambda2(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetHaltEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetHaltEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetRandomMethod(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetRandomMethod(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetSingleStepEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetSingleStepEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetR_LocalBump(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetR_LocalBump(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetR_CornerBump(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetR_CornerBump(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetFFC_ResetEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetFFC_ResetEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_SetNormalizeAtCenterSpotState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: lfsr

    def CLIENT_pkg_lfsr_GetNormalizeAtCenterSpotState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002C0029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: lfsr

    # Begin Module: mem
    def CLIENT_pkg_mem_ReadCapture(self, bufferNum, offset, sizeInBytes):
        # Create bytearray object for inputs
        sendBytes = 7
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 256
        
        # write bufferNum to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UCHARToByte(bufferNum,sendData,outPtr)
        outPtr += 1
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write sizeInBytes to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_16ToByte(sizeInBytes,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHARArray(receiveData,inPtr,sizeInBytes)
        inPtr+=sizeInBytes
        # end of data handling
        
        return returnCode, data
        
    #End of Module: mem

    def CLIENT_pkg_mem_GetCaptureSize(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read bytes from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        bytes = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of bytes handling
        
        # read rows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        rows = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of rows handling
        
        # read columns from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        columns = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of columns handling
        
        return returnCode, bytes, rows, columns
        
    #End of Module: mem

    def CLIENT_pkg_mem_WriteFlash(self, location, index, offset, sizeInBytes, data):
        # Create bytearray object for inputs
        sendBytes = sizeInBytes + 11
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write location to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(location.value,sendData,outPtr)
        outPtr += 4
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write sizeInBytes to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(sizeInBytes,sendData,outPtr)
        outPtr += 2
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(data,sizeInBytes,sendData,outPtr)
        outPtr += sizeInBytes
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: mem

    def CLIENT_pkg_mem_ReadFlash(self, location, index, offset, sizeInBytes):
        # Create bytearray object for inputs
        sendBytes = 11
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 256
        
        # write location to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        INT_32ToByte(location.value,sendData,outPtr)
        outPtr += 4
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write sizeInBytes to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_16ToByte(sizeInBytes,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHARArray(receiveData,inPtr,sizeInBytes)
        inPtr+=sizeInBytes
        # end of data handling
        
        return returnCode, data
        
    #End of Module: mem

    def CLIENT_pkg_mem_GetFlashSize(self, location):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write location to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, bytes
        INT_32ToByte(location.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read bytes from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        bytes = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of bytes handling
        
        return returnCode, bytes
        
    #End of Module: mem

    def CLIENT_pkg_mem_EraseFlash(self, location, index):
        # Create bytearray object for inputs
        sendBytes = 5
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write location to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(location.value,sendData,outPtr)
        outPtr += 4
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: mem

    def CLIENT_pkg_mem_EraseFlashPartial(self, location, index, offset, length):
        # Create bytearray object for inputs
        sendBytes = 13
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write location to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(location.value,sendData,outPtr)
        outPtr += 4
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write length to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(length,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: mem

    def CLIENT_pkg_mem_ReadCurrentGain(self, offset, sizeInBytes):
        # Create bytearray object for inputs
        sendBytes = 6
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 256
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write sizeInBytes to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_16ToByte(sizeInBytes,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHARArray(receiveData,inPtr,sizeInBytes)
        inPtr+=sizeInBytes
        # end of data handling
        
        return returnCode, data
        
    #End of Module: mem

    def CLIENT_pkg_mem_GetGainSize(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read bytes from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        bytes = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of bytes handling
        
        # read rows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        rows = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of rows handling
        
        # read columns from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        columns = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of columns handling
        
        return returnCode, bytes, rows, columns
        
    #End of Module: mem

    def CLIENT_pkg_mem_GetCaptureSizeSrc(self, src):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        # write src to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, bytes, rows, columns
        INT_32ToByte(src.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read bytes from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        bytes = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of bytes handling
        
        # read rows from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        rows = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of rows handling
        
        # read columns from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        columns = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of columns handling
        
        return returnCode, bytes, rows, columns
        
    #End of Module: mem

    def CLIENT_pkg_mem_ReadCaptureSrc(self, src, bufferNum, offset, sizeInBytes):
        # Create bytearray object for inputs
        sendBytes = 11
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 256
        
        # write src to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        INT_32ToByte(src.value,sendData,outPtr)
        outPtr += 4
        
        # write bufferNum to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UCHARToByte(bufferNum,sendData,outPtr)
        outPtr += 1
        
        # write offset to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_32ToByte(offset,sendData,outPtr)
        outPtr += 4
        
        # write sizeInBytes to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UINT_16ToByte(sizeInBytes,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0xFFFF000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHARArray(receiveData,inPtr,sizeInBytes)
        inPtr+=sizeInBytes
        # end of data handling
        
        return returnCode, data
        
    #End of Module: mem

    # Begin Module: normalize
    # Begin Module: radiometry
    def CLIENT_pkg_radiometry_SetTempStableEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempStableEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetFNumberLens0(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetFNumberLens0(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetFNumberLens1(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetFNumberLens1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTauLens0(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTauLens0(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTauLens1(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTauLens1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalGainDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalOffsetDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalGainApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalOffsetApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420011, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTComponentOverrideMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTComponentOverrideMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetGlobalGainOverride(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalGainOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetGlobalOffsetOverride(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalOffsetOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetGlobalParamOverrideMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGlobalParamOverrideMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetRBFOHighGainDefault(self, data):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRBFOHighGainDefault(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetRBFOLowGainDefault(self, data):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRBFOLowGainDefault(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetRBFOHighGainFactory(self, data):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRBFOHighGainFactory(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetRBFOLowGainFactory(self, data):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRBFOLowGainFactory(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetDampingFactor(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetDampingFactor(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGoMEQ(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420024, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGoMShutter(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGoMLens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGoMLG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGoMFFC(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempLensHousing(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempShutterHousing(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempShutterPaddle(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetFNumberShutterHousing(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetFNumberShutterHousing(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetEmissivityShutterHousing(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetEmissivityShutterHousing(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042002F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_DTfpa_Lens(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420030, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_DTfpa_Lens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420031, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetOffset_Lens(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420032, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetOffset_Lens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420033, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Recursive_Lens(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420034, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Recursive_Lens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420035, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGgFfc(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420036, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetCountsFromTemp(self, rbfoType, temp):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        # write rbfoType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, counts
        INT_32ToByte(rbfoType.value,sendData,outPtr)
        outPtr += 4
        
        # write temp to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, counts
        FLOATToByte(temp,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420037, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read counts from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        counts = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of counts handling
        
        return returnCode, counts
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempFromCounts(self, rbfoType, counts):
        # Create bytearray object for inputs
        sendBytes = 6
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write rbfoType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, temp
        INT_32ToByte(rbfoType.value,sendData,outPtr)
        outPtr += 4
        
        # write counts to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, temp
        UINT_16ToByte(counts,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420038, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read temp from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        temp = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of temp handling
        
        return returnCode, temp
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempLensHousingOverride(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420039, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempLensHousingOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempShutterHousingOverride(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempShutterHousingOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempShutterPaddleOverride(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempShutterPaddleOverride(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetSignalFactorLut(self, data):
        # Create bytearray object for inputs
        sendBytes = 34
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr)
        outPtr += 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042003F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetSignalFactorLut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420040, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T(receiveData,inPtr)
        inPtr+=34
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetNoiseFactorLut(self, data):
        # Create bytearray object for inputs
        sendBytes = 34
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr)
        outPtr += 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420041, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetNoiseFactorLut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420042, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T(receiveData,inPtr)
        inPtr+=34
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_tfpaK(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420047, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_tfpaK(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420048, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_tfpaK(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420049, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_tfpaK(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTAuxParams(self, data):
        # Create bytearray object for inputs
        sendBytes = 16
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_RADIOMETRY_TAUX_PARAMS_TToByte(data,sendData,outPtr)
        outPtr += 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTAuxParams(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_RADIOMETRY_TAUX_PARAMS_T(receiveData,inPtr)
        inPtr+=16
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_tAux(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_tAux(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_tAux(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042004F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_tAux(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420050, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTsource_FFC(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420051, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTsource_FFC(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420052, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_DTfpa_Sh_h(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420053, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_DTfpa_Sh_h(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420054, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetOffset_Sh_h(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420055, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetOffset_Sh_h(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420056, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Recursive_Sh_h(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420057, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Recursive_Sh_h(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420058, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_DTfpa_Sh_p(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420059, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_DTfpa_Sh_p(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetOffset_Sh_p(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetOffset_Sh_p(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Recursive_Sh_p(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Recursive_Sh_p(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_p(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042005F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_p(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420060, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_p(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420061, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_p(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420062, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetDtTfpaK(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420064, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetDtTfpaK_Damp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420065, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTAuxK(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420066, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetExternalFfcUpdateMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420067, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetExternalFfcUpdateMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420068, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGG_scale(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempWindow(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempWindow(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTransmissionWindow(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTransmissionWindow(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetReflectivityWindow(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042006F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetReflectivityWindow(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420070, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempWindowReflection(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420071, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempWindowReflection(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420072, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTransmissionAtmosphere(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420073, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTransmissionAtmosphere(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420074, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempAtmosphere(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420075, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempAtmosphere(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420076, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetEmissivityTarget(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420077, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetEmissivityTarget(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420078, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTempBackground(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420079, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTempBackground(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042007A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRadiometryCapable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042007D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetdeltaTempDampingFactor(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042007E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetdeltaTempDampingFactor(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042007F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetdeltaTempIntervalTime(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420080, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetdeltaTempIntervalTime(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420081, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetdeltaTempMaxValue(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420082, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetdeltaTempMaxValue(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420083, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetdeltaTempMaxIncrement(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420084, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetdeltaTempMaxIncrement(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420085, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetdeltaTempDampingTime(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420086, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetdeltaTempDampingTime(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420087, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetResponsivityFpaTemp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420088, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Lens(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420089, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Lens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Lens(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Lens(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_h(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_h(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_h(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042008F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_h(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420090, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetGG_Scale_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420091, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGG_Scale_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420092, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetGG_Scale_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420093, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGG_Scale_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420094, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetRbfoScaledMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420095, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetRbfoScaledMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420096, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetUncertaintyFactor(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420097, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTRoomMinThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00420099, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTRoomMaxThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042009B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTOperatingMinThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042009D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTOperatingMaxThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0042009F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetStableTempThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200A1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetSlowDriftThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200A3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetFfcTempThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200A5, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTargetTempMinThreshLG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200A7, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTargetTempMaxThreshLG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200A9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetMFactorThresh(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200AB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTargetTempMinThreshHG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200AD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTargetTempMaxThreshHG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200AF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetUncertaintyStatusBits(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B0, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTemperatureOffset_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTemperatureOffset_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B2, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetTemperatureOffset_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetTemperatureOffset_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B4, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Lens_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B5, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Lens_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B6, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Lens_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B7, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Lens_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B8, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Lens_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200B9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Lens_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Lens_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Lens_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BC, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetOffset_Lens_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetOffset_Lens_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BE, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetOffset_Lens_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200BF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetOffset_Lens_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C0, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_p_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_p_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C2, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_p_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C3, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_p_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C4, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_p_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C5, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_p_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C6, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_p_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C7, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_p_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C8, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_h_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200C9, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_h_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CA, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_h_HG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CB, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_h_HG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CC, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetM_Delta_Sh_h_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CD, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetM_Delta_Sh_h_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CE, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_SetB_Delta_Sh_h_LG(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200CF, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetB_Delta_Sh_h_LG(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200D0, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    def CLIENT_pkg_radiometry_GetGG_RoomTemp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x004200D1, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: radiometry

    # Begin Module: roic
    def CLIENT_pkg_roic_GetFPATemp(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFrameCount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetActiveNormalizationTarget(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFPARampState(self, state):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write state to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(state.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFPARampState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read state from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        state = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of state handling
        
        return returnCode, state
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetSensorADC1(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetSensorADC2(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFPATempOffset(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFPATempOffset(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFPATempMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFPATempMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ROIC_TEMP_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFPATempTable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 64
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read table from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        table = byteToFLR_ROIC_FPATEMP_TABLE_T(receiveData,inPtr)
        inPtr+=64
        # end of table handling
        
        return returnCode, table
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFPATempValue(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFPATempValue(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetPreambleError(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read preambleError from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        preambleError = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of preambleError handling
        
        return returnCode, preambleError
        
    #End of Module: roic

    def CLIENT_pkg_roic_InducePreambleError(self, everyNthFrame):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write everyNthFrame to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(everyNthFrame,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002002B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetRoicStarted(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002002C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read roicStarted from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        roicStarted = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of roicStarted handling
        
        return returnCode, roicStarted
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFrameSkip(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00020039, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    def CLIENT_pkg_roic_GetFrameSkip(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002003A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: roic

    def CLIENT_pkg_roic_SetFrameOneShot(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0002003D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: roic

    # Begin Module: scaler
    def CLIENT_pkg_scaler_GetMaxZoom(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000D0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read zoom from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        zoom = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of zoom handling
        
        return returnCode, zoom
        
    #End of Module: scaler

    def CLIENT_pkg_scaler_SetZoom(self, zoomParams):
        # Create bytearray object for inputs
        sendBytes = 12
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write zoomParams to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SCALER_ZOOM_PARAMS_TToByte(zoomParams,sendData,outPtr)
        outPtr += 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000D0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scaler

    def CLIENT_pkg_scaler_GetZoom(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000D0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read zoomParams from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        zoomParams = byteToFLR_SCALER_ZOOM_PARAMS_T(receiveData,inPtr)
        inPtr+=12
        # end of zoomParams handling
        
        return returnCode, zoomParams
        
    #End of Module: scaler

    def CLIENT_pkg_scaler_SetFractionalZoom(self, zoomNumerator, zoomDenominator, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable):
        # Create bytearray object for inputs
        sendBytes = 32
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write zoomNumerator to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomNumerator,sendData,outPtr)
        outPtr += 4
        
        # write zoomDenominator to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomDenominator,sendData,outPtr)
        outPtr += 4
        
        # write zoomXCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomXCenter,sendData,outPtr)
        outPtr += 4
        
        # write zoomYCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomYCenter,sendData,outPtr)
        outPtr += 4
        
        # write inChangeEnable to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(inChangeEnable.value,sendData,outPtr)
        outPtr += 4
        
        # write zoomOutXCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomOutXCenter,sendData,outPtr)
        outPtr += 4
        
        # write zoomOutYCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomOutYCenter,sendData,outPtr)
        outPtr += 4
        
        # write outChangeEnable to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(outChangeEnable.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000D0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scaler

    def CLIENT_pkg_scaler_SetIndexZoom(self, zoomIndex, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable):
        # Create bytearray object for inputs
        sendBytes = 28
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write zoomIndex to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomIndex,sendData,outPtr)
        outPtr += 4
        
        # write zoomXCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomXCenter,sendData,outPtr)
        outPtr += 4
        
        # write zoomYCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomYCenter,sendData,outPtr)
        outPtr += 4
        
        # write inChangeEnable to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(inChangeEnable.value,sendData,outPtr)
        outPtr += 4
        
        # write zoomOutXCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomOutXCenter,sendData,outPtr)
        outPtr += 4
        
        # write zoomOutYCenter to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(zoomOutYCenter,sendData,outPtr)
        outPtr += 4
        
        # write outChangeEnable to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(outChangeEnable.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000D0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scaler

    # Begin Module: scnr
    def CLIENT_pkg_scnr_SetEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetThColSum(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetThColSum(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetThPixel(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetThPixel(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetMaxCorr(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetMaxCorr(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetThPixelApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetMaxCorrApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetThColSumSafe(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetThColSumSafe(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetThPixelSafe(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetThPixelSafe(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetMaxCorrSafe(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetMaxCorrSafe(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080011, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetCorrectionMethod(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetCorrectionMethod(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SCNR_CORR_SELECT_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetStdThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetStdThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetNFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetNFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetResetDesired(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetResetDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetM_modeOnly(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetM_modeOnly(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SCNR_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetSpecklesEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetSpecklesThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetSpecklesRatio(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080024, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesRatio(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetSpecklesDF(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesDF(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesDiffsBufferAddr(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesOffsBufferAddr(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00080029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_SetSpecklesResetDesired(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008002A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: scnr

    def CLIENT_pkg_scnr_GetSpecklesResetDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0008002B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: scnr

    # Begin Module: sffc
    def CLIENT_pkg_sffc_GetScaleFactor(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_GetDeltaTempLinearCoeff(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_SetDeltaTempLinearCoeff(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_GetDeltaTempOffsetCoeff(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_SetDeltaTempOffsetCoeff(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_GetFpaTempLinearCoeff(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_SetFpaTempLinearCoeff(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_GetFpaTempOffsetCoeff(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_SetFpaTempOffsetCoeff(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_GetDeltaTempTimeLimitInSecs(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sffc

    def CLIENT_pkg_sffc_SetDeltaTempTimeLimitInSecs(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001C000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sffc

    # Begin Module: splashScreen
    def CLIENT_pkg_splashScreen_SetDuration(self, screen_num, periodMs):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        # write periodMs to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(periodMs,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: splashScreen

    def CLIENT_pkg_splashScreen_SetDataType(self, screen_num, filetype):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        # write filetype to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(filetype.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: splashScreen

    def CLIENT_pkg_splashScreen_SetBackground(self, screen_num, backgroundColor):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        # write backgroundColor to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(backgroundColor,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: splashScreen

    def CLIENT_pkg_splashScreen_GetDuration(self, screen_num):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, periodMs
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read periodMs from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        periodMs = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of periodMs handling
        
        return returnCode, periodMs
        
    #End of Module: splashScreen

    def CLIENT_pkg_splashScreen_GetDataType(self, screen_num):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, filetype
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read filetype from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        filetype = FLR_SPLASHSCREEN_FILETYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of filetype handling
        
        return returnCode, filetype
        
    #End of Module: splashScreen

    def CLIENT_pkg_splashScreen_GetBackground(self, screen_num):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write screen_num to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, backgroundColor
        UINT_32ToByte(screen_num,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001A0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read backgroundColor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        backgroundColor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of backgroundColor handling
        
        return returnCode, backgroundColor
        
    #End of Module: splashScreen

    # Begin Module: spnr
    def CLIENT_pkg_spnr_SetEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SPNR_STATE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetFrameDelay(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetFrameDelay(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetSFApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read sf from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        sf = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of sf handling
        
        return returnCode, sf
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetPSDKernel(self, data):
        # Create bytearray object for inputs
        sendBytes = 256
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SPNR_PSD_KERNEL_TToByte(data,sendData,outPtr)
        outPtr += 256
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetPSDKernel(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 256
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_SPNR_PSD_KERNEL_T(receiveData,inPtr)
        inPtr+=256
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetSFMin(self, sfmin):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write sfmin to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(sfmin,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetSFMin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read sfmin from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        sfmin = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of sfmin handling
        
        return returnCode, sfmin
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetSFMax(self, sfmax):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write sfmax to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(sfmax,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetSFMax(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read sfmax from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        sfmax = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of sfmax handling
        
        return returnCode, sfmax
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetDFMin(self, dfmin):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write dfmin to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(dfmin,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetDFMin(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read dfmin from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        dfmin = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of dfmin handling
        
        return returnCode, dfmin
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetDFMax(self, dfmax):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write dfmax to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(dfmax,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetDFMax(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read dfmax from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        dfmax = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of dfmax handling
        
        return returnCode, dfmax
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetNormTarget(self, normTarget):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write normTarget to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(normTarget,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0024, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetNormTarget(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read normTarget from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        normTarget = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of normTarget handling
        
        return returnCode, normTarget
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetNormTargetApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read normTargetApplied from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        normTargetApplied = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of normTargetApplied handling
        
        return returnCode, normTargetApplied
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetThPix(self, th_pix):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write th_pix to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(th_pix,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetThPix(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read th_pix from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        th_pix = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of th_pix handling
        
        return returnCode, th_pix
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetThPixSum(self, th_pixSum):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write th_pixSum to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(th_pixSum,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetThPixSum(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C002A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read th_pixSum from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        th_pixSum = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of th_pixSum handling
        
        return returnCode, th_pixSum
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetMaxcorr(self, maxcorr):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write maxcorr to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(maxcorr,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C002B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetMaxcorr(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C002C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read maxcorr from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        maxcorr = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of maxcorr handling
        
        return returnCode, maxcorr
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetAlgorithm(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0033, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SPNR_ALGORITHM_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_SetAlgorithmDesired(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0034, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spnr

    def CLIENT_pkg_spnr_GetAlgorithmDesired(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000C0035, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SPNR_ALGORITHM_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spnr

    # Begin Module: spotMeter
    def CLIENT_pkg_spotMeter_SetEnable(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetRoiMaxSize(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read width from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        width = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of width handling
        
        # read height from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        height = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of height handling
        
        return returnCode, width, height
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_SetRoi(self, roi):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write roi to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_ROI_TToByte(roi,sendData,outPtr)
        outPtr += 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetRoi(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 8
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read roi from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        roi = byteToFLR_ROI_T(receiveData,inPtr)
        inPtr+=8
        # end of roi handling
        
        return returnCode, roi
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetSpotStats(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 16
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read mean from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        mean = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of mean handling
        
        # read deviation from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        deviation = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of deviation handling
        
        # read min from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        min = byteToFLR_SPOTMETER_SPOT_PARAM_T(receiveData,inPtr)
        inPtr+=6
        # end of min handling
        
        # read max from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        max = byteToFLR_SPOTMETER_SPOT_PARAM_T(receiveData,inPtr)
        inPtr+=6
        # end of max handling
        
        return returnCode, mean, deviation, min, max
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_SetStatsMode(self, mode):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write mode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(mode.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetStatsMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read mode from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        mode = FLR_SPOTMETER_STATS_TEMP_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of mode handling
        
        return returnCode, mode
        
    #End of Module: spotMeter

    def CLIENT_pkg_spotMeter_GetTempStats(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 24
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00430008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None, None
        
        inPtr = 0 #simple array index
        
        # read mean from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        mean = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of mean handling
        
        # read deviation from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        deviation = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of deviation handling
        
        # read min from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        min = byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T(receiveData,inPtr)
        inPtr+=8
        # end of min handling
        
        # read max from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None, None
        max = byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T(receiveData,inPtr)
        inPtr+=8
        # end of max handling
        
        return returnCode, mean, deviation, min, max
        
    #End of Module: spotMeter

    # Begin Module: srnr
    def CLIENT_pkg_srnr_SetEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_SetThRowSum(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetThRowSum(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_SetThPixel(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetThPixel(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_SetMaxCorr(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetMaxCorr(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00280008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetThPixelApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0028000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    def CLIENT_pkg_srnr_GetMaxCorrApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0028000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: srnr

    # Begin Module: symbology
    def CLIENT_pkg_symbology_SetEnable(self, draw_symbols):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write draw_symbols to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(draw_symbols.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateBitmap(self, ID, pos_X, pos_Y, width, height):
        # Create bytearray object for inputs
        sendBytes = 9
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SendData(self, ID, size, text):
        # Create bytearray object for inputs
        sendBytes = 131
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write size to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(size,sendData,outPtr)
        outPtr += 2
        
        # write text to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(text,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateArc(self, ID, pos_X, pos_Y, width, height, start_angle, end_angle, color):
        # Create bytearray object for inputs
        sendBytes = 21
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write start_angle to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(start_angle,sendData,outPtr)
        outPtr += 4
        
        # write end_angle to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLOATToByte(end_angle,sendData,outPtr)
        outPtr += 4
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateText(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, text):
        # Create bytearray object for inputs
        sendBytes = 146
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write font to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        CHARToByte(font,sendData,outPtr)
        outPtr += 1
        
        # write size to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(size,sendData,outPtr)
        outPtr += 2
        
        # write alignment to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(alignment.value,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        # write text to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(text,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_MoveSprite(self, ID, pos_X, pos_Y):
        # Create bytearray object for inputs
        sendBytes = 5
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_AddToGroup(self, ID, group_ID):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write group_ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(group_ID,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_RemoveFromGroup(self, ID, group_ID):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write group_ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(group_ID,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_UpdateAndShow(self, ID, visible):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write visible to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(visible,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_UpdateAndShowGroup(self, group_ID, visible):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write group_ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(group_ID,sendData,outPtr)
        outPtr += 1
        
        # write visible to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(visible,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_Delete(self, ID):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_DeleteGroup(self, group_ID):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write group_ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(group_ID,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateFilledRectangle(self, ID, pos_X, pos_Y, width, height, color):
        # Create bytearray object for inputs
        sendBytes = 13
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateOutlinedRectangle(self, ID, pos_X, pos_Y, width, height, color):
        # Create bytearray object for inputs
        sendBytes = 13
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateBitmapFromPng(self, ID, pos_X, pos_Y, size):
        # Create bytearray object for inputs
        sendBytes = 7
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write size to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(size,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140012, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateCompressedBitmap(self, ID, pos_X, pos_Y, width, height):
        # Create bytearray object for inputs
        sendBytes = 9
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140014, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateBitmapFromPngFile(self, ID, pos_X, pos_Y, path):
        # Create bytearray object for inputs
        sendBytes = 133
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateBitmapFromFile(self, ID, pos_X, pos_Y, path, imageType):
        # Create bytearray object for inputs
        sendBytes = 135
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        # write imageType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(imageType.value,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_ResetWritePosition(self, ID):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_MoveByOffset(self, ID, off_X, off_Y):
        # Create bytearray object for inputs
        sendBytes = 5
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write off_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(off_X,sendData,outPtr)
        outPtr += 2
        
        # write off_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(off_Y,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_MoveGroupByOffset(self, ID, off_X, off_Y):
        # Create bytearray object for inputs
        sendBytes = 5
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write off_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(off_X,sendData,outPtr)
        outPtr += 2
        
        # write off_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(off_Y,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateFilledEllipse(self, ID, pos_X, pos_Y, width, height, color):
        # Create bytearray object for inputs
        sendBytes = 13
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateLine(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color):
        # Create bytearray object for inputs
        sendBytes = 13
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write pos_X2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X2,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y2,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SetZorder(self, ID, zorder):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write zorder to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(zorder,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SaveConfiguration(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_ReloadConfiguration(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_GetEnable(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read draw_symbols from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        draw_symbols = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of draw_symbols handling
        
        return returnCode, draw_symbols
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SetClonesNumber(self, ID, numberOfClones):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write numberOfClones to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(numberOfClones,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140021, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_MoveCloneByOffset(self, ID, cloneID, pos_X, pos_Y):
        # Create bytearray object for inputs
        sendBytes = 6
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write cloneID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(cloneID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140022, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_MoveCloneSprite(self, ID, cloneID, pos_X, pos_Y):
        # Create bytearray object for inputs
        sendBytes = 6
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write cloneID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(cloneID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140023, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SetTransformation(self, transformation):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write transformation to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(transformation.value,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140024, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_UpdateAllVisible(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140025, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_SetSizeAndScalingMode(self, ID, width, height, scalingMode):
        # Create bytearray object for inputs
        sendBytes = 7
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write scalingMode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(scalingMode.value,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140026, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateLineHVT(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color1, color2, dashLen, thickness):
        # Create bytearray object for inputs
        sendBytes = 21
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write pos_X2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X2,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y2,sendData,outPtr)
        outPtr += 2
        
        # write color1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color1,sendData,outPtr)
        outPtr += 4
        
        # write color2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color2,sendData,outPtr)
        outPtr += 4
        
        # write dashLen to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(dashLen,sendData,outPtr)
        outPtr += 2
        
        # write thickness to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(thickness,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140027, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateTextHVT(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color1, color2, dashLen, text):
        # Create bytearray object for inputs
        sendBytes = 151
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write font to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        CHARToByte(font,sendData,outPtr)
        outPtr += 1
        
        # write size to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(size,sendData,outPtr)
        outPtr += 2
        
        # write alignment to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(alignment.value,sendData,outPtr)
        outPtr += 2
        
        # write color1 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color1,sendData,outPtr)
        outPtr += 4
        
        # write color2 to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color2,sendData,outPtr)
        outPtr += 4
        
        # write dashLen to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(dashLen,sendData,outPtr)
        outPtr += 1
        
        # write text to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(text,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140028, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateTextBg(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, bgColor, text):
        # Create bytearray object for inputs
        sendBytes = 150
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write font to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        CHARToByte(font,sendData,outPtr)
        outPtr += 1
        
        # write size to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(size,sendData,outPtr)
        outPtr += 2
        
        # write alignment to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(alignment.value,sendData,outPtr)
        outPtr += 2
        
        # write color to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(color,sendData,outPtr)
        outPtr += 4
        
        # write bgColor to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(bgColor,sendData,outPtr)
        outPtr += 4
        
        # write text to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(text,128,sendData,outPtr)
        outPtr += 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00140029, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    def CLIENT_pkg_symbology_CreateScaledBitmapFromFile(self, ID, pos_X, pos_Y, width, height, scalingMode, path, imageType):
        # Create bytearray object for inputs
        sendBytes = 141
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write ID to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(ID,sendData,outPtr)
        outPtr += 1
        
        # write pos_X to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_X,sendData,outPtr)
        outPtr += 2
        
        # write pos_Y to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(pos_Y,sendData,outPtr)
        outPtr += 2
        
        # write width to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(width,sendData,outPtr)
        outPtr += 2
        
        # write height to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(height,sendData,outPtr)
        outPtr += 2
        
        # write scalingMode to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(scalingMode.value,sendData,outPtr)
        outPtr += 2
        
        # write path to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARArrayToByte(path,128,sendData,outPtr)
        outPtr += 128
        
        # write imageType to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_16ToByte(imageType.value,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0014002A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: symbology

    # Begin Module: sysctrl
    def CLIENT_pkg_sysctrl_SetFreezeState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetFreezeState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetCameraFrameRate(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read frameRate from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        frameRate = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of frameRate handling
        
        return returnCode, frameRate
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetUptimeSecs(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read uptime from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        uptime = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of uptime handling
        
        return returnCode, uptime
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_SetUsbVideoIR16Mode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetUsbVideoIR16Mode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SYSCTRL_USBIR16_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_SetOperatingMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetOperatingMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0010, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_SYSCTRL_OPERATING_MODE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetAvgFpaTempCounts(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0018, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLOAT(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_SetFpaTempFrames(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0019, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: sysctrl

    def CLIENT_pkg_sysctrl_GetFpaTempFrames(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000E0020, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: sysctrl

    # Begin Module: sysinfo
    def CLIENT_pkg_sysinfo_GetMonitorSoftwareRev(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetMonitorBuildVariant(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 50
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read monitorBuildVariant from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        monitorBuildVariant = byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T(receiveData,inPtr)
        inPtr+=50
        # end of monitorBuildVariant handling
        
        return returnCode, monitorBuildVariant
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetProductName(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read name from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        name = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of name handling
        
        return returnCode, name
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetCameraSN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read number from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        number = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of number handling
        
        return returnCode, number
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetBootLocation(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read bootSwLocation from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        bootSwLocation = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of bootSwLocation handling
        
        return returnCode, bootSwLocation
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetSwConfigID(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read swConfigID from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        swConfigID = FLR_SYSINFO_SW_CONFIG_ID_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of swConfigID handling
        
        return returnCode, swConfigID
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetSwPermissions(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read swPermissions from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        swPermissions = FLR_SYSINFO_SW_PERMISSIONS_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of swPermissions handling
        
        return returnCode, swPermissions
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetIs9HzBuild(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read is9HzBuild from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        is9HzBuild = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of is9HzBuild handling
        
        return returnCode, is9HzBuild
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetProductVersion(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetMonitorProductRev(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 12
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read major from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        major = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of major handling
        
        # read minor from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        minor = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of minor handling
        
        # read patch from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        patch = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of patch handling
        
        return returnCode, major, minor, patch
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetOpticalRevision(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0011, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read revision from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        revision = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of revision handling
        
        return returnCode, revision
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetSensorRevision(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0013, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read revision from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        revision = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of revision handling
        
        return returnCode, revision
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetProbeTipSN(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 128
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0015, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read number from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        number = byteToUCHARArray(receiveData,inPtr,128)
        inPtr+=128
        # end of number handling
        
        return returnCode, number
        
    #End of Module: sysinfo

    def CLIENT_pkg_sysinfo_GetMechanicalRevision(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x002F0017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read revision from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        revision = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of revision handling
        
        return returnCode, revision
        
    #End of Module: sysinfo

    # Begin Module: systemSymbols
    def CLIENT_pkg_systemSymbols_GetID(self, symbol):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 5
        
        # write symbol to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, id, id_type
        INT_32ToByte(symbol.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None
        
        inPtr = 0 #simple array index
        
        # read id from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        id = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of id handling
        
        # read id_type from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None
        id_type = FLR_SYSTEMSYMBOLS_ID_TYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of id_type handling
        
        return returnCode, id, id_type
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_SetID(self, symbol, id, id_type):
        # Create bytearray object for inputs
        sendBytes = 9
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write symbol to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(symbol.value,sendData,outPtr)
        outPtr += 4
        
        # write id to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(id,sendData,outPtr)
        outPtr += 1
        
        # write id_type to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(id_type.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_GetEnable(self, symbol):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write symbol to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, enabled
        INT_32ToByte(symbol.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read enabled from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        enabled = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of enabled handling
        
        return returnCode, enabled
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_SetEnable(self, symbol, enabled):
        # Create bytearray object for inputs
        sendBytes = 8
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write symbol to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(symbol.value,sendData,outPtr)
        outPtr += 4
        
        # write enabled to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(enabled.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_GetSpotConfig(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 195
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read config from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        config = byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T(receiveData,inPtr)
        inPtr+=195
        # end of config handling
        
        return returnCode, config
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_SetSpotConfig(self, config):
        # Create bytearray object for inputs
        sendBytes = 195
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write config to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte(config,sendData,outPtr)
        outPtr += 195
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_GetIsoConfig(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 45
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read config from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        config = byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T(receiveData,inPtr)
        inPtr+=45
        # end of config handling
        
        return returnCode, config
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_SetIsoConfig(self, config):
        # Create bytearray object for inputs
        sendBytes = 45
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write config to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte(config,sendData,outPtr)
        outPtr += 45
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B000B, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_GetBarConfig(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 24
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B000C, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None, None, None
        
        inPtr = 0 #simple array index
        
        # read lowGainConfig from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        lowGainConfig = byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T(receiveData,inPtr)
        inPtr+=10
        # end of lowGainConfig handling
        
        # read highGainConfig from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        highGainConfig = byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T(receiveData,inPtr)
        inPtr+=10
        # end of highGainConfig handling
        
        # read unit from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None, None, None
        unit = FLR_TEMPERATURE_UNIT_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of unit handling
        
        return returnCode, lowGainConfig, highGainConfig, unit
        
    #End of Module: systemSymbols

    def CLIENT_pkg_systemSymbols_SetBarConfig(self, lowGainConfig, highGainConfig, unit):
        # Create bytearray object for inputs
        sendBytes = 24
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write lowGainConfig to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(lowGainConfig,sendData,outPtr)
        outPtr += 10
        
        # write highGainConfig to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(highGainConfig,sendData,outPtr)
        outPtr += 10
        
        # write unit to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(unit.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x001B000D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: systemSymbols

    # Begin Module: telemetry
    def CLIENT_pkg_telemetry_SetState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_GetState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_SetLocation(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_GetLocation(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_TELEMETRY_LOC_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_SetPacking(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_GetPacking(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_TELEMETRY_PACKING_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_SetOrder(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: telemetry

    def CLIENT_pkg_telemetry_GetOrder(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00040008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_TELEMETRY_ORDER_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: telemetry

    # Begin Module: testRamp
    def CLIENT_pkg_testRamp_SetType(self, index, data):
        # Create bytearray object for inputs
        sendBytes = 5
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetType(self, index):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_TESTRAMP_TYPE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_SetSettings(self, index, data):
        # Create bytearray object for inputs
        sendBytes = 7
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_TESTRAMP_SETTINGS_TToByte(data,sendData,outPtr)
        outPtr += 6
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetSettings(self, index):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 6
        
        # write index to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, data
        UCHARToByte(index,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_TESTRAMP_SETTINGS_T(receiveData,inPtr)
        inPtr+=6
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_SetMotionState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetMotionState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_SetIndex(self, data):
        # Create bytearray object for inputs
        sendBytes = 1
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UCHARToByte(data,sendData,outPtr)
        outPtr += 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetIndex(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetMaxIndex(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 1
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUCHAR(receiveData,inPtr)
        inPtr+=1
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_SetPN9ContinuousMode(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00100009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: testRamp

    def CLIENT_pkg_testRamp_GetPN9ContinuousMode(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x0010000A, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: testRamp

    # Begin Module: tf
    def CLIENT_pkg_tf_SetEnableState(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetEnableState(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0002, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_ENABLE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_SetDelta_nf(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0003, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetDelta_nf(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0004, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_SetTHDeltaMotion(self, data):
        # Create bytearray object for inputs
        sendBytes = 2
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_16ToByte(data,sendData,outPtr)
        outPtr += 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0005, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetTHDeltaMotion(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0006, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_SetWLut(self, data):
        # Create bytearray object for inputs
        sendBytes = 32
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_TF_WLUT_TToByte(data,sendData,outPtr)
        outPtr += 32
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0007, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetWLut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 32
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0008, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_TF_WLUT_T(receiveData,inPtr)
        inPtr+=32
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetMotionCount(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0009, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_SetMotionThreshold(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        UINT_32ToByte(data,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A000E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetMotionThreshold(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A000F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_32(receiveData,inPtr)
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetDelta_nfApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0016, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetTHDeltaMotionApplied(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A0017, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_SetTempSignalCompFactorLut(self, data):
        # Create bytearray object for inputs
        sendBytes = 34
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr)
        outPtr += 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A001D, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetTempSignalCompFactorLut(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 34
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A001E, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T(receiveData,inPtr)
        inPtr+=34
        # end of data handling
        
        return returnCode, data
        
    #End of Module: tf

    def CLIENT_pkg_tf_GetRnf(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 2
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x000A001F, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read rnf from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        rnf = byteToUINT_16(receiveData,inPtr)
        inPtr+=2
        # end of rnf handling
        
        return returnCode, rnf
        
    #End of Module: tf

    # Begin Module: uart
    def CLIENT_pkg_uart_SetStartupBaudRate(self, data):
        # Create bytearray object for inputs
        sendBytes = 4
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 0
        
        # write data to sendData buffer
        if(outPtr >= sendBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW
        INT_32ToByte(data.value,sendData,outPtr)
        outPtr += 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00400000, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode
        
        inPtr = 0 #simple array index
        
        return returnCode
        
    #End of Module: uart

    def CLIENT_pkg_uart_GetStartupBaudRate(self):
        # Create bytearray object for inputs
        sendBytes = 0
        sendData = bytearray(sendBytes)
        outPtr = 0 #simple array index in python
        expectedReceiveBytes = 4
        
        returnCode, receiveData = CLIENT_dispatch(self.__commandCount, 0x00400001, sendData, sendBytes, expectedReceiveBytes, self.fslp)
        self.__commandCount = fixSpecialBytes(self.__commandCount+1)
        
        # Check for any errorcode
        if(returnCode.value):
            return returnCode, None
        
        inPtr = 0 #simple array index
        
        # read data from receiveData buffer
        if(inPtr >= expectedReceiveBytes):
            return FLR_RESULT.R_API_PKG_BUFFER_OVERFLOW, None
        data = FLR_UART_STARTUP_BAUDRATE_E(byteToINT_32(receiveData,inPtr))
        inPtr+=4
        # end of data handling
        
        return returnCode, data
        
    #End of Module: uart

