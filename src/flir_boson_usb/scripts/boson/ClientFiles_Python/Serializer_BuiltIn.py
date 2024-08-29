from struct import unpack, pack_into
from .ReturnCodes import FLR_RESULT

def byteToBOOL(inBuff, inPtr):
	return bool(unpack('>?',inBuff[inPtr:inPtr+1])[0])

def byteToCHAR(inBuff, inPtr):
	return unpack('>b',inBuff[inPtr:inPtr+1])[0]

def byteToUCHAR(inBuff, inPtr):
	return unpack('>B',inBuff[inPtr:inPtr+1])[0]

def byteToINT_16(inBuff, inPtr):
	return unpack('>h',inBuff[inPtr:inPtr+2])[0]

def byteToUINT_16(inBuff, inPtr):
	return unpack('>H',inBuff[inPtr:inPtr+2])[0]

def byteToINT_32(inBuff, inPtr):
	return unpack('>i',inBuff[inPtr:inPtr+4])[0]

def byteToUINT_32(inBuff, inPtr):
	return unpack('>I',inBuff[inPtr:inPtr+4])[0]

def byteToFLOAT(inBuff, inPtr):
	return unpack('>f',inBuff[inPtr:inPtr+4])[0]

def byteToDOUBLE(inBuff, inPtr):
	return unpack('>d',inBuff[inPtr:inPtr+8])[0]


def BOOLToByte(inVal, outBuff, outPtr):
	pack_into('>?',outBuff,outPtr,bool(inVal))

def CHARToByte(inVal, outBuff, outPtr):
	pack_into('>b',outBuff,outPtr,int(inVal))

def UCHARToByte(inVal, outBuff, outPtr):
	pack_into('>B',outBuff,outPtr,int(inVal))

def INT_16ToByte(inVal, outBuff, outPtr):
	pack_into('>h',outBuff,outPtr,int(inVal))

def UINT_16ToByte(inVal, outBuff, outPtr):
	pack_into('>H',outBuff,outPtr,int(inVal))

def INT_32ToByte(inVal, outBuff, outPtr):
	pack_into('>i',outBuff,outPtr,int(inVal))

def UINT_32ToByte(inVal, outBuff, outPtr):
	pack_into('>I',outBuff,outPtr,int(inVal))

def FLOATToByte(inVal, outBuff, outPtr):
	pack_into('>f',outBuff,outPtr,float(inVal))

def DOUBLEToByte(inVal, outBuff, outPtr):
	pack_into('>d',outBuff,outPtr,float(inVal))


def byteToBOOLArray(inBuff, inPtr, length):
	codes = "?"*length
	return list(bool(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+1*length])))

def byteToCHARArray(inBuff, inPtr, length):
	codes = "b"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+1*length]))

def byteToUCHARArray(inBuff, inPtr, length):
	codes = "B"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+1*length]))

def byteToINT_16Array(inBuff, inPtr, length):
	codes = "h"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+2*length]))

def byteToUINT_16Array(inBuff, inPtr, length):
	codes = "H"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+2*length]))

def byteToINT_32Array(inBuff, inPtr, length):
	codes = "i"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+4*length]))

def byteToUINT_32Array(inBuff, inPtr, length):
	codes = "I"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+4*length]))

def byteToFLOATArray(inBuff, inPtr, length):
	codes = "f"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+4*length]))

def byteToDOUBLEArray(inBuff, inPtr, length):
	codes = "d"*length
	return list(unpack('>{:s}'.format(codes),inBuff[inPtr:inPtr+8*length]))


def BOOLArrayToByte(inVal, length, outBuff, outPtr):
	codes = "?"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def CHARArrayToByte(inVal, length, outBuff, outPtr):
	codes = "b"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def UCHARArrayToByte(inVal, length, outBuff, outPtr):
	codes = "B"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def INT_16ArrayToByte(inVal, length, outBuff, outPtr):
	codes = "h"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def UINT_16ArrayToByte(inVal, length, outBuff, outPtr):
	codes = "H"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def INT_32ArrayToByte(inVal, length, outBuff, outPtr):
	codes = "i"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def UINT_32ArrayToByte(inVal, length, outBuff, outPtr):
	codes = "I"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def FLOATArrayToByte(inVal, length, outBuff, outPtr):
	codes = "f"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)

def DOUBLEArrayToByte(inVal, length, outBuff, outPtr):
	codes = "d"*length
	pack_into('>{:s}'.format(codes),outBuff,outPtr,*inVal)