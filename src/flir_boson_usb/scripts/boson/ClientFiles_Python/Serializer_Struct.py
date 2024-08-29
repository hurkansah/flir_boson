#  /////////////////////////////////////////////////////
#  // DO NOT EDIT.  This is a machine generated file. //
#  /////////////////////////////////////////////////////


from struct import unpack,pack_into
from .ReturnCodes import FLR_RESULT

# Garbage Variable to avoid ever having blank code

class FLR_BOSON_GAIN_SWITCH_PARAMS_T():
    def __init__(self):
        self.pHighToLowPercent = None
        self.cHighToLowPercent = None
        self.pLowToHighPercent = None
        self.hysteresisPercent = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 16
    
# end of FLR_BOSON_GAIN_SWITCH_PARAMS_T()

def byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_GAIN_SWITCH_PARAMS_T()
    returnStruct.pHighToLowPercent, returnStruct.cHighToLowPercent, returnStruct.pLowToHighPercent, returnStruct.hysteresisPercent = unpack(endian+"IIII",inBuff[inPtr:inPtr+16])
    return returnStruct
# end of byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T()

def FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte(inVal, outBuff, outPtr):
    pack_into(">IIII",outBuff,outPtr,inVal.pHighToLowPercent, inVal.cHighToLowPercent, inVal.pLowToHighPercent, inVal.hysteresisPercent)
# end of FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte()

class FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T():
    def __init__(self):
        self.pHighToLowPercent = None
        self.TempHighToLowDegK = None
        self.pLowToHighPercent = None
        self.TempLowToHighDegK = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 16
    
# end of FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T()

def byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T()
    returnStruct.pHighToLowPercent, returnStruct.TempHighToLowDegK, returnStruct.pLowToHighPercent, returnStruct.TempLowToHighDegK = unpack(endian+"IfIf",inBuff[inPtr:inPtr+16])
    return returnStruct
# end of byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T()

def FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte(inVal, outBuff, outPtr):
    pack_into(">IfIf",outBuff,outPtr,inVal.pHighToLowPercent, inVal.TempHighToLowDegK, inVal.pLowToHighPercent, inVal.TempLowToHighDegK)
# end of FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte()

class FLR_BOSON_PARTNUMBER_T():
    def __init__(self):
        self.value = [None]*20
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 20
    
# end of FLR_BOSON_PARTNUMBER_T()

def byteToFLR_BOSON_PARTNUMBER_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_PARTNUMBER_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19] = unpack(endian+"BBBBBBBBBBBBBBBBBBBB",inBuff[inPtr:inPtr+20])
    return returnStruct
# end of byteToFLR_BOSON_PARTNUMBER_T()

def FLR_BOSON_PARTNUMBER_TToByte(inVal, outBuff, outPtr):
    pack_into(">BBBBBBBBBBBBBBBBBBBB",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19])
# end of FLR_BOSON_PARTNUMBER_TToByte()

class FLR_BOSON_SATURATION_HEADER_LUT_T():
    def __init__(self):
        self.lut = FLR_BOSON_SATURATION_LUT_T()
        self.tableIndex = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 36
    
# end of FLR_BOSON_SATURATION_HEADER_LUT_T()

def byteToFLR_BOSON_SATURATION_HEADER_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_SATURATION_HEADER_LUT_T()
    returnStruct.lut.value[0], returnStruct.lut.value[1], returnStruct.lut.value[2], returnStruct.lut.value[3], returnStruct.lut.value[4], returnStruct.lut.value[5], returnStruct.lut.value[6], returnStruct.lut.value[7], returnStruct.lut.value[8], returnStruct.lut.value[9], returnStruct.lut.value[10], returnStruct.lut.value[11], returnStruct.lut.value[12], returnStruct.lut.value[13], returnStruct.lut.value[14], returnStruct.lut.value[15], returnStruct.lut.value[16], returnStruct.tableIndex = unpack(endian+"HHHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+36])
    return returnStruct
# end of byteToFLR_BOSON_SATURATION_HEADER_LUT_T()

def FLR_BOSON_SATURATION_HEADER_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.lut.value[0], inVal.lut.value[1], inVal.lut.value[2], inVal.lut.value[3], inVal.lut.value[4], inVal.lut.value[5], inVal.lut.value[6], inVal.lut.value[7], inVal.lut.value[8], inVal.lut.value[9], inVal.lut.value[10], inVal.lut.value[11], inVal.lut.value[12], inVal.lut.value[13], inVal.lut.value[14], inVal.lut.value[15], inVal.lut.value[16], inVal.tableIndex)
# end of FLR_BOSON_SATURATION_HEADER_LUT_TToByte()

class FLR_BOSON_SATURATION_LUT_T():
    def __init__(self):
        self.value = [None]*17
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 34
    
# end of FLR_BOSON_SATURATION_LUT_T()

def byteToFLR_BOSON_SATURATION_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_SATURATION_LUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16] = unpack(endian+"HHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+34])
    return returnStruct
# end of byteToFLR_BOSON_SATURATION_LUT_T()

def FLR_BOSON_SATURATION_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16])
# end of FLR_BOSON_SATURATION_LUT_TToByte()

class FLR_BOSON_SENSOR_PARTNUMBER_T():
    def __init__(self):
        self.value = [None]*32
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 32
    
# end of FLR_BOSON_SENSOR_PARTNUMBER_T()

def byteToFLR_BOSON_SENSOR_PARTNUMBER_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_BOSON_SENSOR_PARTNUMBER_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19], returnStruct.value[20], returnStruct.value[21], returnStruct.value[22], returnStruct.value[23], returnStruct.value[24], returnStruct.value[25], returnStruct.value[26], returnStruct.value[27], returnStruct.value[28], returnStruct.value[29], returnStruct.value[30], returnStruct.value[31] = unpack(endian+"BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",inBuff[inPtr:inPtr+32])
    return returnStruct
# end of byteToFLR_BOSON_SENSOR_PARTNUMBER_T()

def FLR_BOSON_SENSOR_PARTNUMBER_TToByte(inVal, outBuff, outPtr):
    pack_into(">BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19], inVal.value[20], inVal.value[21], inVal.value[22], inVal.value[23], inVal.value[24], inVal.value[25], inVal.value[26], inVal.value[27], inVal.value[28], inVal.value[29], inVal.value[30], inVal.value[31])
# end of FLR_BOSON_SENSOR_PARTNUMBER_TToByte()

class FLR_CAPTURE_FILE_SETTINGS_T():
    def __init__(self):
        self.captureFileType = None
        self.filePath = [None]*128
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 132
    
# end of FLR_CAPTURE_FILE_SETTINGS_T()

def byteToFLR_CAPTURE_FILE_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_CAPTURE_FILE_SETTINGS_T()
    returnStruct.captureFileType, returnStruct.filePath[0], returnStruct.filePath[1], returnStruct.filePath[2], returnStruct.filePath[3], returnStruct.filePath[4], returnStruct.filePath[5], returnStruct.filePath[6], returnStruct.filePath[7], returnStruct.filePath[8], returnStruct.filePath[9], returnStruct.filePath[10], returnStruct.filePath[11], returnStruct.filePath[12], returnStruct.filePath[13], returnStruct.filePath[14], returnStruct.filePath[15], returnStruct.filePath[16], returnStruct.filePath[17], returnStruct.filePath[18], returnStruct.filePath[19], returnStruct.filePath[20], returnStruct.filePath[21], returnStruct.filePath[22], returnStruct.filePath[23], returnStruct.filePath[24], returnStruct.filePath[25], returnStruct.filePath[26], returnStruct.filePath[27], returnStruct.filePath[28], returnStruct.filePath[29], returnStruct.filePath[30], returnStruct.filePath[31], returnStruct.filePath[32], returnStruct.filePath[33], returnStruct.filePath[34], returnStruct.filePath[35], returnStruct.filePath[36], returnStruct.filePath[37], returnStruct.filePath[38], returnStruct.filePath[39], returnStruct.filePath[40], returnStruct.filePath[41], returnStruct.filePath[42], returnStruct.filePath[43], returnStruct.filePath[44], returnStruct.filePath[45], returnStruct.filePath[46], returnStruct.filePath[47], returnStruct.filePath[48], returnStruct.filePath[49], returnStruct.filePath[50], returnStruct.filePath[51], returnStruct.filePath[52], returnStruct.filePath[53], returnStruct.filePath[54], returnStruct.filePath[55], returnStruct.filePath[56], returnStruct.filePath[57], returnStruct.filePath[58], returnStruct.filePath[59], returnStruct.filePath[60], returnStruct.filePath[61], returnStruct.filePath[62], returnStruct.filePath[63], returnStruct.filePath[64], returnStruct.filePath[65], returnStruct.filePath[66], returnStruct.filePath[67], returnStruct.filePath[68], returnStruct.filePath[69], returnStruct.filePath[70], returnStruct.filePath[71], returnStruct.filePath[72], returnStruct.filePath[73], returnStruct.filePath[74], returnStruct.filePath[75], returnStruct.filePath[76], returnStruct.filePath[77], returnStruct.filePath[78], returnStruct.filePath[79], returnStruct.filePath[80], returnStruct.filePath[81], returnStruct.filePath[82], returnStruct.filePath[83], returnStruct.filePath[84], returnStruct.filePath[85], returnStruct.filePath[86], returnStruct.filePath[87], returnStruct.filePath[88], returnStruct.filePath[89], returnStruct.filePath[90], returnStruct.filePath[91], returnStruct.filePath[92], returnStruct.filePath[93], returnStruct.filePath[94], returnStruct.filePath[95], returnStruct.filePath[96], returnStruct.filePath[97], returnStruct.filePath[98], returnStruct.filePath[99], returnStruct.filePath[100], returnStruct.filePath[101], returnStruct.filePath[102], returnStruct.filePath[103], returnStruct.filePath[104], returnStruct.filePath[105], returnStruct.filePath[106], returnStruct.filePath[107], returnStruct.filePath[108], returnStruct.filePath[109], returnStruct.filePath[110], returnStruct.filePath[111], returnStruct.filePath[112], returnStruct.filePath[113], returnStruct.filePath[114], returnStruct.filePath[115], returnStruct.filePath[116], returnStruct.filePath[117], returnStruct.filePath[118], returnStruct.filePath[119], returnStruct.filePath[120], returnStruct.filePath[121], returnStruct.filePath[122], returnStruct.filePath[123], returnStruct.filePath[124], returnStruct.filePath[125], returnStruct.filePath[126], returnStruct.filePath[127] = unpack(endian+"iBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",inBuff[inPtr:inPtr+132])
    return returnStruct
# end of byteToFLR_CAPTURE_FILE_SETTINGS_T()

def FLR_CAPTURE_FILE_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">iBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",outBuff,outPtr,inVal.captureFileType, inVal.filePath[0], inVal.filePath[1], inVal.filePath[2], inVal.filePath[3], inVal.filePath[4], inVal.filePath[5], inVal.filePath[6], inVal.filePath[7], inVal.filePath[8], inVal.filePath[9], inVal.filePath[10], inVal.filePath[11], inVal.filePath[12], inVal.filePath[13], inVal.filePath[14], inVal.filePath[15], inVal.filePath[16], inVal.filePath[17], inVal.filePath[18], inVal.filePath[19], inVal.filePath[20], inVal.filePath[21], inVal.filePath[22], inVal.filePath[23], inVal.filePath[24], inVal.filePath[25], inVal.filePath[26], inVal.filePath[27], inVal.filePath[28], inVal.filePath[29], inVal.filePath[30], inVal.filePath[31], inVal.filePath[32], inVal.filePath[33], inVal.filePath[34], inVal.filePath[35], inVal.filePath[36], inVal.filePath[37], inVal.filePath[38], inVal.filePath[39], inVal.filePath[40], inVal.filePath[41], inVal.filePath[42], inVal.filePath[43], inVal.filePath[44], inVal.filePath[45], inVal.filePath[46], inVal.filePath[47], inVal.filePath[48], inVal.filePath[49], inVal.filePath[50], inVal.filePath[51], inVal.filePath[52], inVal.filePath[53], inVal.filePath[54], inVal.filePath[55], inVal.filePath[56], inVal.filePath[57], inVal.filePath[58], inVal.filePath[59], inVal.filePath[60], inVal.filePath[61], inVal.filePath[62], inVal.filePath[63], inVal.filePath[64], inVal.filePath[65], inVal.filePath[66], inVal.filePath[67], inVal.filePath[68], inVal.filePath[69], inVal.filePath[70], inVal.filePath[71], inVal.filePath[72], inVal.filePath[73], inVal.filePath[74], inVal.filePath[75], inVal.filePath[76], inVal.filePath[77], inVal.filePath[78], inVal.filePath[79], inVal.filePath[80], inVal.filePath[81], inVal.filePath[82], inVal.filePath[83], inVal.filePath[84], inVal.filePath[85], inVal.filePath[86], inVal.filePath[87], inVal.filePath[88], inVal.filePath[89], inVal.filePath[90], inVal.filePath[91], inVal.filePath[92], inVal.filePath[93], inVal.filePath[94], inVal.filePath[95], inVal.filePath[96], inVal.filePath[97], inVal.filePath[98], inVal.filePath[99], inVal.filePath[100], inVal.filePath[101], inVal.filePath[102], inVal.filePath[103], inVal.filePath[104], inVal.filePath[105], inVal.filePath[106], inVal.filePath[107], inVal.filePath[108], inVal.filePath[109], inVal.filePath[110], inVal.filePath[111], inVal.filePath[112], inVal.filePath[113], inVal.filePath[114], inVal.filePath[115], inVal.filePath[116], inVal.filePath[117], inVal.filePath[118], inVal.filePath[119], inVal.filePath[120], inVal.filePath[121], inVal.filePath[122], inVal.filePath[123], inVal.filePath[124], inVal.filePath[125], inVal.filePath[126], inVal.filePath[127])
# end of FLR_CAPTURE_FILE_SETTINGS_TToByte()

class FLR_CAPTURE_SETTINGS_T():
    def __init__(self):
        self.dataSrc = None
        self.numFrames = None
        self.bufferIndex = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 10
    
# end of FLR_CAPTURE_SETTINGS_T()

def byteToFLR_CAPTURE_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_CAPTURE_SETTINGS_T()
    returnStruct.dataSrc, returnStruct.numFrames, returnStruct.bufferIndex = unpack(endian+"iIH",inBuff[inPtr:inPtr+10])
    return returnStruct
# end of byteToFLR_CAPTURE_SETTINGS_T()

def FLR_CAPTURE_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">iIH",outBuff,outPtr,inVal.dataSrc, inVal.numFrames, inVal.bufferIndex)
# end of FLR_CAPTURE_SETTINGS_TToByte()

class FLR_CAPTURE_STATUS_T():
    def __init__(self):
        self.state = None
        self.result = None
        self.capturedFrames = None
        self.missedFrames = None
        self.savedFrames = None
        self.unsyncFrames = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 24
    
# end of FLR_CAPTURE_STATUS_T()

def byteToFLR_CAPTURE_STATUS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_CAPTURE_STATUS_T()
    returnStruct.state, returnStruct.result, returnStruct.capturedFrames, returnStruct.missedFrames, returnStruct.savedFrames, returnStruct.unsyncFrames = unpack(endian+"iIIIII",inBuff[inPtr:inPtr+24])
    return returnStruct
# end of byteToFLR_CAPTURE_STATUS_T()

def FLR_CAPTURE_STATUS_TToByte(inVal, outBuff, outPtr):
    pack_into(">iIIIII",outBuff,outPtr,inVal.state, inVal.result, inVal.capturedFrames, inVal.missedFrames, inVal.savedFrames, inVal.unsyncFrames)
# end of FLR_CAPTURE_STATUS_TToByte()

class FLR_DVO_LCD_CONFIG_T():
    def __init__(self):
        self.width = None
        self.hPulseWidth = None
        self.hBackP = None
        self.hFrontP = None
        self.height = None
        self.vPulseWidth = None
        self.vBackP = None
        self.vFrontP = None
        self.outputFormat = None
        self.control = None
        self.rotation = None
        self.pixelClockkHz = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 48
    
# end of FLR_DVO_LCD_CONFIG_T()

def byteToFLR_DVO_LCD_CONFIG_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_DVO_LCD_CONFIG_T()
    returnStruct.width, returnStruct.hPulseWidth, returnStruct.hBackP, returnStruct.hFrontP, returnStruct.height, returnStruct.vPulseWidth, returnStruct.vBackP, returnStruct.vFrontP, returnStruct.outputFormat, returnStruct.control, returnStruct.rotation, returnStruct.pixelClockkHz = unpack(endian+"IIIIIIIIIIII",inBuff[inPtr:inPtr+48])
    return returnStruct
# end of byteToFLR_DVO_LCD_CONFIG_T()

def FLR_DVO_LCD_CONFIG_TToByte(inVal, outBuff, outPtr):
    pack_into(">IIIIIIIIIIII",outBuff,outPtr,inVal.width, inVal.hPulseWidth, inVal.hBackP, inVal.hFrontP, inVal.height, inVal.vPulseWidth, inVal.vBackP, inVal.vFrontP, inVal.outputFormat, inVal.control, inVal.rotation, inVal.pixelClockkHz)
# end of FLR_DVO_LCD_CONFIG_TToByte()

class FLR_DVO_RGB_SETTINGS_T():
    def __init__(self):
        self.rgbFormat = None
        self.rgbOrder = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 8
    
# end of FLR_DVO_RGB_SETTINGS_T()

def byteToFLR_DVO_RGB_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_DVO_RGB_SETTINGS_T()
    returnStruct.rgbFormat, returnStruct.rgbOrder = unpack(endian+"ii",inBuff[inPtr:inPtr+8])
    return returnStruct
# end of byteToFLR_DVO_RGB_SETTINGS_T()

def FLR_DVO_RGB_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">ii",outBuff,outPtr,inVal.rgbFormat, inVal.rgbOrder)
# end of FLR_DVO_RGB_SETTINGS_TToByte()

class FLR_DVO_YCBCR_SETTINGS_T():
    def __init__(self):
        self.ycbcrFormat = None
        self.cbcrOrder = None
        self.yOrder = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 12
    
# end of FLR_DVO_YCBCR_SETTINGS_T()

def byteToFLR_DVO_YCBCR_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_DVO_YCBCR_SETTINGS_T()
    returnStruct.ycbcrFormat, returnStruct.cbcrOrder, returnStruct.yOrder = unpack(endian+"iii",inBuff[inPtr:inPtr+12])
    return returnStruct
# end of byteToFLR_DVO_YCBCR_SETTINGS_T()

def FLR_DVO_YCBCR_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">iii",outBuff,outPtr,inVal.ycbcrFormat, inVal.cbcrOrder, inVal.yOrder)
# end of FLR_DVO_YCBCR_SETTINGS_TToByte()

class FLR_GAO_RNS_COL_CORRECT_T():
    def __init__(self):
        self.value = [None]*20
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 40
    
# end of FLR_GAO_RNS_COL_CORRECT_T()

def byteToFLR_GAO_RNS_COL_CORRECT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_GAO_RNS_COL_CORRECT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19] = unpack(endian+"hhhhhhhhhhhhhhhhhhhh",inBuff[inPtr:inPtr+40])
    return returnStruct
# end of byteToFLR_GAO_RNS_COL_CORRECT_T()

def FLR_GAO_RNS_COL_CORRECT_TToByte(inVal, outBuff, outPtr):
    pack_into(">hhhhhhhhhhhhhhhhhhhh",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19])
# end of FLR_GAO_RNS_COL_CORRECT_TToByte()

class FLR_ISOTHERM_COLORS_T():
    def __init__(self):
        self.range1 = FLR_ISOTHERM_COLOR_T()
        self.range2 = FLR_ISOTHERM_COLOR_T()
        self.range3 = FLR_ISOTHERM_COLOR_T()
        self.num = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 20
    
# end of FLR_ISOTHERM_COLORS_T()

def byteToFLR_ISOTHERM_COLORS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_ISOTHERM_COLORS_T()
    returnStruct.range1.r, returnStruct.range1.g, returnStruct.range1.b, returnStruct.range2.r, returnStruct.range2.g, returnStruct.range2.b, returnStruct.range3.r, returnStruct.range3.g, returnStruct.range3.b, returnStruct.num = unpack(endian+"HHHHHHHHHH",inBuff[inPtr:inPtr+20])
    return returnStruct
# end of byteToFLR_ISOTHERM_COLORS_T()

def FLR_ISOTHERM_COLORS_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHH",outBuff,outPtr,inVal.range1.r, inVal.range1.g, inVal.range1.b, inVal.range2.r, inVal.range2.g, inVal.range2.b, inVal.range3.r, inVal.range3.g, inVal.range3.b, inVal.num)
# end of FLR_ISOTHERM_COLORS_TToByte()

class FLR_ISOTHERM_COLOR_T():
    def __init__(self):
        self.r = None
        self.g = None
        self.b = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 6
    
# end of FLR_ISOTHERM_COLOR_T()

def byteToFLR_ISOTHERM_COLOR_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_ISOTHERM_COLOR_T()
    returnStruct.r, returnStruct.g, returnStruct.b = unpack(endian+"HHH",inBuff[inPtr:inPtr+6])
    return returnStruct
# end of byteToFLR_ISOTHERM_COLOR_T()

def FLR_ISOTHERM_COLOR_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHH",outBuff,outPtr,inVal.r, inVal.g, inVal.b)
# end of FLR_ISOTHERM_COLOR_TToByte()

class FLR_ISOTHERM_SETTINGS_T():
    def __init__(self):
        self.thIsoT1 = None
        self.thIsoT2 = None
        self.thIsoT3 = None
        self.thIsoT4 = None
        self.thIsoT5 = None
        self.color0 = FLR_ISOTHERM_COLORS_T()
        self.color0.range1 = FLR_ISOTHERM_COLOR_T()
        self.color0.range2 = FLR_ISOTHERM_COLOR_T()
        self.color0.range3 = FLR_ISOTHERM_COLOR_T()
        self.color1 = FLR_ISOTHERM_COLORS_T()
        self.color1.range1 = FLR_ISOTHERM_COLOR_T()
        self.color1.range2 = FLR_ISOTHERM_COLOR_T()
        self.color1.range3 = FLR_ISOTHERM_COLOR_T()
        self.color2 = FLR_ISOTHERM_COLORS_T()
        self.color2.range1 = FLR_ISOTHERM_COLOR_T()
        self.color2.range2 = FLR_ISOTHERM_COLOR_T()
        self.color2.range3 = FLR_ISOTHERM_COLOR_T()
        self.color3 = FLR_ISOTHERM_COLORS_T()
        self.color3.range1 = FLR_ISOTHERM_COLOR_T()
        self.color3.range2 = FLR_ISOTHERM_COLOR_T()
        self.color3.range3 = FLR_ISOTHERM_COLOR_T()
        self.color4 = FLR_ISOTHERM_COLORS_T()
        self.color4.range1 = FLR_ISOTHERM_COLOR_T()
        self.color4.range2 = FLR_ISOTHERM_COLOR_T()
        self.color4.range3 = FLR_ISOTHERM_COLOR_T()
        self.color5 = FLR_ISOTHERM_COLORS_T()
        self.color5.range1 = FLR_ISOTHERM_COLOR_T()
        self.color5.range2 = FLR_ISOTHERM_COLOR_T()
        self.color5.range3 = FLR_ISOTHERM_COLOR_T()
        self.region0 = None
        self.region1 = None
        self.region2 = None
        self.region3 = None
        self.region4 = None
        self.region5 = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 164
    
# end of FLR_ISOTHERM_SETTINGS_T()

def byteToFLR_ISOTHERM_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_ISOTHERM_SETTINGS_T()
    returnStruct.thIsoT1, returnStruct.thIsoT2, returnStruct.thIsoT3, returnStruct.thIsoT4, returnStruct.thIsoT5, returnStruct.color0.range1.r, returnStruct.color0.range1.g, returnStruct.color0.range1.b, returnStruct.color0.range2.r, returnStruct.color0.range2.g, returnStruct.color0.range2.b, returnStruct.color0.range3.r, returnStruct.color0.range3.g, returnStruct.color0.range3.b, returnStruct.color0.num, returnStruct.color1.range1.r, returnStruct.color1.range1.g, returnStruct.color1.range1.b, returnStruct.color1.range2.r, returnStruct.color1.range2.g, returnStruct.color1.range2.b, returnStruct.color1.range3.r, returnStruct.color1.range3.g, returnStruct.color1.range3.b, returnStruct.color1.num, returnStruct.color2.range1.r, returnStruct.color2.range1.g, returnStruct.color2.range1.b, returnStruct.color2.range2.r, returnStruct.color2.range2.g, returnStruct.color2.range2.b, returnStruct.color2.range3.r, returnStruct.color2.range3.g, returnStruct.color2.range3.b, returnStruct.color2.num, returnStruct.color3.range1.r, returnStruct.color3.range1.g, returnStruct.color3.range1.b, returnStruct.color3.range2.r, returnStruct.color3.range2.g, returnStruct.color3.range2.b, returnStruct.color3.range3.r, returnStruct.color3.range3.g, returnStruct.color3.range3.b, returnStruct.color3.num, returnStruct.color4.range1.r, returnStruct.color4.range1.g, returnStruct.color4.range1.b, returnStruct.color4.range2.r, returnStruct.color4.range2.g, returnStruct.color4.range2.b, returnStruct.color4.range3.r, returnStruct.color4.range3.g, returnStruct.color4.range3.b, returnStruct.color4.num, returnStruct.color5.range1.r, returnStruct.color5.range1.g, returnStruct.color5.range1.b, returnStruct.color5.range2.r, returnStruct.color5.range2.g, returnStruct.color5.range2.b, returnStruct.color5.range3.r, returnStruct.color5.range3.g, returnStruct.color5.range3.b, returnStruct.color5.num, returnStruct.region0, returnStruct.region1, returnStruct.region2, returnStruct.region3, returnStruct.region4, returnStruct.region5 = unpack(endian+"iiiiiHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHiiiiii",inBuff[inPtr:inPtr+164])
    return returnStruct
# end of byteToFLR_ISOTHERM_SETTINGS_T()

def FLR_ISOTHERM_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">iiiiiHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHiiiiii",outBuff,outPtr,inVal.thIsoT1, inVal.thIsoT2, inVal.thIsoT3, inVal.thIsoT4, inVal.thIsoT5, inVal.color0.range1.r, inVal.color0.range1.g, inVal.color0.range1.b, inVal.color0.range2.r, inVal.color0.range2.g, inVal.color0.range2.b, inVal.color0.range3.r, inVal.color0.range3.g, inVal.color0.range3.b, inVal.color0.num, inVal.color1.range1.r, inVal.color1.range1.g, inVal.color1.range1.b, inVal.color1.range2.r, inVal.color1.range2.g, inVal.color1.range2.b, inVal.color1.range3.r, inVal.color1.range3.g, inVal.color1.range3.b, inVal.color1.num, inVal.color2.range1.r, inVal.color2.range1.g, inVal.color2.range1.b, inVal.color2.range2.r, inVal.color2.range2.g, inVal.color2.range2.b, inVal.color2.range3.r, inVal.color2.range3.g, inVal.color2.range3.b, inVal.color2.num, inVal.color3.range1.r, inVal.color3.range1.g, inVal.color3.range1.b, inVal.color3.range2.r, inVal.color3.range2.g, inVal.color3.range2.b, inVal.color3.range3.r, inVal.color3.range3.g, inVal.color3.range3.b, inVal.color3.num, inVal.color4.range1.r, inVal.color4.range1.g, inVal.color4.range1.b, inVal.color4.range2.r, inVal.color4.range2.g, inVal.color4.range2.b, inVal.color4.range3.r, inVal.color4.range3.g, inVal.color4.range3.b, inVal.color4.num, inVal.color5.range1.r, inVal.color5.range1.g, inVal.color5.range1.b, inVal.color5.range2.r, inVal.color5.range2.g, inVal.color5.range2.b, inVal.color5.range3.r, inVal.color5.range3.g, inVal.color5.range3.b, inVal.color5.num, inVal.region0, inVal.region1, inVal.region2, inVal.region3, inVal.region4, inVal.region5)
# end of FLR_ISOTHERM_SETTINGS_TToByte()

class FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T():
    def __init__(self):
        self.lut = FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()
        self.tableIndex = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 36
    
# end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T()

def byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T()
    returnStruct.lut.value[0], returnStruct.lut.value[1], returnStruct.lut.value[2], returnStruct.lut.value[3], returnStruct.lut.value[4], returnStruct.lut.value[5], returnStruct.lut.value[6], returnStruct.lut.value[7], returnStruct.lut.value[8], returnStruct.lut.value[9], returnStruct.lut.value[10], returnStruct.lut.value[11], returnStruct.lut.value[12], returnStruct.lut.value[13], returnStruct.lut.value[14], returnStruct.lut.value[15], returnStruct.lut.value[16], returnStruct.tableIndex = unpack(endian+"HHHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+36])
    return returnStruct
# end of byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T()

def FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.lut.value[0], inVal.lut.value[1], inVal.lut.value[2], inVal.lut.value[3], inVal.lut.value[4], inVal.lut.value[5], inVal.lut.value[6], inVal.lut.value[7], inVal.lut.value[8], inVal.lut.value[9], inVal.lut.value[10], inVal.lut.value[11], inVal.lut.value[12], inVal.lut.value[13], inVal.lut.value[14], inVal.lut.value[15], inVal.lut.value[16], inVal.tableIndex)
# end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_TToByte()

class FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T():
    def __init__(self):
        self.value = [None]*17
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 34
    
# end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()

def byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16] = unpack(endian+"HHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+34])
    return returnStruct
# end of byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()

def FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16])
# end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte()

class FLR_RADIOMETRY_RBFO_PARAMS_T():
    def __init__(self):
        self.RBFO_R = None
        self.RBFO_B = None
        self.RBFO_F = None
        self.RBFO_O = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 16
    
# end of FLR_RADIOMETRY_RBFO_PARAMS_T()

def byteToFLR_RADIOMETRY_RBFO_PARAMS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_RBFO_PARAMS_T()
    returnStruct.RBFO_R, returnStruct.RBFO_B, returnStruct.RBFO_F, returnStruct.RBFO_O = unpack(endian+"ffff",inBuff[inPtr:inPtr+16])
    return returnStruct
# end of byteToFLR_RADIOMETRY_RBFO_PARAMS_T()

def FLR_RADIOMETRY_RBFO_PARAMS_TToByte(inVal, outBuff, outPtr):
    pack_into(">ffff",outBuff,outPtr,inVal.RBFO_R, inVal.RBFO_B, inVal.RBFO_F, inVal.RBFO_O)
# end of FLR_RADIOMETRY_RBFO_PARAMS_TToByte()

class FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T():
    def __init__(self):
        self.lut = FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()
        self.tableIndex = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 36
    
# end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T()

def byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T()
    returnStruct.lut.value[0], returnStruct.lut.value[1], returnStruct.lut.value[2], returnStruct.lut.value[3], returnStruct.lut.value[4], returnStruct.lut.value[5], returnStruct.lut.value[6], returnStruct.lut.value[7], returnStruct.lut.value[8], returnStruct.lut.value[9], returnStruct.lut.value[10], returnStruct.lut.value[11], returnStruct.lut.value[12], returnStruct.lut.value[13], returnStruct.lut.value[14], returnStruct.lut.value[15], returnStruct.lut.value[16], returnStruct.tableIndex = unpack(endian+"HHHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+36])
    return returnStruct
# end of byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T()

def FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.lut.value[0], inVal.lut.value[1], inVal.lut.value[2], inVal.lut.value[3], inVal.lut.value[4], inVal.lut.value[5], inVal.lut.value[6], inVal.lut.value[7], inVal.lut.value[8], inVal.lut.value[9], inVal.lut.value[10], inVal.lut.value[11], inVal.lut.value[12], inVal.lut.value[13], inVal.lut.value[14], inVal.lut.value[15], inVal.lut.value[16], inVal.tableIndex)
# end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_TToByte()

class FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T():
    def __init__(self):
        self.value = [None]*17
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 34
    
# end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()

def byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16] = unpack(endian+"HHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+34])
    return returnStruct
# end of byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()

def FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16])
# end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte()

class FLR_RADIOMETRY_TAUX_PARAMS_T():
    def __init__(self):
        self.A3 = None
        self.A2 = None
        self.A1 = None
        self.A0 = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 16
    
# end of FLR_RADIOMETRY_TAUX_PARAMS_T()

def byteToFLR_RADIOMETRY_TAUX_PARAMS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_RADIOMETRY_TAUX_PARAMS_T()
    returnStruct.A3, returnStruct.A2, returnStruct.A1, returnStruct.A0 = unpack(endian+"ffff",inBuff[inPtr:inPtr+16])
    return returnStruct
# end of byteToFLR_RADIOMETRY_TAUX_PARAMS_T()

def FLR_RADIOMETRY_TAUX_PARAMS_TToByte(inVal, outBuff, outPtr):
    pack_into(">ffff",outBuff,outPtr,inVal.A3, inVal.A2, inVal.A1, inVal.A0)
# end of FLR_RADIOMETRY_TAUX_PARAMS_TToByte()

class FLR_ROIC_FPATEMP_TABLE_T():
    def __init__(self):
        self.value = [None]*32
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 64
    
# end of FLR_ROIC_FPATEMP_TABLE_T()

def byteToFLR_ROIC_FPATEMP_TABLE_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_ROIC_FPATEMP_TABLE_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19], returnStruct.value[20], returnStruct.value[21], returnStruct.value[22], returnStruct.value[23], returnStruct.value[24], returnStruct.value[25], returnStruct.value[26], returnStruct.value[27], returnStruct.value[28], returnStruct.value[29], returnStruct.value[30], returnStruct.value[31] = unpack(endian+"hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh",inBuff[inPtr:inPtr+64])
    return returnStruct
# end of byteToFLR_ROIC_FPATEMP_TABLE_T()

def FLR_ROIC_FPATEMP_TABLE_TToByte(inVal, outBuff, outPtr):
    pack_into(">hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19], inVal.value[20], inVal.value[21], inVal.value[22], inVal.value[23], inVal.value[24], inVal.value[25], inVal.value[26], inVal.value[27], inVal.value[28], inVal.value[29], inVal.value[30], inVal.value[31])
# end of FLR_ROIC_FPATEMP_TABLE_TToByte()

class FLR_ROI_T():
    def __init__(self):
        self.rowStart = None
        self.rowStop = None
        self.colStart = None
        self.colStop = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 8
    
# end of FLR_ROI_T()

def byteToFLR_ROI_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_ROI_T()
    returnStruct.rowStart, returnStruct.rowStop, returnStruct.colStart, returnStruct.colStop = unpack(endian+"HHHH",inBuff[inPtr:inPtr+8])
    return returnStruct
# end of byteToFLR_ROI_T()

def FLR_ROI_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHH",outBuff,outPtr,inVal.rowStart, inVal.rowStop, inVal.colStart, inVal.colStop)
# end of FLR_ROI_TToByte()

class FLR_SCALER_ZOOM_PARAMS_T():
    def __init__(self):
        self.zoom = None
        self.xCenter = None
        self.yCenter = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 12
    
# end of FLR_SCALER_ZOOM_PARAMS_T()

def byteToFLR_SCALER_ZOOM_PARAMS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SCALER_ZOOM_PARAMS_T()
    returnStruct.zoom, returnStruct.xCenter, returnStruct.yCenter = unpack(endian+"III",inBuff[inPtr:inPtr+12])
    return returnStruct
# end of byteToFLR_SCALER_ZOOM_PARAMS_T()

def FLR_SCALER_ZOOM_PARAMS_TToByte(inVal, outBuff, outPtr):
    pack_into(">III",outBuff,outPtr,inVal.zoom, inVal.xCenter, inVal.yCenter)
# end of FLR_SCALER_ZOOM_PARAMS_TToByte()

class FLR_SPNR_PSD_KERNEL_T():
    def __init__(self):
        self.fvalue = [None]*64
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 256
    
# end of FLR_SPNR_PSD_KERNEL_T()

def byteToFLR_SPNR_PSD_KERNEL_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SPNR_PSD_KERNEL_T()
    returnStruct.fvalue[0], returnStruct.fvalue[1], returnStruct.fvalue[2], returnStruct.fvalue[3], returnStruct.fvalue[4], returnStruct.fvalue[5], returnStruct.fvalue[6], returnStruct.fvalue[7], returnStruct.fvalue[8], returnStruct.fvalue[9], returnStruct.fvalue[10], returnStruct.fvalue[11], returnStruct.fvalue[12], returnStruct.fvalue[13], returnStruct.fvalue[14], returnStruct.fvalue[15], returnStruct.fvalue[16], returnStruct.fvalue[17], returnStruct.fvalue[18], returnStruct.fvalue[19], returnStruct.fvalue[20], returnStruct.fvalue[21], returnStruct.fvalue[22], returnStruct.fvalue[23], returnStruct.fvalue[24], returnStruct.fvalue[25], returnStruct.fvalue[26], returnStruct.fvalue[27], returnStruct.fvalue[28], returnStruct.fvalue[29], returnStruct.fvalue[30], returnStruct.fvalue[31], returnStruct.fvalue[32], returnStruct.fvalue[33], returnStruct.fvalue[34], returnStruct.fvalue[35], returnStruct.fvalue[36], returnStruct.fvalue[37], returnStruct.fvalue[38], returnStruct.fvalue[39], returnStruct.fvalue[40], returnStruct.fvalue[41], returnStruct.fvalue[42], returnStruct.fvalue[43], returnStruct.fvalue[44], returnStruct.fvalue[45], returnStruct.fvalue[46], returnStruct.fvalue[47], returnStruct.fvalue[48], returnStruct.fvalue[49], returnStruct.fvalue[50], returnStruct.fvalue[51], returnStruct.fvalue[52], returnStruct.fvalue[53], returnStruct.fvalue[54], returnStruct.fvalue[55], returnStruct.fvalue[56], returnStruct.fvalue[57], returnStruct.fvalue[58], returnStruct.fvalue[59], returnStruct.fvalue[60], returnStruct.fvalue[61], returnStruct.fvalue[62], returnStruct.fvalue[63] = unpack(endian+"ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",inBuff[inPtr:inPtr+256])
    return returnStruct
# end of byteToFLR_SPNR_PSD_KERNEL_T()

def FLR_SPNR_PSD_KERNEL_TToByte(inVal, outBuff, outPtr):
    pack_into(">ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",outBuff,outPtr,inVal.fvalue[0], inVal.fvalue[1], inVal.fvalue[2], inVal.fvalue[3], inVal.fvalue[4], inVal.fvalue[5], inVal.fvalue[6], inVal.fvalue[7], inVal.fvalue[8], inVal.fvalue[9], inVal.fvalue[10], inVal.fvalue[11], inVal.fvalue[12], inVal.fvalue[13], inVal.fvalue[14], inVal.fvalue[15], inVal.fvalue[16], inVal.fvalue[17], inVal.fvalue[18], inVal.fvalue[19], inVal.fvalue[20], inVal.fvalue[21], inVal.fvalue[22], inVal.fvalue[23], inVal.fvalue[24], inVal.fvalue[25], inVal.fvalue[26], inVal.fvalue[27], inVal.fvalue[28], inVal.fvalue[29], inVal.fvalue[30], inVal.fvalue[31], inVal.fvalue[32], inVal.fvalue[33], inVal.fvalue[34], inVal.fvalue[35], inVal.fvalue[36], inVal.fvalue[37], inVal.fvalue[38], inVal.fvalue[39], inVal.fvalue[40], inVal.fvalue[41], inVal.fvalue[42], inVal.fvalue[43], inVal.fvalue[44], inVal.fvalue[45], inVal.fvalue[46], inVal.fvalue[47], inVal.fvalue[48], inVal.fvalue[49], inVal.fvalue[50], inVal.fvalue[51], inVal.fvalue[52], inVal.fvalue[53], inVal.fvalue[54], inVal.fvalue[55], inVal.fvalue[56], inVal.fvalue[57], inVal.fvalue[58], inVal.fvalue[59], inVal.fvalue[60], inVal.fvalue[61], inVal.fvalue[62], inVal.fvalue[63])
# end of FLR_SPNR_PSD_KERNEL_TToByte()

class FLR_SPOTMETER_SPOT_PARAM_T():
    def __init__(self):
        self.row = None
        self.column = None
        self.value = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 6
    
# end of FLR_SPOTMETER_SPOT_PARAM_T()

def byteToFLR_SPOTMETER_SPOT_PARAM_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SPOTMETER_SPOT_PARAM_T()
    returnStruct.row, returnStruct.column, returnStruct.value = unpack(endian+"HHH",inBuff[inPtr:inPtr+6])
    return returnStruct
# end of byteToFLR_SPOTMETER_SPOT_PARAM_T()

def FLR_SPOTMETER_SPOT_PARAM_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHH",outBuff,outPtr,inVal.row, inVal.column, inVal.value)
# end of FLR_SPOTMETER_SPOT_PARAM_TToByte()

class FLR_SPOTMETER_STAT_PARAM_TEMP_T():
    def __init__(self):
        self.row = None
        self.column = None
        self.value = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 8
    
# end of FLR_SPOTMETER_STAT_PARAM_TEMP_T()

def byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SPOTMETER_STAT_PARAM_TEMP_T()
    returnStruct.row, returnStruct.column, returnStruct.value = unpack(endian+"HHf",inBuff[inPtr:inPtr+8])
    return returnStruct
# end of byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T()

def FLR_SPOTMETER_STAT_PARAM_TEMP_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHf",outBuff,outPtr,inVal.row, inVal.column, inVal.value)
# end of FLR_SPOTMETER_STAT_PARAM_TEMP_TToByte()

class FLR_SYSINFO_MONITOR_BUILD_VARIANT_T():
    def __init__(self):
        self.value = [None]*50
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 50
    
# end of FLR_SYSINFO_MONITOR_BUILD_VARIANT_T()

def byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SYSINFO_MONITOR_BUILD_VARIANT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19], returnStruct.value[20], returnStruct.value[21], returnStruct.value[22], returnStruct.value[23], returnStruct.value[24], returnStruct.value[25], returnStruct.value[26], returnStruct.value[27], returnStruct.value[28], returnStruct.value[29], returnStruct.value[30], returnStruct.value[31], returnStruct.value[32], returnStruct.value[33], returnStruct.value[34], returnStruct.value[35], returnStruct.value[36], returnStruct.value[37], returnStruct.value[38], returnStruct.value[39], returnStruct.value[40], returnStruct.value[41], returnStruct.value[42], returnStruct.value[43], returnStruct.value[44], returnStruct.value[45], returnStruct.value[46], returnStruct.value[47], returnStruct.value[48], returnStruct.value[49] = unpack(endian+"BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",inBuff[inPtr:inPtr+50])
    return returnStruct
# end of byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T()

def FLR_SYSINFO_MONITOR_BUILD_VARIANT_TToByte(inVal, outBuff, outPtr):
    pack_into(">BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19], inVal.value[20], inVal.value[21], inVal.value[22], inVal.value[23], inVal.value[24], inVal.value[25], inVal.value[26], inVal.value[27], inVal.value[28], inVal.value[29], inVal.value[30], inVal.value[31], inVal.value[32], inVal.value[33], inVal.value[34], inVal.value[35], inVal.value[36], inVal.value[37], inVal.value[38], inVal.value[39], inVal.value[40], inVal.value[41], inVal.value[42], inVal.value[43], inVal.value[44], inVal.value[45], inVal.value[46], inVal.value[47], inVal.value[48], inVal.value[49])
# end of FLR_SYSINFO_MONITOR_BUILD_VARIANT_TToByte()

class FLR_SYSTEMSYMBOLS_BARCONFIG_T():
    def __init__(self):
        self.val0 = None
        self.val1 = None
        self.val2 = None
        self.val3 = None
        self.val4 = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 10
    
# end of FLR_SYSTEMSYMBOLS_BARCONFIG_T()

def byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SYSTEMSYMBOLS_BARCONFIG_T()
    returnStruct.val0, returnStruct.val1, returnStruct.val2, returnStruct.val3, returnStruct.val4 = unpack(endian+"hhhhh",inBuff[inPtr:inPtr+10])
    return returnStruct
# end of byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T()

def FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(inVal, outBuff, outPtr):
    pack_into(">hhhhh",outBuff,outPtr,inVal.val0, inVal.val1, inVal.val2, inVal.val3, inVal.val4)
# end of FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte()

class FLR_SYSTEMSYMBOLS_ISOCONFIG_T():
    def __init__(self):
        self.colorBar1 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.colorBar2 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.colorBarOutline = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 45
    
# end of FLR_SYSTEMSYMBOLS_ISOCONFIG_T()

def byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SYSTEMSYMBOLS_ISOCONFIG_T()
    returnStruct.colorBar1.id, returnStruct.colorBar1.x, returnStruct.colorBar1.y, returnStruct.colorBar1.width, returnStruct.colorBar1.height, returnStruct.colorBar1.color, returnStruct.colorBar1.size, returnStruct.colorBar2.id, returnStruct.colorBar2.x, returnStruct.colorBar2.y, returnStruct.colorBar2.width, returnStruct.colorBar2.height, returnStruct.colorBar2.color, returnStruct.colorBar2.size, returnStruct.colorBarOutline.id, returnStruct.colorBarOutline.x, returnStruct.colorBarOutline.y, returnStruct.colorBarOutline.width, returnStruct.colorBarOutline.height, returnStruct.colorBarOutline.color, returnStruct.colorBarOutline.size = unpack(endian+"BhhhhIhBhhhhIhBhhhhIh",inBuff[inPtr:inPtr+45])
    return returnStruct
# end of byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T()

def FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte(inVal, outBuff, outPtr):
    pack_into(">BhhhhIhBhhhhIhBhhhhIh",outBuff,outPtr,inVal.colorBar1.id, inVal.colorBar1.x, inVal.colorBar1.y, inVal.colorBar1.width, inVal.colorBar1.height, inVal.colorBar1.color, inVal.colorBar1.size, inVal.colorBar2.id, inVal.colorBar2.x, inVal.colorBar2.y, inVal.colorBar2.width, inVal.colorBar2.height, inVal.colorBar2.color, inVal.colorBar2.size, inVal.colorBarOutline.id, inVal.colorBarOutline.x, inVal.colorBarOutline.y, inVal.colorBarOutline.width, inVal.colorBarOutline.height, inVal.colorBarOutline.color, inVal.colorBarOutline.size)
# end of FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte()

class FLR_SYSTEMSYMBOLS_SPOTCONFIG_T():
    def __init__(self):
        self.symbol = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.area = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.min = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.max = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.mean = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.meanBar = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBar = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarFilling = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarText1 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarText2 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarText3 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarText4 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
        self.greenBarText5 = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 195
    
# end of FLR_SYSTEMSYMBOLS_SPOTCONFIG_T()

def byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SYSTEMSYMBOLS_SPOTCONFIG_T()
    returnStruct.symbol.id, returnStruct.symbol.x, returnStruct.symbol.y, returnStruct.symbol.width, returnStruct.symbol.height, returnStruct.symbol.color, returnStruct.symbol.size, returnStruct.area.id, returnStruct.area.x, returnStruct.area.y, returnStruct.area.width, returnStruct.area.height, returnStruct.area.color, returnStruct.area.size, returnStruct.min.id, returnStruct.min.x, returnStruct.min.y, returnStruct.min.width, returnStruct.min.height, returnStruct.min.color, returnStruct.min.size, returnStruct.max.id, returnStruct.max.x, returnStruct.max.y, returnStruct.max.width, returnStruct.max.height, returnStruct.max.color, returnStruct.max.size, returnStruct.mean.id, returnStruct.mean.x, returnStruct.mean.y, returnStruct.mean.width, returnStruct.mean.height, returnStruct.mean.color, returnStruct.mean.size, returnStruct.meanBar.id, returnStruct.meanBar.x, returnStruct.meanBar.y, returnStruct.meanBar.width, returnStruct.meanBar.height, returnStruct.meanBar.color, returnStruct.meanBar.size, returnStruct.greenBar.id, returnStruct.greenBar.x, returnStruct.greenBar.y, returnStruct.greenBar.width, returnStruct.greenBar.height, returnStruct.greenBar.color, returnStruct.greenBar.size, returnStruct.greenBarFilling.id, returnStruct.greenBarFilling.x, returnStruct.greenBarFilling.y, returnStruct.greenBarFilling.width, returnStruct.greenBarFilling.height, returnStruct.greenBarFilling.color, returnStruct.greenBarFilling.size, returnStruct.greenBarText1.id, returnStruct.greenBarText1.x, returnStruct.greenBarText1.y, returnStruct.greenBarText1.width, returnStruct.greenBarText1.height, returnStruct.greenBarText1.color, returnStruct.greenBarText1.size, returnStruct.greenBarText2.id, returnStruct.greenBarText2.x, returnStruct.greenBarText2.y, returnStruct.greenBarText2.width, returnStruct.greenBarText2.height, returnStruct.greenBarText2.color, returnStruct.greenBarText2.size, returnStruct.greenBarText3.id, returnStruct.greenBarText3.x, returnStruct.greenBarText3.y, returnStruct.greenBarText3.width, returnStruct.greenBarText3.height, returnStruct.greenBarText3.color, returnStruct.greenBarText3.size, returnStruct.greenBarText4.id, returnStruct.greenBarText4.x, returnStruct.greenBarText4.y, returnStruct.greenBarText4.width, returnStruct.greenBarText4.height, returnStruct.greenBarText4.color, returnStruct.greenBarText4.size, returnStruct.greenBarText5.id, returnStruct.greenBarText5.x, returnStruct.greenBarText5.y, returnStruct.greenBarText5.width, returnStruct.greenBarText5.height, returnStruct.greenBarText5.color, returnStruct.greenBarText5.size = unpack(endian+"BhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIh",inBuff[inPtr:inPtr+195])
    return returnStruct
# end of byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T()

def FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte(inVal, outBuff, outPtr):
    pack_into(">BhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIhBhhhhIh",outBuff,outPtr,inVal.symbol.id, inVal.symbol.x, inVal.symbol.y, inVal.symbol.width, inVal.symbol.height, inVal.symbol.color, inVal.symbol.size, inVal.area.id, inVal.area.x, inVal.area.y, inVal.area.width, inVal.area.height, inVal.area.color, inVal.area.size, inVal.min.id, inVal.min.x, inVal.min.y, inVal.min.width, inVal.min.height, inVal.min.color, inVal.min.size, inVal.max.id, inVal.max.x, inVal.max.y, inVal.max.width, inVal.max.height, inVal.max.color, inVal.max.size, inVal.mean.id, inVal.mean.x, inVal.mean.y, inVal.mean.width, inVal.mean.height, inVal.mean.color, inVal.mean.size, inVal.meanBar.id, inVal.meanBar.x, inVal.meanBar.y, inVal.meanBar.width, inVal.meanBar.height, inVal.meanBar.color, inVal.meanBar.size, inVal.greenBar.id, inVal.greenBar.x, inVal.greenBar.y, inVal.greenBar.width, inVal.greenBar.height, inVal.greenBar.color, inVal.greenBar.size, inVal.greenBarFilling.id, inVal.greenBarFilling.x, inVal.greenBarFilling.y, inVal.greenBarFilling.width, inVal.greenBarFilling.height, inVal.greenBarFilling.color, inVal.greenBarFilling.size, inVal.greenBarText1.id, inVal.greenBarText1.x, inVal.greenBarText1.y, inVal.greenBarText1.width, inVal.greenBarText1.height, inVal.greenBarText1.color, inVal.greenBarText1.size, inVal.greenBarText2.id, inVal.greenBarText2.x, inVal.greenBarText2.y, inVal.greenBarText2.width, inVal.greenBarText2.height, inVal.greenBarText2.color, inVal.greenBarText2.size, inVal.greenBarText3.id, inVal.greenBarText3.x, inVal.greenBarText3.y, inVal.greenBarText3.width, inVal.greenBarText3.height, inVal.greenBarText3.color, inVal.greenBarText3.size, inVal.greenBarText4.id, inVal.greenBarText4.x, inVal.greenBarText4.y, inVal.greenBarText4.width, inVal.greenBarText4.height, inVal.greenBarText4.color, inVal.greenBarText4.size, inVal.greenBarText5.id, inVal.greenBarText5.x, inVal.greenBarText5.y, inVal.greenBarText5.width, inVal.greenBarText5.height, inVal.greenBarText5.color, inVal.greenBarText5.size)
# end of FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte()

class FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T():
    def __init__(self):
        self.id = None
        self.x = None
        self.y = None
        self.width = None
        self.height = None
        self.color = None
        self.size = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 15
    
# end of FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()

def byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
    returnStruct.id, returnStruct.x, returnStruct.y, returnStruct.width, returnStruct.height, returnStruct.color, returnStruct.size = unpack(endian+"BhhhhIh",inBuff[inPtr:inPtr+15])
    return returnStruct
# end of byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()

def FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte(inVal, outBuff, outPtr):
    pack_into(">BhhhhIh",outBuff,outPtr,inVal.id, inVal.x, inVal.y, inVal.width, inVal.height, inVal.color, inVal.size)
# end of FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte()

class FLR_TESTRAMP_SETTINGS_T():
    def __init__(self):
        self.start = None
        self.end = None
        self.increment = None
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 6
    
# end of FLR_TESTRAMP_SETTINGS_T()

def byteToFLR_TESTRAMP_SETTINGS_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_TESTRAMP_SETTINGS_T()
    returnStruct.start, returnStruct.end, returnStruct.increment = unpack(endian+"HHH",inBuff[inPtr:inPtr+6])
    return returnStruct
# end of byteToFLR_TESTRAMP_SETTINGS_T()

def FLR_TESTRAMP_SETTINGS_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHH",outBuff,outPtr,inVal.start, inVal.end, inVal.increment)
# end of FLR_TESTRAMP_SETTINGS_TToByte()

class FLR_TF_NF_LUT_T():
    def __init__(self):
        self.value = [None]*17
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 34
    
# end of FLR_TF_NF_LUT_T()

def byteToFLR_TF_NF_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_TF_NF_LUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16] = unpack(endian+"HHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+34])
    return returnStruct
# end of byteToFLR_TF_NF_LUT_T()

def FLR_TF_NF_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16])
# end of FLR_TF_NF_LUT_TToByte()

class FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T():
    def __init__(self):
        self.value = [None]*17
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 34
    
# end of FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T()

def byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16] = unpack(endian+"HHHHHHHHHHHHHHHHH",inBuff[inPtr:inPtr+34])
    return returnStruct
# end of byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T()

def FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">HHHHHHHHHHHHHHHHH",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16])
# end of FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte()

class FLR_TF_WLUT_T():
    def __init__(self):
        self.value = [None]*32
    # end of __init__()
    def __eq__(self, other):
        return (isinstance(other, self.__class__) and self.__dict__ == other.__dict__)
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def getPackSize(self):
        return 32
    
# end of FLR_TF_WLUT_T()

def byteToFLR_TF_WLUT_T(inBuff,inPtr,endian=">"):
    returnStruct = FLR_TF_WLUT_T()
    returnStruct.value[0], returnStruct.value[1], returnStruct.value[2], returnStruct.value[3], returnStruct.value[4], returnStruct.value[5], returnStruct.value[6], returnStruct.value[7], returnStruct.value[8], returnStruct.value[9], returnStruct.value[10], returnStruct.value[11], returnStruct.value[12], returnStruct.value[13], returnStruct.value[14], returnStruct.value[15], returnStruct.value[16], returnStruct.value[17], returnStruct.value[18], returnStruct.value[19], returnStruct.value[20], returnStruct.value[21], returnStruct.value[22], returnStruct.value[23], returnStruct.value[24], returnStruct.value[25], returnStruct.value[26], returnStruct.value[27], returnStruct.value[28], returnStruct.value[29], returnStruct.value[30], returnStruct.value[31] = unpack(endian+"BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",inBuff[inPtr:inPtr+32])
    return returnStruct
# end of byteToFLR_TF_WLUT_T()

def FLR_TF_WLUT_TToByte(inVal, outBuff, outPtr):
    pack_into(">BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",outBuff,outPtr,inVal.value[0], inVal.value[1], inVal.value[2], inVal.value[3], inVal.value[4], inVal.value[5], inVal.value[6], inVal.value[7], inVal.value[8], inVal.value[9], inVal.value[10], inVal.value[11], inVal.value[12], inVal.value[13], inVal.value[14], inVal.value[15], inVal.value[16], inVal.value[17], inVal.value[18], inVal.value[19], inVal.value[20], inVal.value[21], inVal.value[22], inVal.value[23], inVal.value[24], inVal.value[25], inVal.value[26], inVal.value[27], inVal.value[28], inVal.value[29], inVal.value[30], inVal.value[31])
# end of FLR_TF_WLUT_TToByte()

