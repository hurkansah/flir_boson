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


namespace Boson {
	public partial class Camera{
		internal static class ClientPackager {
			static UInt32 commandCount = 0;
			
			// Begin Module: TLinear
			public static FLR_RESULT TlinearSetControl(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TLINEAR_SETCONTROL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTlinearSetControl()
			
			public static FLR_RESULT TlinearGetControl(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TLINEAR_GETCONTROL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTlinearGetControl()
			
			public static FLR_RESULT TlinearGetLUT(Camera parent, FLR_BOSON_TABLETYPE_E mode, UInt16 offset, out Double[] a, out Double[] b) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 6;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				a = new Double[16];
				b = new Double[16];
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) mode,sendData,outPtr);
				outPtr += 4;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(offset,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TLINEAR_GETLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read a from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				a = byteToFLOATArray(receiveData,inPtr,16);
				inPtr+=64;
				
				// read b from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				b = byteToFLOATArray(receiveData,inPtr,16);
				inPtr+=64;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTlinearGetLUT()
			
			public static FLR_RESULT TlinearRefreshLUT(Camera parent, FLR_BOSON_TABLETYPE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) mode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TLINEAR_REFRESHLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTlinearRefreshLUT()
			
			// End Module: TLinear
			
			// Begin Module: agc
			public static FLR_RESULT AgcSetPercentPerBin(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETPERCENTPERBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetPercentPerBin()
			
			public static FLR_RESULT AgcGetPercentPerBin(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETPERCENTPERBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetPercentPerBin()
			
			public static FLR_RESULT AgcSetLinearPercent(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETLINEARPERCENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetLinearPercent()
			
			public static FLR_RESULT AgcGetLinearPercent(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETLINEARPERCENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetLinearPercent()
			
			public static FLR_RESULT AgcSetOutlierCut(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETOUTLIERCUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetOutlierCut()
			
			public static FLR_RESULT AgcGetOutlierCut(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETOUTLIERCUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetOutlierCut()
			
			public static FLR_RESULT AgcGetDrOut(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETDROUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetDrOut()
			
			public static FLR_RESULT AgcSetMaxGain(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETMAXGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetMaxGain()
			
			public static FLR_RESULT AgcGetMaxGain(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETMAXGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetMaxGain()
			
			public static FLR_RESULT AgcSetdf(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetdf()
			
			public static FLR_RESULT AgcGetdf(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetdf()
			
			public static FLR_RESULT AgcSetGamma(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETGAMMA, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetGamma()
			
			public static FLR_RESULT AgcGetGamma(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETGAMMA, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetGamma()
			
			public static FLR_RESULT AgcGetFirstBin(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETFIRSTBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetFirstBin()
			
			public static FLR_RESULT AgcGetLastBin(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETLASTBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetLastBin()
			
			public static FLR_RESULT AgcSetDetailHeadroom(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETDETAILHEADROOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetDetailHeadroom()
			
			public static FLR_RESULT AgcGetDetailHeadroom(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETDETAILHEADROOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetDetailHeadroom()
			
			public static FLR_RESULT AgcSetd2br(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETD2BR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetd2br()
			
			public static FLR_RESULT AgcGetd2br(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETD2BR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetd2br()
			
			public static FLR_RESULT AgcSetSigmaR(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETSIGMAR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetSigmaR()
			
			public static FLR_RESULT AgcGetSigmaR(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETSIGMAR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetSigmaR()
			
			public static FLR_RESULT AgcSetUseEntropy(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETUSEENTROPY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetUseEntropy()
			
			public static FLR_RESULT AgcGetUseEntropy(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETUSEENTROPY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetUseEntropy()
			
			public static FLR_RESULT AgcSetROI(Camera parent, FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write roi to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ROI_TToByte(roi,sendData,outPtr);
				outPtr += 8;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetROI()
			
			public static FLR_RESULT AgcGetROI(Camera parent, out FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				roi = new FLR_ROI_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read roi from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				roi = byteToFLR_ROI_T(receiveData,inPtr);
				inPtr+=8;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetROI()
			
			public static FLR_RESULT AgcGetMaxGainApplied(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETMAXGAINAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetMaxGainApplied()
			
			public static FLR_RESULT AgcGetSigmaRApplied(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETSIGMARAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetSigmaRApplied()
			
			public static FLR_RESULT AgcSetOutlierCutBalance(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETOUTLIERCUTBALANCE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetOutlierCutBalance()
			
			public static FLR_RESULT AgcGetOutlierCutBalance(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETOUTLIERCUTBALANCE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetOutlierCutBalance()
			
			public static FLR_RESULT AgcGetOutlierCutApplied(Camera parent, out Double percentHigh, out Double percentLow) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				percentHigh = new Double();
				percentLow = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETOUTLIERCUTAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read percentHigh from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				percentHigh = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read percentLow from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				percentLow = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetOutlierCutApplied()
			
			public static FLR_RESULT AgcGetTfThresholds(Camera parent, out UInt16 tf_thresholdMin, out UInt16 tf_thresholdMax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				tf_thresholdMin = new UInt16();
				tf_thresholdMax = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETTFTHRESHOLDS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read tf_thresholdMin from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				tf_thresholdMin = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read tf_thresholdMax from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				tf_thresholdMax = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetTfThresholds()
			
			public static FLR_RESULT AgcSetTfThresholds(Camera parent, UInt16 tf_thresholdMin, UInt16 tf_thresholdMax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write tf_thresholdMin to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(tf_thresholdMin,sendData,outPtr);
				outPtr += 2;
				
				//write tf_thresholdMax to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(tf_thresholdMax,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETTFTHRESHOLDS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetTfThresholds()
			
			public static FLR_RESULT AgcGetMode(Camera parent, out FLR_AGC_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mode = new FLR_AGC_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mode = (FLR_AGC_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetMode()
			
			public static FLR_RESULT AgcSetMode(Camera parent, FLR_AGC_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) mode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetMode()
			
			public static FLR_RESULT AgcSetHighTempAlarmValues(Camera parent, UInt32 lowGain, UInt32 highGain, UInt32 pixPopulation) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 12;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write lowGain to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(lowGain,sendData,outPtr);
				outPtr += 4;
				
				//write highGain to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(highGain,sendData,outPtr);
				outPtr += 4;
				
				//write pixPopulation to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(pixPopulation,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETHIGHTEMPALARMVALUES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetHighTempAlarmValues()
			
			public static FLR_RESULT AgcGetContrast(Camera parent, out Int32 contrast) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				contrast = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETCONTRAST, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read contrast from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				contrast = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetContrast()
			
			public static FLR_RESULT AgcSetContrast(Camera parent, Int32 contrast) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write contrast to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(contrast,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETCONTRAST, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetContrast()
			
			public static FLR_RESULT AgcGetBrightnessBias(Camera parent, out Int32 brightnessBias) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				brightnessBias = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETBRIGHTNESSBIAS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read brightnessBias from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				brightnessBias = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetBrightnessBias()
			
			public static FLR_RESULT AgcSetBrightnessBias(Camera parent, Int32 brightnessBias) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write brightnessBias to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(brightnessBias,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETBRIGHTNESSBIAS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetBrightnessBias()
			
			public static FLR_RESULT AgcGetBrightness(Camera parent, out Int32 brightness) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				brightness = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETBRIGHTNESS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read brightness from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				brightness = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetBrightness()
			
			public static FLR_RESULT AgcSetBrightness(Camera parent, Int32 brightness) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write brightness to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(brightness,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETBRIGHTNESS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetBrightness()
			
			public static FLR_RESULT AgcSetMaxGainForLowGain(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_SETMAXGAINFORLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcSetMaxGainForLowGain()
			
			public static FLR_RESULT AgcGetMaxGainForLowGain(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.AGC_GETMAXGAINFORLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgAgcGetMaxGainForLowGain()
			
			// End Module: agc
			
			// Begin Module: boson
			public static FLR_RESULT BosonGetCameraSN(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETCAMERASN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetCameraSN()
			
			public static FLR_RESULT BosonGetCameraPN(Camera parent, out FLR_BOSON_PARTNUMBER_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 20;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_BOSON_PARTNUMBER_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETCAMERAPN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_BOSON_PARTNUMBER_T(receiveData,inPtr);
				inPtr+=20;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetCameraPN()
			
			public static FLR_RESULT BosonGetSensorSN(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSENSORSN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSensorSN()
			
			public static FLR_RESULT BosonRunFFC(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_RUNFFC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonRunFFC()
			
			public static FLR_RESULT BosonSetFFCTempThreshold(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCTEMPTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCTempThreshold()
			
			public static FLR_RESULT BosonGetFFCTempThreshold(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCTEMPTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCTempThreshold()
			
			public static FLR_RESULT BosonSetFFCFrameThreshold(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCFRAMETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCFrameThreshold()
			
			public static FLR_RESULT BosonGetFFCFrameThreshold(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCFRAMETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCFrameThreshold()
			
			public static FLR_RESULT BosonGetFFCInProgress(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCINPROGRESS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCInProgress()
			
			public static FLR_RESULT BosonReboot(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_REBOOT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonReboot()
			
			public static FLR_RESULT BosonSetFFCMode(Camera parent, FLR_BOSON_FFCMODE_E ffcMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ffcMode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) ffcMode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCMode()
			
			public static FLR_RESULT BosonGetFFCMode(Camera parent, out FLR_BOSON_FFCMODE_E ffcMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ffcMode = new FLR_BOSON_FFCMODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ffcMode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ffcMode = (FLR_BOSON_FFCMODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCMode()
			
			public static FLR_RESULT BosonSetGainMode(Camera parent, FLR_BOSON_GAINMODE_E gainMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write gainMode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) gainMode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETGAINMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetGainMode()
			
			public static FLR_RESULT BosonGetGainMode(Camera parent, out FLR_BOSON_GAINMODE_E gainMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				gainMode = new FLR_BOSON_GAINMODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read gainMode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				gainMode = (FLR_BOSON_GAINMODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainMode()
			
			public static FLR_RESULT BosonWriteDynamicHeaderToFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITEDYNAMICHEADERTOFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteDynamicHeaderToFlash()
			
			public static FLR_RESULT BosonReadDynamicHeaderFromFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_READDYNAMICHEADERFROMFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonReadDynamicHeaderFromFlash()
			
			public static FLR_RESULT BosonRestoreFactoryDefaultsFromFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_RESTOREFACTORYDEFAULTSFROMFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonRestoreFactoryDefaultsFromFlash()
			
			public static FLR_RESULT BosonRestoreFactoryBadPixelsFromFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_RESTOREFACTORYBADPIXELSFROMFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonRestoreFactoryBadPixelsFromFlash()
			
			public static FLR_RESULT BosonWriteBadPixelsToFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITEBADPIXELSTOFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteBadPixelsToFlash()
			
			public static FLR_RESULT BosonGetSoftwareRev(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSOFTWAREREV, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSoftwareRev()
			
			public static FLR_RESULT BosonSetBadPixelLocation(Camera parent, UInt32 row, UInt32 col) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write row to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(row,sendData,outPtr);
				outPtr += 4;
				
				//write col to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(col,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETBADPIXELLOCATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetBadPixelLocation()
			
			public static FLR_RESULT BosonlookupFPATempDegCx10(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_LOOKUPFPATEMPDEGCX10, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonlookupFPATempDegCx10()
			
			public static FLR_RESULT BosonlookupFPATempDegKx10(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_LOOKUPFPATEMPDEGKX10, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonlookupFPATempDegKx10()
			
			public static FLR_RESULT BosonWriteLensNvFfcToFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITELENSNVFFCTOFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteLensNvFfcToFlash()
			
			public static FLR_RESULT BosonWriteLensGainToFlash(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITELENSGAINTOFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteLensGainToFlash()
			
			public static FLR_RESULT BosonSetLensNumber(Camera parent, UInt32 lensNumber) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write lensNumber to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(lensNumber,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETLENSNUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetLensNumber()
			
			public static FLR_RESULT BosonGetLensNumber(Camera parent, out UInt32 lensNumber) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				lensNumber = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETLENSNUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read lensNumber from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				lensNumber = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetLensNumber()
			
			public static FLR_RESULT BosonSetTableNumber(Camera parent, UInt32 tableNumber) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write tableNumber to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(tableNumber,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETTABLENUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetTableNumber()
			
			public static FLR_RESULT BosonGetTableNumber(Camera parent, out UInt32 tableNumber) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				tableNumber = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTABLENUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read tableNumber from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				tableNumber = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTableNumber()
			
			public static FLR_RESULT BosonGetSensorPN(Camera parent, out FLR_BOSON_SENSOR_PARTNUMBER_T sensorPN) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 32;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				sensorPN = new FLR_BOSON_SENSOR_PARTNUMBER_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSENSORPN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read sensorPN from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				sensorPN = byteToFLR_BOSON_SENSOR_PARTNUMBER_T(receiveData,inPtr);
				inPtr+=32;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSensorPN()
			
			public static FLR_RESULT BosonSetGainSwitchParams(Camera parent, FLR_BOSON_GAIN_SWITCH_PARAMS_T parm_struct) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write parm_struct to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_BOSON_GAIN_SWITCH_PARAMS_TToByte(parm_struct,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETGAINSWITCHPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetGainSwitchParams()
			
			public static FLR_RESULT BosonGetGainSwitchParams(Camera parent, out FLR_BOSON_GAIN_SWITCH_PARAMS_T parm_struct) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				parm_struct = new FLR_BOSON_GAIN_SWITCH_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINSWITCHPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read parm_struct from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				parm_struct = byteToFLR_BOSON_GAIN_SWITCH_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainSwitchParams()
			
			public static FLR_RESULT BosonGetSwitchToHighGainFlag(Camera parent, out Byte switchToHighGainFlag) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				switchToHighGainFlag = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSWITCHTOHIGHGAINFLAG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read switchToHighGainFlag from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				switchToHighGainFlag = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSwitchToHighGainFlag()
			
			public static FLR_RESULT BosonGetSwitchToLowGainFlag(Camera parent, out Byte switchToLowGainFlag) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				switchToLowGainFlag = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSWITCHTOLOWGAINFLAG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read switchToLowGainFlag from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				switchToLowGainFlag = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSwitchToLowGainFlag()
			
			public static FLR_RESULT BosonGetCLowToHighPercent(Camera parent, out UInt32 cLowToHighPercent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				cLowToHighPercent = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETCLOWTOHIGHPERCENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read cLowToHighPercent from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				cLowToHighPercent = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetCLowToHighPercent()
			
			public static FLR_RESULT BosonGetMaxNUCTables(Camera parent, out UInt32 maxNUCTables) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				maxNUCTables = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETMAXNUCTABLES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read maxNUCTables from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				maxNUCTables = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetMaxNUCTables()
			
			public static FLR_RESULT BosonGetMaxLensTables(Camera parent, out UInt32 maxLensTables) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				maxLensTables = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETMAXLENSTABLES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read maxLensTables from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				maxLensTables = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetMaxLensTables()
			
			public static FLR_RESULT BosonGetFfcWaitCloseFrames(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCWAITCLOSEFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFfcWaitCloseFrames()
			
			public static FLR_RESULT BosonSetFfcWaitCloseFrames(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCWAITCLOSEFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFfcWaitCloseFrames()
			
			public static FLR_RESULT BosonCheckForTableSwitch(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_CHECKFORTABLESWITCH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonCheckForTableSwitch()
			
			public static FLR_RESULT BosonGetDesiredTableNumber(Camera parent, out UInt32 desiredTableNumber) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				desiredTableNumber = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETDESIREDTABLENUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read desiredTableNumber from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				desiredTableNumber = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetDesiredTableNumber()
			
			public static FLR_RESULT BosonGetFfcStatus(Camera parent, out FLR_BOSON_FFCSTATUS_E ffcStatus) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ffcStatus = new FLR_BOSON_FFCSTATUS_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCSTATUS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ffcStatus from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ffcStatus = (FLR_BOSON_FFCSTATUS_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFfcStatus()
			
			public static FLR_RESULT BosonGetFfcDesired(Camera parent, out UInt32 ffcDesired) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ffcDesired = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ffcDesired from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ffcDesired = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFfcDesired()
			
			public static FLR_RESULT BosonGetSwRevInHeader(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSWREVINHEADER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSwRevInHeader()
			
			public static FLR_RESULT BosonGetLastFFCFrameCount(Camera parent, out UInt32 frameCount) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				frameCount = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETLASTFFCFRAMECOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read frameCount from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				frameCount = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetLastFFCFrameCount()
			
			public static FLR_RESULT BosonGetLastFFCTempDegKx10(Camera parent, out UInt16 temp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				temp = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETLASTFFCTEMPDEGKX10, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read temp from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				temp = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetLastFFCTempDegKx10()
			
			public static FLR_RESULT BosonGetTableSwitchDesired(Camera parent, out UInt16 tableSwitchDesired) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				tableSwitchDesired = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTABLESWITCHDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read tableSwitchDesired from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				tableSwitchDesired = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTableSwitchDesired()
			
			public static FLR_RESULT BosonGetOverTempThreshold(Camera parent, out Double temperatureInC) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				temperatureInC = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETOVERTEMPTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read temperatureInC from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				temperatureInC = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetOverTempThreshold()
			
			public static FLR_RESULT BosonGetLowPowerMode(Camera parent, out UInt16 lowPowerMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				lowPowerMode = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETLOWPOWERMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read lowPowerMode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				lowPowerMode = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetLowPowerMode()
			
			public static FLR_RESULT BosonGetOverTempEventOccurred(Camera parent, out UInt16 overTempEventOccurred) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				overTempEventOccurred = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETOVERTEMPEVENTOCCURRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read overTempEventOccurred from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				overTempEventOccurred = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetOverTempEventOccurred()
			
			public static FLR_RESULT BosonSetPermitThermalShutdownOverride(Camera parent, FLR_ENABLE_E permitThermalShutdownOverride) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write permitThermalShutdownOverride to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) permitThermalShutdownOverride,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETPERMITTHERMALSHUTDOWNOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetPermitThermalShutdownOverride()
			
			public static FLR_RESULT BosonGetPermitThermalShutdownOverride(Camera parent, out FLR_ENABLE_E permitThermalShutdownOverride) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				permitThermalShutdownOverride = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETPERMITTHERMALSHUTDOWNOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read permitThermalShutdownOverride from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				permitThermalShutdownOverride = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetPermitThermalShutdownOverride()
			
			public static FLR_RESULT BosonGetMyriadTemp(Camera parent, out Double myriadTemp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				myriadTemp = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETMYRIADTEMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read myriadTemp from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				myriadTemp = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetMyriadTemp()
			
			public static FLR_RESULT BosonGetNvFFCNucTableNumberLens0(Camera parent, out Int32 nvFFCNucTableNumberLens0) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				nvFFCNucTableNumberLens0 = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCNUCTABLENUMBERLENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read nvFFCNucTableNumberLens0 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				nvFFCNucTableNumberLens0 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCNucTableNumberLens0()
			
			public static FLR_RESULT BosonGetNvFFCNucTableNumberLens1(Camera parent, out Int32 nvFFCNucTableNumberLens1) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				nvFFCNucTableNumberLens1 = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCNUCTABLENUMBERLENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read nvFFCNucTableNumberLens1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				nvFFCNucTableNumberLens1 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCNucTableNumberLens1()
			
			public static FLR_RESULT BosonGetNvFFCFPATempDegKx10Lens0(Camera parent, out UInt16 nvFFCFPATempDegKx10Lens0) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				nvFFCFPATempDegKx10Lens0 = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCFPATEMPDEGKX10LENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read nvFFCFPATempDegKx10Lens0 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				nvFFCFPATempDegKx10Lens0 = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCFPATempDegKx10Lens0()
			
			public static FLR_RESULT BosonGetNvFFCFPATempDegKx10Lens1(Camera parent, out UInt16 nvFFCFPATempDegKx10Lens1) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				nvFFCFPATempDegKx10Lens1 = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCFPATEMPDEGKX10LENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read nvFFCFPATempDegKx10Lens1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				nvFFCFPATempDegKx10Lens1 = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCFPATempDegKx10Lens1()
			
			public static FLR_RESULT BosonSetFFCWarnTimeInSecx10(Camera parent, UInt16 ffcWarnTime) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ffcWarnTime to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(ffcWarnTime,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCWARNTIMEINSECX10, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCWarnTimeInSecx10()
			
			public static FLR_RESULT BosonGetFFCWarnTimeInSecx10(Camera parent, out UInt16 ffcWarnTime) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ffcWarnTime = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCWARNTIMEINSECX10, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ffcWarnTime from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ffcWarnTime = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCWarnTimeInSecx10()
			
			public static FLR_RESULT BosonGetOverTempEventCounter(Camera parent, out UInt32 overTempEventCounter) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				overTempEventCounter = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETOVERTEMPEVENTCOUNTER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read overTempEventCounter from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				overTempEventCounter = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetOverTempEventCounter()
			
			public static FLR_RESULT BosonSetOverTempTimerInSec(Camera parent, UInt16 overTempTimerInSec) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write overTempTimerInSec to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(overTempTimerInSec,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETOVERTEMPTIMERINSEC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetOverTempTimerInSec()
			
			public static FLR_RESULT BosonGetOverTempTimerInSec(Camera parent, out UInt16 overTempTimerInSec) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				overTempTimerInSec = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETOVERTEMPTIMERINSEC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read overTempTimerInSec from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				overTempTimerInSec = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetOverTempTimerInSec()
			
			public static FLR_RESULT BosonUnloadCurrentLensCorrections(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_UNLOADCURRENTLENSCORRECTIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonUnloadCurrentLensCorrections()
			
			public static FLR_RESULT BosonSetTimeForQuickFFCsInSecs(Camera parent, UInt32 timeForQuickFFCsInSecs) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write timeForQuickFFCsInSecs to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(timeForQuickFFCsInSecs,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETTIMEFORQUICKFFCSINSECS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetTimeForQuickFFCsInSecs()
			
			public static FLR_RESULT BosonGetTimeForQuickFFCsInSecs(Camera parent, out UInt32 timeForQuickFFCsInSecs) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				timeForQuickFFCsInSecs = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTIMEFORQUICKFFCSINSECS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read timeForQuickFFCsInSecs from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				timeForQuickFFCsInSecs = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTimeForQuickFFCsInSecs()
			
			public static FLR_RESULT BosonReloadCurrentLensCorrections(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_RELOADCURRENTLENSCORRECTIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonReloadCurrentLensCorrections()
			
			public static FLR_RESULT BosonGetBootTimestamps(Camera parent, out Double FirstLight, out Double StartInit, out Double BosonExecDone, out Double Timestamp4) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				FirstLight = new Double();
				StartInit = new Double();
				BosonExecDone = new Double();
				Timestamp4 = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETBOOTTIMESTAMPS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read FirstLight from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FirstLight = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read StartInit from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				StartInit = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read BosonExecDone from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				BosonExecDone = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read Timestamp4 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				Timestamp4 = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetBootTimestamps()
			
			public static FLR_RESULT BosonSetExtSyncMode(Camera parent, FLR_BOSON_EXT_SYNC_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) mode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETEXTSYNCMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetExtSyncMode()
			
			public static FLR_RESULT BosonGetExtSyncMode(Camera parent, out FLR_BOSON_EXT_SYNC_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mode = new FLR_BOSON_EXT_SYNC_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETEXTSYNCMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mode = (FLR_BOSON_EXT_SYNC_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetExtSyncMode()
			
			public static FLR_RESULT BosonGetLastCommand(Camera parent, out UInt32 sequenceNum, out UInt32 cmdID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				sequenceNum = new UInt32();
				cmdID = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETLASTCOMMAND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read sequenceNum from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				sequenceNum = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read cmdID from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				cmdID = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetLastCommand()
			
			public static FLR_RESULT BosonGetSensorHostCalVersion(Camera parent, out UInt32 version) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				version = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSENSORHOSTCALVERSION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read version from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				version = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSensorHostCalVersion()
			
			public static FLR_RESULT BosonSetDesiredStartupTableNumber(Camera parent, Int32 table) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(table,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETDESIREDSTARTUPTABLENUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetDesiredStartupTableNumber()
			
			public static FLR_RESULT BosonGetDesiredStartupTableNumber(Camera parent, out Int32 table) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				table = new Int32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETDESIREDSTARTUPTABLENUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read table from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				table = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetDesiredStartupTableNumber()
			
			public static FLR_RESULT BosonSetNvFFCMeanValueLens0(Camera parent, Double meanValue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write meanValue to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(meanValue,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETNVFFCMEANVALUELENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetNvFFCMeanValueLens0()
			
			public static FLR_RESULT BosonGetNvFFCMeanValueLens0(Camera parent, out Double meanValue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				meanValue = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCMEANVALUELENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read meanValue from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				meanValue = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCMeanValueLens0()
			
			public static FLR_RESULT BosonSetNvFFCMeanValueLens1(Camera parent, Double meanValue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write meanValue to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(meanValue,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETNVFFCMEANVALUELENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetNvFFCMeanValueLens1()
			
			public static FLR_RESULT BosonGetNvFFCMeanValueLens1(Camera parent, out Double meanValue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				meanValue = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETNVFFCMEANVALUELENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read meanValue from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				meanValue = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetNvFFCMeanValueLens1()
			
			public static FLR_RESULT BosonSetInvertImage(Camera parent, FLR_ENABLE_E invertImage) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write invertImage to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) invertImage,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETINVERTIMAGE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetInvertImage()
			
			public static FLR_RESULT BosonGetInvertImage(Camera parent, out FLR_ENABLE_E invertImage) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				invertImage = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETINVERTIMAGE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read invertImage from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				invertImage = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetInvertImage()
			
			public static FLR_RESULT BosonSetRevertImage(Camera parent, FLR_ENABLE_E revertImage) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write revertImage to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) revertImage,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETREVERTIMAGE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetRevertImage()
			
			public static FLR_RESULT BosonGetRevertImage(Camera parent, out FLR_ENABLE_E revertImage) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				revertImage = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETREVERTIMAGE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read revertImage from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				revertImage = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetRevertImage()
			
			public static FLR_RESULT BosonGetTimeStamp(Camera parent, FLR_BOSON_TIMESTAMPTYPE_E timeStampType, out Double timeStamp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				timeStamp = new Double();
				
				//write timeStampType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) timeStampType,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTIMESTAMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read timeStamp from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				timeStamp = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTimeStamp()
			
			public static FLR_RESULT BosonGetISPFrameCount(Camera parent, out UInt32 ispFrameCount) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ispFrameCount = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETISPFRAMECOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ispFrameCount from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ispFrameCount = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetISPFrameCount()
			
			public static FLR_RESULT BosonWriteUserBadPixelsToAllTables(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITEUSERBADPIXELSTOALLTABLES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteUserBadPixelsToAllTables()
			
			public static FLR_RESULT BosonWriteFactoryBadPixelsToAllTables(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_WRITEFACTORYBADPIXELSTOALLTABLES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonWriteFactoryBadPixelsToAllTables()
			
			public static FLR_RESULT BosonGetTempDiodeStatus(Camera parent, out FLR_BOSON_TEMP_DIODE_STATUS_E status) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				status = new FLR_BOSON_TEMP_DIODE_STATUS_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTEMPDIODESTATUS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read status from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				status = (FLR_BOSON_TEMP_DIODE_STATUS_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTempDiodeStatus()
			
			public static FLR_RESULT BosonClearFactoryBadPixelsInDDR(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_CLEARFACTORYBADPIXELSINDDR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonClearFactoryBadPixelsInDDR()
			
			public static FLR_RESULT BosonGetFfcWaitOpenFrames(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCWAITOPENFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFfcWaitOpenFrames()
			
			public static FLR_RESULT BosonSetFfcWaitOpenFrames(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCWAITOPENFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFfcWaitOpenFrames()
			
			public static FLR_RESULT BosonGetFfcWaitOpenFlagSettleFrames(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCWAITOPENFLAGSETTLEFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFfcWaitOpenFlagSettleFrames()
			
			public static FLR_RESULT BosonSetFfcWaitOpenFlagSettleFrames(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCWAITOPENFLAGSETTLEFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFfcWaitOpenFlagSettleFrames()
			
			public static FLR_RESULT BosonGetTauExtFfcCompatibilityMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETTAUEXTFFCCOMPATIBILITYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetTauExtFfcCompatibilityMode()
			
			public static FLR_RESULT BosonSetTauExtFfcCompatibilityMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETTAUEXTFFCCOMPATIBILITYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetTauExtFfcCompatibilityMode()
			
			public static FLR_RESULT BosonGetInitialTableSelectionTempOffset(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETINITIALTABLESELECTIONTEMPOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetInitialTableSelectionTempOffset()
			
			public static FLR_RESULT BosonSetInitialTableSelectionTempOffset(Camera parent, Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETINITIALTABLESELECTIONTEMPOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetInitialTableSelectionTempOffset()
			
			public static FLR_RESULT BosonGetImageValid(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETIMAGEVALID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetImageValid()
			
			public static FLR_RESULT BosonGetCurrentTableType(Camera parent, out FLR_BOSON_TABLETYPE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_BOSON_TABLETYPE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETCURRENTTABLETYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_BOSON_TABLETYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetCurrentTableType()
			
			public static FLR_RESULT BosonGetGainSwitchFrameThreshold(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINSWITCHFRAMETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainSwitchFrameThreshold()
			
			public static FLR_RESULT BosonSetGainSwitchFrameThreshold(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETGAINSWITCHFRAMETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetGainSwitchFrameThreshold()
			
			public static FLR_RESULT BosonGetGainSwitchHysteresisTime(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINSWITCHHYSTERESISTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainSwitchHysteresisTime()
			
			public static FLR_RESULT BosonSetGainSwitchHysteresisTime(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETGAINSWITCHHYSTERESISTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetGainSwitchHysteresisTime()
			
			public static FLR_RESULT BosonGetGainSwitchDesired(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINSWITCHDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainSwitchDesired()
			
			public static FLR_RESULT BosonGetGainSwitchRadiometricParams(Camera parent, out FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T parm_struct) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				parm_struct = new FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETGAINSWITCHRADIOMETRICPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read parm_struct from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				parm_struct = byteToFLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetGainSwitchRadiometricParams()
			
			public static FLR_RESULT BosonSetGainSwitchRadiometricParams(Camera parent, FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T parm_struct) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write parm_struct to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_TToByte(parm_struct,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETGAINSWITCHRADIOMETRICPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetGainSwitchRadiometricParams()
			
			public static FLR_RESULT BosonSetSaturationOverrideMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETSATURATIONOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetSaturationOverrideMode()
			
			public static FLR_RESULT BosonGetSaturationOverrideMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSATURATIONOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSaturationOverrideMode()
			
			public static FLR_RESULT BosonSetSaturationOverrideValue(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETSATURATIONOVERRIDEVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetSaturationOverrideValue()
			
			public static FLR_RESULT BosonGetSaturationOverrideValue(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETSATURATIONOVERRIDEVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetSaturationOverrideValue()
			
			public static FLR_RESULT BosonSetffcHighLowGainThresholdMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCHIGHLOWGAINTHRESHOLDMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetffcHighLowGainThresholdMode()
			
			public static FLR_RESULT BosonGetffcHighLowGainThresholdMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCHIGHLOWGAINTHRESHOLDMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetffcHighLowGainThresholdMode()
			
			public static FLR_RESULT BosonSetFFCTempThresholdLowGain(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCTEMPTHRESHOLDLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCTempThresholdLowGain()
			
			public static FLR_RESULT BosonGetFFCTempThresholdLowGain(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCTEMPTHRESHOLDLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCTempThresholdLowGain()
			
			public static FLR_RESULT BosonSetFFCFrameThresholdLowGain(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_SETFFCFRAMETHRESHOLDLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonSetFFCFrameThresholdLowGain()
			
			public static FLR_RESULT BosonGetFFCFrameThresholdLowGain(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BOSON_GETFFCFRAMETHRESHOLDLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBosonGetFFCFrameThresholdLowGain()
			
			// End Module: boson
			
			// Begin Module: bpr
			public static FLR_RESULT BprGetState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetState()
			
			public static FLR_RESULT BprSetState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_SETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprSetState()
			
			public static FLR_RESULT BprGetStats(Camera parent, out UInt32 threeby, out UInt32 fiveby, out UInt32 rows, out UInt32 budget, out UInt32 used) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 20;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				threeby = new UInt32();
				fiveby = new UInt32();
				rows = new UInt32();
				budget = new UInt32();
				used = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETSTATS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read threeby from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				threeby = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read fiveby from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				fiveby = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rows = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read budget from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				budget = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read used from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				used = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetStats()
			
			public static FLR_RESULT BprGetDisplayMode(Camera parent, out FLR_BPR_DISPLAY_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_BPR_DISPLAY_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETDISPLAYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_BPR_DISPLAY_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetDisplayMode()
			
			public static FLR_RESULT BprSetDisplayMode(Camera parent, FLR_BPR_DISPLAY_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_SETDISPLAYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprSetDisplayMode()
			
			public static FLR_RESULT BprGetDisplayModeMinValue(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETDISPLAYMODEMINVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetDisplayModeMinValue()
			
			public static FLR_RESULT BprSetDisplayModeMinValue(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_SETDISPLAYMODEMINVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprSetDisplayModeMinValue()
			
			public static FLR_RESULT BprGetDisplayModeMaxValue(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETDISPLAYMODEMAXVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetDisplayModeMaxValue()
			
			public static FLR_RESULT BprSetDisplayModeMaxValue(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_SETDISPLAYMODEMAXVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprSetDisplayModeMaxValue()
			
			public static FLR_RESULT BprGetWorkBufIndex(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETWORKBUFINDEX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetWorkBufIndex()
			
			public static FLR_RESULT BprSetWorkBufIndex(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_SETWORKBUFINDEX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprSetWorkBufIndex()
			
			public static FLR_RESULT BprGetWorkBufStats(Camera parent, out UInt32 threeby, out UInt32 fiveby, out UInt32 rows, out UInt32 budget, out UInt32 used) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 20;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				threeby = new UInt32();
				fiveby = new UInt32();
				rows = new UInt32();
				budget = new UInt32();
				used = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.BPR_GETWORKBUFSTATS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read threeby from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				threeby = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read fiveby from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				fiveby = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rows = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read budget from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				budget = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read used from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				used = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgBprGetWorkBufStats()
			
			// End Module: bpr
			
			// Begin Module: capture
			public static FLR_RESULT CaptureSingleFrame(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.CAPTURE_SINGLEFRAME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgCaptureSingleFrame()
			
			public static FLR_RESULT CaptureFrames(Camera parent, FLR_CAPTURE_SETTINGS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 10;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_CAPTURE_SETTINGS_TToByte(data,sendData,outPtr);
				outPtr += 10;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.CAPTURE_FRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgCaptureFrames()
			
			public static FLR_RESULT CaptureSingleFrameWithSrc(Camera parent, FLR_CAPTURE_SRC_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.CAPTURE_SINGLEFRAMEWITHSRC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgCaptureSingleFrameWithSrc()
			
			public static FLR_RESULT CaptureSingleFrameToFile(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.CAPTURE_SINGLEFRAMETOFILE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgCaptureSingleFrameToFile()
			
			public static FLR_RESULT CaptureGetStatus(Camera parent, out FLR_CAPTURE_STATUS_T status) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 24;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				status = new FLR_CAPTURE_STATUS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.CAPTURE_GETSTATUS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read status from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				status = byteToFLR_CAPTURE_STATUS_T(receiveData,inPtr);
				inPtr+=24;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgCaptureGetStatus()
			
			// End Module: capture
			
			// Begin Module: colorLut
			public static FLR_RESULT ColorlutSetControl(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_SETCONTROL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutSetControl()
			
			public static FLR_RESULT ColorlutGetControl(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_GETCONTROL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutGetControl()
			
			public static FLR_RESULT ColorlutSetId(Camera parent, FLR_COLORLUT_ID_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_SETID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutSetId()
			
			public static FLR_RESULT ColorlutGetId(Camera parent, out FLR_COLORLUT_ID_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_COLORLUT_ID_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_GETID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_COLORLUT_ID_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutGetId()
			
			public static FLR_RESULT ColorlutSetOutlineColor(Camera parent, Byte red, Byte green, Byte blue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 3;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write red to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(red,sendData,outPtr);
				outPtr += 1;
				
				//write green to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(green,sendData,outPtr);
				outPtr += 1;
				
				//write blue to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(blue,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_SETOUTLINECOLOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutSetOutlineColor()
			
			public static FLR_RESULT ColorlutGetOutlineColor(Camera parent, out Byte red, out Byte green, out Byte blue) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 3;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				red = new Byte();
				green = new Byte();
				blue = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.COLORLUT_GETOUTLINECOLOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read red from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				red = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				// read green from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				green = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				// read blue from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				blue = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgColorlutGetOutlineColor()
			
			// End Module: colorLut
			
			// Begin Module: dummy
			public static FLR_RESULT DummyBadCommand(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DUMMY_BADCOMMAND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDummyBadCommand()
			
			// End Module: dummy
			
			// Begin Module: dvo
			public static FLR_RESULT DvoSetAnalogVideoState(Camera parent, FLR_ENABLE_E analogVideoState) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write analogVideoState to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) analogVideoState,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETANALOGVIDEOSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetAnalogVideoState()
			
			public static FLR_RESULT DvoGetAnalogVideoState(Camera parent, out FLR_ENABLE_E analogVideoState) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				analogVideoState = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETANALOGVIDEOSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read analogVideoState from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				analogVideoState = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetAnalogVideoState()
			
			public static FLR_RESULT DvoSetOutputFormat(Camera parent, FLR_DVO_OUTPUT_FORMAT_E format) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write format to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) format,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETOUTPUTFORMAT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetOutputFormat()
			
			public static FLR_RESULT DvoGetOutputFormat(Camera parent, out FLR_DVO_OUTPUT_FORMAT_E format) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				format = new FLR_DVO_OUTPUT_FORMAT_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETOUTPUTFORMAT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read format from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				format = (FLR_DVO_OUTPUT_FORMAT_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetOutputFormat()
			
			public static FLR_RESULT DvoSetOutputYCbCrSettings(Camera parent, FLR_DVO_YCBCR_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 12;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write settings to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_DVO_YCBCR_SETTINGS_TToByte(settings,sendData,outPtr);
				outPtr += 12;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETOUTPUTYCBCRSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetOutputYCbCrSettings()
			
			public static FLR_RESULT DvoGetOutputYCbCrSettings(Camera parent, out FLR_DVO_YCBCR_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				settings = new FLR_DVO_YCBCR_SETTINGS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETOUTPUTYCBCRSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read settings from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				settings = byteToFLR_DVO_YCBCR_SETTINGS_T(receiveData,inPtr);
				inPtr+=12;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetOutputYCbCrSettings()
			
			public static FLR_RESULT DvoSetOutputRGBSettings(Camera parent, FLR_DVO_RGB_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write settings to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_DVO_RGB_SETTINGS_TToByte(settings,sendData,outPtr);
				outPtr += 8;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETOUTPUTRGBSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetOutputRGBSettings()
			
			public static FLR_RESULT DvoGetOutputRGBSettings(Camera parent, out FLR_DVO_RGB_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				settings = new FLR_DVO_RGB_SETTINGS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETOUTPUTRGBSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read settings from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				settings = byteToFLR_DVO_RGB_SETTINGS_T(receiveData,inPtr);
				inPtr+=8;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetOutputRGBSettings()
			
			public static FLR_RESULT DvoApplyCustomSettings(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_APPLYCUSTOMSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoApplyCustomSettings()
			
			public static FLR_RESULT DvoSetDisplayMode(Camera parent, FLR_DVO_DISPLAY_MODE_E displayMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write displayMode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) displayMode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETDISPLAYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetDisplayMode()
			
			public static FLR_RESULT DvoGetDisplayMode(Camera parent, out FLR_DVO_DISPLAY_MODE_E displayMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				displayMode = new FLR_DVO_DISPLAY_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETDISPLAYMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read displayMode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				displayMode = (FLR_DVO_DISPLAY_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetDisplayMode()
			
			public static FLR_RESULT DvoSetType(Camera parent, FLR_DVO_TYPE_E tap) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write tap to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) tap,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetType()
			
			public static FLR_RESULT DvoGetType(Camera parent, out FLR_DVO_TYPE_E tap) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				tap = new FLR_DVO_TYPE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read tap from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				tap = (FLR_DVO_TYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetType()
			
			public static FLR_RESULT DvoSetVideoStandard(Camera parent, FLR_DVO_VIDEO_STANDARD_E videoStandard) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write videoStandard to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) videoStandard,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETVIDEOSTANDARD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetVideoStandard()
			
			public static FLR_RESULT DvoGetVideoStandard(Camera parent, out FLR_DVO_VIDEO_STANDARD_E videoStandard) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				videoStandard = new FLR_DVO_VIDEO_STANDARD_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETVIDEOSTANDARD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read videoStandard from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				videoStandard = (FLR_DVO_VIDEO_STANDARD_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetVideoStandard()
			
			public static FLR_RESULT DvoSetCheckVideoDacPresent(Camera parent, FLR_ENABLE_E checkVideoDacPresent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write checkVideoDacPresent to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) checkVideoDacPresent,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETCHECKVIDEODACPRESENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetCheckVideoDacPresent()
			
			public static FLR_RESULT DvoGetCheckVideoDacPresent(Camera parent, out FLR_ENABLE_E checkVideoDacPresent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				checkVideoDacPresent = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETCHECKVIDEODACPRESENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read checkVideoDacPresent from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				checkVideoDacPresent = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetCheckVideoDacPresent()
			
			public static FLR_RESULT DvoSetCustomLcdConfig(Camera parent, FLR_DVO_LCD_CONFIG_ID_E id, FLR_DVO_LCD_CONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 52;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) id,sendData,outPtr);
				outPtr += 4;
				
				//write config to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_DVO_LCD_CONFIG_TToByte(config,sendData,outPtr);
				outPtr += 48;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETCUSTOMLCDCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetCustomLcdConfig()
			
			public static FLR_RESULT DvoGetCustomLcdConfig(Camera parent, FLR_DVO_LCD_CONFIG_ID_E id, out FLR_DVO_LCD_CONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 48;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				config = new FLR_DVO_LCD_CONFIG_T();
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) id,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETCUSTOMLCDCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read config from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				config = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr);
				inPtr+=48;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetCustomLcdConfig()
			
			public static FLR_RESULT DvoSetLCDConfig(Camera parent, FLR_DVO_LCD_CONFIG_ID_E id) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) id,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETLCDCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetLCDConfig()
			
			public static FLR_RESULT DvoGetLCDConfig(Camera parent, out FLR_DVO_LCD_CONFIG_ID_E id) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				id = new FLR_DVO_LCD_CONFIG_ID_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETLCDCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read id from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				id = (FLR_DVO_LCD_CONFIG_ID_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetLCDConfig()
			
			public static FLR_RESULT DvoGetClockInfo(Camera parent, out UInt32 horizontalSyncWidth, out UInt32 verticalSyncWidth, out UInt32 clocksPerRowPeriod, out UInt32 horizontalFrontPorch, out UInt32 horizontalBackPorch, out UInt32 frontTelemetryPixels, out UInt32 rearTelemetryPixels, out UInt32 videoColumns, out UInt32 validColumns, out UInt32 telemetryRows, out UInt32 videoRows, out UInt32 validRows, out UInt32 verticalFrontPorch, out UInt32 verticalBackPorch, out UInt32 rowPeriodsPerFrame, out UInt32 clocksPerFrame, out Double clockRateInMHz, out Double frameRateInHz, out UInt32 validOnRisingEdge, out UInt32 dataWidthInBits) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 80;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				horizontalSyncWidth = new UInt32();
				verticalSyncWidth = new UInt32();
				clocksPerRowPeriod = new UInt32();
				horizontalFrontPorch = new UInt32();
				horizontalBackPorch = new UInt32();
				frontTelemetryPixels = new UInt32();
				rearTelemetryPixels = new UInt32();
				videoColumns = new UInt32();
				validColumns = new UInt32();
				telemetryRows = new UInt32();
				videoRows = new UInt32();
				validRows = new UInt32();
				verticalFrontPorch = new UInt32();
				verticalBackPorch = new UInt32();
				rowPeriodsPerFrame = new UInt32();
				clocksPerFrame = new UInt32();
				clockRateInMHz = new Double();
				frameRateInHz = new Double();
				validOnRisingEdge = new UInt32();
				dataWidthInBits = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETCLOCKINFO, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read horizontalSyncWidth from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				horizontalSyncWidth = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read verticalSyncWidth from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				verticalSyncWidth = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read clocksPerRowPeriod from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				clocksPerRowPeriod = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read horizontalFrontPorch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				horizontalFrontPorch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read horizontalBackPorch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				horizontalBackPorch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read frontTelemetryPixels from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				frontTelemetryPixels = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rearTelemetryPixels from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rearTelemetryPixels = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read videoColumns from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				videoColumns = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read validColumns from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				validColumns = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read telemetryRows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				telemetryRows = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read videoRows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				videoRows = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read validRows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				validRows = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read verticalFrontPorch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				verticalFrontPorch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read verticalBackPorch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				verticalBackPorch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rowPeriodsPerFrame from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rowPeriodsPerFrame = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read clocksPerFrame from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				clocksPerFrame = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read clockRateInMHz from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				clockRateInMHz = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read frameRateInHz from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				frameRateInHz = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read validOnRisingEdge from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				validOnRisingEdge = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read dataWidthInBits from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				dataWidthInBits = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetClockInfo()
			
			public static FLR_RESULT DvoSetAllCustomLcdConfigs(Camera parent, FLR_DVO_LCD_CONFIG_T config0, FLR_DVO_LCD_CONFIG_T config1) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 96;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write config0 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_DVO_LCD_CONFIG_TToByte(config0,sendData,outPtr);
				outPtr += 48;
				
				//write config1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_DVO_LCD_CONFIG_TToByte(config1,sendData,outPtr);
				outPtr += 48;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETALLCUSTOMLCDCONFIGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetAllCustomLcdConfigs()
			
			public static FLR_RESULT DvoGetAllCustomLcdConfigs(Camera parent, out FLR_DVO_LCD_CONFIG_T config0, out FLR_DVO_LCD_CONFIG_T config1) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 96;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				config0 = new FLR_DVO_LCD_CONFIG_T();
				config1 = new FLR_DVO_LCD_CONFIG_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETALLCUSTOMLCDCONFIGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read config0 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				config0 = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr);
				inPtr+=48;
				
				// read config1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				config1 = byteToFLR_DVO_LCD_CONFIG_T(receiveData,inPtr);
				inPtr+=48;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetAllCustomLcdConfigs()
			
			public static FLR_RESULT DvoSetOutputIr16Format(Camera parent, FLR_DVO_OUTPUT_IR16_FORMAT_E format) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write format to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) format,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETOUTPUTIR16FORMAT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetOutputIr16Format()
			
			public static FLR_RESULT DvoGetOutputIr16Format(Camera parent, out FLR_DVO_OUTPUT_IR16_FORMAT_E format) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				format = new FLR_DVO_OUTPUT_IR16_FORMAT_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETOUTPUTIR16FORMAT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read format from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				format = (FLR_DVO_OUTPUT_IR16_FORMAT_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetOutputIr16Format()
			
			public static FLR_RESULT DvoSetLcdClockRate(Camera parent, FLR_DVO_LCD_CLOCK_RATE_E clockRate) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write clockRate to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) clockRate,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETLCDCLOCKRATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetLcdClockRate()
			
			public static FLR_RESULT DvoGetLcdClockRate(Camera parent, out FLR_DVO_LCD_CLOCK_RATE_E clockRate) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				clockRate = new FLR_DVO_LCD_CLOCK_RATE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETLCDCLOCKRATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read clockRate from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				clockRate = (FLR_DVO_LCD_CLOCK_RATE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetLcdClockRate()
			
			public static FLR_RESULT DvoSetLcdVideoFrameRate(Camera parent, UInt32 framerate) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write framerate to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(framerate,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_SETLCDVIDEOFRAMERATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoSetLcdVideoFrameRate()
			
			public static FLR_RESULT DvoGetLcdVideoFrameRate(Camera parent, out UInt32 framerate) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				framerate = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.DVO_GETLCDVIDEOFRAMERATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read framerate from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				framerate = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgDvoGetLcdVideoFrameRate()
			
			// End Module: dvo
			
			// Begin Module: fileOps
			public static FLR_RESULT FileopsDir(Camera parent, out Byte[] dirent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				dirent = new Byte[128];
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_DIR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read dirent from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				dirent = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsDir()
			
			public static FLR_RESULT FileopsCd(Camera parent, Byte[] path, out Byte[] pwd) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 128;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				pwd = new Byte[128];
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_CD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read pwd from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				pwd = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsCd()
			
			public static FLR_RESULT FileopsMd(Camera parent, Byte[] path) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 128;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_MD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsMd()
			
			public static FLR_RESULT FileopsFopen(Camera parent, Byte[] path, Byte[] mode, out UInt32 id) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 256;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				id = new UInt32();
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(mode,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FOPEN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read id from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				id = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFopen()
			
			public static FLR_RESULT FileopsFclose(Camera parent, UInt32 id) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FCLOSE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFclose()
			
			public static FLR_RESULT FileopsFread(Camera parent, UInt32 id, UInt32 length, out Byte[] buf, out UInt32 ret) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 132;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				buf = new Byte[128];
				ret = new UInt32();
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				//write length to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(length,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FREAD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read buf from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				buf = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				// read ret from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ret = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFread()
			
			public static FLR_RESULT FileopsFwrite(Camera parent, UInt32 id, UInt32 length, Byte[] buf, out UInt32 ret) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 136;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				ret = new UInt32();
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				//write length to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(length,sendData,outPtr);
				outPtr += 4;
				
				//write buf to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(buf,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FWRITE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read ret from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				ret = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFwrite()
			
			public static FLR_RESULT FileopsFtell(Camera parent, UInt32 id, out UInt32 offset) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				offset = new UInt32();
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FTELL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read offset from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				offset = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFtell()
			
			public static FLR_RESULT FileopsFseek(Camera parent, UInt32 id, UInt32 offset, UInt32 origin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 12;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write origin to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(origin,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FSEEK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFseek()
			
			public static FLR_RESULT FileopsFtruncate(Camera parent, UInt32 id, UInt32 length) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(id,sendData,outPtr);
				outPtr += 4;
				
				//write length to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(length,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_FTRUNCATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsFtruncate()
			
			public static FLR_RESULT FileopsRmdir(Camera parent, Byte[] path) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 128;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_RMDIR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsRmdir()
			
			public static FLR_RESULT FileopsRm(Camera parent, Byte[] path) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 128;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_RM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsRm()
			
			public static FLR_RESULT FileopsRename(Camera parent, Byte[] oldpath, Byte[] newpath) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 256;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write oldpath to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(oldpath,128,sendData,outPtr);
				outPtr += 128;
				
				//write newpath to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(newpath,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_RENAME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsRename()
			
			public static FLR_RESULT FileopsGetFileSize(Camera parent, Byte[] path, out UInt32 fileLength) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 128;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				fileLength = new UInt32();
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FILEOPS_GETFILESIZE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read fileLength from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				fileLength = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFileopsGetFileSize()
			
			// End Module: fileOps
			
			// Begin Module: flashIO
			public static FLR_RESULT FlashioSetProtectionState(Camera parent, FLR_ENABLE_E protectionState) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write protectionState to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) protectionState,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FLASHIO_SETPROTECTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFlashioSetProtectionState()
			
			public static FLR_RESULT FlashioGetProtectionState(Camera parent, out FLR_ENABLE_E protectionState) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				protectionState = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FLASHIO_GETPROTECTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read protectionState from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				protectionState = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFlashioGetProtectionState()
			
			// End Module: flashIO
			
			// Begin Module: flashMapFs
			public static FLR_RESULT FlashmapfsGetHeaderVersion(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.FLASHMAPFS_GETHEADERVERSION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgFlashmapfsGetHeaderVersion()
			
			// End Module: flashMapFs
			
			// Begin Module: gao
			public static FLR_RESULT GaoSetGainState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETGAINSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetGainState()
			
			public static FLR_RESULT GaoGetGainState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETGAINSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetGainState()
			
			public static FLR_RESULT GaoSetFfcState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETFFCSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetFfcState()
			
			public static FLR_RESULT GaoGetFfcState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETFFCSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetFfcState()
			
			public static FLR_RESULT GaoSetTempCorrectionState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETTEMPCORRECTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetTempCorrectionState()
			
			public static FLR_RESULT GaoGetTempCorrectionState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETTEMPCORRECTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetTempCorrectionState()
			
			public static FLR_RESULT GaoSetIConstL(Camera parent, Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETICONSTL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetIConstL()
			
			public static FLR_RESULT GaoGetIConstL(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETICONSTL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetIConstL()
			
			public static FLR_RESULT GaoSetIConstM(Camera parent, Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETICONSTM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetIConstM()
			
			public static FLR_RESULT GaoGetIConstM(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETICONSTM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetIConstM()
			
			public static FLR_RESULT GaoSetAveragerState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETAVERAGERSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetAveragerState()
			
			public static FLR_RESULT GaoGetAveragerState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETAVERAGERSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetAveragerState()
			
			public static FLR_RESULT GaoSetNumFFCFrames(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETNUMFFCFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetNumFFCFrames()
			
			public static FLR_RESULT GaoGetNumFFCFrames(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETNUMFFCFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetNumFFCFrames()
			
			public static FLR_RESULT GaoGetAveragerThreshold(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETAVERAGERTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetAveragerThreshold()
			
			public static FLR_RESULT GaoSetRnsState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsState()
			
			public static FLR_RESULT GaoGetRnsState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsState()
			
			public static FLR_RESULT GaoSetTestRampState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETTESTRAMPSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetTestRampState()
			
			public static FLR_RESULT GaoGetTestRampState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETTESTRAMPSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetTestRampState()
			
			public static FLR_RESULT GaoSetSffcState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETSFFCSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetSffcState()
			
			public static FLR_RESULT GaoGetSffcState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETSFFCSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetSffcState()
			
			public static FLR_RESULT GaoSetNucType(Camera parent, FLR_GAO_NUC_TYPE_E nucType) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write nucType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) nucType,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETNUCTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetNucType()
			
			public static FLR_RESULT GaoGetNucType(Camera parent, out FLR_GAO_NUC_TYPE_E nucType) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				nucType = new FLR_GAO_NUC_TYPE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETNUCTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read nucType from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				nucType = (FLR_GAO_NUC_TYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetNucType()
			
			public static FLR_RESULT GaoSetFfcZeroMeanState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETFFCZEROMEANSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetFfcZeroMeanState()
			
			public static FLR_RESULT GaoGetFfcZeroMeanState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETFFCZEROMEANSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetFfcZeroMeanState()
			
			public static FLR_RESULT GaoSetRnsPopThreshold(Camera parent, UInt16 threshold) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write threshold to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(threshold,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSPOPTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsPopThreshold()
			
			public static FLR_RESULT GaoGetRnsPopThreshold(Camera parent, out UInt16 threshold) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				threshold = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSPOPTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read threshold from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				threshold = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsPopThreshold()
			
			public static FLR_RESULT GaoSetRnsCloseThreshold(Camera parent, UInt16 threshold) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write threshold to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(threshold,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSCLOSETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsCloseThreshold()
			
			public static FLR_RESULT GaoGetRnsCloseThreshold(Camera parent, out UInt16 threshold) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				threshold = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSCLOSETHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read threshold from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				threshold = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsCloseThreshold()
			
			public static FLR_RESULT GaoSetRnsTooFewQuit(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTOOFEWQUIT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsTooFewQuit()
			
			public static FLR_RESULT GaoGetRnsTooFewQuit(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTOOFEWQUIT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsTooFewQuit()
			
			public static FLR_RESULT GaoSetRnsTooFew(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTOOFEW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsTooFew()
			
			public static FLR_RESULT GaoGetRnsTooFew(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTOOFEW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsTooFew()
			
			public static FLR_RESULT GaoSetRnsMinCorrection(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSMINCORRECTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsMinCorrection()
			
			public static FLR_RESULT GaoGetRnsMinCorrection(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSMINCORRECTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsMinCorrection()
			
			public static FLR_RESULT GaoSetRnsDamping(Camera parent, Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(data,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSDAMPING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsDamping()
			
			public static FLR_RESULT GaoGetRnsDamping(Camera parent, out Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSDAMPING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsDamping()
			
			public static FLR_RESULT GaoSetRnsFrameHysteresis(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSFRAMEHYSTERESIS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsFrameHysteresis()
			
			public static FLR_RESULT GaoGetRnsFrameHysteresis(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSFRAMEHYSTERESIS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsFrameHysteresis()
			
			public static FLR_RESULT GaoSetRnsBadDamping(Camera parent, Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(data,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSBADDAMPING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsBadDamping()
			
			public static FLR_RESULT GaoGetRnsBadDamping(Camera parent, out Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSBADDAMPING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsBadDamping()
			
			public static FLR_RESULT GaoSetRnsNumGoodDampingThreshold(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSNUMGOODDAMPINGTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsNumGoodDampingThreshold()
			
			public static FLR_RESULT GaoGetRnsNumGoodDampingThreshold(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSNUMGOODDAMPINGTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsNumGoodDampingThreshold()
			
			public static FLR_RESULT GaoGetRnsFfcDesired(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSFFCDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsFfcDesired()
			
			public static FLR_RESULT GaoGetAveragerDesiredState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETAVERAGERDESIREDSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetAveragerDesiredState()
			
			public static FLR_RESULT GaoSetRnsThDamp(Camera parent, UInt16 thDamp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write thDamp to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thDamp,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTHDAMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsThDamp()
			
			public static FLR_RESULT GaoGetRnsThDamp(Camera parent, out UInt16 thDamp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thDamp = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTHDAMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thDamp from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thDamp = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsThDamp()
			
			public static FLR_RESULT GaoSetRnsThException(Camera parent, UInt16 thException) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write thException to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thException,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTHEXCEPTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsThException()
			
			public static FLR_RESULT GaoGetRnsThException(Camera parent, out UInt16 thException) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thException = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTHEXCEPTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thException from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thException = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsThException()
			
			public static FLR_RESULT GaoSetRnsThBad(Camera parent, UInt16 thBad) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write thBad to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thBad,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTHBAD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsThBad()
			
			public static FLR_RESULT GaoGetRnsThBad(Camera parent, out UInt16 thBad) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thBad = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTHBAD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thBad from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thBad = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsThBad()
			
			public static FLR_RESULT GaoSetRnsThBadInitial(Camera parent, UInt16 thBadInitial) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write thBadInitial to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thBadInitial,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTHBADINITIAL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsThBadInitial()
			
			public static FLR_RESULT GaoGetRnsThBadInitial(Camera parent, out UInt16 thBadInitial) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thBadInitial = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTHBADINITIAL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thBadInitial from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thBadInitial = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsThBadInitial()
			
			public static FLR_RESULT GaoSetRnsThAllowedExceptions(Camera parent, UInt16 thAllowedExceptions) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write thAllowedExceptions to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thAllowedExceptions,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETRNSTHALLOWEDEXCEPTIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetRnsThAllowedExceptions()
			
			public static FLR_RESULT GaoGetRnsThAllowedExceptions(Camera parent, out UInt16 thAllowedExceptions) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thAllowedExceptions = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSTHALLOWEDEXCEPTIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thAllowedExceptions from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thAllowedExceptions = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsThAllowedExceptions()
			
			public static FLR_RESULT GaoGetRnsFramesExceptionLimitReached(Camera parent, out UInt32 framesReached) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				framesReached = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETRNSFRAMESEXCEPTIONLIMITREACHED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read framesReached from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				framesReached = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetRnsFramesExceptionLimitReached()
			
			public static FLR_RESULT GaoGetAppliedClip(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETAPPLIEDCLIP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetAppliedClip()
			
			public static FLR_RESULT GaoSetAppliedClipEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_SETAPPLIEDCLIPENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoSetAppliedClipEnable()
			
			public static FLR_RESULT GaoGetAppliedClipEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.GAO_GETAPPLIEDCLIPENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgGaoGetAppliedClipEnable()
			
			// End Module: gao
			
			// Begin Module: imageStats
			public static FLR_RESULT ImagestatsGetTotalHistPixelsInROI(Camera parent, out UInt32 totalPixelsInROI) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				totalPixelsInROI = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETTOTALHISTPIXELSINROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read totalPixelsInROI from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				totalPixelsInROI = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetTotalHistPixelsInROI()
			
			public static FLR_RESULT ImagestatsGetPopBelowLowToHighThresh(Camera parent, out UInt32 popBelowLowToHighThresh) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				popBelowLowToHighThresh = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETPOPBELOWLOWTOHIGHTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read popBelowLowToHighThresh from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				popBelowLowToHighThresh = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetPopBelowLowToHighThresh()
			
			public static FLR_RESULT ImagestatsGetPopAboveHighToLowThresh(Camera parent, out UInt32 popAboveHighToLowThresh) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				popAboveHighToLowThresh = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETPOPABOVEHIGHTOLOWTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read popAboveHighToLowThresh from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				popAboveHighToLowThresh = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetPopAboveHighToLowThresh()
			
			public static FLR_RESULT ImagestatsSetROI(Camera parent, FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write roi to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ROI_TToByte(roi,sendData,outPtr);
				outPtr += 8;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_SETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsSetROI()
			
			public static FLR_RESULT ImagestatsGetROI(Camera parent, out FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				roi = new FLR_ROI_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read roi from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				roi = byteToFLR_ROI_T(receiveData,inPtr);
				inPtr+=8;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetROI()
			
			public static FLR_RESULT ImagestatsGetFirstBin(Camera parent, out UInt16 firstBin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				firstBin = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETFIRSTBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read firstBin from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				firstBin = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetFirstBin()
			
			public static FLR_RESULT ImagestatsGetLastBin(Camera parent, out UInt16 lastBin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				lastBin = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETLASTBIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read lastBin from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				lastBin = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetLastBin()
			
			public static FLR_RESULT ImagestatsGetMean(Camera parent, out UInt16 mean) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mean = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETMEAN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mean from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mean = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetMean()
			
			public static FLR_RESULT ImagestatsGetFirstBinInROI(Camera parent, out UInt16 firstBinInROI) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				firstBinInROI = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETFIRSTBININROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read firstBinInROI from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				firstBinInROI = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetFirstBinInROI()
			
			public static FLR_RESULT ImagestatsGetLastBinInROI(Camera parent, out UInt16 lastBinInROI) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				lastBinInROI = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETLASTBININROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read lastBinInROI from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				lastBinInROI = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetLastBinInROI()
			
			public static FLR_RESULT ImagestatsGetMeanInROI(Camera parent, out UInt16 meanInROI) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				meanInROI = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETMEANINROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read meanInROI from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				meanInROI = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetMeanInROI()
			
			public static FLR_RESULT ImagestatsGetImageStats(Camera parent, out UInt16 meanIntensity, out UInt16 peakIntensity, out UInt16 baseIntensity) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 6;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				meanIntensity = new UInt16();
				peakIntensity = new UInt16();
				baseIntensity = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.IMAGESTATS_GETIMAGESTATS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read meanIntensity from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				meanIntensity = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read peakIntensity from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				peakIntensity = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read baseIntensity from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				baseIntensity = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgImagestatsGetImageStats()
			
			// End Module: imageStats
			
			// Begin Module: isotherm
			public static FLR_RESULT IsothermGetEnable(Camera parent, out FLR_ENABLE_E isothermEnable) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				isothermEnable = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read isothermEnable from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				isothermEnable = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetEnable()
			
			public static FLR_RESULT IsothermSetEnable(Camera parent, FLR_ENABLE_E isothermEnable) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write isothermEnable to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) isothermEnable,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetEnable()
			
			public static FLR_RESULT IsothermSetTemps(Camera parent, FLR_ISOTHERM_GAIN_E table, Int32 thIsoT1, Int32 thIsoT2, Int32 thIsoT3, Int32 thIsoT4, Int32 thIsoT5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 24;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				//write thIsoT1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(thIsoT1,sendData,outPtr);
				outPtr += 4;
				
				//write thIsoT2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(thIsoT2,sendData,outPtr);
				outPtr += 4;
				
				//write thIsoT3 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(thIsoT3,sendData,outPtr);
				outPtr += 4;
				
				//write thIsoT4 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(thIsoT4,sendData,outPtr);
				outPtr += 4;
				
				//write thIsoT5 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte(thIsoT5,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETTEMPS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetTemps()
			
			public static FLR_RESULT IsothermGetTemps(Camera parent, FLR_ISOTHERM_GAIN_E table, out Int32 thIsoT1, out Int32 thIsoT2, out Int32 thIsoT3, out Int32 thIsoT4, out Int32 thIsoT5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 20;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				thIsoT1 = new Int32();
				thIsoT2 = new Int32();
				thIsoT3 = new Int32();
				thIsoT4 = new Int32();
				thIsoT5 = new Int32();
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETTEMPS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read thIsoT1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thIsoT1 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read thIsoT2 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thIsoT2 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read thIsoT3 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thIsoT3 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read thIsoT4 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thIsoT4 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read thIsoT5 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				thIsoT5 = byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetTemps()
			
			public static FLR_RESULT IsothermSetIsoColorValues(Camera parent, FLR_ISOTHERM_GAIN_E table, FLR_ISOTHERM_COLORS_T region0, FLR_ISOTHERM_COLORS_T region1, FLR_ISOTHERM_COLORS_T region2, FLR_ISOTHERM_COLORS_T region3, FLR_ISOTHERM_COLORS_T region4, FLR_ISOTHERM_COLORS_T region5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 124;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				//write region0 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region0,sendData,outPtr);
				outPtr += 20;
				
				//write region1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region1,sendData,outPtr);
				outPtr += 20;
				
				//write region2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region2,sendData,outPtr);
				outPtr += 20;
				
				//write region3 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region3,sendData,outPtr);
				outPtr += 20;
				
				//write region4 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region4,sendData,outPtr);
				outPtr += 20;
				
				//write region5 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_COLORS_TToByte(region5,sendData,outPtr);
				outPtr += 20;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETISOCOLORVALUES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetIsoColorValues()
			
			public static FLR_RESULT IsothermGetIsoColorValues(Camera parent, FLR_ISOTHERM_GAIN_E table, out FLR_ISOTHERM_COLORS_T region0, out FLR_ISOTHERM_COLORS_T region1, out FLR_ISOTHERM_COLORS_T region2, out FLR_ISOTHERM_COLORS_T region3, out FLR_ISOTHERM_COLORS_T region4, out FLR_ISOTHERM_COLORS_T region5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 120;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				region0 = new FLR_ISOTHERM_COLORS_T();
				region1 = new FLR_ISOTHERM_COLORS_T();
				region2 = new FLR_ISOTHERM_COLORS_T();
				region3 = new FLR_ISOTHERM_COLORS_T();
				region4 = new FLR_ISOTHERM_COLORS_T();
				region5 = new FLR_ISOTHERM_COLORS_T();
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETISOCOLORVALUES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read region0 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region0 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				// read region1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region1 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				// read region2 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region2 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				// read region3 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region3 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				// read region4 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region4 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				// read region5 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region5 = byteToFLR_ISOTHERM_COLORS_T(receiveData,inPtr);
				inPtr+=20;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetIsoColorValues()
			
			public static FLR_RESULT IsothermSetRegionMode(Camera parent, FLR_ISOTHERM_GAIN_E table, FLR_ISOTHERM_REGION_E region0, FLR_ISOTHERM_REGION_E region1, FLR_ISOTHERM_REGION_E region2, FLR_ISOTHERM_REGION_E region3, FLR_ISOTHERM_REGION_E region4, FLR_ISOTHERM_REGION_E region5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 28;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				//write region0 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region0,sendData,outPtr);
				outPtr += 4;
				
				//write region1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region1,sendData,outPtr);
				outPtr += 4;
				
				//write region2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region2,sendData,outPtr);
				outPtr += 4;
				
				//write region3 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region3,sendData,outPtr);
				outPtr += 4;
				
				//write region4 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region4,sendData,outPtr);
				outPtr += 4;
				
				//write region5 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) region5,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETREGIONMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetRegionMode()
			
			public static FLR_RESULT IsothermGetRegionMode(Camera parent, FLR_ISOTHERM_GAIN_E table, out FLR_ISOTHERM_REGION_E region0, out FLR_ISOTHERM_REGION_E region1, out FLR_ISOTHERM_REGION_E region2, out FLR_ISOTHERM_REGION_E region3, out FLR_ISOTHERM_REGION_E region4, out FLR_ISOTHERM_REGION_E region5) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 24;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				region0 = new FLR_ISOTHERM_REGION_E();
				region1 = new FLR_ISOTHERM_REGION_E();
				region2 = new FLR_ISOTHERM_REGION_E();
				region3 = new FLR_ISOTHERM_REGION_E();
				region4 = new FLR_ISOTHERM_REGION_E();
				region5 = new FLR_ISOTHERM_REGION_E();
				
				//write table to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) table,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETREGIONMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read region0 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region0 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read region1 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region1 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read region2 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region2 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read region3 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region3 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read region4 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region4 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read region5 from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				region5 = (FLR_ISOTHERM_REGION_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetRegionMode()
			
			public static FLR_RESULT IsothermGetUnit(Camera parent, out FLR_ISOTHERM_UNIT_E unit) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				unit = new FLR_ISOTHERM_UNIT_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETUNIT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read unit from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				unit = (FLR_ISOTHERM_UNIT_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetUnit()
			
			public static FLR_RESULT IsothermSetUnit(Camera parent, FLR_ISOTHERM_UNIT_E unit) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write unit to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) unit,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETUNIT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetUnit()
			
			public static FLR_RESULT IsothermGetSettingsLowGain(Camera parent, out FLR_ISOTHERM_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 164;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				settings = new FLR_ISOTHERM_SETTINGS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETSETTINGSLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read settings from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				settings = byteToFLR_ISOTHERM_SETTINGS_T(receiveData,inPtr);
				inPtr+=164;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetSettingsLowGain()
			
			public static FLR_RESULT IsothermSetSettingsLowGain(Camera parent, FLR_ISOTHERM_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 164;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write settings to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_SETTINGS_TToByte(settings,sendData,outPtr);
				outPtr += 164;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETSETTINGSLOWGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetSettingsLowGain()
			
			public static FLR_RESULT IsothermGetSettingsHighGain(Camera parent, out FLR_ISOTHERM_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 164;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				settings = new FLR_ISOTHERM_SETTINGS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETSETTINGSHIGHGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read settings from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				settings = byteToFLR_ISOTHERM_SETTINGS_T(receiveData,inPtr);
				inPtr+=164;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetSettingsHighGain()
			
			public static FLR_RESULT IsothermSetSettingsHighGain(Camera parent, FLR_ISOTHERM_SETTINGS_T settings) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 164;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write settings to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ISOTHERM_SETTINGS_TToByte(settings,sendData,outPtr);
				outPtr += 164;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETSETTINGSHIGHGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetSettingsHighGain()
			
			public static FLR_RESULT IsothermSetColorLutId(Camera parent, FLR_COLORLUT_ID_E colorLutIdLowGain, FLR_COLORLUT_ID_E colorLutIdHighGain) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write colorLutIdLowGain to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) colorLutIdLowGain,sendData,outPtr);
				outPtr += 4;
				
				//write colorLutIdHighGain to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) colorLutIdHighGain,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_SETCOLORLUTID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermSetColorLutId()
			
			public static FLR_RESULT IsothermGetColorLutId(Camera parent, out FLR_COLORLUT_ID_E colorLutIdLowGain, out FLR_COLORLUT_ID_E colorLutIdHighGain) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				colorLutIdLowGain = new FLR_COLORLUT_ID_E();
				colorLutIdHighGain = new FLR_COLORLUT_ID_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ISOTHERM_GETCOLORLUTID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read colorLutIdLowGain from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				colorLutIdLowGain = (FLR_COLORLUT_ID_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read colorLutIdHighGain from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				colorLutIdHighGain = (FLR_COLORLUT_ID_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgIsothermGetColorLutId()
			
			// End Module: isotherm
			
			// Begin Module: jffs2
			public static FLR_RESULT Jffs2Mount(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.JFFS2_MOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgJffs2Mount()
			
			public static FLR_RESULT Jffs2Unmount(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.JFFS2_UNMOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgJffs2Unmount()
			
			public static FLR_RESULT Jffs2GetState(Camera parent, out FLR_JFFS2_STATE_E state) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				state = new FLR_JFFS2_STATE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.JFFS2_GETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read state from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				state = (FLR_JFFS2_STATE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgJffs2GetState()
			
			// End Module: jffs2
			
			// Begin Module: lagrange
			// End Module: lagrange
			
			// Begin Module: lfsr
			public static FLR_RESULT LfsrSetApplyOffsetEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETAPPLYOFFSETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetApplyOffsetEnableState()
			
			public static FLR_RESULT LfsrGetApplyOffsetEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETAPPLYOFFSETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetApplyOffsetEnableState()
			
			public static FLR_RESULT LfsrSetMaxIterations(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETMAXITERATIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetMaxIterations()
			
			public static FLR_RESULT LfsrGetMaxIterations(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETMAXITERATIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetMaxIterations()
			
			public static FLR_RESULT LfsrSetDf(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetDf()
			
			public static FLR_RESULT LfsrGetDf(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetDf()
			
			public static FLR_RESULT LfsrSetLambda1(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETLAMBDA1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetLambda1()
			
			public static FLR_RESULT LfsrGetLambda1(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETLAMBDA1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetLambda1()
			
			public static FLR_RESULT LfsrSetLambda2(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETLAMBDA2, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetLambda2()
			
			public static FLR_RESULT LfsrGetLambda2(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETLAMBDA2, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetLambda2()
			
			public static FLR_RESULT LfsrSetHaltEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETHALTENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetHaltEnable()
			
			public static FLR_RESULT LfsrGetHaltEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETHALTENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetHaltEnable()
			
			public static FLR_RESULT LfsrSetRandomMethod(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETRANDOMMETHOD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetRandomMethod()
			
			public static FLR_RESULT LfsrGetRandomMethod(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETRANDOMMETHOD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetRandomMethod()
			
			public static FLR_RESULT LfsrSetSingleStepEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETSINGLESTEPENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetSingleStepEnable()
			
			public static FLR_RESULT LfsrGetSingleStepEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETSINGLESTEPENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetSingleStepEnable()
			
			public static FLR_RESULT LfsrSetR_LocalBump(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETR_LOCALBUMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetR_LocalBump()
			
			public static FLR_RESULT LfsrGetR_LocalBump(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETR_LOCALBUMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetR_LocalBump()
			
			public static FLR_RESULT LfsrSetR_CornerBump(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETR_CORNERBUMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetR_CornerBump()
			
			public static FLR_RESULT LfsrGetR_CornerBump(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETR_CORNERBUMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetR_CornerBump()
			
			public static FLR_RESULT LfsrSetFFC_ResetEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETFFC_RESETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetFFC_ResetEnable()
			
			public static FLR_RESULT LfsrGetFFC_ResetEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETFFC_RESETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetFFC_ResetEnable()
			
			public static FLR_RESULT LfsrSetNormalizeAtCenterSpotState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_SETNORMALIZEATCENTERSPOTSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrSetNormalizeAtCenterSpotState()
			
			public static FLR_RESULT LfsrGetNormalizeAtCenterSpotState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.LFSR_GETNORMALIZEATCENTERSPOTSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgLfsrGetNormalizeAtCenterSpotState()
			
			// End Module: lfsr
			
			// Begin Module: mem
			public static FLR_RESULT MemReadCapture(Camera parent, Byte bufferNum, UInt32 offset, UInt16 sizeInBytes, out Byte[] data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 7;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 256;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte[sizeInBytes];
				
				//write bufferNum to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(bufferNum,sendData,outPtr);
				outPtr += 1;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write sizeInBytes to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(sizeInBytes,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_READCAPTURE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHARArray(receiveData,inPtr,sizeInBytes);
				inPtr+=sizeInBytes;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemReadCapture()
			
			public static FLR_RESULT MemGetCaptureSize(Camera parent, out UInt32 bytes, out UInt16 rows, out UInt16 columns) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				bytes = new UInt32();
				rows = new UInt16();
				columns = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_GETCAPTURESIZE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read bytes from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				bytes = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rows = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read columns from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				columns = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemGetCaptureSize()
			
			public static FLR_RESULT MemWriteFlash(Camera parent, FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt16 sizeInBytes, Byte[] data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = (UInt32) sizeInBytes + 11;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write location to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) location,sendData,outPtr);
				outPtr += 4;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write sizeInBytes to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(sizeInBytes,sendData,outPtr);
				outPtr += 2;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(data,sizeInBytes,sendData,outPtr);
				outPtr += sizeInBytes;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_WRITEFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemWriteFlash()
			
			public static FLR_RESULT MemReadFlash(Camera parent, FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt16 sizeInBytes, out Byte[] data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 11;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 256;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte[sizeInBytes];
				
				//write location to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) location,sendData,outPtr);
				outPtr += 4;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write sizeInBytes to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(sizeInBytes,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_READFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHARArray(receiveData,inPtr,sizeInBytes);
				inPtr+=sizeInBytes;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemReadFlash()
			
			public static FLR_RESULT MemGetFlashSize(Camera parent, FLR_MEM_LOCATION_E location, out UInt32 bytes) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				bytes = new UInt32();
				
				//write location to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) location,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_GETFLASHSIZE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read bytes from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				bytes = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemGetFlashSize()
			
			public static FLR_RESULT MemEraseFlash(Camera parent, FLR_MEM_LOCATION_E location, Byte index) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 5;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write location to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) location,sendData,outPtr);
				outPtr += 4;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_ERASEFLASH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemEraseFlash()
			
			public static FLR_RESULT MemEraseFlashPartial(Camera parent, FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt32 length) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 13;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write location to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) location,sendData,outPtr);
				outPtr += 4;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write length to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(length,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_ERASEFLASHPARTIAL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemEraseFlashPartial()
			
			public static FLR_RESULT MemReadCurrentGain(Camera parent, UInt32 offset, UInt16 sizeInBytes, out Byte[] data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 6;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 256;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte[sizeInBytes];
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write sizeInBytes to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(sizeInBytes,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_READCURRENTGAIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHARArray(receiveData,inPtr,sizeInBytes);
				inPtr+=sizeInBytes;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemReadCurrentGain()
			
			public static FLR_RESULT MemGetGainSize(Camera parent, out UInt32 bytes, out UInt16 rows, out UInt16 columns) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				bytes = new UInt32();
				rows = new UInt16();
				columns = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_GETGAINSIZE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read bytes from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				bytes = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rows = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read columns from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				columns = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemGetGainSize()
			
			public static FLR_RESULT MemGetCaptureSizeSrc(Camera parent, FLR_CAPTURE_SRC_E src, out UInt32 bytes, out UInt16 rows, out UInt16 columns) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				bytes = new UInt32();
				rows = new UInt16();
				columns = new UInt16();
				
				//write src to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) src,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_GETCAPTURESIZESRC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read bytes from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				bytes = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read rows from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rows = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read columns from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				columns = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemGetCaptureSizeSrc()
			
			public static FLR_RESULT MemReadCaptureSrc(Camera parent, FLR_CAPTURE_SRC_E src, Byte bufferNum, UInt32 offset, UInt16 sizeInBytes, out Byte[] data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 11;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 256;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte[sizeInBytes];
				
				//write src to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) src,sendData,outPtr);
				outPtr += 4;
				
				//write bufferNum to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(bufferNum,sendData,outPtr);
				outPtr += 1;
				
				//write offset to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(offset,sendData,outPtr);
				outPtr += 4;
				
				//write sizeInBytes to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(sizeInBytes,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.MEM_READCAPTURESRC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHARArray(receiveData,inPtr,sizeInBytes);
				inPtr+=sizeInBytes;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgMemReadCaptureSrc()
			
			// End Module: mem
			
			// Begin Module: normalize
			// End Module: normalize
			
			// Begin Module: radiometry
			public static FLR_RESULT RadiometrySetTempStableEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPSTABLEENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempStableEnable()
			
			public static FLR_RESULT RadiometryGetTempStableEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPSTABLEENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempStableEnable()
			
			public static FLR_RESULT RadiometrySetFNumberLens0(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETFNUMBERLENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetFNumberLens0()
			
			public static FLR_RESULT RadiometryGetFNumberLens0(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETFNUMBERLENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetFNumberLens0()
			
			public static FLR_RESULT RadiometrySetFNumberLens1(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETFNUMBERLENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetFNumberLens1()
			
			public static FLR_RESULT RadiometryGetFNumberLens1(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETFNUMBERLENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetFNumberLens1()
			
			public static FLR_RESULT RadiometrySetTauLens0(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTAULENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTauLens0()
			
			public static FLR_RESULT RadiometryGetTauLens0(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTAULENS0, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTauLens0()
			
			public static FLR_RESULT RadiometrySetTauLens1(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTAULENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTauLens1()
			
			public static FLR_RESULT RadiometryGetTauLens1(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTAULENS1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTauLens1()
			
			public static FLR_RESULT RadiometryGetGlobalGainDesired(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALGAINDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalGainDesired()
			
			public static FLR_RESULT RadiometryGetGlobalOffsetDesired(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALOFFSETDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalOffsetDesired()
			
			public static FLR_RESULT RadiometryGetGlobalGainApplied(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALGAINAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalGainApplied()
			
			public static FLR_RESULT RadiometryGetGlobalOffsetApplied(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALOFFSETAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalOffsetApplied()
			
			public static FLR_RESULT RadiometrySetTComponentOverrideMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTCOMPONENTOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTComponentOverrideMode()
			
			public static FLR_RESULT RadiometryGetTComponentOverrideMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTCOMPONENTOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTComponentOverrideMode()
			
			public static FLR_RESULT RadiometrySetGlobalGainOverride(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETGLOBALGAINOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetGlobalGainOverride()
			
			public static FLR_RESULT RadiometryGetGlobalGainOverride(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALGAINOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalGainOverride()
			
			public static FLR_RESULT RadiometrySetGlobalOffsetOverride(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETGLOBALOFFSETOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetGlobalOffsetOverride()
			
			public static FLR_RESULT RadiometryGetGlobalOffsetOverride(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALOFFSETOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalOffsetOverride()
			
			public static FLR_RESULT RadiometrySetGlobalParamOverrideMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETGLOBALPARAMOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetGlobalParamOverrideMode()
			
			public static FLR_RESULT RadiometryGetGlobalParamOverrideMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGLOBALPARAMOVERRIDEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGlobalParamOverrideMode()
			
			public static FLR_RESULT RadiometrySetRBFOHighGainDefault(Camera parent, FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETRBFOHIGHGAINDEFAULT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetRBFOHighGainDefault()
			
			public static FLR_RESULT RadiometryGetRBFOHighGainDefault(Camera parent, out FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_RBFO_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRBFOHIGHGAINDEFAULT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRBFOHighGainDefault()
			
			public static FLR_RESULT RadiometrySetRBFOLowGainDefault(Camera parent, FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETRBFOLOWGAINDEFAULT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetRBFOLowGainDefault()
			
			public static FLR_RESULT RadiometryGetRBFOLowGainDefault(Camera parent, out FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_RBFO_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRBFOLOWGAINDEFAULT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRBFOLowGainDefault()
			
			public static FLR_RESULT RadiometrySetRBFOHighGainFactory(Camera parent, FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETRBFOHIGHGAINFACTORY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetRBFOHighGainFactory()
			
			public static FLR_RESULT RadiometryGetRBFOHighGainFactory(Camera parent, out FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_RBFO_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRBFOHIGHGAINFACTORY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRBFOHighGainFactory()
			
			public static FLR_RESULT RadiometrySetRBFOLowGainFactory(Camera parent, FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_RBFO_PARAMS_TToByte(data,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETRBFOLOWGAINFACTORY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetRBFOLowGainFactory()
			
			public static FLR_RESULT RadiometryGetRBFOLowGainFactory(Camera parent, out FLR_RADIOMETRY_RBFO_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_RBFO_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRBFOLOWGAINFACTORY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_RBFO_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRBFOLowGainFactory()
			
			public static FLR_RESULT RadiometrySetDampingFactor(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDAMPINGFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetDampingFactor()
			
			public static FLR_RESULT RadiometryGetDampingFactor(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDAMPINGFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetDampingFactor()
			
			public static FLR_RESULT RadiometryGetGoMEQ(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGOMEQ, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGoMEQ()
			
			public static FLR_RESULT RadiometryGetGoMShutter(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGOMSHUTTER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGoMShutter()
			
			public static FLR_RESULT RadiometryGetGoMLens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGOMLENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGoMLens()
			
			public static FLR_RESULT RadiometryGetGoMLG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGOMLG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGoMLG()
			
			public static FLR_RESULT RadiometryGetGoMFFC(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGOMFFC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGoMFFC()
			
			public static FLR_RESULT RadiometryGetTempLensHousing(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPLENSHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempLensHousing()
			
			public static FLR_RESULT RadiometryGetTempShutterHousing(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPSHUTTERHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempShutterHousing()
			
			public static FLR_RESULT RadiometryGetTempShutterPaddle(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPSHUTTERPADDLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempShutterPaddle()
			
			public static FLR_RESULT RadiometrySetFNumberShutterHousing(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETFNUMBERSHUTTERHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetFNumberShutterHousing()
			
			public static FLR_RESULT RadiometryGetFNumberShutterHousing(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETFNUMBERSHUTTERHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetFNumberShutterHousing()
			
			public static FLR_RESULT RadiometrySetEmissivityShutterHousing(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETEMISSIVITYSHUTTERHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetEmissivityShutterHousing()
			
			public static FLR_RESULT RadiometryGetEmissivityShutterHousing(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETEMISSIVITYSHUTTERHOUSING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetEmissivityShutterHousing()
			
			public static FLR_RESULT RadiometrySetM_DTfpa_Lens(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DTFPA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_DTfpa_Lens()
			
			public static FLR_RESULT RadiometryGetM_DTfpa_Lens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DTFPA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_DTfpa_Lens()
			
			public static FLR_RESULT RadiometrySetOffset_Lens(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETOFFSET_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetOffset_Lens()
			
			public static FLR_RESULT RadiometryGetOffset_Lens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETOFFSET_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetOffset_Lens()
			
			public static FLR_RESULT RadiometrySetM_Recursive_Lens(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_RECURSIVE_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Recursive_Lens()
			
			public static FLR_RESULT RadiometryGetM_Recursive_Lens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_RECURSIVE_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Recursive_Lens()
			
			public static FLR_RESULT RadiometryGetGgFfc(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGGFFC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGgFfc()
			
			public static FLR_RESULT RadiometryGetCountsFromTemp(Camera parent, FLR_RADIOMETRY_RBFO_TYPE_E rbfoType, Double temp, out UInt16 counts) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				counts = new UInt16();
				
				//write rbfoType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) rbfoType,sendData,outPtr);
				outPtr += 4;
				
				//write temp to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(temp,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETCOUNTSFROMTEMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read counts from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				counts = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetCountsFromTemp()
			
			public static FLR_RESULT RadiometryGetTempFromCounts(Camera parent, FLR_RADIOMETRY_RBFO_TYPE_E rbfoType, UInt16 counts, out Double temp) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 6;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				temp = new Double();
				
				//write rbfoType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) rbfoType,sendData,outPtr);
				outPtr += 4;
				
				//write counts to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(counts,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPFROMCOUNTS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read temp from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				temp = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempFromCounts()
			
			public static FLR_RESULT RadiometrySetTempLensHousingOverride(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPLENSHOUSINGOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempLensHousingOverride()
			
			public static FLR_RESULT RadiometryGetTempLensHousingOverride(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPLENSHOUSINGOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempLensHousingOverride()
			
			public static FLR_RESULT RadiometrySetTempShutterHousingOverride(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPSHUTTERHOUSINGOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempShutterHousingOverride()
			
			public static FLR_RESULT RadiometryGetTempShutterHousingOverride(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPSHUTTERHOUSINGOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempShutterHousingOverride()
			
			public static FLR_RESULT RadiometrySetTempShutterPaddleOverride(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPSHUTTERPADDLEOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempShutterPaddleOverride()
			
			public static FLR_RESULT RadiometryGetTempShutterPaddleOverride(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPSHUTTERPADDLEOVERRIDE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempShutterPaddleOverride()
			
			public static FLR_RESULT RadiometrySetSignalFactorLut(Camera parent, FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 34;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr);
				outPtr += 34;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETSIGNALFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetSignalFactorLut()
			
			public static FLR_RESULT RadiometryGetSignalFactorLut(Camera parent, out FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 34;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETSIGNALFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T(receiveData,inPtr);
				inPtr+=34;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetSignalFactorLut()
			
			public static FLR_RESULT RadiometrySetNoiseFactorLut(Camera parent, FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 34;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr);
				outPtr += 34;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETNOISEFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetNoiseFactorLut()
			
			public static FLR_RESULT RadiometryGetNoiseFactorLut(Camera parent, out FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 34;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETNOISEFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T(receiveData,inPtr);
				inPtr+=34;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetNoiseFactorLut()
			
			public static FLR_RESULT RadiometrySetM_tfpaK(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_TFPAK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_tfpaK()
			
			public static FLR_RESULT RadiometryGetM_tfpaK(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_TFPAK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_tfpaK()
			
			public static FLR_RESULT RadiometrySetB_tfpaK(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_TFPAK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_tfpaK()
			
			public static FLR_RESULT RadiometryGetB_tfpaK(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_TFPAK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_tfpaK()
			
			public static FLR_RESULT RadiometrySetTAuxParams(Camera parent, FLR_RADIOMETRY_TAUX_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 16;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_RADIOMETRY_TAUX_PARAMS_TToByte(data,sendData,outPtr);
				outPtr += 16;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTAUXPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTAuxParams()
			
			public static FLR_RESULT RadiometryGetTAuxParams(Camera parent, out FLR_RADIOMETRY_TAUX_PARAMS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_TAUX_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTAUXPARAMS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_RADIOMETRY_TAUX_PARAMS_T(receiveData,inPtr);
				inPtr+=16;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTAuxParams()
			
			public static FLR_RESULT RadiometrySetM_tAux(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_TAUX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_tAux()
			
			public static FLR_RESULT RadiometryGetM_tAux(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_TAUX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_tAux()
			
			public static FLR_RESULT RadiometrySetB_tAux(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_TAUX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_tAux()
			
			public static FLR_RESULT RadiometryGetB_tAux(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_TAUX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_tAux()
			
			public static FLR_RESULT RadiometrySetTsource_FFC(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTSOURCE_FFC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTsource_FFC()
			
			public static FLR_RESULT RadiometryGetTsource_FFC(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTSOURCE_FFC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTsource_FFC()
			
			public static FLR_RESULT RadiometrySetM_DTfpa_Sh_h(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DTFPA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_DTfpa_Sh_h()
			
			public static FLR_RESULT RadiometryGetM_DTfpa_Sh_h(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DTFPA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_DTfpa_Sh_h()
			
			public static FLR_RESULT RadiometrySetOffset_Sh_h(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETOFFSET_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetOffset_Sh_h()
			
			public static FLR_RESULT RadiometryGetOffset_Sh_h(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETOFFSET_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetOffset_Sh_h()
			
			public static FLR_RESULT RadiometrySetM_Recursive_Sh_h(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_RECURSIVE_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Recursive_Sh_h()
			
			public static FLR_RESULT RadiometryGetM_Recursive_Sh_h(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_RECURSIVE_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Recursive_Sh_h()
			
			public static FLR_RESULT RadiometrySetM_DTfpa_Sh_p(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DTFPA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_DTfpa_Sh_p()
			
			public static FLR_RESULT RadiometryGetM_DTfpa_Sh_p(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DTFPA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_DTfpa_Sh_p()
			
			public static FLR_RESULT RadiometrySetOffset_Sh_p(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETOFFSET_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetOffset_Sh_p()
			
			public static FLR_RESULT RadiometryGetOffset_Sh_p(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETOFFSET_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetOffset_Sh_p()
			
			public static FLR_RESULT RadiometrySetM_Recursive_Sh_p(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_RECURSIVE_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Recursive_Sh_p()
			
			public static FLR_RESULT RadiometryGetM_Recursive_Sh_p(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_RECURSIVE_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Recursive_Sh_p()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_p(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_p()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_p(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_p()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_p(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_p()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_p(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_P, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_p()
			
			public static FLR_RESULT RadiometryGetDtTfpaK(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDTTFPAK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetDtTfpaK()
			
			public static FLR_RESULT RadiometryGetDtTfpaK_Damp(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDTTFPAK_DAMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetDtTfpaK_Damp()
			
			public static FLR_RESULT RadiometryGetTAuxK(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTAUXK, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTAuxK()
			
			public static FLR_RESULT RadiometrySetExternalFfcUpdateMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETEXTERNALFFCUPDATEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetExternalFfcUpdateMode()
			
			public static FLR_RESULT RadiometryGetExternalFfcUpdateMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETEXTERNALFFCUPDATEMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetExternalFfcUpdateMode()
			
			public static FLR_RESULT RadiometryGetGG_scale(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGG_SCALE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGG_scale()
			
			public static FLR_RESULT RadiometrySetTempWindow(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempWindow()
			
			public static FLR_RESULT RadiometryGetTempWindow(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempWindow()
			
			public static FLR_RESULT RadiometrySetTransmissionWindow(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTRANSMISSIONWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTransmissionWindow()
			
			public static FLR_RESULT RadiometryGetTransmissionWindow(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTRANSMISSIONWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTransmissionWindow()
			
			public static FLR_RESULT RadiometrySetReflectivityWindow(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETREFLECTIVITYWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetReflectivityWindow()
			
			public static FLR_RESULT RadiometryGetReflectivityWindow(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETREFLECTIVITYWINDOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetReflectivityWindow()
			
			public static FLR_RESULT RadiometrySetTempWindowReflection(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPWINDOWREFLECTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempWindowReflection()
			
			public static FLR_RESULT RadiometryGetTempWindowReflection(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPWINDOWREFLECTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempWindowReflection()
			
			public static FLR_RESULT RadiometrySetTransmissionAtmosphere(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTRANSMISSIONATMOSPHERE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTransmissionAtmosphere()
			
			public static FLR_RESULT RadiometryGetTransmissionAtmosphere(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTRANSMISSIONATMOSPHERE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTransmissionAtmosphere()
			
			public static FLR_RESULT RadiometrySetTempAtmosphere(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPATMOSPHERE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempAtmosphere()
			
			public static FLR_RESULT RadiometryGetTempAtmosphere(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPATMOSPHERE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempAtmosphere()
			
			public static FLR_RESULT RadiometrySetEmissivityTarget(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETEMISSIVITYTARGET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetEmissivityTarget()
			
			public static FLR_RESULT RadiometryGetEmissivityTarget(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETEMISSIVITYTARGET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetEmissivityTarget()
			
			public static FLR_RESULT RadiometrySetTempBackground(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPBACKGROUND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTempBackground()
			
			public static FLR_RESULT RadiometryGetTempBackground(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPBACKGROUND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTempBackground()
			
			public static FLR_RESULT RadiometryGetRadiometryCapable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRADIOMETRYCAPABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRadiometryCapable()
			
			public static FLR_RESULT RadiometrySetdeltaTempDampingFactor(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDELTATEMPDAMPINGFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetdeltaTempDampingFactor()
			
			public static FLR_RESULT RadiometryGetdeltaTempDampingFactor(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDELTATEMPDAMPINGFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetdeltaTempDampingFactor()
			
			public static FLR_RESULT RadiometrySetdeltaTempIntervalTime(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDELTATEMPINTERVALTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetdeltaTempIntervalTime()
			
			public static FLR_RESULT RadiometryGetdeltaTempIntervalTime(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDELTATEMPINTERVALTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetdeltaTempIntervalTime()
			
			public static FLR_RESULT RadiometrySetdeltaTempMaxValue(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDELTATEMPMAXVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetdeltaTempMaxValue()
			
			public static FLR_RESULT RadiometryGetdeltaTempMaxValue(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDELTATEMPMAXVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetdeltaTempMaxValue()
			
			public static FLR_RESULT RadiometrySetdeltaTempMaxIncrement(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDELTATEMPMAXINCREMENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetdeltaTempMaxIncrement()
			
			public static FLR_RESULT RadiometryGetdeltaTempMaxIncrement(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDELTATEMPMAXINCREMENT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetdeltaTempMaxIncrement()
			
			public static FLR_RESULT RadiometrySetdeltaTempDampingTime(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETDELTATEMPDAMPINGTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetdeltaTempDampingTime()
			
			public static FLR_RESULT RadiometryGetdeltaTempDampingTime(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETDELTATEMPDAMPINGTIME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetdeltaTempDampingTime()
			
			public static FLR_RESULT RadiometryGetResponsivityFpaTemp(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRESPONSIVITYFPATEMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetResponsivityFpaTemp()
			
			public static FLR_RESULT RadiometrySetM_Delta_Lens(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Lens()
			
			public static FLR_RESULT RadiometryGetM_Delta_Lens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Lens()
			
			public static FLR_RESULT RadiometrySetB_Delta_Lens(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Lens()
			
			public static FLR_RESULT RadiometryGetB_Delta_Lens(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_LENS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Lens()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_h(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_h()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_h(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_h()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_h(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_h()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_h(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_H, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_h()
			
			public static FLR_RESULT RadiometrySetGG_Scale_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETGG_SCALE_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetGG_Scale_HG()
			
			public static FLR_RESULT RadiometryGetGG_Scale_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGG_SCALE_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGG_Scale_HG()
			
			public static FLR_RESULT RadiometrySetGG_Scale_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETGG_SCALE_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetGG_Scale_LG()
			
			public static FLR_RESULT RadiometryGetGG_Scale_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGG_SCALE_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGG_Scale_LG()
			
			public static FLR_RESULT RadiometrySetRbfoScaledMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETRBFOSCALEDMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetRbfoScaledMode()
			
			public static FLR_RESULT RadiometryGetRbfoScaledMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETRBFOSCALEDMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetRbfoScaledMode()
			
			public static FLR_RESULT RadiometryGetUncertaintyFactor(Camera parent, out FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETUNCERTAINTYFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetUncertaintyFactor()
			
			public static FLR_RESULT RadiometryGetTRoomMinThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTROOMMINTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTRoomMinThresh()
			
			public static FLR_RESULT RadiometryGetTRoomMaxThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTROOMMAXTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTRoomMaxThresh()
			
			public static FLR_RESULT RadiometryGetTOperatingMinThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTOPERATINGMINTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTOperatingMinThresh()
			
			public static FLR_RESULT RadiometryGetTOperatingMaxThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTOPERATINGMAXTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTOperatingMaxThresh()
			
			public static FLR_RESULT RadiometryGetStableTempThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETSTABLETEMPTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetStableTempThresh()
			
			public static FLR_RESULT RadiometryGetSlowDriftThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETSLOWDRIFTTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetSlowDriftThresh()
			
			public static FLR_RESULT RadiometryGetFfcTempThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETFFCTEMPTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetFfcTempThresh()
			
			public static FLR_RESULT RadiometryGetTargetTempMinThreshLG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTARGETTEMPMINTHRESHLG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTargetTempMinThreshLG()
			
			public static FLR_RESULT RadiometryGetTargetTempMaxThreshLG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTARGETTEMPMAXTHRESHLG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTargetTempMaxThreshLG()
			
			public static FLR_RESULT RadiometryGetMFactorThresh(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETMFACTORTHRESH, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetMFactorThresh()
			
			public static FLR_RESULT RadiometryGetTargetTempMinThreshHG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTARGETTEMPMINTHRESHHG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTargetTempMinThreshHG()
			
			public static FLR_RESULT RadiometryGetTargetTempMaxThreshHG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTARGETTEMPMAXTHRESHHG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTargetTempMaxThreshHG()
			
			public static FLR_RESULT RadiometryGetUncertaintyStatusBits(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETUNCERTAINTYSTATUSBITS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetUncertaintyStatusBits()
			
			public static FLR_RESULT RadiometrySetTemperatureOffset_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPERATUREOFFSET_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTemperatureOffset_HG()
			
			public static FLR_RESULT RadiometryGetTemperatureOffset_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPERATUREOFFSET_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTemperatureOffset_HG()
			
			public static FLR_RESULT RadiometrySetTemperatureOffset_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETTEMPERATUREOFFSET_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetTemperatureOffset_LG()
			
			public static FLR_RESULT RadiometryGetTemperatureOffset_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETTEMPERATUREOFFSET_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetTemperatureOffset_LG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Lens_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Lens_HG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Lens_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Lens_HG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Lens_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Lens_HG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Lens_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Lens_HG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Lens_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Lens_LG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Lens_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Lens_LG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Lens_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Lens_LG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Lens_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Lens_LG()
			
			public static FLR_RESULT RadiometrySetOffset_Lens_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETOFFSET_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetOffset_Lens_HG()
			
			public static FLR_RESULT RadiometryGetOffset_Lens_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETOFFSET_LENS_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetOffset_Lens_HG()
			
			public static FLR_RESULT RadiometrySetOffset_Lens_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETOFFSET_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetOffset_Lens_LG()
			
			public static FLR_RESULT RadiometryGetOffset_Lens_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETOFFSET_LENS_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetOffset_Lens_LG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_p_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_P_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_p_HG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_p_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_P_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_p_HG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_p_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_P_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_p_HG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_p_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_P_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_p_HG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_p_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_P_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_p_LG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_p_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_P_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_p_LG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_p_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_P_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_p_LG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_p_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_P_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_p_LG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_h_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_H_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_h_HG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_h_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_H_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_h_HG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_h_HG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_H_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_h_HG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_h_HG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_H_HG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_h_HG()
			
			public static FLR_RESULT RadiometrySetM_Delta_Sh_h_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETM_DELTA_SH_H_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetM_Delta_Sh_h_LG()
			
			public static FLR_RESULT RadiometryGetM_Delta_Sh_h_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETM_DELTA_SH_H_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetM_Delta_Sh_h_LG()
			
			public static FLR_RESULT RadiometrySetB_Delta_Sh_h_LG(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_SETB_DELTA_SH_H_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometrySetB_Delta_Sh_h_LG()
			
			public static FLR_RESULT RadiometryGetB_Delta_Sh_h_LG(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETB_DELTA_SH_H_LG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetB_Delta_Sh_h_LG()
			
			public static FLR_RESULT RadiometryGetGG_RoomTemp(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.RADIOMETRY_GETGG_ROOMTEMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRadiometryGetGG_RoomTemp()
			
			// End Module: radiometry
			
			// Begin Module: roic
			public static FLR_RESULT RoicGetFPATemp(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPATEMP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPATemp()
			
			public static FLR_RESULT RoicGetFrameCount(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFRAMECOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFrameCount()
			
			public static FLR_RESULT RoicGetActiveNormalizationTarget(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETACTIVENORMALIZATIONTARGET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetActiveNormalizationTarget()
			
			public static FLR_RESULT RoicSetFPARampState(Camera parent, FLR_ENABLE_E state) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write state to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) state,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFPARAMPSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFPARampState()
			
			public static FLR_RESULT RoicGetFPARampState(Camera parent, out FLR_ENABLE_E state) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				state = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPARAMPSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read state from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				state = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPARampState()
			
			public static FLR_RESULT RoicGetSensorADC1(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETSENSORADC1, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetSensorADC1()
			
			public static FLR_RESULT RoicGetSensorADC2(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETSENSORADC2, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetSensorADC2()
			
			public static FLR_RESULT RoicSetFPATempOffset(Camera parent, Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFPATEMPOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFPATempOffset()
			
			public static FLR_RESULT RoicGetFPATempOffset(Camera parent, out Int16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Int16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPATEMPOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPATempOffset()
			
			public static FLR_RESULT RoicSetFPATempMode(Camera parent, FLR_ROIC_TEMP_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFPATEMPMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFPATempMode()
			
			public static FLR_RESULT RoicGetFPATempMode(Camera parent, out FLR_ROIC_TEMP_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ROIC_TEMP_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPATEMPMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ROIC_TEMP_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPATempMode()
			
			public static FLR_RESULT RoicGetFPATempTable(Camera parent, out FLR_ROIC_FPATEMP_TABLE_T table) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 64;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				table = new FLR_ROIC_FPATEMP_TABLE_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPATEMPTABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read table from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				table = byteToFLR_ROIC_FPATEMP_TABLE_T(receiveData,inPtr);
				inPtr+=64;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPATempTable()
			
			public static FLR_RESULT RoicSetFPATempValue(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFPATEMPVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFPATempValue()
			
			public static FLR_RESULT RoicGetFPATempValue(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFPATEMPVALUE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFPATempValue()
			
			public static FLR_RESULT RoicGetPreambleError(Camera parent, out UInt32 preambleError) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				preambleError = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETPREAMBLEERROR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read preambleError from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				preambleError = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetPreambleError()
			
			public static FLR_RESULT RoicInducePreambleError(Camera parent, UInt32 everyNthFrame) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write everyNthFrame to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(everyNthFrame,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_INDUCEPREAMBLEERROR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicInducePreambleError()
			
			public static FLR_RESULT RoicGetRoicStarted(Camera parent, out FLR_ENABLE_E roicStarted) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				roicStarted = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETROICSTARTED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read roicStarted from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				roicStarted = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetRoicStarted()
			
			public static FLR_RESULT RoicSetFrameSkip(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFRAMESKIP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFrameSkip()
			
			public static FLR_RESULT RoicGetFrameSkip(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_GETFRAMESKIP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicGetFrameSkip()
			
			public static FLR_RESULT RoicSetFrameOneShot(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.ROIC_SETFRAMEONESHOT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgRoicSetFrameOneShot()
			
			// End Module: roic
			
			// Begin Module: scaler
			public static FLR_RESULT ScalerGetMaxZoom(Camera parent, out UInt32 zoom) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				zoom = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCALER_GETMAXZOOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read zoom from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				zoom = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScalerGetMaxZoom()
			
			public static FLR_RESULT ScalerSetZoom(Camera parent, FLR_SCALER_ZOOM_PARAMS_T zoomParams) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 12;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write zoomParams to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SCALER_ZOOM_PARAMS_TToByte(zoomParams,sendData,outPtr);
				outPtr += 12;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCALER_SETZOOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScalerSetZoom()
			
			public static FLR_RESULT ScalerGetZoom(Camera parent, out FLR_SCALER_ZOOM_PARAMS_T zoomParams) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				zoomParams = new FLR_SCALER_ZOOM_PARAMS_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCALER_GETZOOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read zoomParams from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				zoomParams = byteToFLR_SCALER_ZOOM_PARAMS_T(receiveData,inPtr);
				inPtr+=12;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScalerGetZoom()
			
			public static FLR_RESULT ScalerSetFractionalZoom(Camera parent, UInt32 zoomNumerator, UInt32 zoomDenominator, UInt32 zoomXCenter, UInt32 zoomYCenter, FLR_ENABLE_E inChangeEnable, UInt32 zoomOutXCenter, UInt32 zoomOutYCenter, FLR_ENABLE_E outChangeEnable) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 32;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write zoomNumerator to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomNumerator,sendData,outPtr);
				outPtr += 4;
				
				//write zoomDenominator to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomDenominator,sendData,outPtr);
				outPtr += 4;
				
				//write zoomXCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomXCenter,sendData,outPtr);
				outPtr += 4;
				
				//write zoomYCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomYCenter,sendData,outPtr);
				outPtr += 4;
				
				//write inChangeEnable to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) inChangeEnable,sendData,outPtr);
				outPtr += 4;
				
				//write zoomOutXCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomOutXCenter,sendData,outPtr);
				outPtr += 4;
				
				//write zoomOutYCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomOutYCenter,sendData,outPtr);
				outPtr += 4;
				
				//write outChangeEnable to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) outChangeEnable,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCALER_SETFRACTIONALZOOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScalerSetFractionalZoom()
			
			public static FLR_RESULT ScalerSetIndexZoom(Camera parent, UInt32 zoomIndex, UInt32 zoomXCenter, UInt32 zoomYCenter, FLR_ENABLE_E inChangeEnable, UInt32 zoomOutXCenter, UInt32 zoomOutYCenter, FLR_ENABLE_E outChangeEnable) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 28;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write zoomIndex to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomIndex,sendData,outPtr);
				outPtr += 4;
				
				//write zoomXCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomXCenter,sendData,outPtr);
				outPtr += 4;
				
				//write zoomYCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomYCenter,sendData,outPtr);
				outPtr += 4;
				
				//write inChangeEnable to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) inChangeEnable,sendData,outPtr);
				outPtr += 4;
				
				//write zoomOutXCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomOutXCenter,sendData,outPtr);
				outPtr += 4;
				
				//write zoomOutYCenter to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(zoomOutYCenter,sendData,outPtr);
				outPtr += 4;
				
				//write outChangeEnable to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) outChangeEnable,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCALER_SETINDEXZOOM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScalerSetIndexZoom()
			
			// End Module: scaler
			
			// Begin Module: scnr
			public static FLR_RESULT ScnrSetEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetEnableState()
			
			public static FLR_RESULT ScnrGetEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetEnableState()
			
			public static FLR_RESULT ScnrSetThColSum(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETTHCOLSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetThColSum()
			
			public static FLR_RESULT ScnrGetThColSum(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETTHCOLSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetThColSum()
			
			public static FLR_RESULT ScnrSetThPixel(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETTHPIXEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetThPixel()
			
			public static FLR_RESULT ScnrGetThPixel(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETTHPIXEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetThPixel()
			
			public static FLR_RESULT ScnrSetMaxCorr(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetMaxCorr()
			
			public static FLR_RESULT ScnrGetMaxCorr(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetMaxCorr()
			
			public static FLR_RESULT ScnrGetThPixelApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETTHPIXELAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetThPixelApplied()
			
			public static FLR_RESULT ScnrGetMaxCorrApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETMAXCORRAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetMaxCorrApplied()
			
			public static FLR_RESULT ScnrSetThColSumSafe(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETTHCOLSUMSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetThColSumSafe()
			
			public static FLR_RESULT ScnrGetThColSumSafe(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETTHCOLSUMSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetThColSumSafe()
			
			public static FLR_RESULT ScnrSetThPixelSafe(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETTHPIXELSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetThPixelSafe()
			
			public static FLR_RESULT ScnrGetThPixelSafe(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETTHPIXELSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetThPixelSafe()
			
			public static FLR_RESULT ScnrSetMaxCorrSafe(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETMAXCORRSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetMaxCorrSafe()
			
			public static FLR_RESULT ScnrGetMaxCorrSafe(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETMAXCORRSAFE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetMaxCorrSafe()
			
			public static FLR_RESULT ScnrSetCorrectionMethod(Camera parent, FLR_SCNR_CORR_SELECT_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETCORRECTIONMETHOD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetCorrectionMethod()
			
			public static FLR_RESULT ScnrGetCorrectionMethod(Camera parent, out FLR_SCNR_CORR_SELECT_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SCNR_CORR_SELECT_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETCORRECTIONMETHOD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SCNR_CORR_SELECT_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetCorrectionMethod()
			
			public static FLR_RESULT ScnrSetStdThreshold(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSTDTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetStdThreshold()
			
			public static FLR_RESULT ScnrGetStdThreshold(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSTDTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetStdThreshold()
			
			public static FLR_RESULT ScnrSetNFrames(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETNFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetNFrames()
			
			public static FLR_RESULT ScnrGetNFrames(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETNFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetNFrames()
			
			public static FLR_RESULT ScnrSetResetDesired(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETRESETDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetResetDesired()
			
			public static FLR_RESULT ScnrGetResetDesired(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETRESETDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetResetDesired()
			
			public static FLR_RESULT ScnrSetM_modeOnly(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETM_MODEONLY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetM_modeOnly()
			
			public static FLR_RESULT ScnrGetM_modeOnly(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETM_MODEONLY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetM_modeOnly()
			
			public static FLR_RESULT ScnrGetMode(Camera parent, out FLR_SCNR_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SCNR_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SCNR_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetMode()
			
			public static FLR_RESULT ScnrSetSpecklesEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSPECKLESENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetSpecklesEnableState()
			
			public static FLR_RESULT ScnrGetSpecklesEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesEnableState()
			
			public static FLR_RESULT ScnrSetSpecklesThreshold(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSPECKLESTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetSpecklesThreshold()
			
			public static FLR_RESULT ScnrGetSpecklesThreshold(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesThreshold()
			
			public static FLR_RESULT ScnrSetSpecklesRatio(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSPECKLESRATIO, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetSpecklesRatio()
			
			public static FLR_RESULT ScnrGetSpecklesRatio(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESRATIO, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesRatio()
			
			public static FLR_RESULT ScnrSetSpecklesDF(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSPECKLESDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetSpecklesDF()
			
			public static FLR_RESULT ScnrGetSpecklesDF(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESDF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesDF()
			
			public static FLR_RESULT ScnrGetSpecklesDiffsBufferAddr(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESDIFFSBUFFERADDR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesDiffsBufferAddr()
			
			public static FLR_RESULT ScnrGetSpecklesOffsBufferAddr(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESOFFSBUFFERADDR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesOffsBufferAddr()
			
			public static FLR_RESULT ScnrSetSpecklesResetDesired(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_SETSPECKLESRESETDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrSetSpecklesResetDesired()
			
			public static FLR_RESULT ScnrGetSpecklesResetDesired(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SCNR_GETSPECKLESRESETDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgScnrGetSpecklesResetDesired()
			
			// End Module: scnr
			
			// Begin Module: sffc
			public static FLR_RESULT SffcGetScaleFactor(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETSCALEFACTOR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetScaleFactor()
			
			public static FLR_RESULT SffcGetDeltaTempLinearCoeff(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETDELTATEMPLINEARCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetDeltaTempLinearCoeff()
			
			public static FLR_RESULT SffcSetDeltaTempLinearCoeff(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_SETDELTATEMPLINEARCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcSetDeltaTempLinearCoeff()
			
			public static FLR_RESULT SffcGetDeltaTempOffsetCoeff(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETDELTATEMPOFFSETCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetDeltaTempOffsetCoeff()
			
			public static FLR_RESULT SffcSetDeltaTempOffsetCoeff(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_SETDELTATEMPOFFSETCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcSetDeltaTempOffsetCoeff()
			
			public static FLR_RESULT SffcGetFpaTempLinearCoeff(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETFPATEMPLINEARCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetFpaTempLinearCoeff()
			
			public static FLR_RESULT SffcSetFpaTempLinearCoeff(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_SETFPATEMPLINEARCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcSetFpaTempLinearCoeff()
			
			public static FLR_RESULT SffcGetFpaTempOffsetCoeff(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETFPATEMPOFFSETCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetFpaTempOffsetCoeff()
			
			public static FLR_RESULT SffcSetFpaTempOffsetCoeff(Camera parent, Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_SETFPATEMPOFFSETCOEFF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcSetFpaTempOffsetCoeff()
			
			public static FLR_RESULT SffcGetDeltaTempTimeLimitInSecs(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_GETDELTATEMPTIMELIMITINSECS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcGetDeltaTempTimeLimitInSecs()
			
			public static FLR_RESULT SffcSetDeltaTempTimeLimitInSecs(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SFFC_SETDELTATEMPTIMELIMITINSECS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSffcSetDeltaTempTimeLimitInSecs()
			
			// End Module: sffc
			
			// Begin Module: splashScreen
			public static FLR_RESULT SplashscreenSetDuration(Camera parent, UInt32 screen_num, UInt32 periodMs) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				//write periodMs to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(periodMs,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_SETDURATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenSetDuration()
			
			public static FLR_RESULT SplashscreenSetDataType(Camera parent, UInt32 screen_num, FLR_SPLASHSCREEN_FILETYPE_E filetype) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				//write filetype to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) filetype,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_SETDATATYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenSetDataType()
			
			public static FLR_RESULT SplashscreenSetBackground(Camera parent, UInt32 screen_num, UInt32 backgroundColor) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				//write backgroundColor to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(backgroundColor,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_SETBACKGROUND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenSetBackground()
			
			public static FLR_RESULT SplashscreenGetDuration(Camera parent, UInt32 screen_num, out UInt32 periodMs) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				periodMs = new UInt32();
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_GETDURATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read periodMs from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				periodMs = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenGetDuration()
			
			public static FLR_RESULT SplashscreenGetDataType(Camera parent, UInt32 screen_num, out FLR_SPLASHSCREEN_FILETYPE_E filetype) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				filetype = new FLR_SPLASHSCREEN_FILETYPE_E();
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_GETDATATYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read filetype from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				filetype = (FLR_SPLASHSCREEN_FILETYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenGetDataType()
			
			public static FLR_RESULT SplashscreenGetBackground(Camera parent, UInt32 screen_num, out UInt32 backgroundColor) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				backgroundColor = new UInt32();
				
				//write screen_num to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(screen_num,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPLASHSCREEN_GETBACKGROUND, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read backgroundColor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				backgroundColor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSplashscreenGetBackground()
			
			// End Module: splashScreen
			
			// Begin Module: spnr
			public static FLR_RESULT SpnrSetEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetEnableState()
			
			public static FLR_RESULT SpnrGetEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetEnableState()
			
			public static FLR_RESULT SpnrGetState(Camera parent, out FLR_SPNR_STATE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SPNR_STATE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SPNR_STATE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetState()
			
			public static FLR_RESULT SpnrSetFrameDelay(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETFRAMEDELAY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetFrameDelay()
			
			public static FLR_RESULT SpnrGetFrameDelay(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETFRAMEDELAY, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetFrameDelay()
			
			public static FLR_RESULT SpnrGetSFApplied(Camera parent, out Double sf) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				sf = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETSFAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read sf from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				sf = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetSFApplied()
			
			public static FLR_RESULT SpnrSetPSDKernel(Camera parent, FLR_SPNR_PSD_KERNEL_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 256;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SPNR_PSD_KERNEL_TToByte(data,sendData,outPtr);
				outPtr += 256;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETPSDKERNEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetPSDKernel()
			
			public static FLR_RESULT SpnrGetPSDKernel(Camera parent, out FLR_SPNR_PSD_KERNEL_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 256;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SPNR_PSD_KERNEL_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETPSDKERNEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_SPNR_PSD_KERNEL_T(receiveData,inPtr);
				inPtr+=256;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetPSDKernel()
			
			public static FLR_RESULT SpnrSetSFMin(Camera parent, Double sfmin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write sfmin to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(sfmin,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETSFMIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetSFMin()
			
			public static FLR_RESULT SpnrGetSFMin(Camera parent, out Double sfmin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				sfmin = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETSFMIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read sfmin from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				sfmin = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetSFMin()
			
			public static FLR_RESULT SpnrSetSFMax(Camera parent, Double sfmax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write sfmax to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(sfmax,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETSFMAX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetSFMax()
			
			public static FLR_RESULT SpnrGetSFMax(Camera parent, out Double sfmax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				sfmax = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETSFMAX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read sfmax from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				sfmax = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetSFMax()
			
			public static FLR_RESULT SpnrSetDFMin(Camera parent, Double dfmin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write dfmin to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(dfmin,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETDFMIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetDFMin()
			
			public static FLR_RESULT SpnrGetDFMin(Camera parent, out Double dfmin) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				dfmin = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETDFMIN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read dfmin from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				dfmin = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetDFMin()
			
			public static FLR_RESULT SpnrSetDFMax(Camera parent, Double dfmax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write dfmax to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(dfmax,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETDFMAX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetDFMax()
			
			public static FLR_RESULT SpnrGetDFMax(Camera parent, out Double dfmax) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				dfmax = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETDFMAX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read dfmax from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				dfmax = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetDFMax()
			
			public static FLR_RESULT SpnrSetNormTarget(Camera parent, Double normTarget) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write normTarget to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(normTarget,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETNORMTARGET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetNormTarget()
			
			public static FLR_RESULT SpnrGetNormTarget(Camera parent, out Double normTarget) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				normTarget = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETNORMTARGET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read normTarget from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				normTarget = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetNormTarget()
			
			public static FLR_RESULT SpnrGetNormTargetApplied(Camera parent, out Double normTargetApplied) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				normTargetApplied = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETNORMTARGETAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read normTargetApplied from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				normTargetApplied = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetNormTargetApplied()
			
			public static FLR_RESULT SpnrSetThPix(Camera parent, UInt16 th_pix) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write th_pix to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(th_pix,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETTHPIX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetThPix()
			
			public static FLR_RESULT SpnrGetThPix(Camera parent, out UInt16 th_pix) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				th_pix = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETTHPIX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read th_pix from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				th_pix = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetThPix()
			
			public static FLR_RESULT SpnrSetThPixSum(Camera parent, UInt16 th_pixSum) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write th_pixSum to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(th_pixSum,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETTHPIXSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetThPixSum()
			
			public static FLR_RESULT SpnrGetThPixSum(Camera parent, out UInt16 th_pixSum) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				th_pixSum = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETTHPIXSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read th_pixSum from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				th_pixSum = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetThPixSum()
			
			public static FLR_RESULT SpnrSetMaxcorr(Camera parent, UInt16 maxcorr) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write maxcorr to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(maxcorr,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetMaxcorr()
			
			public static FLR_RESULT SpnrGetMaxcorr(Camera parent, out UInt16 maxcorr) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				maxcorr = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read maxcorr from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				maxcorr = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetMaxcorr()
			
			public static FLR_RESULT SpnrGetAlgorithm(Camera parent, out FLR_SPNR_ALGORITHM_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SPNR_ALGORITHM_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETALGORITHM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SPNR_ALGORITHM_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetAlgorithm()
			
			public static FLR_RESULT SpnrSetAlgorithmDesired(Camera parent, FLR_SPNR_ALGORITHM_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_SETALGORITHMDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrSetAlgorithmDesired()
			
			public static FLR_RESULT SpnrGetAlgorithmDesired(Camera parent, out FLR_SPNR_ALGORITHM_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SPNR_ALGORITHM_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPNR_GETALGORITHMDESIRED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SPNR_ALGORITHM_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpnrGetAlgorithmDesired()
			
			// End Module: spnr
			
			// Begin Module: spotMeter
			public static FLR_RESULT SpotmeterSetEnable(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_SETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterSetEnable()
			
			public static FLR_RESULT SpotmeterGetEnable(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetEnable()
			
			public static FLR_RESULT SpotmeterGetRoiMaxSize(Camera parent, out UInt16 width, out UInt16 height) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				width = new UInt16();
				height = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETROIMAXSIZE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read width from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				width = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read height from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				height = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetRoiMaxSize()
			
			public static FLR_RESULT SpotmeterSetRoi(Camera parent, FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write roi to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_ROI_TToByte(roi,sendData,outPtr);
				outPtr += 8;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_SETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterSetRoi()
			
			public static FLR_RESULT SpotmeterGetRoi(Camera parent, out FLR_ROI_T roi) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 8;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				roi = new FLR_ROI_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETROI, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read roi from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				roi = byteToFLR_ROI_T(receiveData,inPtr);
				inPtr+=8;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetRoi()
			
			public static FLR_RESULT SpotmeterGetSpotStats(Camera parent, out UInt16 mean, out UInt16 deviation, out FLR_SPOTMETER_SPOT_PARAM_T min, out FLR_SPOTMETER_SPOT_PARAM_T max) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 16;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mean = new UInt16();
				deviation = new UInt16();
				min = new FLR_SPOTMETER_SPOT_PARAM_T();
				max = new FLR_SPOTMETER_SPOT_PARAM_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETSPOTSTATS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mean from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mean = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read deviation from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				deviation = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				// read min from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				min = byteToFLR_SPOTMETER_SPOT_PARAM_T(receiveData,inPtr);
				inPtr+=6;
				
				// read max from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				max = byteToFLR_SPOTMETER_SPOT_PARAM_T(receiveData,inPtr);
				inPtr+=6;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetSpotStats()
			
			public static FLR_RESULT SpotmeterSetStatsMode(Camera parent, FLR_SPOTMETER_STATS_TEMP_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write mode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) mode,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_SETSTATSMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterSetStatsMode()
			
			public static FLR_RESULT SpotmeterGetStatsMode(Camera parent, out FLR_SPOTMETER_STATS_TEMP_MODE_E mode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mode = new FLR_SPOTMETER_STATS_TEMP_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETSTATSMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mode from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mode = (FLR_SPOTMETER_STATS_TEMP_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetStatsMode()
			
			public static FLR_RESULT SpotmeterGetTempStats(Camera parent, out Double mean, out Double deviation, out FLR_SPOTMETER_STAT_PARAM_TEMP_T min, out FLR_SPOTMETER_STAT_PARAM_TEMP_T max) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 24;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				mean = new Double();
				deviation = new Double();
				min = new FLR_SPOTMETER_STAT_PARAM_TEMP_T();
				max = new FLR_SPOTMETER_STAT_PARAM_TEMP_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SPOTMETER_GETTEMPSTATS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read mean from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				mean = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read deviation from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				deviation = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				// read min from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				min = byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T(receiveData,inPtr);
				inPtr+=8;
				
				// read max from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				max = byteToFLR_SPOTMETER_STAT_PARAM_TEMP_T(receiveData,inPtr);
				inPtr+=8;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSpotmeterGetTempStats()
			
			// End Module: spotMeter
			
			// Begin Module: srnr
			public static FLR_RESULT SrnrSetEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_SETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrSetEnableState()
			
			public static FLR_RESULT SrnrGetEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetEnableState()
			
			public static FLR_RESULT SrnrSetThRowSum(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_SETTHROWSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrSetThRowSum()
			
			public static FLR_RESULT SrnrGetThRowSum(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETTHROWSUM, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetThRowSum()
			
			public static FLR_RESULT SrnrSetThPixel(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_SETTHPIXEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrSetThPixel()
			
			public static FLR_RESULT SrnrGetThPixel(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETTHPIXEL, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetThPixel()
			
			public static FLR_RESULT SrnrSetMaxCorr(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_SETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrSetMaxCorr()
			
			public static FLR_RESULT SrnrGetMaxCorr(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETMAXCORR, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetMaxCorr()
			
			public static FLR_RESULT SrnrGetThPixelApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETTHPIXELAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetThPixelApplied()
			
			public static FLR_RESULT SrnrGetMaxCorrApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SRNR_GETMAXCORRAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSrnrGetMaxCorrApplied()
			
			// End Module: srnr
			
			// Begin Module: symbology
			public static FLR_RESULT SymbologySetEnable(Camera parent, FLR_ENABLE_E draw_symbols) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write draw_symbols to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) draw_symbols,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySetEnable()
			
			public static FLR_RESULT SymbologyCreateBitmap(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 9;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEBITMAP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateBitmap()
			
			public static FLR_RESULT SymbologySendData(Camera parent, Byte ID, Int16 size, Byte[] text) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 131;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write size to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(size,sendData,outPtr);
				outPtr += 2;
				
				//write text to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(text,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SENDDATA, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySendData()
			
			public static FLR_RESULT SymbologyCreateArc(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, Double start_angle, Double end_angle, UInt32 color) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 21;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write start_angle to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(start_angle,sendData,outPtr);
				outPtr += 4;
				
				//write end_angle to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLOATToByte(end_angle,sendData,outPtr);
				outPtr += 4;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEARC, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateArc()
			
			public static FLR_RESULT SymbologyCreateText(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color, Byte[] text) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 146;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write font to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				CHARToByte(font,sendData,outPtr);
				outPtr += 1;
				
				//write size to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(size,sendData,outPtr);
				outPtr += 2;
				
				//write alignment to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) alignment,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				//write text to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(text,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATETEXT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateText()
			
			public static FLR_RESULT SymbologyMoveSprite(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 5;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_MOVESPRITE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyMoveSprite()
			
			public static FLR_RESULT SymbologyAddToGroup(Camera parent, Byte ID, Byte group_ID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write group_ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(group_ID,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_ADDTOGROUP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyAddToGroup()
			
			public static FLR_RESULT SymbologyRemoveFromGroup(Camera parent, Byte ID, Byte group_ID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write group_ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(group_ID,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_REMOVEFROMGROUP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyRemoveFromGroup()
			
			public static FLR_RESULT SymbologyUpdateAndShow(Camera parent, Byte ID, Byte visible) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write visible to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(visible,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_UPDATEANDSHOW, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyUpdateAndShow()
			
			public static FLR_RESULT SymbologyUpdateAndShowGroup(Camera parent, Byte group_ID, Byte visible) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write group_ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(group_ID,sendData,outPtr);
				outPtr += 1;
				
				//write visible to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(visible,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_UPDATEANDSHOWGROUP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyUpdateAndShowGroup()
			
			public static FLR_RESULT SymbologyDelete(Camera parent, Byte ID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_DELETE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyDelete()
			
			public static FLR_RESULT SymbologyDeleteGroup(Camera parent, Byte group_ID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write group_ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(group_ID,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_DELETEGROUP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyDeleteGroup()
			
			public static FLR_RESULT SymbologyCreateFilledRectangle(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 13;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEFILLEDRECTANGLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateFilledRectangle()
			
			public static FLR_RESULT SymbologyCreateOutlinedRectangle(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 13;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEOUTLINEDRECTANGLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateOutlinedRectangle()
			
			public static FLR_RESULT SymbologyCreateBitmapFromPng(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 size) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 7;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write size to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(size,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEBITMAPFROMPNG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateBitmapFromPng()
			
			public static FLR_RESULT SymbologyCreateCompressedBitmap(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 9;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATECOMPRESSEDBITMAP, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateCompressedBitmap()
			
			public static FLR_RESULT SymbologyCreateBitmapFromPngFile(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Byte[] path) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 133;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEBITMAPFROMPNGFILE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateBitmapFromPngFile()
			
			public static FLR_RESULT SymbologyCreateBitmapFromFile(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Byte[] path, FLR_SYMBOLOGY_IMAGE_TYPE_E imageType) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 135;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				//write imageType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) imageType,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEBITMAPFROMFILE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateBitmapFromFile()
			
			public static FLR_RESULT SymbologyResetWritePosition(Camera parent, Byte ID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_RESETWRITEPOSITION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyResetWritePosition()
			
			public static FLR_RESULT SymbologyMoveByOffset(Camera parent, Byte ID, Int16 off_X, Int16 off_Y) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 5;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write off_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(off_X,sendData,outPtr);
				outPtr += 2;
				
				//write off_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(off_Y,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_MOVEBYOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyMoveByOffset()
			
			public static FLR_RESULT SymbologyMoveGroupByOffset(Camera parent, Byte ID, Int16 off_X, Int16 off_Y) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 5;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write off_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(off_X,sendData,outPtr);
				outPtr += 2;
				
				//write off_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(off_Y,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_MOVEGROUPBYOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyMoveGroupByOffset()
			
			public static FLR_RESULT SymbologyCreateFilledEllipse(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 13;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATEFILLEDELLIPSE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateFilledEllipse()
			
			public static FLR_RESULT SymbologyCreateLine(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 pos_X2, Int16 pos_Y2, UInt32 color) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 13;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write pos_X2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X2,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y2,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATELINE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateLine()
			
			public static FLR_RESULT SymbologySetZorder(Camera parent, Byte ID, Byte zorder) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write zorder to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(zorder,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SETZORDER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySetZorder()
			
			public static FLR_RESULT SymbologySaveConfiguration(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SAVECONFIGURATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySaveConfiguration()
			
			public static FLR_RESULT SymbologyReloadConfiguration(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_RELOADCONFIGURATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyReloadConfiguration()
			
			public static FLR_RESULT SymbologyGetEnable(Camera parent, out FLR_ENABLE_E draw_symbols) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				draw_symbols = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_GETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read draw_symbols from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				draw_symbols = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyGetEnable()
			
			public static FLR_RESULT SymbologySetClonesNumber(Camera parent, Byte ID, Byte numberOfClones) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write numberOfClones to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(numberOfClones,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SETCLONESNUMBER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySetClonesNumber()
			
			public static FLR_RESULT SymbologyMoveCloneByOffset(Camera parent, Byte ID, Byte cloneID, Int16 pos_X, Int16 pos_Y) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 6;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write cloneID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(cloneID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_MOVECLONEBYOFFSET, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyMoveCloneByOffset()
			
			public static FLR_RESULT SymbologyMoveCloneSprite(Camera parent, Byte ID, Byte cloneID, Int16 pos_X, Int16 pos_Y) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 6;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write cloneID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(cloneID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_MOVECLONESPRITE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyMoveCloneSprite()
			
			public static FLR_RESULT SymbologySetTransformation(Camera parent, FLR_SYMBOLOGY_TRANSFORMATION_E transformation) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write transformation to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) transformation,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SETTRANSFORMATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySetTransformation()
			
			public static FLR_RESULT SymbologyUpdateAllVisible(Camera parent) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_UPDATEALLVISIBLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyUpdateAllVisible()
			
			public static FLR_RESULT SymbologySetSizeAndScalingMode(Camera parent, Byte ID, Int16 width, Int16 height, FLR_SYMBOLOGY_SCALING_MODE_E scalingMode) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 7;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write scalingMode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) scalingMode,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_SETSIZEANDSCALINGMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologySetSizeAndScalingMode()
			
			public static FLR_RESULT SymbologyCreateLineHVT(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 pos_X2, Int16 pos_Y2, UInt32 color1, UInt32 color2, UInt16 dashLen, UInt16 thickness) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 21;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write pos_X2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X2,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y2,sendData,outPtr);
				outPtr += 2;
				
				//write color1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color1,sendData,outPtr);
				outPtr += 4;
				
				//write color2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color2,sendData,outPtr);
				outPtr += 4;
				
				//write dashLen to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(dashLen,sendData,outPtr);
				outPtr += 2;
				
				//write thickness to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(thickness,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATELINEHVT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateLineHVT()
			
			public static FLR_RESULT SymbologyCreateTextHVT(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color1, UInt32 color2, Byte dashLen, Byte[] text) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 151;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write font to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				CHARToByte(font,sendData,outPtr);
				outPtr += 1;
				
				//write size to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(size,sendData,outPtr);
				outPtr += 2;
				
				//write alignment to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) alignment,sendData,outPtr);
				outPtr += 2;
				
				//write color1 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color1,sendData,outPtr);
				outPtr += 4;
				
				//write color2 to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color2,sendData,outPtr);
				outPtr += 4;
				
				//write dashLen to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(dashLen,sendData,outPtr);
				outPtr += 1;
				
				//write text to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(text,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATETEXTHVT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateTextHVT()
			
			public static FLR_RESULT SymbologyCreateTextBg(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color, UInt32 bgColor, Byte[] text) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 150;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write font to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				CHARToByte(font,sendData,outPtr);
				outPtr += 1;
				
				//write size to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(size,sendData,outPtr);
				outPtr += 2;
				
				//write alignment to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) alignment,sendData,outPtr);
				outPtr += 2;
				
				//write color to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(color,sendData,outPtr);
				outPtr += 4;
				
				//write bgColor to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(bgColor,sendData,outPtr);
				outPtr += 4;
				
				//write text to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(text,128,sendData,outPtr);
				outPtr += 128;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATETEXTBG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateTextBg()
			
			public static FLR_RESULT SymbologyCreateScaledBitmapFromFile(Camera parent, Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, FLR_SYMBOLOGY_SCALING_MODE_E scalingMode, Byte[] path, FLR_SYMBOLOGY_IMAGE_TYPE_E imageType) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 141;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write ID to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(ID,sendData,outPtr);
				outPtr += 1;
				
				//write pos_X to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_X,sendData,outPtr);
				outPtr += 2;
				
				//write pos_Y to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(pos_Y,sendData,outPtr);
				outPtr += 2;
				
				//write width to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(width,sendData,outPtr);
				outPtr += 2;
				
				//write height to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte(height,sendData,outPtr);
				outPtr += 2;
				
				//write scalingMode to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) scalingMode,sendData,outPtr);
				outPtr += 2;
				
				//write path to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARArrayToByte(path,128,sendData,outPtr);
				outPtr += 128;
				
				//write imageType to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_16ToByte((Int16) imageType,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYMBOLOGY_CREATESCALEDBITMAPFROMFILE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSymbologyCreateScaledBitmapFromFile()
			
			// End Module: symbology
			
			// Begin Module: sysctrl
			public static FLR_RESULT SysctrlSetFreezeState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_SETFREEZESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlSetFreezeState()
			
			public static FLR_RESULT SysctrlGetFreezeState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETFREEZESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetFreezeState()
			
			public static FLR_RESULT SysctrlGetCameraFrameRate(Camera parent, out UInt32 frameRate) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				frameRate = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETCAMERAFRAMERATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read frameRate from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				frameRate = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetCameraFrameRate()
			
			public static FLR_RESULT SysctrlGetUptimeSecs(Camera parent, out UInt32 uptime) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				uptime = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETUPTIMESECS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read uptime from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				uptime = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetUptimeSecs()
			
			public static FLR_RESULT SysctrlSetUsbVideoIR16Mode(Camera parent, FLR_SYSCTRL_USBIR16_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_SETUSBVIDEOIR16MODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlSetUsbVideoIR16Mode()
			
			public static FLR_RESULT SysctrlGetUsbVideoIR16Mode(Camera parent, out FLR_SYSCTRL_USBIR16_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SYSCTRL_USBIR16_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETUSBVIDEOIR16MODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SYSCTRL_USBIR16_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetUsbVideoIR16Mode()
			
			public static FLR_RESULT SysctrlSetOperatingMode(Camera parent, FLR_SYSCTRL_OPERATING_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_SETOPERATINGMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlSetOperatingMode()
			
			public static FLR_RESULT SysctrlGetOperatingMode(Camera parent, out FLR_SYSCTRL_OPERATING_MODE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_SYSCTRL_OPERATING_MODE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETOPERATINGMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_SYSCTRL_OPERATING_MODE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetOperatingMode()
			
			public static FLR_RESULT SysctrlGetAvgFpaTempCounts(Camera parent, out Double data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Double();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETAVGFPATEMPCOUNTS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLOAT(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetAvgFpaTempCounts()
			
			public static FLR_RESULT SysctrlSetFpaTempFrames(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_SETFPATEMPFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlSetFpaTempFrames()
			
			public static FLR_RESULT SysctrlGetFpaTempFrames(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSCTRL_GETFPATEMPFRAMES, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysctrlGetFpaTempFrames()
			
			// End Module: sysctrl
			
			// Begin Module: sysinfo
			public static FLR_RESULT SysinfoGetMonitorSoftwareRev(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETMONITORSOFTWAREREV, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetMonitorSoftwareRev()
			
			public static FLR_RESULT SysinfoGetMonitorBuildVariant(Camera parent, out FLR_SYSINFO_MONITOR_BUILD_VARIANT_T monitorBuildVariant) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 50;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				monitorBuildVariant = new FLR_SYSINFO_MONITOR_BUILD_VARIANT_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETMONITORBUILDVARIANT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read monitorBuildVariant from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				monitorBuildVariant = byteToFLR_SYSINFO_MONITOR_BUILD_VARIANT_T(receiveData,inPtr);
				inPtr+=50;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetMonitorBuildVariant()
			
			public static FLR_RESULT SysinfoGetProductName(Camera parent, out Byte[] name) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				name = new Byte[128];
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETPRODUCTNAME, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read name from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				name = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetProductName()
			
			public static FLR_RESULT SysinfoGetCameraSN(Camera parent, out Byte[] number) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				number = new Byte[128];
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETCAMERASN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read number from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				number = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetCameraSN()
			
			public static FLR_RESULT SysinfoGetBootLocation(Camera parent, out UInt32 bootSwLocation) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				bootSwLocation = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETBOOTLOCATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read bootSwLocation from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				bootSwLocation = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetBootLocation()
			
			public static FLR_RESULT SysinfoGetSwConfigID(Camera parent, out FLR_SYSINFO_SW_CONFIG_ID_E swConfigID) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				swConfigID = new FLR_SYSINFO_SW_CONFIG_ID_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETSWCONFIGID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read swConfigID from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				swConfigID = (FLR_SYSINFO_SW_CONFIG_ID_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetSwConfigID()
			
			public static FLR_RESULT SysinfoGetSwPermissions(Camera parent, out FLR_SYSINFO_SW_PERMISSIONS_E swPermissions) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				swPermissions = new FLR_SYSINFO_SW_PERMISSIONS_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETSWPERMISSIONS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read swPermissions from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				swPermissions = (FLR_SYSINFO_SW_PERMISSIONS_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetSwPermissions()
			
			public static FLR_RESULT SysinfoGetIs9HzBuild(Camera parent, out UInt32 is9HzBuild) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				is9HzBuild = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETIS9HZBUILD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read is9HzBuild from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				is9HzBuild = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetIs9HzBuild()
			
			public static FLR_RESULT SysinfoGetProductVersion(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETPRODUCTVERSION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetProductVersion()
			
			public static FLR_RESULT SysinfoGetMonitorProductRev(Camera parent, out UInt32 major, out UInt32 minor, out UInt32 patch) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 12;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				major = new UInt32();
				minor = new UInt32();
				patch = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETMONITORPRODUCTREV, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read major from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				major = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read minor from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				minor = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				// read patch from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				patch = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetMonitorProductRev()
			
			public static FLR_RESULT SysinfoGetOpticalRevision(Camera parent, out UInt16 revision) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				revision = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETOPTICALREVISION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read revision from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				revision = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetOpticalRevision()
			
			public static FLR_RESULT SysinfoGetSensorRevision(Camera parent, out UInt16 revision) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				revision = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETSENSORREVISION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read revision from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				revision = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetSensorRevision()
			
			public static FLR_RESULT SysinfoGetProbeTipSN(Camera parent, out Byte[] number) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 128;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				number = new Byte[128];
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETPROBETIPSN, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read number from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				number = byteToUCHARArray(receiveData,inPtr,128);
				inPtr+=128;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetProbeTipSN()
			
			public static FLR_RESULT SysinfoGetMechanicalRevision(Camera parent, out UInt16 revision) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				revision = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSINFO_GETMECHANICALREVISION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read revision from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				revision = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSysinfoGetMechanicalRevision()
			
			// End Module: sysinfo
			
			// Begin Module: systemSymbols
			public static FLR_RESULT SystemsymbolsGetID(Camera parent, FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, out Byte id, out FLR_SYSTEMSYMBOLS_ID_TYPE_E id_type) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 5;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				id = new Byte();
				id_type = new FLR_SYSTEMSYMBOLS_ID_TYPE_E();
				
				//write symbol to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) symbol,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_GETID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read id from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				id = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				// read id_type from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				id_type = (FLR_SYSTEMSYMBOLS_ID_TYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsGetID()
			
			public static FLR_RESULT SystemsymbolsSetID(Camera parent, FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, Byte id, FLR_SYSTEMSYMBOLS_ID_TYPE_E id_type) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 9;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write symbol to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) symbol,sendData,outPtr);
				outPtr += 4;
				
				//write id to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(id,sendData,outPtr);
				outPtr += 1;
				
				//write id_type to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) id_type,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_SETID, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsSetID()
			
			public static FLR_RESULT SystemsymbolsGetEnable(Camera parent, FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, out FLR_ENABLE_E enabled) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				enabled = new FLR_ENABLE_E();
				
				//write symbol to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) symbol,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_GETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read enabled from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				enabled = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsGetEnable()
			
			public static FLR_RESULT SystemsymbolsSetEnable(Camera parent, FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, FLR_ENABLE_E enabled) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 8;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write symbol to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) symbol,sendData,outPtr);
				outPtr += 4;
				
				//write enabled to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) enabled,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_SETENABLE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsSetEnable()
			
			public static FLR_RESULT SystemsymbolsGetSpotConfig(Camera parent, out FLR_SYSTEMSYMBOLS_SPOTCONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 195;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				config = new FLR_SYSTEMSYMBOLS_SPOTCONFIG_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_GETSPOTCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read config from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				config = byteToFLR_SYSTEMSYMBOLS_SPOTCONFIG_T(receiveData,inPtr);
				inPtr+=195;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsGetSpotConfig()
			
			public static FLR_RESULT SystemsymbolsSetSpotConfig(Camera parent, FLR_SYSTEMSYMBOLS_SPOTCONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 195;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write config to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SYSTEMSYMBOLS_SPOTCONFIG_TToByte(config,sendData,outPtr);
				outPtr += 195;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_SETSPOTCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsSetSpotConfig()
			
			public static FLR_RESULT SystemsymbolsGetIsoConfig(Camera parent, out FLR_SYSTEMSYMBOLS_ISOCONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 45;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				config = new FLR_SYSTEMSYMBOLS_ISOCONFIG_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_GETISOCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read config from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				config = byteToFLR_SYSTEMSYMBOLS_ISOCONFIG_T(receiveData,inPtr);
				inPtr+=45;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsGetIsoConfig()
			
			public static FLR_RESULT SystemsymbolsSetIsoConfig(Camera parent, FLR_SYSTEMSYMBOLS_ISOCONFIG_T config) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 45;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write config to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SYSTEMSYMBOLS_ISOCONFIG_TToByte(config,sendData,outPtr);
				outPtr += 45;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_SETISOCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsSetIsoConfig()
			
			public static FLR_RESULT SystemsymbolsGetBarConfig(Camera parent, out FLR_SYSTEMSYMBOLS_BARCONFIG_T lowGainConfig, out FLR_SYSTEMSYMBOLS_BARCONFIG_T highGainConfig, out FLR_TEMPERATURE_UNIT_E unit) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 24;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				lowGainConfig = new FLR_SYSTEMSYMBOLS_BARCONFIG_T();
				highGainConfig = new FLR_SYSTEMSYMBOLS_BARCONFIG_T();
				unit = new FLR_TEMPERATURE_UNIT_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_GETBARCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read lowGainConfig from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				lowGainConfig = byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T(receiveData,inPtr);
				inPtr+=10;
				
				// read highGainConfig from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				highGainConfig = byteToFLR_SYSTEMSYMBOLS_BARCONFIG_T(receiveData,inPtr);
				inPtr+=10;
				
				// read unit from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				unit = (FLR_TEMPERATURE_UNIT_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsGetBarConfig()
			
			public static FLR_RESULT SystemsymbolsSetBarConfig(Camera parent, FLR_SYSTEMSYMBOLS_BARCONFIG_T lowGainConfig, FLR_SYSTEMSYMBOLS_BARCONFIG_T highGainConfig, FLR_TEMPERATURE_UNIT_E unit) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 24;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write lowGainConfig to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(lowGainConfig,sendData,outPtr);
				outPtr += 10;
				
				//write highGainConfig to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_SYSTEMSYMBOLS_BARCONFIG_TToByte(highGainConfig,sendData,outPtr);
				outPtr += 10;
				
				//write unit to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) unit,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.SYSTEMSYMBOLS_SETBARCONFIG, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgSystemsymbolsSetBarConfig()
			
			// End Module: systemSymbols
			
			// Begin Module: telemetry
			public static FLR_RESULT TelemetrySetState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_SETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetrySetState()
			
			public static FLR_RESULT TelemetryGetState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_GETSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetryGetState()
			
			public static FLR_RESULT TelemetrySetLocation(Camera parent, FLR_TELEMETRY_LOC_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_SETLOCATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetrySetLocation()
			
			public static FLR_RESULT TelemetryGetLocation(Camera parent, out FLR_TELEMETRY_LOC_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TELEMETRY_LOC_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_GETLOCATION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_TELEMETRY_LOC_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetryGetLocation()
			
			public static FLR_RESULT TelemetrySetPacking(Camera parent, FLR_TELEMETRY_PACKING_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_SETPACKING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetrySetPacking()
			
			public static FLR_RESULT TelemetryGetPacking(Camera parent, out FLR_TELEMETRY_PACKING_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TELEMETRY_PACKING_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_GETPACKING, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_TELEMETRY_PACKING_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetryGetPacking()
			
			public static FLR_RESULT TelemetrySetOrder(Camera parent, FLR_TELEMETRY_ORDER_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_SETORDER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetrySetOrder()
			
			public static FLR_RESULT TelemetryGetOrder(Camera parent, out FLR_TELEMETRY_ORDER_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TELEMETRY_ORDER_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TELEMETRY_GETORDER, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_TELEMETRY_ORDER_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTelemetryGetOrder()
			
			// End Module: telemetry
			
			// Begin Module: testRamp
			public static FLR_RESULT TestrampSetType(Camera parent, Byte index, FLR_TESTRAMP_TYPE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 5;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_SETTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampSetType()
			
			public static FLR_RESULT TestrampGetType(Camera parent, Byte index, out FLR_TESTRAMP_TYPE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TESTRAMP_TYPE_E();
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETTYPE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_TESTRAMP_TYPE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetType()
			
			public static FLR_RESULT TestrampSetSettings(Camera parent, Byte index, FLR_TESTRAMP_SETTINGS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 7;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_TESTRAMP_SETTINGS_TToByte(data,sendData,outPtr);
				outPtr += 6;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_SETSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampSetSettings()
			
			public static FLR_RESULT TestrampGetSettings(Camera parent, Byte index, out FLR_TESTRAMP_SETTINGS_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 6;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TESTRAMP_SETTINGS_T();
				
				//write index to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(index,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETSETTINGS, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_TESTRAMP_SETTINGS_T(receiveData,inPtr);
				inPtr+=6;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetSettings()
			
			public static FLR_RESULT TestrampSetMotionState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_SETMOTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampSetMotionState()
			
			public static FLR_RESULT TestrampGetMotionState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETMOTIONSTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetMotionState()
			
			public static FLR_RESULT TestrampSetIndex(Camera parent, Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 1;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UCHARToByte(data,sendData,outPtr);
				outPtr += 1;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_SETINDEX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampSetIndex()
			
			public static FLR_RESULT TestrampGetIndex(Camera parent, out Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETINDEX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetIndex()
			
			public static FLR_RESULT TestrampGetMaxIndex(Camera parent, out Byte data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 1;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new Byte();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETMAXINDEX, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUCHAR(receiveData,inPtr);
				inPtr+=1;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetMaxIndex()
			
			public static FLR_RESULT TestrampSetPN9ContinuousMode(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_SETPN9CONTINUOUSMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampSetPN9ContinuousMode()
			
			public static FLR_RESULT TestrampGetPN9ContinuousMode(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TESTRAMP_GETPN9CONTINUOUSMODE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTestrampGetPN9ContinuousMode()
			
			// End Module: testRamp
			
			// Begin Module: tf
			public static FLR_RESULT TfSetEnableState(Camera parent, FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetEnableState()
			
			public static FLR_RESULT TfGetEnableState(Camera parent, out FLR_ENABLE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_ENABLE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETENABLESTATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_ENABLE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetEnableState()
			
			public static FLR_RESULT TfSetDelta_nf(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETDELTA_NF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetDelta_nf()
			
			public static FLR_RESULT TfGetDelta_nf(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETDELTA_NF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetDelta_nf()
			
			public static FLR_RESULT TfSetTHDeltaMotion(Camera parent, UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 2;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_16ToByte(data,sendData,outPtr);
				outPtr += 2;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETTHDELTAMOTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetTHDeltaMotion()
			
			public static FLR_RESULT TfGetTHDeltaMotion(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETTHDELTAMOTION, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetTHDeltaMotion()
			
			public static FLR_RESULT TfSetWLut(Camera parent, FLR_TF_WLUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 32;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_TF_WLUT_TToByte(data,sendData,outPtr);
				outPtr += 32;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETWLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetWLut()
			
			public static FLR_RESULT TfGetWLut(Camera parent, out FLR_TF_WLUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 32;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TF_WLUT_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETWLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_TF_WLUT_T(receiveData,inPtr);
				inPtr+=32;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetWLut()
			
			public static FLR_RESULT TfGetMotionCount(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETMOTIONCOUNT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetMotionCount()
			
			public static FLR_RESULT TfSetMotionThreshold(Camera parent, UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				UINT_32ToByte(data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETMOTIONTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetMotionThreshold()
			
			public static FLR_RESULT TfGetMotionThreshold(Camera parent, out UInt32 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt32();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETMOTIONTHRESHOLD, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetMotionThreshold()
			
			public static FLR_RESULT TfGetDelta_nfApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETDELTA_NFAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetDelta_nfApplied()
			
			public static FLR_RESULT TfGetTHDeltaMotionApplied(Camera parent, out UInt16 data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETTHDELTAMOTIONAPPLIED, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetTHDeltaMotionApplied()
			
			public static FLR_RESULT TfSetTempSignalCompFactorLut(Camera parent, FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 34;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_TToByte(data,sendData,outPtr);
				outPtr += 34;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_SETTEMPSIGNALCOMPFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfSetTempSignalCompFactorLut()
			
			public static FLR_RESULT TfGetTempSignalCompFactorLut(Camera parent, out FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 34;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETTEMPSIGNALCOMPFACTORLUT, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = byteToFLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T(receiveData,inPtr);
				inPtr+=34;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetTempSignalCompFactorLut()
			
			public static FLR_RESULT TfGetRnf(Camera parent, out UInt16 rnf) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 2;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				rnf = new UInt16();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.TF_GETRNF, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read rnf from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				rnf = byteToUINT_16(receiveData,inPtr);
				inPtr+=2;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgTfGetRnf()
			
			// End Module: tf
			
			// Begin Module: uart
			public static FLR_RESULT UartSetStartupBaudRate(Camera parent, FLR_UART_STARTUP_BAUDRATE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 4;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 0;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				//write data to sendData buffer
				if(outPtr >= (sendBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				INT_32ToByte((Int32) data,sendData,outPtr);
				outPtr += 4;
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.UART_SETSTARTUPBAUDRATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgUartSetStartupBaudRate()
			
			public static FLR_RESULT UartGetStartupBaudRate(Camera parent, out FLR_UART_STARTUP_BAUDRATE_E data) {
				// Allocate buffers with space for marshalled data
				UInt32 sendBytes = 0;
				Byte[] sendData = new Byte[sendBytes];
				UInt32 receiveBytes = 4;
				Byte[] receiveData = new Byte[receiveBytes];
				UInt16 outPtr = 0;
				
				// Assign Null values to all receive parameters
				data = new FLR_UART_STARTUP_BAUDRATE_E();
				
				FLR_RESULT returncode = parent.dispatcher(commandCount++, FLR_FUNCTION.UART_GETSTARTUPBAUDRATE, sendData, sendBytes, receiveData, ref receiveBytes);
				
				// Check for any errorcode
				if(returncode != FLR_RESULT.R_SUCCESS){
					return returncode;
				}
				
				UInt16 inPtr = 0;
				
				// read data from receiveData buffer
				if(inPtr >= (receiveBytes)){
					return FLR_RESULT.R_SDK_PKG_BUFFER_OVERFLOW;
				}
				data = (FLR_UART_STARTUP_BAUDRATE_E) byteToINT_32(receiveData,inPtr);
				inPtr+=4;
				
				return FLR_RESULT.R_SUCCESS;
				
			}// End of CLIENT_pkgUartGetStartupBaudRate()
			
			// End Module: uart
			
		} // End class ClientPackager
	} // End partial class Camera
} // End namespace Boson

