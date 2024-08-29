using System;
using Boson;

namespace Boson {
	partial class Camera
	{
		internal static Boolean byteToBOOL(Byte[] inBuff, UInt16 inPtr)
		{
			return (inBuff[inPtr+0] != 0);
		}
		internal static Boolean[] byteToBOOLArray(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Boolean[] returnVal = new Boolean[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToBOOL(inBuff,(UInt16) (inPtr+i));
			}
			return returnVal;
		}
		
		internal static SByte byteToCHAR(Byte[] inBuff, UInt16 inPtr)
		{
			return (SByte)inBuff[inPtr+0];
		}
		internal static SByte[] byteToCHARArray(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			SByte[] returnVal = new SByte[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToCHAR(inBuff,(UInt16) (inPtr+i));
			}
			return returnVal;
		}
		
		internal static Byte byteToUCHAR(Byte[] inBuff, UInt16 inPtr)
		{
			return (Byte)inBuff[inPtr+0];
		}
		internal static Byte[] byteToUCHARArray(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Byte[] returnVal = new Byte[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToUCHAR(inBuff,(UInt16) (inPtr+i));
			}
			return returnVal;
		}
		
		internal static Int16 byteToINT_16(Byte[] inBuff, UInt16 inPtr)
		{
			UInt16 outVal;
			outVal = (UInt16)(((UInt16)inBuff[inPtr+0]) << 8);
			outVal = (UInt16) (outVal | inBuff[inPtr+1]);
			return (Int16) outVal;
		}
		internal static Int16[] byteToINT_16Array(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Int16[] returnVal = new Int16[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToINT_16(inBuff,(UInt16) (inPtr+2*i));
			}
			return returnVal;
		}
		
		internal static UInt16 byteToUINT_16(Byte[] inBuff, UInt16 inPtr)
		{
			UInt16 outVal;
			outVal = (UInt16)((UInt16)inBuff[inPtr+0] << 8);
			outVal = (UInt16)(outVal | inBuff[inPtr+1]);
			return outVal;
		}
		internal static UInt16[] byteToUINT_16Array(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			UInt16[] returnVal = new UInt16[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToUINT_16(inBuff,(UInt16) (inPtr+2*i));
			}
			return returnVal;
		}
		
		internal static Int32 byteToINT_32(Byte[] inBuff, UInt16 inPtr)
		{
			UInt32 outVal;
			outVal = (UInt32)(inBuff[inPtr+0]) << 24;
			outVal |= ((UInt32)(inBuff[inPtr+1]) << 16);
			outVal |= ((UInt32)(inBuff[inPtr+2]) << 8);
			outVal |= (UInt32) inBuff[inPtr+3];
			return (Int32) outVal;
		}
		internal static Int32[] byteToINT_32Array(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Int32[] returnVal = new Int32[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToINT_32(inBuff,(UInt16) (inPtr+4*i));
			}
			return returnVal;
		}
		
		internal static UInt32 byteToUINT_32(Byte[] inBuff, UInt16 inPtr)
		{
			UInt32 outVal;
			outVal = (UInt32)(inBuff[inPtr+0]) << 24;
			outVal |= ((UInt32)(inBuff[inPtr+1]) << 16);
			outVal |= ((UInt32)(inBuff[inPtr+2]) << 8);
			outVal |= inBuff[inPtr+3];
			return outVal;
		}
		internal static UInt32[] byteToUINT_32Array(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			UInt32[] returnVal = new UInt32[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToUINT_32(inBuff,(UInt16) (inPtr+4*i));
			}
			return returnVal;
		}
		internal static Double byteToFLOAT(Byte[] inBuff, UInt16 inPtr)
		{
			UInt32 tempVal = 0;
			tempVal = (UInt32)(inBuff[inPtr+0]) << 24;
			tempVal |= ((UInt32)(inBuff[inPtr+1]) << 16);
			tempVal |= ((UInt32)(inBuff[inPtr+2]) << 8);
			tempVal |= inBuff[inPtr+3];
			Byte[] tempbytes = BitConverter.GetBytes(tempVal);
			return (Double) BitConverter.ToSingle( tempbytes,0);
		}
		internal static Double[] byteToFLOATArray(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Double[] returnVal = new Double[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToFLOAT(inBuff,(UInt16) (inPtr+4*i));
			}
			return returnVal;
		}
		
		internal static Double byteToDOUBLE(Byte[] inBuff, UInt16 inPtr)
		{
			UInt64 tempVal = 0;
			tempVal = (UInt64)(inBuff[inPtr+0]) << 56;
			tempVal |= ((UInt64)(inBuff[inPtr+1]) << 48);
			tempVal |= ((UInt64)(inBuff[inPtr+2]) << 40);
			tempVal |= ((UInt64)(inBuff[inPtr+3]) << 32);
			tempVal |= ((UInt64)(inBuff[inPtr+4]) << 24);
			tempVal |= ((UInt64)(inBuff[inPtr+5]) << 16);
			tempVal |= ((UInt64)(inBuff[inPtr+6]) << 8);
			tempVal |= inBuff[inPtr+7];
			Byte[] tempbytes = BitConverter.GetBytes(tempVal);
			return BitConverter.ToDouble( tempbytes,0);
		}
		internal static Double[] byteToDOUBLEArray(Byte[] inBuff, UInt16 inPtr, UInt16 length)
		{
			Double[] returnVal = new Double[length];
			UInt16 i;
			for (i=0;i<length;i++) {
				returnVal[i] = byteToFLOAT(inBuff,(UInt16) (inPtr+8*i));
			}
			return returnVal;
		}


		internal static void BOOLToByte(Boolean inVal, Byte[] outBuff, UInt16 outPtr)
		{
			if (inVal){
				outBuff[outPtr+0] = ((Byte)1);
			} else {
				outBuff[outPtr+0] = ((Byte)0);
			}
		}
		internal static void BOOLArrayToByte(Boolean[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				BOOLToByte(inVal[i],outBuff,(UInt16) (outPtr+i));
			}
		}
		
		internal static void CHARToByte(SByte inVal, Byte[] outBuff, UInt16 outPtr)
		{
			outBuff[outPtr+0] = ((Byte)(inVal));
		}
		internal static void CHARArrayToByte(SByte[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				CHARToByte(inVal[i],outBuff,(UInt16) (outPtr+i));
			}
		}
		
		internal static void UCHARToByte(Byte inVal, Byte[] outBuff, UInt16 outPtr)
		{
			outBuff[outPtr+0] = inVal;
		}
		internal static void UCHARArrayToByte(Byte[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				UCHARToByte(inVal[i],outBuff,(UInt16) (outPtr+i));
			}
		}
		
		internal static void INT_16ToByte(Int16 inVal, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 tempBytes = ((UInt16)(inVal));
			outBuff[outPtr+0] = (Byte)(tempBytes >> 8 & 0xff);
			outBuff[outPtr+1] = (Byte)(tempBytes & 0xff);
		}
		internal static void INT_16ArrayToByte(Int16[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				INT_16ToByte(inVal[i],outBuff,(UInt16) (outPtr+2*i));
			}
		}
		
		internal static void UINT_16ToByte(UInt16 inVal, Byte[] outBuff, UInt16 outPtr)
		{
			outBuff[outPtr+0] = (Byte)(inVal >> 8 & 0xff);
			outBuff[outPtr+1] = (Byte)(inVal & 0xff);
		}
		internal static void UINT_16ArrayToByte(UInt16[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				UINT_16ToByte(inVal[i],outBuff,(UInt16) (outPtr+2*i));
			}
		}
		
		internal static void INT_32ToByte(Int32 inVal, Byte[] outBuff, UInt16 outPtr)
		{
			UInt32 tempBytes = ((UInt32)(inVal));
			outBuff[outPtr+0] = (Byte)(tempBytes >> 24 & 0xff);
			outBuff[outPtr+1] = (Byte)(tempBytes >> 16 & 0xff);
			outBuff[outPtr+2] = (Byte)(tempBytes >> 8 & 0xff);
			outBuff[outPtr+3] = (Byte)(tempBytes & 0xff);
		}
		internal static void INT_32ArrayToByte(Int32[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				INT_32ToByte(inVal[i],outBuff,(UInt16) (outPtr+4*i));
			}
		}

		internal static void UINT_32ToByte(UInt32 inVal, Byte[] outBuff, UInt16 outPtr)
		{
			outBuff[outPtr+0] = (Byte)(inVal >> 24 & 0xff);
			outBuff[outPtr+1] = (Byte)(inVal >> 16 & 0xff);
			outBuff[outPtr+2] = (Byte)(inVal >> 8 & 0xff);
			outBuff[outPtr+3] = (Byte)(inVal & 0xff);
		}
		internal static void UINT_32ArrayToByte(UInt32[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				UINT_32ToByte(inVal[i],outBuff,(UInt16) (outPtr+4*i));
			}
		}
		
		internal static void FLOATToByte(Double inVal, Byte[] outBuff, UInt16 outPtr)
		{
			UInt32 tempBytes = BitConverter.ToUInt32(BitConverter.GetBytes((Single)inVal),0);
			outBuff[outPtr+0] = (Byte)(tempBytes >> 24 & 0xff);
			outBuff[outPtr+1] = (Byte)(tempBytes >> 16 & 0xff);
			outBuff[outPtr+2] = (Byte)(tempBytes >> 8 & 0xff);
			outBuff[outPtr+3] = (Byte)(tempBytes & 0xff);
		}
		internal static void FLOATArrayToByte(Double[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				FLOATToByte(inVal[i],outBuff,(UInt16) (outPtr+4*i));
			}
		}
		
		internal static void DOUBLEToByte(Double inVal, Byte[] outBuff, UInt16 outPtr)
		{
			UInt64 tempBytes = BitConverter.ToUInt64(BitConverter.GetBytes(inVal),0);
			outBuff[outPtr+0] = (Byte)(tempBytes >> 56 & 0xff);
			outBuff[outPtr+1] = (Byte)(tempBytes >> 48 & 0xff);
			outBuff[outPtr+2] = (Byte)(tempBytes >> 40 & 0xff);
			outBuff[outPtr+3] = (Byte)(tempBytes >> 32 & 0xff);
			outBuff[outPtr+4] = (Byte)(tempBytes >> 24 & 0xff);
			outBuff[outPtr+5] = (Byte)(tempBytes >> 16 & 0xff);
			outBuff[outPtr+6] = (Byte)(tempBytes >> 8 & 0xff);
			outBuff[outPtr+7] = (Byte)(tempBytes & 0xff);
		}
		internal static void DOUBLEArrayToByte(Double[] inVal, UInt16 length, Byte[] outBuff, UInt16 outPtr)
		{
			UInt16 i;
			for (i=0;i<length;i++) {
				DOUBLEToByte(inVal[i],outBuff,(UInt16) (outPtr+8*i));
			}
		}
	} // End partial class Camera
} // End namespace Boson