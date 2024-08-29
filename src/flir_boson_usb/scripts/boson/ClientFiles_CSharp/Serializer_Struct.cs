//  /////////////////////////////////////////////////////
//  // DO NOT EDIT.  This is a machine generated file. //
//  /////////////////////////////////////////////////////

/******************************************************************************/
/*                                                                            */
/*  Copyright (C) 2018, FLIR Systems                                          */
/*  All rights reserved.                                                      */
/*                                                                            */
/*  This document is controlled to FLIR Technology Level 2. The information   */
/*  contained in this document pertains to a dual use product controlled for  */
/*  export by the Export Administration Regulations (EAR). Diversion contrary */
/*  to US law is prohibited. US Department of Commerce authorization is not   */
/*  required prior to export or transfer to foreign persons or parties unless */
/*  otherwise prohibited.                                                     */
/*                                                                            */
/******************************************************************************/


using System;
using Boson;
using System.Runtime.InteropServices;

namespace Boson {
	public partial class Camera {
		//Garbage Variable to avoid ever having blank code
		static Boolean NotEmptyC = true;
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_ROI_T {
			public UInt16 rowStart;
			public UInt16 rowStop;
			public UInt16 colStart;
			public UInt16 colStop;
			public static bool operator ==(FLR_ROI_T self, FLR_ROI_T other) {
				return ((self.rowStart == other.rowStart) && (self.rowStop == other.rowStop) && (self.colStart == other.colStart) && (self.colStop == other.colStop));
			}
			public static bool operator !=(FLR_ROI_T self, FLR_ROI_T other) {
				return !(self == other);
			}
		}// end of FLR_ROI_T()
		
		private static FLR_ROI_T byteToFLR_ROI_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_ROI_T outVal;
			outVal.rowStart = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.rowStop = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.colStart = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.colStop = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_ROI_T()
		private static void FLR_ROI_TToByte(FLR_ROI_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ToByte((inVal.rowStart),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.rowStop),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.colStart),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.colStop),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_ROI_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_PARTNUMBER_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
				public Byte[] value;
			public static bool operator ==(FLR_BOSON_PARTNUMBER_T self, FLR_BOSON_PARTNUMBER_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_BOSON_PARTNUMBER_T self, FLR_BOSON_PARTNUMBER_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_PARTNUMBER_T()
		
		private static FLR_BOSON_PARTNUMBER_T byteToFLR_BOSON_PARTNUMBER_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_PARTNUMBER_T outVal;
			outVal.value = byteToUCHARArray(inBuff,ptr,(UInt16) 20);
			ptr += 20;
			
			return outVal;
		} //end byteToFLR_BOSON_PARTNUMBER_T()
		private static void FLR_BOSON_PARTNUMBER_TToByte(FLR_BOSON_PARTNUMBER_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UCHARArrayToByte((inVal.value),(UInt16) 20,outBuff,ptr);
			ptr += 20;
			
		} //end FLR_BOSON_PARTNUMBER_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_SENSOR_PARTNUMBER_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=32)]
				public Byte[] value;
			public static bool operator ==(FLR_BOSON_SENSOR_PARTNUMBER_T self, FLR_BOSON_SENSOR_PARTNUMBER_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_BOSON_SENSOR_PARTNUMBER_T self, FLR_BOSON_SENSOR_PARTNUMBER_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_SENSOR_PARTNUMBER_T()
		
		private static FLR_BOSON_SENSOR_PARTNUMBER_T byteToFLR_BOSON_SENSOR_PARTNUMBER_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_SENSOR_PARTNUMBER_T outVal;
			outVal.value = byteToUCHARArray(inBuff,ptr,(UInt16) 32);
			ptr += 32;
			
			return outVal;
		} //end byteToFLR_BOSON_SENSOR_PARTNUMBER_T()
		private static void FLR_BOSON_SENSOR_PARTNUMBER_TToByte(FLR_BOSON_SENSOR_PARTNUMBER_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UCHARArrayToByte((inVal.value),(UInt16) 32,outBuff,ptr);
			ptr += 32;
			
		} //end FLR_BOSON_SENSOR_PARTNUMBER_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_GAIN_SWITCH_PARAMS_T {
			public UInt32 pHighToLowPercent;
			public UInt32 cHighToLowPercent;
			public UInt32 pLowToHighPercent;
			public UInt32 hysteresisPercent;
			public static bool operator ==(FLR_BOSON_GAIN_SWITCH_PARAMS_T self, FLR_BOSON_GAIN_SWITCH_PARAMS_T other) {
				return ((self.pHighToLowPercent == other.pHighToLowPercent) && (self.cHighToLowPercent == other.cHighToLowPercent) && (self.pLowToHighPercent == other.pLowToHighPercent) && (self.hysteresisPercent == other.hysteresisPercent));
			}
			public static bool operator !=(FLR_BOSON_GAIN_SWITCH_PARAMS_T self, FLR_BOSON_GAIN_SWITCH_PARAMS_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_GAIN_SWITCH_PARAMS_T()
		
		private static FLR_BOSON_GAIN_SWITCH_PARAMS_T byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_GAIN_SWITCH_PARAMS_T outVal;
			outVal.pHighToLowPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.cHighToLowPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.pLowToHighPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.hysteresisPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T()
		private static void FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte(FLR_BOSON_GAIN_SWITCH_PARAMS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_32ToByte((inVal.pHighToLowPercent),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.cHighToLowPercent),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.pLowToHighPercent),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.hysteresisPercent),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T {
			public UInt32 pHighToLowPercent;
			public Double TempHighToLowDegK;
			public UInt32 pLowToHighPercent;
			public Double TempLowToHighDegK;
			public static bool operator ==(FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T self, FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T other) {
				return ((self.pHighToLowPercent == other.pHighToLowPercent) && (self.TempHighToLowDegK == other.TempHighToLowDegK) && (self.pLowToHighPercent == other.pLowToHighPercent) && (self.TempLowToHighDegK == other.TempLowToHighDegK));
			}
			public static bool operator !=(FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T self, FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T()
		
		private static FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T outVal;
			outVal.pHighToLowPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.TempHighToLowDegK = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.pLowToHighPercent = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.TempLowToHighDegK = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T()
		private static void FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte(FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_32ToByte((inVal.pHighToLowPercent),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.TempHighToLowDegK),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.pLowToHighPercent),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.TempLowToHighDegK),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_SATURATION_LUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=17)]
				public UInt16[] value;
			public static bool operator ==(FLR_BOSON_SATURATION_LUT_T self, FLR_BOSON_SATURATION_LUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_BOSON_SATURATION_LUT_T self, FLR_BOSON_SATURATION_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_SATURATION_LUT_T()
		
		private static FLR_BOSON_SATURATION_LUT_T byteToFLR_BOSON_SATURATION_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_SATURATION_LUT_T outVal;
			outVal.value = byteToUINT_16Array(inBuff,ptr,(UInt16) 17);
			ptr += 34;
			
			return outVal;
		} //end byteToFLR_BOSON_SATURATION_LUT_T()
		private static void FLR_BOSON_SATURATION_LUT_TToByte(FLR_BOSON_SATURATION_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ArrayToByte((inVal.value),(UInt16) 17,outBuff,ptr);
			ptr += 34;
			
		} //end FLR_BOSON_SATURATION_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_BOSON_SATURATION_HEADER_LUT_T {
			public FLR_BOSON_SATURATION_LUT_T lut;
			public UInt16 tableIndex;
			public static bool operator ==(FLR_BOSON_SATURATION_HEADER_LUT_T self, FLR_BOSON_SATURATION_HEADER_LUT_T other) {
				return ((self.lut == other.lut) && (self.tableIndex == other.tableIndex));
			}
			public static bool operator !=(FLR_BOSON_SATURATION_HEADER_LUT_T self, FLR_BOSON_SATURATION_HEADER_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_BOSON_SATURATION_HEADER_LUT_T()
		
		private static FLR_BOSON_SATURATION_HEADER_LUT_T byteToFLR_BOSON_SATURATION_HEADER_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_BOSON_SATURATION_HEADER_LUT_T outVal;
			outVal.lut = byteToFLR_BOSON_SATURATION_LUT_T(inBuff,ptr);
			ptr += 34;
			
			outVal.tableIndex = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_BOSON_SATURATION_HEADER_LUT_T()
		private static void FLR_BOSON_SATURATION_HEADER_LUT_TToByte(FLR_BOSON_SATURATION_HEADER_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_BOSON_SATURATION_LUT_TToByte((inVal.lut),outBuff,ptr);
			ptr += 34;
			
			UINT_16ToByte((inVal.tableIndex),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_BOSON_SATURATION_HEADER_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_CAPTURE_SETTINGS_T {
			public FLR_CAPTURE_SRC_E dataSrc;
			public UInt32 numFrames;
			public UInt16 bufferIndex;
			public static bool operator ==(FLR_CAPTURE_SETTINGS_T self, FLR_CAPTURE_SETTINGS_T other) {
				return ((self.dataSrc == other.dataSrc) && (self.numFrames == other.numFrames) && (self.bufferIndex == other.bufferIndex));
			}
			public static bool operator !=(FLR_CAPTURE_SETTINGS_T self, FLR_CAPTURE_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_CAPTURE_SETTINGS_T()
		
		private static FLR_CAPTURE_SETTINGS_T byteToFLR_CAPTURE_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_CAPTURE_SETTINGS_T outVal;
			outVal.dataSrc =(FLR_CAPTURE_SRC_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.numFrames = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.bufferIndex = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_CAPTURE_SETTINGS_T()
		private static void FLR_CAPTURE_SETTINGS_TToByte(FLR_CAPTURE_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((Int32)(inVal.dataSrc),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.numFrames),outBuff,ptr);
			ptr += 4;
			
			UINT_16ToByte((inVal.bufferIndex),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_CAPTURE_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_CAPTURE_FILE_SETTINGS_T {
			public FLR_CAPTURE_FILE_TYPE_E captureFileType;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=128)]
				public Byte[] filePath;
			public static bool operator ==(FLR_CAPTURE_FILE_SETTINGS_T self, FLR_CAPTURE_FILE_SETTINGS_T other) {
				return ((self.captureFileType == other.captureFileType) && (self.filePath == other.filePath));
			}
			public static bool operator !=(FLR_CAPTURE_FILE_SETTINGS_T self, FLR_CAPTURE_FILE_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_CAPTURE_FILE_SETTINGS_T()
		
		private static FLR_CAPTURE_FILE_SETTINGS_T byteToFLR_CAPTURE_FILE_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_CAPTURE_FILE_SETTINGS_T outVal;
			outVal.captureFileType =(FLR_CAPTURE_FILE_TYPE_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.filePath = byteToUCHARArray(inBuff,ptr,(UInt16) 128);
			ptr += 128;
			
			return outVal;
		} //end byteToFLR_CAPTURE_FILE_SETTINGS_T()
		private static void FLR_CAPTURE_FILE_SETTINGS_TToByte(FLR_CAPTURE_FILE_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((Int32)(inVal.captureFileType),outBuff,ptr);
			ptr += 4;
			
			UCHARArrayToByte((inVal.filePath),(UInt16) 128,outBuff,ptr);
			ptr += 128;
			
		} //end FLR_CAPTURE_FILE_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_CAPTURE_STATUS_T {
			public FLR_CAPTURE_STATE_E state;
			public UInt32 result;
			public UInt32 capturedFrames;
			public UInt32 missedFrames;
			public UInt32 savedFrames;
			public UInt32 unsyncFrames;
			public static bool operator ==(FLR_CAPTURE_STATUS_T self, FLR_CAPTURE_STATUS_T other) {
				return ((self.state == other.state) && (self.result == other.result) && (self.capturedFrames == other.capturedFrames) && (self.missedFrames == other.missedFrames) && (self.savedFrames == other.savedFrames) && (self.unsyncFrames == other.unsyncFrames));
			}
			public static bool operator !=(FLR_CAPTURE_STATUS_T self, FLR_CAPTURE_STATUS_T other) {
				return !(self == other);
			}
		}// end of FLR_CAPTURE_STATUS_T()
		
		private static FLR_CAPTURE_STATUS_T byteToFLR_CAPTURE_STATUS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_CAPTURE_STATUS_T outVal;
			outVal.state =(FLR_CAPTURE_STATE_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.result = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.capturedFrames = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.missedFrames = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.savedFrames = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.unsyncFrames = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_CAPTURE_STATUS_T()
		private static void FLR_CAPTURE_STATUS_TToByte(FLR_CAPTURE_STATUS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((Int32)(inVal.state),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.result),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.capturedFrames),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.missedFrames),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.savedFrames),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.unsyncFrames),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_CAPTURE_STATUS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_DVO_YCBCR_SETTINGS_T {
			public FLR_DVO_OUTPUT_YCBCR_FORMAT_E ycbcrFormat;
			public FLR_DVO_OUTPUT_CBCR_ORDER_E cbcrOrder;
			public FLR_DVO_OUTPUT_Y_ORDER_E yOrder;
			public static bool operator ==(FLR_DVO_YCBCR_SETTINGS_T self, FLR_DVO_YCBCR_SETTINGS_T other) {
				return ((self.ycbcrFormat == other.ycbcrFormat) && (self.cbcrOrder == other.cbcrOrder) && (self.yOrder == other.yOrder));
			}
			public static bool operator !=(FLR_DVO_YCBCR_SETTINGS_T self, FLR_DVO_YCBCR_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_DVO_YCBCR_SETTINGS_T()
		
		private static FLR_DVO_YCBCR_SETTINGS_T byteToFLR_DVO_YCBCR_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_DVO_YCBCR_SETTINGS_T outVal;
			outVal.ycbcrFormat =(FLR_DVO_OUTPUT_YCBCR_FORMAT_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.cbcrOrder =(FLR_DVO_OUTPUT_CBCR_ORDER_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.yOrder =(FLR_DVO_OUTPUT_Y_ORDER_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_DVO_YCBCR_SETTINGS_T()
		private static void FLR_DVO_YCBCR_SETTINGS_TToByte(FLR_DVO_YCBCR_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((Int32)(inVal.ycbcrFormat),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.cbcrOrder),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.yOrder),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_DVO_YCBCR_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_DVO_RGB_SETTINGS_T {
			public FLR_DVO_OUTPUT_RGB_FORMAT_E rgbFormat;
			public FLR_DVO_OUTPUT_RGB_ORDER_E rgbOrder;
			public static bool operator ==(FLR_DVO_RGB_SETTINGS_T self, FLR_DVO_RGB_SETTINGS_T other) {
				return ((self.rgbFormat == other.rgbFormat) && (self.rgbOrder == other.rgbOrder));
			}
			public static bool operator !=(FLR_DVO_RGB_SETTINGS_T self, FLR_DVO_RGB_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_DVO_RGB_SETTINGS_T()
		
		private static FLR_DVO_RGB_SETTINGS_T byteToFLR_DVO_RGB_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_DVO_RGB_SETTINGS_T outVal;
			outVal.rgbFormat =(FLR_DVO_OUTPUT_RGB_FORMAT_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.rgbOrder =(FLR_DVO_OUTPUT_RGB_ORDER_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_DVO_RGB_SETTINGS_T()
		private static void FLR_DVO_RGB_SETTINGS_TToByte(FLR_DVO_RGB_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((Int32)(inVal.rgbFormat),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.rgbOrder),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_DVO_RGB_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_DVO_LCD_CONFIG_T {
			public UInt32 width;
			public UInt32 hPulseWidth;
			public UInt32 hBackP;
			public UInt32 hFrontP;
			public UInt32 height;
			public UInt32 vPulseWidth;
			public UInt32 vBackP;
			public UInt32 vFrontP;
			public UInt32 outputFormat;
			public UInt32 control;
			public UInt32 rotation;
			public UInt32 pixelClockkHz;
			public static bool operator ==(FLR_DVO_LCD_CONFIG_T self, FLR_DVO_LCD_CONFIG_T other) {
				return ((self.width == other.width) && (self.hPulseWidth == other.hPulseWidth) && (self.hBackP == other.hBackP) && (self.hFrontP == other.hFrontP) && (self.height == other.height) && (self.vPulseWidth == other.vPulseWidth) && (self.vBackP == other.vBackP) && (self.vFrontP == other.vFrontP) && (self.outputFormat == other.outputFormat) && (self.control == other.control) && (self.rotation == other.rotation) && (self.pixelClockkHz == other.pixelClockkHz));
			}
			public static bool operator !=(FLR_DVO_LCD_CONFIG_T self, FLR_DVO_LCD_CONFIG_T other) {
				return !(self == other);
			}
		}// end of FLR_DVO_LCD_CONFIG_T()
		
		private static FLR_DVO_LCD_CONFIG_T byteToFLR_DVO_LCD_CONFIG_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_DVO_LCD_CONFIG_T outVal;
			outVal.width = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.hPulseWidth = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.hBackP = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.hFrontP = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.height = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.vPulseWidth = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.vBackP = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.vFrontP = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.outputFormat = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.control = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.rotation = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.pixelClockkHz = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_DVO_LCD_CONFIG_T()
		private static void FLR_DVO_LCD_CONFIG_TToByte(FLR_DVO_LCD_CONFIG_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_32ToByte((inVal.width),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.hPulseWidth),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.hBackP),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.hFrontP),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.height),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.vPulseWidth),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.vBackP),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.vFrontP),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.outputFormat),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.control),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.rotation),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.pixelClockkHz),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_DVO_LCD_CONFIG_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_GAO_RNS_COL_CORRECT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
				public Int16[] value;
			public static bool operator ==(FLR_GAO_RNS_COL_CORRECT_T self, FLR_GAO_RNS_COL_CORRECT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_GAO_RNS_COL_CORRECT_T self, FLR_GAO_RNS_COL_CORRECT_T other) {
				return !(self == other);
			}
		}// end of FLR_GAO_RNS_COL_CORRECT_T()
		
		private static FLR_GAO_RNS_COL_CORRECT_T byteToFLR_GAO_RNS_COL_CORRECT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_GAO_RNS_COL_CORRECT_T outVal;
			outVal.value = byteToINT_16Array(inBuff,ptr,(UInt16) 20);
			ptr += 40;
			
			return outVal;
		} //end byteToFLR_GAO_RNS_COL_CORRECT_T()
		private static void FLR_GAO_RNS_COL_CORRECT_TToByte(FLR_GAO_RNS_COL_CORRECT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_16ArrayToByte((inVal.value),(UInt16) 20,outBuff,ptr);
			ptr += 40;
			
		} //end FLR_GAO_RNS_COL_CORRECT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_ISOTHERM_COLOR_T {
			public UInt16 r;
			public UInt16 g;
			public UInt16 b;
			public static bool operator ==(FLR_ISOTHERM_COLOR_T self, FLR_ISOTHERM_COLOR_T other) {
				return ((self.r == other.r) && (self.g == other.g) && (self.b == other.b));
			}
			public static bool operator !=(FLR_ISOTHERM_COLOR_T self, FLR_ISOTHERM_COLOR_T other) {
				return !(self == other);
			}
		}// end of FLR_ISOTHERM_COLOR_T()
		
		private static FLR_ISOTHERM_COLOR_T byteToFLR_ISOTHERM_COLOR_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_ISOTHERM_COLOR_T outVal;
			outVal.r = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.g = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.b = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_ISOTHERM_COLOR_T()
		private static void FLR_ISOTHERM_COLOR_TToByte(FLR_ISOTHERM_COLOR_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ToByte((inVal.r),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.g),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.b),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_ISOTHERM_COLOR_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_ISOTHERM_COLORS_T {
			public FLR_ISOTHERM_COLOR_T range1;
			public FLR_ISOTHERM_COLOR_T range2;
			public FLR_ISOTHERM_COLOR_T range3;
			public UInt16 num;
			public static bool operator ==(FLR_ISOTHERM_COLORS_T self, FLR_ISOTHERM_COLORS_T other) {
				return ((self.range1 == other.range1) && (self.range2 == other.range2) && (self.range3 == other.range3) && (self.num == other.num));
			}
			public static bool operator !=(FLR_ISOTHERM_COLORS_T self, FLR_ISOTHERM_COLORS_T other) {
				return !(self == other);
			}
		}// end of FLR_ISOTHERM_COLORS_T()
		
		private static FLR_ISOTHERM_COLORS_T byteToFLR_ISOTHERM_COLORS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_ISOTHERM_COLORS_T outVal;
			outVal.range1 = byteToFLR_ISOTHERM_COLOR_T(inBuff,ptr);
			ptr += 6;
			
			outVal.range2 = byteToFLR_ISOTHERM_COLOR_T(inBuff,ptr);
			ptr += 6;
			
			outVal.range3 = byteToFLR_ISOTHERM_COLOR_T(inBuff,ptr);
			ptr += 6;
			
			outVal.num = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_ISOTHERM_COLORS_T()
		private static void FLR_ISOTHERM_COLORS_TToByte(FLR_ISOTHERM_COLORS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_ISOTHERM_COLOR_TToByte((inVal.range1),outBuff,ptr);
			ptr += 6;
			
			FLR_ISOTHERM_COLOR_TToByte((inVal.range2),outBuff,ptr);
			ptr += 6;
			
			FLR_ISOTHERM_COLOR_TToByte((inVal.range3),outBuff,ptr);
			ptr += 6;
			
			UINT_16ToByte((inVal.num),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_ISOTHERM_COLORS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_ISOTHERM_SETTINGS_T {
			public Int32 thIsoT1;
			public Int32 thIsoT2;
			public Int32 thIsoT3;
			public Int32 thIsoT4;
			public Int32 thIsoT5;
			public FLR_ISOTHERM_COLORS_T color0;
			public FLR_ISOTHERM_COLORS_T color1;
			public FLR_ISOTHERM_COLORS_T color2;
			public FLR_ISOTHERM_COLORS_T color3;
			public FLR_ISOTHERM_COLORS_T color4;
			public FLR_ISOTHERM_COLORS_T color5;
			public FLR_ISOTHERM_REGION_E region0;
			public FLR_ISOTHERM_REGION_E region1;
			public FLR_ISOTHERM_REGION_E region2;
			public FLR_ISOTHERM_REGION_E region3;
			public FLR_ISOTHERM_REGION_E region4;
			public FLR_ISOTHERM_REGION_E region5;
			public static bool operator ==(FLR_ISOTHERM_SETTINGS_T self, FLR_ISOTHERM_SETTINGS_T other) {
				return ((self.thIsoT1 == other.thIsoT1) && (self.thIsoT2 == other.thIsoT2) && (self.thIsoT3 == other.thIsoT3) && (self.thIsoT4 == other.thIsoT4) && (self.thIsoT5 == other.thIsoT5) && (self.color0 == other.color0) && (self.color1 == other.color1) && (self.color2 == other.color2) && (self.color3 == other.color3) && (self.color4 == other.color4) && (self.color5 == other.color5) && (self.region0 == other.region0) && (self.region1 == other.region1) && (self.region2 == other.region2) && (self.region3 == other.region3) && (self.region4 == other.region4) && (self.region5 == other.region5));
			}
			public static bool operator !=(FLR_ISOTHERM_SETTINGS_T self, FLR_ISOTHERM_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_ISOTHERM_SETTINGS_T()
		
		private static FLR_ISOTHERM_SETTINGS_T byteToFLR_ISOTHERM_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_ISOTHERM_SETTINGS_T outVal;
			outVal.thIsoT1 = byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.thIsoT2 = byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.thIsoT3 = byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.thIsoT4 = byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.thIsoT5 = byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.color0 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.color1 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.color2 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.color3 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.color4 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.color5 = byteToFLR_ISOTHERM_COLORS_T(inBuff,ptr);
			ptr += 20;
			
			outVal.region0 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.region1 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.region2 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.region3 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.region4 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.region5 =(FLR_ISOTHERM_REGION_E) byteToINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_ISOTHERM_SETTINGS_T()
		private static void FLR_ISOTHERM_SETTINGS_TToByte(FLR_ISOTHERM_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_32ToByte((inVal.thIsoT1),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((inVal.thIsoT2),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((inVal.thIsoT3),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((inVal.thIsoT4),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((inVal.thIsoT5),outBuff,ptr);
			ptr += 4;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color0),outBuff,ptr);
			ptr += 20;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color1),outBuff,ptr);
			ptr += 20;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color2),outBuff,ptr);
			ptr += 20;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color3),outBuff,ptr);
			ptr += 20;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color4),outBuff,ptr);
			ptr += 20;
			
			FLR_ISOTHERM_COLORS_TToByte((inVal.color5),outBuff,ptr);
			ptr += 20;
			
			INT_32ToByte((Int32)(inVal.region0),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.region1),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.region2),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.region3),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.region4),outBuff,ptr);
			ptr += 4;
			
			INT_32ToByte((Int32)(inVal.region5),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_ISOTHERM_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=17)]
				public UInt16[] value;
			public static bool operator ==(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T self, FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T self, FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()
		
		private static FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T outVal;
			outVal.value = byteToUINT_16Array(inBuff,ptr,(UInt16) 17);
			ptr += 34;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T()
		private static void FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ArrayToByte((inVal.value),(UInt16) 17,outBuff,ptr);
			ptr += 34;
			
		} //end FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=17)]
				public UInt16[] value;
			public static bool operator ==(FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T self, FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T self, FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()
		
		private static FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T outVal;
			outVal.value = byteToUINT_16Array(inBuff,ptr,(UInt16) 17);
			ptr += 34;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T()
		private static void FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte(FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ArrayToByte((inVal.value),(UInt16) 17,outBuff,ptr);
			ptr += 34;
			
		} //end FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T {
			public FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T lut;
			public UInt16 tableIndex;
			public static bool operator ==(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T self, FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T other) {
				return ((self.lut == other.lut) && (self.tableIndex == other.tableIndex));
			}
			public static bool operator !=(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T self, FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T()
		
		private static FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T outVal;
			outVal.lut = byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T(inBuff,ptr);
			ptr += 34;
			
			outVal.tableIndex = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T()
		private static void FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_TToByte(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte((inVal.lut),outBuff,ptr);
			ptr += 34;
			
			UINT_16ToByte((inVal.tableIndex),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_HEADER_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T {
			public FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T lut;
			public UInt16 tableIndex;
			public static bool operator ==(FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T self, FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T other) {
				return ((self.lut == other.lut) && (self.tableIndex == other.tableIndex));
			}
			public static bool operator !=(FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T self, FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T()
		
		private static FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T outVal;
			outVal.lut = byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T(inBuff,ptr);
			ptr += 34;
			
			outVal.tableIndex = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T()
		private static void FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_TToByte(FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte((inVal.lut),outBuff,ptr);
			ptr += 34;
			
			UINT_16ToByte((inVal.tableIndex),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_RADIOMETRY_NOISE_COMP_FACTOR_HEADER_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_RBFO_PARAMS_T {
			public Double RBFO_R;
			public Double RBFO_B;
			public Double RBFO_F;
			public Double RBFO_O;
			public static bool operator ==(FLR_RADIOMETRY_RBFO_PARAMS_T self, FLR_RADIOMETRY_RBFO_PARAMS_T other) {
				return ((self.RBFO_R == other.RBFO_R) && (self.RBFO_B == other.RBFO_B) && (self.RBFO_F == other.RBFO_F) && (self.RBFO_O == other.RBFO_O));
			}
			public static bool operator !=(FLR_RADIOMETRY_RBFO_PARAMS_T self, FLR_RADIOMETRY_RBFO_PARAMS_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_RBFO_PARAMS_T()
		
		private static FLR_RADIOMETRY_RBFO_PARAMS_T byteToFLR_RADIOMETRY_RBFO_PARAMS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_RBFO_PARAMS_T outVal;
			outVal.RBFO_R = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.RBFO_B = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.RBFO_F = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.RBFO_O = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_RBFO_PARAMS_T()
		private static void FLR_RADIOMETRY_RBFO_PARAMS_TToByte(FLR_RADIOMETRY_RBFO_PARAMS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLOATToByte((inVal.RBFO_R),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.RBFO_B),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.RBFO_F),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.RBFO_O),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_RADIOMETRY_RBFO_PARAMS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_RADIOMETRY_TAUX_PARAMS_T {
			public Double A3;
			public Double A2;
			public Double A1;
			public Double A0;
			public static bool operator ==(FLR_RADIOMETRY_TAUX_PARAMS_T self, FLR_RADIOMETRY_TAUX_PARAMS_T other) {
				return ((self.A3 == other.A3) && (self.A2 == other.A2) && (self.A1 == other.A1) && (self.A0 == other.A0));
			}
			public static bool operator !=(FLR_RADIOMETRY_TAUX_PARAMS_T self, FLR_RADIOMETRY_TAUX_PARAMS_T other) {
				return !(self == other);
			}
		}// end of FLR_RADIOMETRY_TAUX_PARAMS_T()
		
		private static FLR_RADIOMETRY_TAUX_PARAMS_T byteToFLR_RADIOMETRY_TAUX_PARAMS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_RADIOMETRY_TAUX_PARAMS_T outVal;
			outVal.A3 = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.A2 = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.A1 = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			outVal.A0 = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_RADIOMETRY_TAUX_PARAMS_T()
		private static void FLR_RADIOMETRY_TAUX_PARAMS_TToByte(FLR_RADIOMETRY_TAUX_PARAMS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLOATToByte((inVal.A3),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.A2),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.A1),outBuff,ptr);
			ptr += 4;
			
			FLOATToByte((inVal.A0),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_RADIOMETRY_TAUX_PARAMS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_ROIC_FPATEMP_TABLE_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=32)]
				public Int16[] value;
			public static bool operator ==(FLR_ROIC_FPATEMP_TABLE_T self, FLR_ROIC_FPATEMP_TABLE_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_ROIC_FPATEMP_TABLE_T self, FLR_ROIC_FPATEMP_TABLE_T other) {
				return !(self == other);
			}
		}// end of FLR_ROIC_FPATEMP_TABLE_T()
		
		private static FLR_ROIC_FPATEMP_TABLE_T byteToFLR_ROIC_FPATEMP_TABLE_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_ROIC_FPATEMP_TABLE_T outVal;
			outVal.value = byteToINT_16Array(inBuff,ptr,(UInt16) 32);
			ptr += 64;
			
			return outVal;
		} //end byteToFLR_ROIC_FPATEMP_TABLE_T()
		private static void FLR_ROIC_FPATEMP_TABLE_TToByte(FLR_ROIC_FPATEMP_TABLE_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_16ArrayToByte((inVal.value),(UInt16) 32,outBuff,ptr);
			ptr += 64;
			
		} //end FLR_ROIC_FPATEMP_TABLE_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SCALER_ZOOM_PARAMS_T {
			public UInt32 zoom;
			public UInt32 xCenter;
			public UInt32 yCenter;
			public static bool operator ==(FLR_SCALER_ZOOM_PARAMS_T self, FLR_SCALER_ZOOM_PARAMS_T other) {
				return ((self.zoom == other.zoom) && (self.xCenter == other.xCenter) && (self.yCenter == other.yCenter));
			}
			public static bool operator !=(FLR_SCALER_ZOOM_PARAMS_T self, FLR_SCALER_ZOOM_PARAMS_T other) {
				return !(self == other);
			}
		}// end of FLR_SCALER_ZOOM_PARAMS_T()
		
		private static FLR_SCALER_ZOOM_PARAMS_T byteToFLR_SCALER_ZOOM_PARAMS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SCALER_ZOOM_PARAMS_T outVal;
			outVal.zoom = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.xCenter = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.yCenter = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_SCALER_ZOOM_PARAMS_T()
		private static void FLR_SCALER_ZOOM_PARAMS_TToByte(FLR_SCALER_ZOOM_PARAMS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_32ToByte((inVal.zoom),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.xCenter),outBuff,ptr);
			ptr += 4;
			
			UINT_32ToByte((inVal.yCenter),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_SCALER_ZOOM_PARAMS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SPNR_PSD_KERNEL_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=64)]
				public Double[] fvalue;
			public static bool operator ==(FLR_SPNR_PSD_KERNEL_T self, FLR_SPNR_PSD_KERNEL_T other) {
				return ((self.fvalue == other.fvalue));
			}
			public static bool operator !=(FLR_SPNR_PSD_KERNEL_T self, FLR_SPNR_PSD_KERNEL_T other) {
				return !(self == other);
			}
		}// end of FLR_SPNR_PSD_KERNEL_T()
		
		private static FLR_SPNR_PSD_KERNEL_T byteToFLR_SPNR_PSD_KERNEL_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SPNR_PSD_KERNEL_T outVal;
			outVal.fvalue = byteToFLOATArray(inBuff,ptr,(UInt16) 64);
			ptr += 256;
			
			return outVal;
		} //end byteToFLR_SPNR_PSD_KERNEL_T()
		private static void FLR_SPNR_PSD_KERNEL_TToByte(FLR_SPNR_PSD_KERNEL_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLOATArrayToByte((inVal.fvalue),(UInt16) 64,outBuff,ptr);
			ptr += 256;
			
		} //end FLR_SPNR_PSD_KERNEL_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SPOTMETER_SPOT_PARAM_T {
			public UInt16 row;
			public UInt16 column;
			public UInt16 value;
			public static bool operator ==(FLR_SPOTMETER_SPOT_PARAM_T self, FLR_SPOTMETER_SPOT_PARAM_T other) {
				return ((self.row == other.row) && (self.column == other.column) && (self.value == other.value));
			}
			public static bool operator !=(FLR_SPOTMETER_SPOT_PARAM_T self, FLR_SPOTMETER_SPOT_PARAM_T other) {
				return !(self == other);
			}
		}// end of FLR_SPOTMETER_SPOT_PARAM_T()
		
		private static FLR_SPOTMETER_SPOT_PARAM_T byteToFLR_SPOTMETER_SPOT_PARAM_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SPOTMETER_SPOT_PARAM_T outVal;
			outVal.row = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.column = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.value = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_SPOTMETER_SPOT_PARAM_T()
		private static void FLR_SPOTMETER_SPOT_PARAM_TToByte(FLR_SPOTMETER_SPOT_PARAM_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ToByte((inVal.row),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.column),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.value),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_SPOTMETER_SPOT_PARAM_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SPOTMETER_STAT_PARAM_TEMP_T {
			public UInt16 row;
			public UInt16 column;
			public Double value;
			public static bool operator ==(FLR_SPOTMETER_STAT_PARAM_TEMP_T self, FLR_SPOTMETER_STAT_PARAM_TEMP_T other) {
				return ((self.row == other.row) && (self.column == other.column) && (self.value == other.value));
			}
			public static bool operator !=(FLR_SPOTMETER_STAT_PARAM_TEMP_T self, FLR_SPOTMETER_STAT_PARAM_TEMP_T other) {
				return !(self == other);
			}
		}// end of FLR_SPOTMETER_STAT_PARAM_TEMP_T()
		
		private static FLR_SPOTMETER_STAT_PARAM_TEMP_T byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SPOTMETER_STAT_PARAM_TEMP_T outVal;
			outVal.row = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.column = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.value = byteToFLOAT(inBuff,ptr);
			ptr += 4;
			
			return outVal;
		} //end byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T()
		private static void FLR_SPOTMETER_STAT_PARAM_TEMP_TToByte(FLR_SPOTMETER_STAT_PARAM_TEMP_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ToByte((inVal.row),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.column),outBuff,ptr);
			ptr += 2;
			
			FLOATToByte((inVal.value),outBuff,ptr);
			ptr += 4;
			
		} //end FLR_SPOTMETER_STAT_PARAM_TEMP_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SYSINFO_MONITOR_BUILD_VARIANT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=50)]
				public Byte[] value;
			public static bool operator ==(FLR_SYSINFO_MONITOR_BUILD_VARIANT_T self, FLR_SYSINFO_MONITOR_BUILD_VARIANT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_SYSINFO_MONITOR_BUILD_VARIANT_T self, FLR_SYSINFO_MONITOR_BUILD_VARIANT_T other) {
				return !(self == other);
			}
		}// end of FLR_SYSINFO_MONITOR_BUILD_VARIANT_T()
		
		private static FLR_SYSINFO_MONITOR_BUILD_VARIANT_T byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SYSINFO_MONITOR_BUILD_VARIANT_T outVal;
			outVal.value = byteToUCHARArray(inBuff,ptr,(UInt16) 50);
			ptr += 50;
			
			return outVal;
		} //end byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T()
		private static void FLR_SYSINFO_MONITOR_BUILD_VARIANT_TToByte(FLR_SYSINFO_MONITOR_BUILD_VARIANT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UCHARArrayToByte((inVal.value),(UInt16) 50,outBuff,ptr);
			ptr += 50;
			
		} //end FLR_SYSINFO_MONITOR_BUILD_VARIANT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T {
			public Byte id;
			public Int16 x;
			public Int16 y;
			public Int16 width;
			public Int16 height;
			public UInt32 color;
			public Int16 size;
			public static bool operator ==(FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T self, FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T other) {
				return ((self.id == other.id) && (self.x == other.x) && (self.y == other.y) && (self.width == other.width) && (self.height == other.height) && (self.color == other.color) && (self.size == other.size));
			}
			public static bool operator !=(FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T self, FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T other) {
				return !(self == other);
			}
		}// end of FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
		
		private static FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T outVal;
			outVal.id = byteToUCHAR(inBuff,ptr);
			ptr += 1;
			
			outVal.x = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.y = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.width = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.height = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.color = byteToUINT_32(inBuff,ptr);
			ptr += 4;
			
			outVal.size = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T()
		private static void FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte(FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UCHARToByte((inVal.id),outBuff,ptr);
			ptr += 1;
			
			INT_16ToByte((inVal.x),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.y),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.width),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.height),outBuff,ptr);
			ptr += 2;
			
			UINT_32ToByte((inVal.color),outBuff,ptr);
			ptr += 4;
			
			INT_16ToByte((inVal.size),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SYSTEMSYMBOLS_SPOTCONFIG_T {
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T symbol;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T area;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T min;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T max;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T mean;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T meanBar;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBar;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarFilling;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarText1;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarText2;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarText3;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarText4;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T greenBarText5;
			public static bool operator ==(FLR_SYSTEMSYMBOLS_SPOTCONFIG_T self, FLR_SYSTEMSYMBOLS_SPOTCONFIG_T other) {
				return ((self.symbol == other.symbol) && (self.area == other.area) && (self.min == other.min) && (self.max == other.max) && (self.mean == other.mean) && (self.meanBar == other.meanBar) && (self.greenBar == other.greenBar) && (self.greenBarFilling == other.greenBarFilling) && (self.greenBarText1 == other.greenBarText1) && (self.greenBarText2 == other.greenBarText2) && (self.greenBarText3 == other.greenBarText3) && (self.greenBarText4 == other.greenBarText4) && (self.greenBarText5 == other.greenBarText5));
			}
			public static bool operator !=(FLR_SYSTEMSYMBOLS_SPOTCONFIG_T self, FLR_SYSTEMSYMBOLS_SPOTCONFIG_T other) {
				return !(self == other);
			}
		}// end of FLR_SYSTEMSYMBOLS_SPOTCONFIG_T()
		
		private static FLR_SYSTEMSYMBOLS_SPOTCONFIG_T byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SYSTEMSYMBOLS_SPOTCONFIG_T outVal;
			outVal.symbol = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.area = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.min = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.max = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.mean = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.meanBar = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBar = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarFilling = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarText1 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarText2 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarText3 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarText4 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.greenBarText5 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			return outVal;
		} //end byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T()
		private static void FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte(FLR_SYSTEMSYMBOLS_SPOTCONFIG_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.symbol),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.area),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.min),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.max),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.mean),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.meanBar),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBar),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarFilling),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarText1),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarText2),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarText3),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarText4),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.greenBarText5),outBuff,ptr);
			ptr += 15;
			
		} //end FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SYSTEMSYMBOLS_ISOCONFIG_T {
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T colorBar1;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T colorBar2;
			public FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T colorBarOutline;
			public static bool operator ==(FLR_SYSTEMSYMBOLS_ISOCONFIG_T self, FLR_SYSTEMSYMBOLS_ISOCONFIG_T other) {
				return ((self.colorBar1 == other.colorBar1) && (self.colorBar2 == other.colorBar2) && (self.colorBarOutline == other.colorBarOutline));
			}
			public static bool operator !=(FLR_SYSTEMSYMBOLS_ISOCONFIG_T self, FLR_SYSTEMSYMBOLS_ISOCONFIG_T other) {
				return !(self == other);
			}
		}// end of FLR_SYSTEMSYMBOLS_ISOCONFIG_T()
		
		private static FLR_SYSTEMSYMBOLS_ISOCONFIG_T byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SYSTEMSYMBOLS_ISOCONFIG_T outVal;
			outVal.colorBar1 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.colorBar2 = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			outVal.colorBarOutline = byteToFLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_T(inBuff,ptr);
			ptr += 15;
			
			return outVal;
		} //end byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T()
		private static void FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte(FLR_SYSTEMSYMBOLS_ISOCONFIG_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.colorBar1),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.colorBar2),outBuff,ptr);
			ptr += 15;
			
			FLR_SYSTEMSYMBOLS_SPOT_ISO_ENTRY_TToByte((inVal.colorBarOutline),outBuff,ptr);
			ptr += 15;
			
		} //end FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_SYSTEMSYMBOLS_BARCONFIG_T {
			public Int16 val0;
			public Int16 val1;
			public Int16 val2;
			public Int16 val3;
			public Int16 val4;
			public static bool operator ==(FLR_SYSTEMSYMBOLS_BARCONFIG_T self, FLR_SYSTEMSYMBOLS_BARCONFIG_T other) {
				return ((self.val0 == other.val0) && (self.val1 == other.val1) && (self.val2 == other.val2) && (self.val3 == other.val3) && (self.val4 == other.val4));
			}
			public static bool operator !=(FLR_SYSTEMSYMBOLS_BARCONFIG_T self, FLR_SYSTEMSYMBOLS_BARCONFIG_T other) {
				return !(self == other);
			}
		}// end of FLR_SYSTEMSYMBOLS_BARCONFIG_T()
		
		private static FLR_SYSTEMSYMBOLS_BARCONFIG_T byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_SYSTEMSYMBOLS_BARCONFIG_T outVal;
			outVal.val0 = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.val1 = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.val2 = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.val3 = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.val4 = byteToINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T()
		private static void FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(FLR_SYSTEMSYMBOLS_BARCONFIG_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			INT_16ToByte((inVal.val0),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.val1),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.val2),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.val3),outBuff,ptr);
			ptr += 2;
			
			INT_16ToByte((inVal.val4),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_TESTRAMP_SETTINGS_T {
			public UInt16 start;
			public UInt16 end;
			public UInt16 increment;
			public static bool operator ==(FLR_TESTRAMP_SETTINGS_T self, FLR_TESTRAMP_SETTINGS_T other) {
				return ((self.start == other.start) && (self.end == other.end) && (self.increment == other.increment));
			}
			public static bool operator !=(FLR_TESTRAMP_SETTINGS_T self, FLR_TESTRAMP_SETTINGS_T other) {
				return !(self == other);
			}
		}// end of FLR_TESTRAMP_SETTINGS_T()
		
		private static FLR_TESTRAMP_SETTINGS_T byteToFLR_TESTRAMP_SETTINGS_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_TESTRAMP_SETTINGS_T outVal;
			outVal.start = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.end = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			outVal.increment = byteToUINT_16(inBuff,ptr);
			ptr += 2;
			
			return outVal;
		} //end byteToFLR_TESTRAMP_SETTINGS_T()
		private static void FLR_TESTRAMP_SETTINGS_TToByte(FLR_TESTRAMP_SETTINGS_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ToByte((inVal.start),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.end),outBuff,ptr);
			ptr += 2;
			
			UINT_16ToByte((inVal.increment),outBuff,ptr);
			ptr += 2;
			
		} //end FLR_TESTRAMP_SETTINGS_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_TF_WLUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=32)]
				public Byte[] value;
			public static bool operator ==(FLR_TF_WLUT_T self, FLR_TF_WLUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_TF_WLUT_T self, FLR_TF_WLUT_T other) {
				return !(self == other);
			}
		}// end of FLR_TF_WLUT_T()
		
		private static FLR_TF_WLUT_T byteToFLR_TF_WLUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_TF_WLUT_T outVal;
			outVal.value = byteToUCHARArray(inBuff,ptr,(UInt16) 32);
			ptr += 32;
			
			return outVal;
		} //end byteToFLR_TF_WLUT_T()
		private static void FLR_TF_WLUT_TToByte(FLR_TF_WLUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UCHARArrayToByte((inVal.value),(UInt16) 32,outBuff,ptr);
			ptr += 32;
			
		} //end FLR_TF_WLUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_TF_NF_LUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=17)]
				public UInt16[] value;
			public static bool operator ==(FLR_TF_NF_LUT_T self, FLR_TF_NF_LUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_TF_NF_LUT_T self, FLR_TF_NF_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_TF_NF_LUT_T()
		
		private static FLR_TF_NF_LUT_T byteToFLR_TF_NF_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_TF_NF_LUT_T outVal;
			outVal.value = byteToUINT_16Array(inBuff,ptr,(UInt16) 17);
			ptr += 34;
			
			return outVal;
		} //end byteToFLR_TF_NF_LUT_T()
		private static void FLR_TF_NF_LUT_TToByte(FLR_TF_NF_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ArrayToByte((inVal.value),(UInt16) 17,outBuff,ptr);
			ptr += 34;
			
		} //end FLR_TF_NF_LUT_TToByte()
		
		[ StructLayout( LayoutKind.Sequential )]
		public struct FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T {
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=17)]
				public UInt16[] value;
			public static bool operator ==(FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T self, FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T other) {
				return ((self.value == other.value));
			}
			public static bool operator !=(FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T self, FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T other) {
				return !(self == other);
			}
		}// end of FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T()
		
		private static FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T( Byte[] inBuff, UInt16 inPtr) {
			
			UInt16 ptr = inPtr;
			FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T outVal;
			outVal.value = byteToUINT_16Array(inBuff,ptr,(UInt16) 17);
			ptr += 34;
			
			return outVal;
		} //end byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T()
		private static void FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte(FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T inVal, Byte[] outBuff, UInt16 outPtr) {
			
			UInt16 ptr = outPtr;
			UINT_16ArrayToByte((inVal.value),(UInt16) 17,outBuff,ptr);
			ptr += 34;
			
		} //end FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte()
		
	} // end partial class Camera
} // end namespace Boson
