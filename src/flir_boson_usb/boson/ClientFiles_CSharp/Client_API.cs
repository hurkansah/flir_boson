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
	public partial class Camera {
		
	
	public readonly UInt16 MaxMemoryChunk = 256;
	
		public FLR_RESULT dispatcher(UInt32 seqNum, FLR_FUNCTION fnID, Byte[] sendData, UInt32 sendBytes, Byte[] receiveData, ref UInt32 receiveBytes) {
			return ClientDispatcher.dispatcher(this,seqNum,fnID,sendData,sendBytes,receiveData,ref receiveBytes);
		}
		
	// Begin Module TLinear
		public FLR_RESULT TLinearSetControl(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TlinearSetControl(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetControl()
		
		public FLR_RESULT TLinearGetControl(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TlinearGetControl(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetControl()
		
		public FLR_RESULT TLinearGetLUT(FLR_BOSON_TABLETYPE_E mode, UInt16 offset, out Double[] a, out Double[] b){
			FLR_RESULT returncode = ClientPackager.TlinearGetLUT(this, mode, offset, out a, out b);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLUT()
		
		public FLR_RESULT TLinearRefreshLUT(FLR_BOSON_TABLETYPE_E mode){
			FLR_RESULT returncode = ClientPackager.TlinearRefreshLUT(this, mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of RefreshLUT()
		
		// end Module TLinear
	// Begin Module agc
		public FLR_RESULT agcSetPercentPerBin(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetPercentPerBin(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetPercentPerBin()
		
		public FLR_RESULT agcGetPercentPerBin(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetPercentPerBin(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPercentPerBin()
		
		public FLR_RESULT agcSetLinearPercent(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetLinearPercent(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLinearPercent()
		
		public FLR_RESULT agcGetLinearPercent(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetLinearPercent(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLinearPercent()
		
		public FLR_RESULT agcSetOutlierCut(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetOutlierCut(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutlierCut()
		
		public FLR_RESULT agcGetOutlierCut(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetOutlierCut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutlierCut()
		
		public FLR_RESULT agcGetDrOut(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetDrOut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDrOut()
		
		public FLR_RESULT agcSetMaxGain(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetMaxGain(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxGain()
		
		public FLR_RESULT agcGetMaxGain(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetMaxGain(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxGain()
		
		public FLR_RESULT agcSetdf(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetdf(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Setdf()
		
		public FLR_RESULT agcGetdf(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetdf(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Getdf()
		
		public FLR_RESULT agcSetGamma(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetGamma(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGamma()
		
		public FLR_RESULT agcGetGamma(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetGamma(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGamma()
		
		public FLR_RESULT agcGetFirstBin(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.AgcGetFirstBin(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFirstBin()
		
		public FLR_RESULT agcGetLastBin(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.AgcGetLastBin(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastBin()
		
		public FLR_RESULT agcSetDetailHeadroom(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetDetailHeadroom(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDetailHeadroom()
		
		public FLR_RESULT agcGetDetailHeadroom(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetDetailHeadroom(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDetailHeadroom()
		
		public FLR_RESULT agcSetd2br(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetd2br(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Setd2br()
		
		public FLR_RESULT agcGetd2br(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetd2br(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Getd2br()
		
		public FLR_RESULT agcSetSigmaR(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetSigmaR(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSigmaR()
		
		public FLR_RESULT agcGetSigmaR(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetSigmaR(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSigmaR()
		
		public FLR_RESULT agcSetUseEntropy(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.AgcSetUseEntropy(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetUseEntropy()
		
		public FLR_RESULT agcGetUseEntropy(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.AgcGetUseEntropy(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUseEntropy()
		
		public FLR_RESULT agcSetROI(FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.AgcSetROI(this, roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetROI()
		
		public FLR_RESULT agcGetROI(out FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.AgcGetROI(this, out roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetROI()
		
		public FLR_RESULT agcGetMaxGainApplied(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetMaxGainApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxGainApplied()
		
		public FLR_RESULT agcGetSigmaRApplied(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetSigmaRApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSigmaRApplied()
		
		public FLR_RESULT agcSetOutlierCutBalance(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetOutlierCutBalance(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutlierCutBalance()
		
		public FLR_RESULT agcGetOutlierCutBalance(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetOutlierCutBalance(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutlierCutBalance()
		
		public FLR_RESULT agcGetOutlierCutApplied(out Double percentHigh, out Double percentLow){
			FLR_RESULT returncode = ClientPackager.AgcGetOutlierCutApplied(this, out percentHigh, out percentLow);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutlierCutApplied()
		
		public FLR_RESULT agcGetTfThresholds(out UInt16 tf_thresholdMin, out UInt16 tf_thresholdMax){
			FLR_RESULT returncode = ClientPackager.AgcGetTfThresholds(this, out tf_thresholdMin, out tf_thresholdMax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTfThresholds()
		
		public FLR_RESULT agcSetTfThresholds(UInt16 tf_thresholdMin, UInt16 tf_thresholdMax){
			FLR_RESULT returncode = ClientPackager.AgcSetTfThresholds(this, tf_thresholdMin, tf_thresholdMax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTfThresholds()
		
		public FLR_RESULT agcGetMode(out FLR_AGC_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.AgcGetMode(this, out mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMode()
		
		public FLR_RESULT agcSetMode(FLR_AGC_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.AgcSetMode(this, mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMode()
		
		public FLR_RESULT agcSetHighTempAlarmValues(UInt32 lowGain, UInt32 highGain, UInt32 pixPopulation){
			FLR_RESULT returncode = ClientPackager.AgcSetHighTempAlarmValues(this, lowGain, highGain, pixPopulation);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetHighTempAlarmValues()
		
		public FLR_RESULT agcGetContrast(out Int32 contrast){
			FLR_RESULT returncode = ClientPackager.AgcGetContrast(this, out contrast);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetContrast()
		
		public FLR_RESULT agcSetContrast(Int32 contrast){
			FLR_RESULT returncode = ClientPackager.AgcSetContrast(this, contrast);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetContrast()
		
		public FLR_RESULT agcGetBrightnessBias(out Int32 brightnessBias){
			FLR_RESULT returncode = ClientPackager.AgcGetBrightnessBias(this, out brightnessBias);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBrightnessBias()
		
		public FLR_RESULT agcSetBrightnessBias(Int32 brightnessBias){
			FLR_RESULT returncode = ClientPackager.AgcSetBrightnessBias(this, brightnessBias);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetBrightnessBias()
		
		public FLR_RESULT agcGetBrightness(out Int32 brightness){
			FLR_RESULT returncode = ClientPackager.AgcGetBrightness(this, out brightness);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBrightness()
		
		public FLR_RESULT agcSetBrightness(Int32 brightness){
			FLR_RESULT returncode = ClientPackager.AgcSetBrightness(this, brightness);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetBrightness()
		
		public FLR_RESULT agcSetMaxGainForLowGain(Double data){
			FLR_RESULT returncode = ClientPackager.AgcSetMaxGainForLowGain(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxGainForLowGain()
		
		public FLR_RESULT agcGetMaxGainForLowGain(out Double data){
			FLR_RESULT returncode = ClientPackager.AgcGetMaxGainForLowGain(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxGainForLowGain()
		
		// end Module agc
	// Begin Module boson
		public FLR_RESULT bosonGetCameraSN(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetCameraSN(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCameraSN()
		
		public FLR_RESULT bosonGetCameraPN(out FLR_BOSON_PARTNUMBER_T data){
			FLR_RESULT returncode = ClientPackager.BosonGetCameraPN(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCameraPN()
		
		public FLR_RESULT bosonGetSensorSN(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetSensorSN(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorSN()
		
		public FLR_RESULT bosonRunFFC(){
			FLR_RESULT returncode = ClientPackager.BosonRunFFC(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of RunFFC()
		
		public FLR_RESULT bosonSetFFCTempThreshold(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCTempThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCTempThreshold()
		
		public FLR_RESULT bosonGetFFCTempThreshold(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCTempThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCTempThreshold()
		
		public FLR_RESULT bosonSetFFCFrameThreshold(UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCFrameThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCFrameThreshold()
		
		public FLR_RESULT bosonGetFFCFrameThreshold(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCFrameThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCFrameThreshold()
		
		public FLR_RESULT bosonGetFFCInProgress(out Int16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCInProgress(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCInProgress()
		
		public FLR_RESULT bosonReboot(){
			FLR_RESULT returncode = ClientPackager.BosonReboot(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Reboot()
		
		public FLR_RESULT bosonSetFFCMode(FLR_BOSON_FFCMODE_E ffcMode){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCMode(this, ffcMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCMode()
		
		public FLR_RESULT bosonGetFFCMode(out FLR_BOSON_FFCMODE_E ffcMode){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCMode(this, out ffcMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCMode()
		
		public FLR_RESULT bosonSetGainMode(FLR_BOSON_GAINMODE_E gainMode){
			FLR_RESULT returncode = ClientPackager.BosonSetGainMode(this, gainMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainMode()
		
		public FLR_RESULT bosonGetGainMode(out FLR_BOSON_GAINMODE_E gainMode){
			FLR_RESULT returncode = ClientPackager.BosonGetGainMode(this, out gainMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainMode()
		
		public FLR_RESULT bosonWriteDynamicHeaderToFlash(){
			FLR_RESULT returncode = ClientPackager.BosonWriteDynamicHeaderToFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteDynamicHeaderToFlash()
		
		public FLR_RESULT bosonReadDynamicHeaderFromFlash(){
			FLR_RESULT returncode = ClientPackager.BosonReadDynamicHeaderFromFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReadDynamicHeaderFromFlash()
		
		public FLR_RESULT bosonRestoreFactoryDefaultsFromFlash(){
			FLR_RESULT returncode = ClientPackager.BosonRestoreFactoryDefaultsFromFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of RestoreFactoryDefaultsFromFlash()
		
		public FLR_RESULT bosonRestoreFactoryBadPixelsFromFlash(){
			FLR_RESULT returncode = ClientPackager.BosonRestoreFactoryBadPixelsFromFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of RestoreFactoryBadPixelsFromFlash()
		
		public FLR_RESULT bosonWriteBadPixelsToFlash(){
			FLR_RESULT returncode = ClientPackager.BosonWriteBadPixelsToFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteBadPixelsToFlash()
		
		public FLR_RESULT bosonGetSoftwareRev(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.BosonGetSoftwareRev(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSoftwareRev()
		
		public FLR_RESULT bosonSetBadPixelLocation(UInt32 row, UInt32 col){
			FLR_RESULT returncode = ClientPackager.BosonSetBadPixelLocation(this, row, col);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetBadPixelLocation()
		
		public FLR_RESULT bosonlookupFPATempDegCx10(out Int16 data){
			FLR_RESULT returncode = ClientPackager.BosonlookupFPATempDegCx10(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of lookupFPATempDegCx10()
		
		public FLR_RESULT bosonlookupFPATempDegKx10(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonlookupFPATempDegKx10(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of lookupFPATempDegKx10()
		
		public FLR_RESULT bosonWriteLensNvFfcToFlash(){
			FLR_RESULT returncode = ClientPackager.BosonWriteLensNvFfcToFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteLensNvFfcToFlash()
		
		public FLR_RESULT bosonWriteLensGainToFlash(){
			FLR_RESULT returncode = ClientPackager.BosonWriteLensGainToFlash(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteLensGainToFlash()
		
		public FLR_RESULT bosonSetLensNumber(UInt32 lensNumber){
			FLR_RESULT returncode = ClientPackager.BosonSetLensNumber(this, lensNumber);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLensNumber()
		
		public FLR_RESULT bosonGetLensNumber(out UInt32 lensNumber){
			FLR_RESULT returncode = ClientPackager.BosonGetLensNumber(this, out lensNumber);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLensNumber()
		
		public FLR_RESULT bosonSetTableNumber(UInt32 tableNumber){
			FLR_RESULT returncode = ClientPackager.BosonSetTableNumber(this, tableNumber);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTableNumber()
		
		public FLR_RESULT bosonGetTableNumber(out UInt32 tableNumber){
			FLR_RESULT returncode = ClientPackager.BosonGetTableNumber(this, out tableNumber);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTableNumber()
		
		public FLR_RESULT bosonGetSensorPN(out FLR_BOSON_SENSOR_PARTNUMBER_T sensorPN){
			FLR_RESULT returncode = ClientPackager.BosonGetSensorPN(this, out sensorPN);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorPN()
		
		public FLR_RESULT bosonSetGainSwitchParams(FLR_BOSON_GAIN_SWITCH_PARAMS_T parm_struct){
			FLR_RESULT returncode = ClientPackager.BosonSetGainSwitchParams(this, parm_struct);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainSwitchParams()
		
		public FLR_RESULT bosonGetGainSwitchParams(out FLR_BOSON_GAIN_SWITCH_PARAMS_T parm_struct){
			FLR_RESULT returncode = ClientPackager.BosonGetGainSwitchParams(this, out parm_struct);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSwitchParams()
		
		public FLR_RESULT bosonGetSwitchToHighGainFlag(out Byte switchToHighGainFlag){
			FLR_RESULT returncode = ClientPackager.BosonGetSwitchToHighGainFlag(this, out switchToHighGainFlag);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSwitchToHighGainFlag()
		
		public FLR_RESULT bosonGetSwitchToLowGainFlag(out Byte switchToLowGainFlag){
			FLR_RESULT returncode = ClientPackager.BosonGetSwitchToLowGainFlag(this, out switchToLowGainFlag);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSwitchToLowGainFlag()
		
		public FLR_RESULT bosonGetCLowToHighPercent(out UInt32 cLowToHighPercent){
			FLR_RESULT returncode = ClientPackager.BosonGetCLowToHighPercent(this, out cLowToHighPercent);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCLowToHighPercent()
		
		public FLR_RESULT bosonGetMaxNUCTables(out UInt32 maxNUCTables){
			FLR_RESULT returncode = ClientPackager.BosonGetMaxNUCTables(this, out maxNUCTables);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxNUCTables()
		
		public FLR_RESULT bosonGetMaxLensTables(out UInt32 maxLensTables){
			FLR_RESULT returncode = ClientPackager.BosonGetMaxLensTables(this, out maxLensTables);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxLensTables()
		
		public FLR_RESULT bosonGetFfcWaitCloseFrames(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFfcWaitCloseFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcWaitCloseFrames()
		
		public FLR_RESULT bosonSetFfcWaitCloseFrames(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFfcWaitCloseFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFfcWaitCloseFrames()
		
		public FLR_RESULT bosonCheckForTableSwitch(){
			FLR_RESULT returncode = ClientPackager.BosonCheckForTableSwitch(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CheckForTableSwitch()
		
		public FLR_RESULT bosonGetDesiredTableNumber(out UInt32 desiredTableNumber){
			FLR_RESULT returncode = ClientPackager.BosonGetDesiredTableNumber(this, out desiredTableNumber);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDesiredTableNumber()
		
		public FLR_RESULT bosonGetFfcStatus(out FLR_BOSON_FFCSTATUS_E ffcStatus){
			FLR_RESULT returncode = ClientPackager.BosonGetFfcStatus(this, out ffcStatus);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcStatus()
		
		public FLR_RESULT bosonGetFfcDesired(out UInt32 ffcDesired){
			FLR_RESULT returncode = ClientPackager.BosonGetFfcDesired(this, out ffcDesired);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcDesired()
		
		public FLR_RESULT bosonGetSwRevInHeader(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.BosonGetSwRevInHeader(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSwRevInHeader()
		
		public FLR_RESULT bosonGetLastFFCFrameCount(out UInt32 frameCount){
			FLR_RESULT returncode = ClientPackager.BosonGetLastFFCFrameCount(this, out frameCount);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastFFCFrameCount()
		
		public FLR_RESULT bosonGetLastFFCTempDegKx10(out UInt16 temp){
			FLR_RESULT returncode = ClientPackager.BosonGetLastFFCTempDegKx10(this, out temp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastFFCTempDegKx10()
		
		public FLR_RESULT bosonGetTableSwitchDesired(out UInt16 tableSwitchDesired){
			FLR_RESULT returncode = ClientPackager.BosonGetTableSwitchDesired(this, out tableSwitchDesired);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTableSwitchDesired()
		
		public FLR_RESULT bosonGetOverTempThreshold(out Double temperatureInC){
			FLR_RESULT returncode = ClientPackager.BosonGetOverTempThreshold(this, out temperatureInC);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOverTempThreshold()
		
		public FLR_RESULT bosonGetLowPowerMode(out UInt16 lowPowerMode){
			FLR_RESULT returncode = ClientPackager.BosonGetLowPowerMode(this, out lowPowerMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLowPowerMode()
		
		public FLR_RESULT bosonGetOverTempEventOccurred(out UInt16 overTempEventOccurred){
			FLR_RESULT returncode = ClientPackager.BosonGetOverTempEventOccurred(this, out overTempEventOccurred);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOverTempEventOccurred()
		
		public FLR_RESULT bosonSetPermitThermalShutdownOverride(FLR_ENABLE_E permitThermalShutdownOverride){
			FLR_RESULT returncode = ClientPackager.BosonSetPermitThermalShutdownOverride(this, permitThermalShutdownOverride);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetPermitThermalShutdownOverride()
		
		public FLR_RESULT bosonGetPermitThermalShutdownOverride(out FLR_ENABLE_E permitThermalShutdownOverride){
			FLR_RESULT returncode = ClientPackager.BosonGetPermitThermalShutdownOverride(this, out permitThermalShutdownOverride);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPermitThermalShutdownOverride()
		
		public FLR_RESULT bosonGetMyriadTemp(out Double myriadTemp){
			FLR_RESULT returncode = ClientPackager.BosonGetMyriadTemp(this, out myriadTemp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMyriadTemp()
		
		public FLR_RESULT bosonGetNvFFCNucTableNumberLens0(out Int32 nvFFCNucTableNumberLens0){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCNucTableNumberLens0(this, out nvFFCNucTableNumberLens0);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCNucTableNumberLens0()
		
		public FLR_RESULT bosonGetNvFFCNucTableNumberLens1(out Int32 nvFFCNucTableNumberLens1){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCNucTableNumberLens1(this, out nvFFCNucTableNumberLens1);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCNucTableNumberLens1()
		
		public FLR_RESULT bosonGetNvFFCFPATempDegKx10Lens0(out UInt16 nvFFCFPATempDegKx10Lens0){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCFPATempDegKx10Lens0(this, out nvFFCFPATempDegKx10Lens0);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCFPATempDegKx10Lens0()
		
		public FLR_RESULT bosonGetNvFFCFPATempDegKx10Lens1(out UInt16 nvFFCFPATempDegKx10Lens1){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCFPATempDegKx10Lens1(this, out nvFFCFPATempDegKx10Lens1);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCFPATempDegKx10Lens1()
		
		public FLR_RESULT bosonSetFFCWarnTimeInSecx10(UInt16 ffcWarnTime){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCWarnTimeInSecx10(this, ffcWarnTime);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCWarnTimeInSecx10()
		
		public FLR_RESULT bosonGetFFCWarnTimeInSecx10(out UInt16 ffcWarnTime){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCWarnTimeInSecx10(this, out ffcWarnTime);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCWarnTimeInSecx10()
		
		public FLR_RESULT bosonGetOverTempEventCounter(out UInt32 overTempEventCounter){
			FLR_RESULT returncode = ClientPackager.BosonGetOverTempEventCounter(this, out overTempEventCounter);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOverTempEventCounter()
		
		public FLR_RESULT bosonSetOverTempTimerInSec(UInt16 overTempTimerInSec){
			FLR_RESULT returncode = ClientPackager.BosonSetOverTempTimerInSec(this, overTempTimerInSec);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOverTempTimerInSec()
		
		public FLR_RESULT bosonGetOverTempTimerInSec(out UInt16 overTempTimerInSec){
			FLR_RESULT returncode = ClientPackager.BosonGetOverTempTimerInSec(this, out overTempTimerInSec);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOverTempTimerInSec()
		
		public FLR_RESULT bosonUnloadCurrentLensCorrections(){
			FLR_RESULT returncode = ClientPackager.BosonUnloadCurrentLensCorrections(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of UnloadCurrentLensCorrections()
		
		public FLR_RESULT bosonSetTimeForQuickFFCsInSecs(UInt32 timeForQuickFFCsInSecs){
			FLR_RESULT returncode = ClientPackager.BosonSetTimeForQuickFFCsInSecs(this, timeForQuickFFCsInSecs);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTimeForQuickFFCsInSecs()
		
		public FLR_RESULT bosonGetTimeForQuickFFCsInSecs(out UInt32 timeForQuickFFCsInSecs){
			FLR_RESULT returncode = ClientPackager.BosonGetTimeForQuickFFCsInSecs(this, out timeForQuickFFCsInSecs);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTimeForQuickFFCsInSecs()
		
		public FLR_RESULT bosonReloadCurrentLensCorrections(){
			FLR_RESULT returncode = ClientPackager.BosonReloadCurrentLensCorrections(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReloadCurrentLensCorrections()
		
		public FLR_RESULT bosonGetBootTimestamps(out Double FirstLight, out Double StartInit, out Double BosonExecDone, out Double Timestamp4){
			FLR_RESULT returncode = ClientPackager.BosonGetBootTimestamps(this, out FirstLight, out StartInit, out BosonExecDone, out Timestamp4);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBootTimestamps()
		
		public FLR_RESULT bosonSetExtSyncMode(FLR_BOSON_EXT_SYNC_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.BosonSetExtSyncMode(this, mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetExtSyncMode()
		
		public FLR_RESULT bosonGetExtSyncMode(out FLR_BOSON_EXT_SYNC_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.BosonGetExtSyncMode(this, out mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetExtSyncMode()
		
		public FLR_RESULT bosonGetLastCommand(out UInt32 sequenceNum, out UInt32 cmdID){
			FLR_RESULT returncode = ClientPackager.BosonGetLastCommand(this, out sequenceNum, out cmdID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastCommand()
		
		public FLR_RESULT bosonGetSensorHostCalVersion(out UInt32 version){
			FLR_RESULT returncode = ClientPackager.BosonGetSensorHostCalVersion(this, out version);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorHostCalVersion()
		
		public FLR_RESULT bosonSetDesiredStartupTableNumber(Int32 table){
			FLR_RESULT returncode = ClientPackager.BosonSetDesiredStartupTableNumber(this, table);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDesiredStartupTableNumber()
		
		public FLR_RESULT bosonGetDesiredStartupTableNumber(out Int32 table){
			FLR_RESULT returncode = ClientPackager.BosonGetDesiredStartupTableNumber(this, out table);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDesiredStartupTableNumber()
		
		public FLR_RESULT bosonSetNvFFCMeanValueLens0(Double meanValue){
			FLR_RESULT returncode = ClientPackager.BosonSetNvFFCMeanValueLens0(this, meanValue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNvFFCMeanValueLens0()
		
		public FLR_RESULT bosonGetNvFFCMeanValueLens0(out Double meanValue){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCMeanValueLens0(this, out meanValue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCMeanValueLens0()
		
		public FLR_RESULT bosonSetNvFFCMeanValueLens1(Double meanValue){
			FLR_RESULT returncode = ClientPackager.BosonSetNvFFCMeanValueLens1(this, meanValue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNvFFCMeanValueLens1()
		
		public FLR_RESULT bosonGetNvFFCMeanValueLens1(out Double meanValue){
			FLR_RESULT returncode = ClientPackager.BosonGetNvFFCMeanValueLens1(this, out meanValue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNvFFCMeanValueLens1()
		
		public FLR_RESULT bosonSetInvertImage(FLR_ENABLE_E invertImage){
			FLR_RESULT returncode = ClientPackager.BosonSetInvertImage(this, invertImage);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetInvertImage()
		
		public FLR_RESULT bosonGetInvertImage(out FLR_ENABLE_E invertImage){
			FLR_RESULT returncode = ClientPackager.BosonGetInvertImage(this, out invertImage);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetInvertImage()
		
		public FLR_RESULT bosonSetRevertImage(FLR_ENABLE_E revertImage){
			FLR_RESULT returncode = ClientPackager.BosonSetRevertImage(this, revertImage);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRevertImage()
		
		public FLR_RESULT bosonGetRevertImage(out FLR_ENABLE_E revertImage){
			FLR_RESULT returncode = ClientPackager.BosonGetRevertImage(this, out revertImage);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRevertImage()
		
		public FLR_RESULT bosonGetTimeStamp(FLR_BOSON_TIMESTAMPTYPE_E timeStampType, out Double timeStamp){
			FLR_RESULT returncode = ClientPackager.BosonGetTimeStamp(this, timeStampType, out timeStamp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTimeStamp()
		
		public FLR_RESULT bosonGetISPFrameCount(out UInt32 ispFrameCount){
			FLR_RESULT returncode = ClientPackager.BosonGetISPFrameCount(this, out ispFrameCount);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetISPFrameCount()
		
		public FLR_RESULT bosonWriteUserBadPixelsToAllTables(){
			FLR_RESULT returncode = ClientPackager.BosonWriteUserBadPixelsToAllTables(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteUserBadPixelsToAllTables()
		
		public FLR_RESULT bosonWriteFactoryBadPixelsToAllTables(){
			FLR_RESULT returncode = ClientPackager.BosonWriteFactoryBadPixelsToAllTables(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteFactoryBadPixelsToAllTables()
		
		public FLR_RESULT bosonGetTempDiodeStatus(out FLR_BOSON_TEMP_DIODE_STATUS_E status){
			FLR_RESULT returncode = ClientPackager.BosonGetTempDiodeStatus(this, out status);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempDiodeStatus()
		
		public FLR_RESULT bosonClearFactoryBadPixelsInDDR(){
			FLR_RESULT returncode = ClientPackager.BosonClearFactoryBadPixelsInDDR(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ClearFactoryBadPixelsInDDR()
		
		public FLR_RESULT bosonGetFfcWaitOpenFrames(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFfcWaitOpenFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcWaitOpenFrames()
		
		public FLR_RESULT bosonSetFfcWaitOpenFrames(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFfcWaitOpenFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFfcWaitOpenFrames()
		
		public FLR_RESULT bosonGetFfcWaitOpenFlagSettleFrames(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFfcWaitOpenFlagSettleFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcWaitOpenFlagSettleFrames()
		
		public FLR_RESULT bosonSetFfcWaitOpenFlagSettleFrames(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFfcWaitOpenFlagSettleFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFfcWaitOpenFlagSettleFrames()
		
		public FLR_RESULT bosonGetTauExtFfcCompatibilityMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonGetTauExtFfcCompatibilityMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTauExtFfcCompatibilityMode()
		
		public FLR_RESULT bosonSetTauExtFfcCompatibilityMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonSetTauExtFfcCompatibilityMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTauExtFfcCompatibilityMode()
		
		public FLR_RESULT bosonGetInitialTableSelectionTempOffset(out Int16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetInitialTableSelectionTempOffset(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetInitialTableSelectionTempOffset()
		
		public FLR_RESULT bosonSetInitialTableSelectionTempOffset(Int16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetInitialTableSelectionTempOffset(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetInitialTableSelectionTempOffset()
		
		public FLR_RESULT bosonGetImageValid(out Int16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetImageValid(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetImageValid()
		
		public FLR_RESULT bosonGetCurrentTableType(out FLR_BOSON_TABLETYPE_E data){
			FLR_RESULT returncode = ClientPackager.BosonGetCurrentTableType(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCurrentTableType()
		
		public FLR_RESULT bosonGetGainSwitchFrameThreshold(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetGainSwitchFrameThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSwitchFrameThreshold()
		
		public FLR_RESULT bosonSetGainSwitchFrameThreshold(UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonSetGainSwitchFrameThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainSwitchFrameThreshold()
		
		public FLR_RESULT bosonGetGainSwitchHysteresisTime(out Double data){
			FLR_RESULT returncode = ClientPackager.BosonGetGainSwitchHysteresisTime(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSwitchHysteresisTime()
		
		public FLR_RESULT bosonSetGainSwitchHysteresisTime(Double data){
			FLR_RESULT returncode = ClientPackager.BosonSetGainSwitchHysteresisTime(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainSwitchHysteresisTime()
		
		public FLR_RESULT bosonGetGainSwitchDesired(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetGainSwitchDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSwitchDesired()
		
		public FLR_RESULT bosonGetGainSwitchRadiometricParams(out FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T parm_struct){
			FLR_RESULT returncode = ClientPackager.BosonGetGainSwitchRadiometricParams(this, out parm_struct);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSwitchRadiometricParams()
		
		public FLR_RESULT bosonSetGainSwitchRadiometricParams(FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T parm_struct){
			FLR_RESULT returncode = ClientPackager.BosonSetGainSwitchRadiometricParams(this, parm_struct);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainSwitchRadiometricParams()
		
		public FLR_RESULT bosonSetSaturationOverrideMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonSetSaturationOverrideMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSaturationOverrideMode()
		
		public FLR_RESULT bosonGetSaturationOverrideMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonGetSaturationOverrideMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSaturationOverrideMode()
		
		public FLR_RESULT bosonSetSaturationOverrideValue(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetSaturationOverrideValue(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSaturationOverrideValue()
		
		public FLR_RESULT bosonGetSaturationOverrideValue(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetSaturationOverrideValue(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSaturationOverrideValue()
		
		public FLR_RESULT bosonSetffcHighLowGainThresholdMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonSetffcHighLowGainThresholdMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetffcHighLowGainThresholdMode()
		
		public FLR_RESULT bosonGetffcHighLowGainThresholdMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BosonGetffcHighLowGainThresholdMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetffcHighLowGainThresholdMode()
		
		public FLR_RESULT bosonSetFFCTempThresholdLowGain(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCTempThresholdLowGain(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCTempThresholdLowGain()
		
		public FLR_RESULT bosonGetFFCTempThresholdLowGain(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCTempThresholdLowGain(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCTempThresholdLowGain()
		
		public FLR_RESULT bosonSetFFCFrameThresholdLowGain(UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonSetFFCFrameThresholdLowGain(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFCFrameThresholdLowGain()
		
		public FLR_RESULT bosonGetFFCFrameThresholdLowGain(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BosonGetFFCFrameThresholdLowGain(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFCFrameThresholdLowGain()
		
		// end Module boson
	// Begin Module bpr
		public FLR_RESULT bprGetState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BprGetState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetState()
		
		public FLR_RESULT bprSetState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.BprSetState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetState()
		
		public FLR_RESULT bprGetStats(out UInt32 threeby, out UInt32 fiveby, out UInt32 rows, out UInt32 budget, out UInt32 used){
			FLR_RESULT returncode = ClientPackager.BprGetStats(this, out threeby, out fiveby, out rows, out budget, out used);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStats()
		
		public FLR_RESULT bprGetDisplayMode(out FLR_BPR_DISPLAY_MODE_E data){
			FLR_RESULT returncode = ClientPackager.BprGetDisplayMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDisplayMode()
		
		public FLR_RESULT bprSetDisplayMode(FLR_BPR_DISPLAY_MODE_E data){
			FLR_RESULT returncode = ClientPackager.BprSetDisplayMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDisplayMode()
		
		public FLR_RESULT bprGetDisplayModeMinValue(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BprGetDisplayModeMinValue(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDisplayModeMinValue()
		
		public FLR_RESULT bprSetDisplayModeMinValue(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BprSetDisplayModeMinValue(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDisplayModeMinValue()
		
		public FLR_RESULT bprGetDisplayModeMaxValue(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.BprGetDisplayModeMaxValue(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDisplayModeMaxValue()
		
		public FLR_RESULT bprSetDisplayModeMaxValue(UInt16 data){
			FLR_RESULT returncode = ClientPackager.BprSetDisplayModeMaxValue(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDisplayModeMaxValue()
		
		public FLR_RESULT bprGetWorkBufIndex(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.BprGetWorkBufIndex(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetWorkBufIndex()
		
		public FLR_RESULT bprSetWorkBufIndex(UInt32 data){
			FLR_RESULT returncode = ClientPackager.BprSetWorkBufIndex(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetWorkBufIndex()
		
		public FLR_RESULT bprGetWorkBufStats(out UInt32 threeby, out UInt32 fiveby, out UInt32 rows, out UInt32 budget, out UInt32 used){
			FLR_RESULT returncode = ClientPackager.BprGetWorkBufStats(this, out threeby, out fiveby, out rows, out budget, out used);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetWorkBufStats()
		
		// end Module bpr
	// Begin Module capture
		public FLR_RESULT captureSingleFrame(){
			FLR_RESULT returncode = ClientPackager.CaptureSingleFrame(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SingleFrame()
		
		public FLR_RESULT captureFrames(FLR_CAPTURE_SETTINGS_T data){
			FLR_RESULT returncode = ClientPackager.CaptureFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Frames()
		
		public FLR_RESULT captureSingleFrameWithSrc(FLR_CAPTURE_SRC_E data){
			FLR_RESULT returncode = ClientPackager.CaptureSingleFrameWithSrc(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SingleFrameWithSrc()
		
		public FLR_RESULT captureSingleFrameToFile(){
			FLR_RESULT returncode = ClientPackager.CaptureSingleFrameToFile(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SingleFrameToFile()
		
		public FLR_RESULT captureGetStatus(out FLR_CAPTURE_STATUS_T status){
			FLR_RESULT returncode = ClientPackager.CaptureGetStatus(this, out status);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStatus()
		
		// end Module capture
	// Begin Module colorLut
		public FLR_RESULT colorLutSetControl(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ColorlutSetControl(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetControl()
		
		public FLR_RESULT colorLutGetControl(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ColorlutGetControl(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetControl()
		
		public FLR_RESULT colorLutSetId(FLR_COLORLUT_ID_E data){
			FLR_RESULT returncode = ClientPackager.ColorlutSetId(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetId()
		
		public FLR_RESULT colorLutGetId(out FLR_COLORLUT_ID_E data){
			FLR_RESULT returncode = ClientPackager.ColorlutGetId(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetId()
		
		public FLR_RESULT colorLutSetOutlineColor(Byte red, Byte green, Byte blue){
			FLR_RESULT returncode = ClientPackager.ColorlutSetOutlineColor(this, red, green, blue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutlineColor()
		
		public FLR_RESULT colorLutGetOutlineColor(out Byte red, out Byte green, out Byte blue){
			FLR_RESULT returncode = ClientPackager.ColorlutGetOutlineColor(this, out red, out green, out blue);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutlineColor()
		
		// end Module colorLut
	// Begin Module dummy
		public FLR_RESULT dummyBadCommand(){
			FLR_RESULT returncode = ClientPackager.DummyBadCommand(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of BadCommand()
		
		// end Module dummy
	// Begin Module dvo
		public FLR_RESULT dvoSetAnalogVideoState(FLR_ENABLE_E analogVideoState){
			FLR_RESULT returncode = ClientPackager.DvoSetAnalogVideoState(this, analogVideoState);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetAnalogVideoState()
		
		public FLR_RESULT dvoGetAnalogVideoState(out FLR_ENABLE_E analogVideoState){
			FLR_RESULT returncode = ClientPackager.DvoGetAnalogVideoState(this, out analogVideoState);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAnalogVideoState()
		
		public FLR_RESULT dvoSetOutputFormat(FLR_DVO_OUTPUT_FORMAT_E format){
			FLR_RESULT returncode = ClientPackager.DvoSetOutputFormat(this, format);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutputFormat()
		
		public FLR_RESULT dvoGetOutputFormat(out FLR_DVO_OUTPUT_FORMAT_E format){
			FLR_RESULT returncode = ClientPackager.DvoGetOutputFormat(this, out format);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutputFormat()
		
		public FLR_RESULT dvoSetOutputYCbCrSettings(FLR_DVO_YCBCR_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.DvoSetOutputYCbCrSettings(this, settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutputYCbCrSettings()
		
		public FLR_RESULT dvoGetOutputYCbCrSettings(out FLR_DVO_YCBCR_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.DvoGetOutputYCbCrSettings(this, out settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutputYCbCrSettings()
		
		public FLR_RESULT dvoSetOutputRGBSettings(FLR_DVO_RGB_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.DvoSetOutputRGBSettings(this, settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutputRGBSettings()
		
		public FLR_RESULT dvoGetOutputRGBSettings(out FLR_DVO_RGB_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.DvoGetOutputRGBSettings(this, out settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutputRGBSettings()
		
		public FLR_RESULT dvoApplyCustomSettings(){
			FLR_RESULT returncode = ClientPackager.DvoApplyCustomSettings(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ApplyCustomSettings()
		
		public FLR_RESULT dvoSetDisplayMode(FLR_DVO_DISPLAY_MODE_E displayMode){
			FLR_RESULT returncode = ClientPackager.DvoSetDisplayMode(this, displayMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDisplayMode()
		
		public FLR_RESULT dvoGetDisplayMode(out FLR_DVO_DISPLAY_MODE_E displayMode){
			FLR_RESULT returncode = ClientPackager.DvoGetDisplayMode(this, out displayMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDisplayMode()
		
		public FLR_RESULT dvoSetType(FLR_DVO_TYPE_E tap){
			FLR_RESULT returncode = ClientPackager.DvoSetType(this, tap);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetType()
		
		public FLR_RESULT dvoGetType(out FLR_DVO_TYPE_E tap){
			FLR_RESULT returncode = ClientPackager.DvoGetType(this, out tap);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetType()
		
		public FLR_RESULT dvoSetVideoStandard(FLR_DVO_VIDEO_STANDARD_E videoStandard){
			FLR_RESULT returncode = ClientPackager.DvoSetVideoStandard(this, videoStandard);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetVideoStandard()
		
		public FLR_RESULT dvoGetVideoStandard(out FLR_DVO_VIDEO_STANDARD_E videoStandard){
			FLR_RESULT returncode = ClientPackager.DvoGetVideoStandard(this, out videoStandard);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetVideoStandard()
		
		public FLR_RESULT dvoSetCheckVideoDacPresent(FLR_ENABLE_E checkVideoDacPresent){
			FLR_RESULT returncode = ClientPackager.DvoSetCheckVideoDacPresent(this, checkVideoDacPresent);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetCheckVideoDacPresent()
		
		public FLR_RESULT dvoGetCheckVideoDacPresent(out FLR_ENABLE_E checkVideoDacPresent){
			FLR_RESULT returncode = ClientPackager.DvoGetCheckVideoDacPresent(this, out checkVideoDacPresent);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCheckVideoDacPresent()
		
		public FLR_RESULT dvoSetCustomLcdConfig(FLR_DVO_LCD_CONFIG_ID_E id, FLR_DVO_LCD_CONFIG_T config){
			FLR_RESULT returncode = ClientPackager.DvoSetCustomLcdConfig(this, id, config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetCustomLcdConfig()
		
		public FLR_RESULT dvoGetCustomLcdConfig(FLR_DVO_LCD_CONFIG_ID_E id, out FLR_DVO_LCD_CONFIG_T config){
			FLR_RESULT returncode = ClientPackager.DvoGetCustomLcdConfig(this, id, out config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCustomLcdConfig()
		
		public FLR_RESULT dvoSetLCDConfig(FLR_DVO_LCD_CONFIG_ID_E id){
			FLR_RESULT returncode = ClientPackager.DvoSetLCDConfig(this, id);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLCDConfig()
		
		public FLR_RESULT dvoGetLCDConfig(out FLR_DVO_LCD_CONFIG_ID_E id){
			FLR_RESULT returncode = ClientPackager.DvoGetLCDConfig(this, out id);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLCDConfig()
		
		public FLR_RESULT dvoGetClockInfo(out UInt32 horizontalSyncWidth, out UInt32 verticalSyncWidth, out UInt32 clocksPerRowPeriod, out UInt32 horizontalFrontPorch, out UInt32 horizontalBackPorch, out UInt32 frontTelemetryPixels, out UInt32 rearTelemetryPixels, out UInt32 videoColumns, out UInt32 validColumns, out UInt32 telemetryRows, out UInt32 videoRows, out UInt32 validRows, out UInt32 verticalFrontPorch, out UInt32 verticalBackPorch, out UInt32 rowPeriodsPerFrame, out UInt32 clocksPerFrame, out Double clockRateInMHz, out Double frameRateInHz, out UInt32 validOnRisingEdge, out UInt32 dataWidthInBits){
			FLR_RESULT returncode = ClientPackager.DvoGetClockInfo(this, out horizontalSyncWidth, out verticalSyncWidth, out clocksPerRowPeriod, out horizontalFrontPorch, out horizontalBackPorch, out frontTelemetryPixels, out rearTelemetryPixels, out videoColumns, out validColumns, out telemetryRows, out videoRows, out validRows, out verticalFrontPorch, out verticalBackPorch, out rowPeriodsPerFrame, out clocksPerFrame, out clockRateInMHz, out frameRateInHz, out validOnRisingEdge, out dataWidthInBits);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetClockInfo()
		
		public FLR_RESULT dvoSetAllCustomLcdConfigs(FLR_DVO_LCD_CONFIG_T config0, FLR_DVO_LCD_CONFIG_T config1){
			FLR_RESULT returncode = ClientPackager.DvoSetAllCustomLcdConfigs(this, config0, config1);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetAllCustomLcdConfigs()
		
		public FLR_RESULT dvoGetAllCustomLcdConfigs(out FLR_DVO_LCD_CONFIG_T config0, out FLR_DVO_LCD_CONFIG_T config1){
			FLR_RESULT returncode = ClientPackager.DvoGetAllCustomLcdConfigs(this, out config0, out config1);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAllCustomLcdConfigs()
		
		public FLR_RESULT dvoSetOutputIr16Format(FLR_DVO_OUTPUT_IR16_FORMAT_E format){
			FLR_RESULT returncode = ClientPackager.DvoSetOutputIr16Format(this, format);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOutputIr16Format()
		
		public FLR_RESULT dvoGetOutputIr16Format(out FLR_DVO_OUTPUT_IR16_FORMAT_E format){
			FLR_RESULT returncode = ClientPackager.DvoGetOutputIr16Format(this, out format);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOutputIr16Format()
		
		public FLR_RESULT dvoSetLcdClockRate(FLR_DVO_LCD_CLOCK_RATE_E clockRate){
			FLR_RESULT returncode = ClientPackager.DvoSetLcdClockRate(this, clockRate);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLcdClockRate()
		
		public FLR_RESULT dvoGetLcdClockRate(out FLR_DVO_LCD_CLOCK_RATE_E clockRate){
			FLR_RESULT returncode = ClientPackager.DvoGetLcdClockRate(this, out clockRate);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLcdClockRate()
		
		public FLR_RESULT dvoSetLcdVideoFrameRate(UInt32 framerate){
			FLR_RESULT returncode = ClientPackager.DvoSetLcdVideoFrameRate(this, framerate);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLcdVideoFrameRate()
		
		public FLR_RESULT dvoGetLcdVideoFrameRate(out UInt32 framerate){
			FLR_RESULT returncode = ClientPackager.DvoGetLcdVideoFrameRate(this, out framerate);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLcdVideoFrameRate()
		
		// end Module dvo
	// Begin Module fileOps
		public FLR_RESULT fileOpsDir(out Byte[] dirent){
			FLR_RESULT returncode = ClientPackager.FileopsDir(this, out dirent);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Dir()
		
		public FLR_RESULT fileOpsCd(Byte[] path, out Byte[] pwd){
			FLR_RESULT returncode = ClientPackager.FileopsCd(this, path, out pwd);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Cd()
		
		public FLR_RESULT fileOpsMd(Byte[] path){
			FLR_RESULT returncode = ClientPackager.FileopsMd(this, path);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Md()
		
		public FLR_RESULT fileOpsFopen(Byte[] path, Byte[] mode, out UInt32 id){
			FLR_RESULT returncode = ClientPackager.FileopsFopen(this, path, mode, out id);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Fopen()
		
		public FLR_RESULT fileOpsFclose(UInt32 id){
			FLR_RESULT returncode = ClientPackager.FileopsFclose(this, id);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Fclose()
		
		public FLR_RESULT fileOpsFread(UInt32 id, UInt32 length, out Byte[] buf, out UInt32 ret){
			FLR_RESULT returncode = ClientPackager.FileopsFread(this, id, length, out buf, out ret);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Fread()
		
		public FLR_RESULT fileOpsFwrite(UInt32 id, UInt32 length, Byte[] buf, out UInt32 ret){
			FLR_RESULT returncode = ClientPackager.FileopsFwrite(this, id, length, buf, out ret);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Fwrite()
		
		public FLR_RESULT fileOpsFtell(UInt32 id, out UInt32 offset){
			FLR_RESULT returncode = ClientPackager.FileopsFtell(this, id, out offset);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Ftell()
		
		public FLR_RESULT fileOpsFseek(UInt32 id, UInt32 offset, UInt32 origin){
			FLR_RESULT returncode = ClientPackager.FileopsFseek(this, id, offset, origin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Fseek()
		
		public FLR_RESULT fileOpsFtruncate(UInt32 id, UInt32 length){
			FLR_RESULT returncode = ClientPackager.FileopsFtruncate(this, id, length);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Ftruncate()
		
		public FLR_RESULT fileOpsRmdir(Byte[] path){
			FLR_RESULT returncode = ClientPackager.FileopsRmdir(this, path);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Rmdir()
		
		public FLR_RESULT fileOpsRm(Byte[] path){
			FLR_RESULT returncode = ClientPackager.FileopsRm(this, path);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Rm()
		
		public FLR_RESULT fileOpsRename(Byte[] oldpath, Byte[] newpath){
			FLR_RESULT returncode = ClientPackager.FileopsRename(this, oldpath, newpath);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Rename()
		
		public FLR_RESULT fileOpsGetFileSize(Byte[] path, out UInt32 fileLength){
			FLR_RESULT returncode = ClientPackager.FileopsGetFileSize(this, path, out fileLength);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFileSize()
		
		// end Module fileOps
	// Begin Module flashIO
		public FLR_RESULT flashIOSetProtectionState(FLR_ENABLE_E protectionState){
			FLR_RESULT returncode = ClientPackager.FlashioSetProtectionState(this, protectionState);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetProtectionState()
		
		public FLR_RESULT flashIOGetProtectionState(out FLR_ENABLE_E protectionState){
			FLR_RESULT returncode = ClientPackager.FlashioGetProtectionState(this, out protectionState);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetProtectionState()
		
		// end Module flashIO
	// Begin Module flashMapFs
		public FLR_RESULT flashMapFsGetHeaderVersion(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.FlashmapfsGetHeaderVersion(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetHeaderVersion()
		
		// end Module flashMapFs
	// Begin Module gao
		public FLR_RESULT gaoSetGainState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetGainState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGainState()
		
		public FLR_RESULT gaoGetGainState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetGainState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainState()
		
		public FLR_RESULT gaoSetFfcState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetFfcState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFfcState()
		
		public FLR_RESULT gaoGetFfcState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetFfcState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcState()
		
		public FLR_RESULT gaoSetTempCorrectionState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetTempCorrectionState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempCorrectionState()
		
		public FLR_RESULT gaoGetTempCorrectionState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetTempCorrectionState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempCorrectionState()
		
		public FLR_RESULT gaoSetIConstL(Int16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetIConstL(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIConstL()
		
		public FLR_RESULT gaoGetIConstL(out Int16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetIConstL(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIConstL()
		
		public FLR_RESULT gaoSetIConstM(Int16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetIConstM(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIConstM()
		
		public FLR_RESULT gaoGetIConstM(out Int16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetIConstM(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIConstM()
		
		public FLR_RESULT gaoSetAveragerState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetAveragerState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetAveragerState()
		
		public FLR_RESULT gaoGetAveragerState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetAveragerState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAveragerState()
		
		public FLR_RESULT gaoSetNumFFCFrames(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetNumFFCFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNumFFCFrames()
		
		public FLR_RESULT gaoGetNumFFCFrames(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetNumFFCFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNumFFCFrames()
		
		public FLR_RESULT gaoGetAveragerThreshold(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetAveragerThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAveragerThreshold()
		
		public FLR_RESULT gaoSetRnsState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsState()
		
		public FLR_RESULT gaoGetRnsState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsState()
		
		public FLR_RESULT gaoSetTestRampState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetTestRampState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTestRampState()
		
		public FLR_RESULT gaoGetTestRampState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetTestRampState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTestRampState()
		
		public FLR_RESULT gaoSetSffcState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetSffcState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSffcState()
		
		public FLR_RESULT gaoGetSffcState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetSffcState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSffcState()
		
		public FLR_RESULT gaoSetNucType(FLR_GAO_NUC_TYPE_E nucType){
			FLR_RESULT returncode = ClientPackager.GaoSetNucType(this, nucType);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNucType()
		
		public FLR_RESULT gaoGetNucType(out FLR_GAO_NUC_TYPE_E nucType){
			FLR_RESULT returncode = ClientPackager.GaoGetNucType(this, out nucType);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNucType()
		
		public FLR_RESULT gaoSetFfcZeroMeanState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetFfcZeroMeanState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFfcZeroMeanState()
		
		public FLR_RESULT gaoGetFfcZeroMeanState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetFfcZeroMeanState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcZeroMeanState()
		
		public FLR_RESULT gaoSetRnsPopThreshold(UInt16 threshold){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsPopThreshold(this, threshold);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsPopThreshold()
		
		public FLR_RESULT gaoGetRnsPopThreshold(out UInt16 threshold){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsPopThreshold(this, out threshold);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsPopThreshold()
		
		public FLR_RESULT gaoSetRnsCloseThreshold(UInt16 threshold){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsCloseThreshold(this, threshold);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsCloseThreshold()
		
		public FLR_RESULT gaoGetRnsCloseThreshold(out UInt16 threshold){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsCloseThreshold(this, out threshold);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsCloseThreshold()
		
		public FLR_RESULT gaoSetRnsTooFewQuit(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsTooFewQuit(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsTooFewQuit()
		
		public FLR_RESULT gaoGetRnsTooFewQuit(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsTooFewQuit(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsTooFewQuit()
		
		public FLR_RESULT gaoSetRnsTooFew(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsTooFew(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsTooFew()
		
		public FLR_RESULT gaoGetRnsTooFew(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsTooFew(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsTooFew()
		
		public FLR_RESULT gaoSetRnsMinCorrection(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsMinCorrection(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsMinCorrection()
		
		public FLR_RESULT gaoGetRnsMinCorrection(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsMinCorrection(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsMinCorrection()
		
		public FLR_RESULT gaoSetRnsDamping(Byte data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsDamping(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsDamping()
		
		public FLR_RESULT gaoGetRnsDamping(out Byte data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsDamping(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsDamping()
		
		public FLR_RESULT gaoSetRnsFrameHysteresis(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsFrameHysteresis(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsFrameHysteresis()
		
		public FLR_RESULT gaoGetRnsFrameHysteresis(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsFrameHysteresis(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsFrameHysteresis()
		
		public FLR_RESULT gaoSetRnsBadDamping(Byte data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsBadDamping(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsBadDamping()
		
		public FLR_RESULT gaoGetRnsBadDamping(out Byte data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsBadDamping(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsBadDamping()
		
		public FLR_RESULT gaoSetRnsNumGoodDampingThreshold(UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsNumGoodDampingThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsNumGoodDampingThreshold()
		
		public FLR_RESULT gaoGetRnsNumGoodDampingThreshold(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsNumGoodDampingThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsNumGoodDampingThreshold()
		
		public FLR_RESULT gaoGetRnsFfcDesired(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsFfcDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsFfcDesired()
		
		public FLR_RESULT gaoGetAveragerDesiredState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetAveragerDesiredState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAveragerDesiredState()
		
		public FLR_RESULT gaoSetRnsThDamp(UInt16 thDamp){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsThDamp(this, thDamp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsThDamp()
		
		public FLR_RESULT gaoGetRnsThDamp(out UInt16 thDamp){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsThDamp(this, out thDamp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsThDamp()
		
		public FLR_RESULT gaoSetRnsThException(UInt16 thException){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsThException(this, thException);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsThException()
		
		public FLR_RESULT gaoGetRnsThException(out UInt16 thException){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsThException(this, out thException);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsThException()
		
		public FLR_RESULT gaoSetRnsThBad(UInt16 thBad){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsThBad(this, thBad);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsThBad()
		
		public FLR_RESULT gaoGetRnsThBad(out UInt16 thBad){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsThBad(this, out thBad);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsThBad()
		
		public FLR_RESULT gaoSetRnsThBadInitial(UInt16 thBadInitial){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsThBadInitial(this, thBadInitial);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsThBadInitial()
		
		public FLR_RESULT gaoGetRnsThBadInitial(out UInt16 thBadInitial){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsThBadInitial(this, out thBadInitial);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsThBadInitial()
		
		public FLR_RESULT gaoSetRnsThAllowedExceptions(UInt16 thAllowedExceptions){
			FLR_RESULT returncode = ClientPackager.GaoSetRnsThAllowedExceptions(this, thAllowedExceptions);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRnsThAllowedExceptions()
		
		public FLR_RESULT gaoGetRnsThAllowedExceptions(out UInt16 thAllowedExceptions){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsThAllowedExceptions(this, out thAllowedExceptions);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsThAllowedExceptions()
		
		public FLR_RESULT gaoGetRnsFramesExceptionLimitReached(out UInt32 framesReached){
			FLR_RESULT returncode = ClientPackager.GaoGetRnsFramesExceptionLimitReached(this, out framesReached);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnsFramesExceptionLimitReached()
		
		public FLR_RESULT gaoGetAppliedClip(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.GaoGetAppliedClip(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAppliedClip()
		
		public FLR_RESULT gaoSetAppliedClipEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoSetAppliedClipEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetAppliedClipEnable()
		
		public FLR_RESULT gaoGetAppliedClipEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.GaoGetAppliedClipEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAppliedClipEnable()
		
		// end Module gao
	// Begin Module imageStats
		public FLR_RESULT imageStatsGetTotalHistPixelsInROI(out UInt32 totalPixelsInROI){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetTotalHistPixelsInROI(this, out totalPixelsInROI);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTotalHistPixelsInROI()
		
		public FLR_RESULT imageStatsGetPopBelowLowToHighThresh(out UInt32 popBelowLowToHighThresh){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetPopBelowLowToHighThresh(this, out popBelowLowToHighThresh);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPopBelowLowToHighThresh()
		
		public FLR_RESULT imageStatsGetPopAboveHighToLowThresh(out UInt32 popAboveHighToLowThresh){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetPopAboveHighToLowThresh(this, out popAboveHighToLowThresh);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPopAboveHighToLowThresh()
		
		public FLR_RESULT imageStatsSetROI(FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.ImagestatsSetROI(this, roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetROI()
		
		public FLR_RESULT imageStatsGetROI(out FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetROI(this, out roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetROI()
		
		public FLR_RESULT imageStatsGetFirstBin(out UInt16 firstBin){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetFirstBin(this, out firstBin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFirstBin()
		
		public FLR_RESULT imageStatsGetLastBin(out UInt16 lastBin){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetLastBin(this, out lastBin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastBin()
		
		public FLR_RESULT imageStatsGetMean(out UInt16 mean){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetMean(this, out mean);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMean()
		
		public FLR_RESULT imageStatsGetFirstBinInROI(out UInt16 firstBinInROI){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetFirstBinInROI(this, out firstBinInROI);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFirstBinInROI()
		
		public FLR_RESULT imageStatsGetLastBinInROI(out UInt16 lastBinInROI){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetLastBinInROI(this, out lastBinInROI);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLastBinInROI()
		
		public FLR_RESULT imageStatsGetMeanInROI(out UInt16 meanInROI){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetMeanInROI(this, out meanInROI);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMeanInROI()
		
		public FLR_RESULT imageStatsGetImageStats(out UInt16 meanIntensity, out UInt16 peakIntensity, out UInt16 baseIntensity){
			FLR_RESULT returncode = ClientPackager.ImagestatsGetImageStats(this, out meanIntensity, out peakIntensity, out baseIntensity);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetImageStats()
		
		// end Module imageStats
	// Begin Module isotherm
		public FLR_RESULT isothermGetEnable(out FLR_ENABLE_E isothermEnable){
			FLR_RESULT returncode = ClientPackager.IsothermGetEnable(this, out isothermEnable);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnable()
		
		public FLR_RESULT isothermSetEnable(FLR_ENABLE_E isothermEnable){
			FLR_RESULT returncode = ClientPackager.IsothermSetEnable(this, isothermEnable);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnable()
		
		public FLR_RESULT isothermSetTemps(FLR_ISOTHERM_GAIN_E table, Int32 thIsoT1, Int32 thIsoT2, Int32 thIsoT3, Int32 thIsoT4, Int32 thIsoT5){
			FLR_RESULT returncode = ClientPackager.IsothermSetTemps(this, table, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTemps()
		
		public FLR_RESULT isothermGetTemps(FLR_ISOTHERM_GAIN_E table, out Int32 thIsoT1, out Int32 thIsoT2, out Int32 thIsoT3, out Int32 thIsoT4, out Int32 thIsoT5){
			FLR_RESULT returncode = ClientPackager.IsothermGetTemps(this, table, out thIsoT1, out thIsoT2, out thIsoT3, out thIsoT4, out thIsoT5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTemps()
		
		public FLR_RESULT isothermSetIsoColorValues(FLR_ISOTHERM_GAIN_E table, FLR_ISOTHERM_COLORS_T region0, FLR_ISOTHERM_COLORS_T region1, FLR_ISOTHERM_COLORS_T region2, FLR_ISOTHERM_COLORS_T region3, FLR_ISOTHERM_COLORS_T region4, FLR_ISOTHERM_COLORS_T region5){
			FLR_RESULT returncode = ClientPackager.IsothermSetIsoColorValues(this, table, region0, region1, region2, region3, region4, region5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIsoColorValues()
		
		public FLR_RESULT isothermGetIsoColorValues(FLR_ISOTHERM_GAIN_E table, out FLR_ISOTHERM_COLORS_T region0, out FLR_ISOTHERM_COLORS_T region1, out FLR_ISOTHERM_COLORS_T region2, out FLR_ISOTHERM_COLORS_T region3, out FLR_ISOTHERM_COLORS_T region4, out FLR_ISOTHERM_COLORS_T region5){
			FLR_RESULT returncode = ClientPackager.IsothermGetIsoColorValues(this, table, out region0, out region1, out region2, out region3, out region4, out region5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIsoColorValues()
		
		public FLR_RESULT isothermSetRegionMode(FLR_ISOTHERM_GAIN_E table, FLR_ISOTHERM_REGION_E region0, FLR_ISOTHERM_REGION_E region1, FLR_ISOTHERM_REGION_E region2, FLR_ISOTHERM_REGION_E region3, FLR_ISOTHERM_REGION_E region4, FLR_ISOTHERM_REGION_E region5){
			FLR_RESULT returncode = ClientPackager.IsothermSetRegionMode(this, table, region0, region1, region2, region3, region4, region5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRegionMode()
		
		public FLR_RESULT isothermGetRegionMode(FLR_ISOTHERM_GAIN_E table, out FLR_ISOTHERM_REGION_E region0, out FLR_ISOTHERM_REGION_E region1, out FLR_ISOTHERM_REGION_E region2, out FLR_ISOTHERM_REGION_E region3, out FLR_ISOTHERM_REGION_E region4, out FLR_ISOTHERM_REGION_E region5){
			FLR_RESULT returncode = ClientPackager.IsothermGetRegionMode(this, table, out region0, out region1, out region2, out region3, out region4, out region5);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRegionMode()
		
		public FLR_RESULT isothermGetUnit(out FLR_ISOTHERM_UNIT_E unit){
			FLR_RESULT returncode = ClientPackager.IsothermGetUnit(this, out unit);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUnit()
		
		public FLR_RESULT isothermSetUnit(FLR_ISOTHERM_UNIT_E unit){
			FLR_RESULT returncode = ClientPackager.IsothermSetUnit(this, unit);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetUnit()
		
		public FLR_RESULT isothermGetSettingsLowGain(out FLR_ISOTHERM_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.IsothermGetSettingsLowGain(this, out settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSettingsLowGain()
		
		public FLR_RESULT isothermSetSettingsLowGain(FLR_ISOTHERM_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.IsothermSetSettingsLowGain(this, settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSettingsLowGain()
		
		public FLR_RESULT isothermGetSettingsHighGain(out FLR_ISOTHERM_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.IsothermGetSettingsHighGain(this, out settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSettingsHighGain()
		
		public FLR_RESULT isothermSetSettingsHighGain(FLR_ISOTHERM_SETTINGS_T settings){
			FLR_RESULT returncode = ClientPackager.IsothermSetSettingsHighGain(this, settings);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSettingsHighGain()
		
		public FLR_RESULT isothermSetColorLutId(FLR_COLORLUT_ID_E colorLutIdLowGain, FLR_COLORLUT_ID_E colorLutIdHighGain){
			FLR_RESULT returncode = ClientPackager.IsothermSetColorLutId(this, colorLutIdLowGain, colorLutIdHighGain);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetColorLutId()
		
		public FLR_RESULT isothermGetColorLutId(out FLR_COLORLUT_ID_E colorLutIdLowGain, out FLR_COLORLUT_ID_E colorLutIdHighGain){
			FLR_RESULT returncode = ClientPackager.IsothermGetColorLutId(this, out colorLutIdLowGain, out colorLutIdHighGain);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetColorLutId()
		
		// end Module isotherm
	// Begin Module jffs2
		public FLR_RESULT jffs2Mount(){
			FLR_RESULT returncode = ClientPackager.Jffs2Mount(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Mount()
		
		public FLR_RESULT jffs2Unmount(){
			FLR_RESULT returncode = ClientPackager.Jffs2Unmount(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Unmount()
		
		public FLR_RESULT jffs2GetState(out FLR_JFFS2_STATE_E state){
			FLR_RESULT returncode = ClientPackager.Jffs2GetState(this, out state);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetState()
		
		// end Module jffs2
	// Begin Module lagrange
		// end Module lagrange
	// Begin Module lfsr
		public FLR_RESULT lfsrSetApplyOffsetEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrSetApplyOffsetEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetApplyOffsetEnableState()
		
		public FLR_RESULT lfsrGetApplyOffsetEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrGetApplyOffsetEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetApplyOffsetEnableState()
		
		public FLR_RESULT lfsrSetMaxIterations(UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrSetMaxIterations(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxIterations()
		
		public FLR_RESULT lfsrGetMaxIterations(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrGetMaxIterations(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxIterations()
		
		public FLR_RESULT lfsrSetDf(UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrSetDf(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDf()
		
		public FLR_RESULT lfsrGetDf(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrGetDf(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDf()
		
		public FLR_RESULT lfsrSetLambda1(Double data){
			FLR_RESULT returncode = ClientPackager.LfsrSetLambda1(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLambda1()
		
		public FLR_RESULT lfsrGetLambda1(out Double data){
			FLR_RESULT returncode = ClientPackager.LfsrGetLambda1(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLambda1()
		
		public FLR_RESULT lfsrSetLambda2(Double data){
			FLR_RESULT returncode = ClientPackager.LfsrSetLambda2(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLambda2()
		
		public FLR_RESULT lfsrGetLambda2(out Double data){
			FLR_RESULT returncode = ClientPackager.LfsrGetLambda2(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLambda2()
		
		public FLR_RESULT lfsrSetHaltEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrSetHaltEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetHaltEnable()
		
		public FLR_RESULT lfsrGetHaltEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrGetHaltEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetHaltEnable()
		
		public FLR_RESULT lfsrSetRandomMethod(UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrSetRandomMethod(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRandomMethod()
		
		public FLR_RESULT lfsrGetRandomMethod(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.LfsrGetRandomMethod(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRandomMethod()
		
		public FLR_RESULT lfsrSetSingleStepEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrSetSingleStepEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSingleStepEnable()
		
		public FLR_RESULT lfsrGetSingleStepEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrGetSingleStepEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSingleStepEnable()
		
		public FLR_RESULT lfsrSetR_LocalBump(Double data){
			FLR_RESULT returncode = ClientPackager.LfsrSetR_LocalBump(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetR_LocalBump()
		
		public FLR_RESULT lfsrGetR_LocalBump(out Double data){
			FLR_RESULT returncode = ClientPackager.LfsrGetR_LocalBump(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetR_LocalBump()
		
		public FLR_RESULT lfsrSetR_CornerBump(Double data){
			FLR_RESULT returncode = ClientPackager.LfsrSetR_CornerBump(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetR_CornerBump()
		
		public FLR_RESULT lfsrGetR_CornerBump(out Double data){
			FLR_RESULT returncode = ClientPackager.LfsrGetR_CornerBump(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetR_CornerBump()
		
		public FLR_RESULT lfsrSetFFC_ResetEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrSetFFC_ResetEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFFC_ResetEnable()
		
		public FLR_RESULT lfsrGetFFC_ResetEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrGetFFC_ResetEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFFC_ResetEnable()
		
		public FLR_RESULT lfsrSetNormalizeAtCenterSpotState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrSetNormalizeAtCenterSpotState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNormalizeAtCenterSpotState()
		
		public FLR_RESULT lfsrGetNormalizeAtCenterSpotState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.LfsrGetNormalizeAtCenterSpotState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNormalizeAtCenterSpotState()
		
		// end Module lfsr
	// Begin Module mem
		public FLR_RESULT memReadCapture(Byte bufferNum, UInt32 offset, UInt16 sizeInBytes, out Byte[] data){
			if (sizeInBytes > MaxMemoryChunk)
			{
				data = null;
				return FLR_RESULT.FLR_DATA_SIZE_ERROR;
			}
			FLR_RESULT returncode = ClientPackager.MemReadCapture(this, bufferNum, offset, sizeInBytes, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReadCapture()
		
		public FLR_RESULT memGetCaptureSize(out UInt32 bytes, out UInt16 rows, out UInt16 columns){
			FLR_RESULT returncode = ClientPackager.MemGetCaptureSize(this, out bytes, out rows, out columns);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCaptureSize()
		
		public FLR_RESULT memWriteFlash(FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt16 sizeInBytes, Byte[] data){
			if (sizeInBytes > MaxMemoryChunk)
			{
				return FLR_RESULT.FLR_DATA_SIZE_ERROR;
			}
			FLR_RESULT returncode = ClientPackager.MemWriteFlash(this, location, index, offset, sizeInBytes, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of WriteFlash()
		
		public FLR_RESULT memReadFlash(FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt16 sizeInBytes, out Byte[] data){
			if (sizeInBytes > MaxMemoryChunk)
			{
				data = null;
				return FLR_RESULT.FLR_DATA_SIZE_ERROR;
			}
			FLR_RESULT returncode = ClientPackager.MemReadFlash(this, location, index, offset, sizeInBytes, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReadFlash()
		
		public FLR_RESULT memGetFlashSize(FLR_MEM_LOCATION_E location, out UInt32 bytes){
			FLR_RESULT returncode = ClientPackager.MemGetFlashSize(this, location, out bytes);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFlashSize()
		
		public FLR_RESULT memEraseFlash(FLR_MEM_LOCATION_E location, Byte index){
			FLR_RESULT returncode = ClientPackager.MemEraseFlash(this, location, index);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of EraseFlash()
		
		public FLR_RESULT memEraseFlashPartial(FLR_MEM_LOCATION_E location, Byte index, UInt32 offset, UInt32 length){
			FLR_RESULT returncode = ClientPackager.MemEraseFlashPartial(this, location, index, offset, length);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of EraseFlashPartial()
		
		public FLR_RESULT memReadCurrentGain(UInt32 offset, UInt16 sizeInBytes, out Byte[] data){
			if (sizeInBytes > MaxMemoryChunk)
			{
				data = null;
				return FLR_RESULT.FLR_DATA_SIZE_ERROR;
			}
			FLR_RESULT returncode = ClientPackager.MemReadCurrentGain(this, offset, sizeInBytes, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReadCurrentGain()
		
		public FLR_RESULT memGetGainSize(out UInt32 bytes, out UInt16 rows, out UInt16 columns){
			FLR_RESULT returncode = ClientPackager.MemGetGainSize(this, out bytes, out rows, out columns);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGainSize()
		
		public FLR_RESULT memGetCaptureSizeSrc(FLR_CAPTURE_SRC_E src, out UInt32 bytes, out UInt16 rows, out UInt16 columns){
			FLR_RESULT returncode = ClientPackager.MemGetCaptureSizeSrc(this, src, out bytes, out rows, out columns);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCaptureSizeSrc()
		
		public FLR_RESULT memReadCaptureSrc(FLR_CAPTURE_SRC_E src, Byte bufferNum, UInt32 offset, UInt16 sizeInBytes, out Byte[] data){
			if (sizeInBytes > MaxMemoryChunk)
			{
				data = null;
				return FLR_RESULT.FLR_DATA_SIZE_ERROR;
			}
			FLR_RESULT returncode = ClientPackager.MemReadCaptureSrc(this, src, bufferNum, offset, sizeInBytes, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReadCaptureSrc()
		
		// end Module mem
	// Begin Module normalize
		// end Module normalize
	// Begin Module radiometry
		public FLR_RESULT radiometrySetTempStableEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempStableEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempStableEnable()
		
		public FLR_RESULT radiometryGetTempStableEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempStableEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempStableEnable()
		
		public FLR_RESULT radiometrySetFNumberLens0(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetFNumberLens0(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFNumberLens0()
		
		public FLR_RESULT radiometryGetFNumberLens0(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetFNumberLens0(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFNumberLens0()
		
		public FLR_RESULT radiometrySetFNumberLens1(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetFNumberLens1(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFNumberLens1()
		
		public FLR_RESULT radiometryGetFNumberLens1(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetFNumberLens1(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFNumberLens1()
		
		public FLR_RESULT radiometrySetTauLens0(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTauLens0(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTauLens0()
		
		public FLR_RESULT radiometryGetTauLens0(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTauLens0(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTauLens0()
		
		public FLR_RESULT radiometrySetTauLens1(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTauLens1(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTauLens1()
		
		public FLR_RESULT radiometryGetTauLens1(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTauLens1(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTauLens1()
		
		public FLR_RESULT radiometryGetGlobalGainDesired(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalGainDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalGainDesired()
		
		public FLR_RESULT radiometryGetGlobalOffsetDesired(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalOffsetDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalOffsetDesired()
		
		public FLR_RESULT radiometryGetGlobalGainApplied(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalGainApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalGainApplied()
		
		public FLR_RESULT radiometryGetGlobalOffsetApplied(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalOffsetApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalOffsetApplied()
		
		public FLR_RESULT radiometrySetTComponentOverrideMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTComponentOverrideMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTComponentOverrideMode()
		
		public FLR_RESULT radiometryGetTComponentOverrideMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTComponentOverrideMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTComponentOverrideMode()
		
		public FLR_RESULT radiometrySetGlobalGainOverride(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetGlobalGainOverride(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGlobalGainOverride()
		
		public FLR_RESULT radiometryGetGlobalGainOverride(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalGainOverride(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalGainOverride()
		
		public FLR_RESULT radiometrySetGlobalOffsetOverride(UInt16 data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetGlobalOffsetOverride(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGlobalOffsetOverride()
		
		public FLR_RESULT radiometryGetGlobalOffsetOverride(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalOffsetOverride(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalOffsetOverride()
		
		public FLR_RESULT radiometrySetGlobalParamOverrideMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetGlobalParamOverrideMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGlobalParamOverrideMode()
		
		public FLR_RESULT radiometryGetGlobalParamOverrideMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGlobalParamOverrideMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGlobalParamOverrideMode()
		
		public FLR_RESULT radiometrySetRBFOHighGainDefault(FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetRBFOHighGainDefault(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRBFOHighGainDefault()
		
		public FLR_RESULT radiometryGetRBFOHighGainDefault(out FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRBFOHighGainDefault(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRBFOHighGainDefault()
		
		public FLR_RESULT radiometrySetRBFOLowGainDefault(FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetRBFOLowGainDefault(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRBFOLowGainDefault()
		
		public FLR_RESULT radiometryGetRBFOLowGainDefault(out FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRBFOLowGainDefault(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRBFOLowGainDefault()
		
		public FLR_RESULT radiometrySetRBFOHighGainFactory(FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetRBFOHighGainFactory(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRBFOHighGainFactory()
		
		public FLR_RESULT radiometryGetRBFOHighGainFactory(out FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRBFOHighGainFactory(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRBFOHighGainFactory()
		
		public FLR_RESULT radiometrySetRBFOLowGainFactory(FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetRBFOLowGainFactory(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRBFOLowGainFactory()
		
		public FLR_RESULT radiometryGetRBFOLowGainFactory(out FLR_RADIOMETRY_RBFO_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRBFOLowGainFactory(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRBFOLowGainFactory()
		
		public FLR_RESULT radiometrySetDampingFactor(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetDampingFactor(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDampingFactor()
		
		public FLR_RESULT radiometryGetDampingFactor(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetDampingFactor(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDampingFactor()
		
		public FLR_RESULT radiometryGetGoMEQ(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGoMEQ(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGoMEQ()
		
		public FLR_RESULT radiometryGetGoMShutter(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGoMShutter(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGoMShutter()
		
		public FLR_RESULT radiometryGetGoMLens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGoMLens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGoMLens()
		
		public FLR_RESULT radiometryGetGoMLG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGoMLG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGoMLG()
		
		public FLR_RESULT radiometryGetGoMFFC(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGoMFFC(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGoMFFC()
		
		public FLR_RESULT radiometryGetTempLensHousing(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempLensHousing(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempLensHousing()
		
		public FLR_RESULT radiometryGetTempShutterHousing(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempShutterHousing(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempShutterHousing()
		
		public FLR_RESULT radiometryGetTempShutterPaddle(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempShutterPaddle(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempShutterPaddle()
		
		public FLR_RESULT radiometrySetFNumberShutterHousing(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetFNumberShutterHousing(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFNumberShutterHousing()
		
		public FLR_RESULT radiometryGetFNumberShutterHousing(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetFNumberShutterHousing(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFNumberShutterHousing()
		
		public FLR_RESULT radiometrySetEmissivityShutterHousing(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetEmissivityShutterHousing(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEmissivityShutterHousing()
		
		public FLR_RESULT radiometryGetEmissivityShutterHousing(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetEmissivityShutterHousing(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEmissivityShutterHousing()
		
		public FLR_RESULT radiometrySetM_DTfpa_Lens(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_DTfpa_Lens(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_DTfpa_Lens()
		
		public FLR_RESULT radiometryGetM_DTfpa_Lens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_DTfpa_Lens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_DTfpa_Lens()
		
		public FLR_RESULT radiometrySetOffset_Lens(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetOffset_Lens(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOffset_Lens()
		
		public FLR_RESULT radiometryGetOffset_Lens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetOffset_Lens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOffset_Lens()
		
		public FLR_RESULT radiometrySetM_Recursive_Lens(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Recursive_Lens(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Recursive_Lens()
		
		public FLR_RESULT radiometryGetM_Recursive_Lens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Recursive_Lens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Recursive_Lens()
		
		public FLR_RESULT radiometryGetGgFfc(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGgFfc(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGgFfc()
		
		public FLR_RESULT radiometryGetCountsFromTemp(FLR_RADIOMETRY_RBFO_TYPE_E rbfoType, Double temp, out UInt16 counts){
			FLR_RESULT returncode = ClientPackager.RadiometryGetCountsFromTemp(this, rbfoType, temp, out counts);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCountsFromTemp()
		
		public FLR_RESULT radiometryGetTempFromCounts(FLR_RADIOMETRY_RBFO_TYPE_E rbfoType, UInt16 counts, out Double temp){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempFromCounts(this, rbfoType, counts, out temp);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempFromCounts()
		
		public FLR_RESULT radiometrySetTempLensHousingOverride(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempLensHousingOverride(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempLensHousingOverride()
		
		public FLR_RESULT radiometryGetTempLensHousingOverride(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempLensHousingOverride(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempLensHousingOverride()
		
		public FLR_RESULT radiometrySetTempShutterHousingOverride(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempShutterHousingOverride(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempShutterHousingOverride()
		
		public FLR_RESULT radiometryGetTempShutterHousingOverride(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempShutterHousingOverride(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempShutterHousingOverride()
		
		public FLR_RESULT radiometrySetTempShutterPaddleOverride(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempShutterPaddleOverride(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempShutterPaddleOverride()
		
		public FLR_RESULT radiometryGetTempShutterPaddleOverride(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempShutterPaddleOverride(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempShutterPaddleOverride()
		
		public FLR_RESULT radiometrySetSignalFactorLut(FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetSignalFactorLut(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSignalFactorLut()
		
		public FLR_RESULT radiometryGetSignalFactorLut(out FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetSignalFactorLut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSignalFactorLut()
		
		public FLR_RESULT radiometrySetNoiseFactorLut(FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetNoiseFactorLut(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNoiseFactorLut()
		
		public FLR_RESULT radiometryGetNoiseFactorLut(out FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetNoiseFactorLut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNoiseFactorLut()
		
		public FLR_RESULT radiometrySetM_tfpaK(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_tfpaK(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_tfpaK()
		
		public FLR_RESULT radiometryGetM_tfpaK(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_tfpaK(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_tfpaK()
		
		public FLR_RESULT radiometrySetB_tfpaK(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_tfpaK(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_tfpaK()
		
		public FLR_RESULT radiometryGetB_tfpaK(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_tfpaK(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_tfpaK()
		
		public FLR_RESULT radiometrySetTAuxParams(FLR_RADIOMETRY_TAUX_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTAuxParams(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTAuxParams()
		
		public FLR_RESULT radiometryGetTAuxParams(out FLR_RADIOMETRY_TAUX_PARAMS_T data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTAuxParams(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTAuxParams()
		
		public FLR_RESULT radiometrySetM_tAux(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_tAux(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_tAux()
		
		public FLR_RESULT radiometryGetM_tAux(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_tAux(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_tAux()
		
		public FLR_RESULT radiometrySetB_tAux(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_tAux(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_tAux()
		
		public FLR_RESULT radiometryGetB_tAux(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_tAux(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_tAux()
		
		public FLR_RESULT radiometrySetTsource_FFC(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTsource_FFC(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTsource_FFC()
		
		public FLR_RESULT radiometryGetTsource_FFC(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTsource_FFC(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTsource_FFC()
		
		public FLR_RESULT radiometrySetM_DTfpa_Sh_h(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_DTfpa_Sh_h(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_DTfpa_Sh_h()
		
		public FLR_RESULT radiometryGetM_DTfpa_Sh_h(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_DTfpa_Sh_h(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_DTfpa_Sh_h()
		
		public FLR_RESULT radiometrySetOffset_Sh_h(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetOffset_Sh_h(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOffset_Sh_h()
		
		public FLR_RESULT radiometryGetOffset_Sh_h(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetOffset_Sh_h(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOffset_Sh_h()
		
		public FLR_RESULT radiometrySetM_Recursive_Sh_h(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Recursive_Sh_h(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Recursive_Sh_h()
		
		public FLR_RESULT radiometryGetM_Recursive_Sh_h(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Recursive_Sh_h(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Recursive_Sh_h()
		
		public FLR_RESULT radiometrySetM_DTfpa_Sh_p(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_DTfpa_Sh_p(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_DTfpa_Sh_p()
		
		public FLR_RESULT radiometryGetM_DTfpa_Sh_p(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_DTfpa_Sh_p(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_DTfpa_Sh_p()
		
		public FLR_RESULT radiometrySetOffset_Sh_p(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetOffset_Sh_p(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOffset_Sh_p()
		
		public FLR_RESULT radiometryGetOffset_Sh_p(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetOffset_Sh_p(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOffset_Sh_p()
		
		public FLR_RESULT radiometrySetM_Recursive_Sh_p(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Recursive_Sh_p(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Recursive_Sh_p()
		
		public FLR_RESULT radiometryGetM_Recursive_Sh_p(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Recursive_Sh_p(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Recursive_Sh_p()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_p(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_p(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_p()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_p(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_p(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_p()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_p(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_p(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_p()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_p(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_p(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_p()
		
		public FLR_RESULT radiometryGetDtTfpaK(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetDtTfpaK(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDtTfpaK()
		
		public FLR_RESULT radiometryGetDtTfpaK_Damp(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetDtTfpaK_Damp(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDtTfpaK_Damp()
		
		public FLR_RESULT radiometryGetTAuxK(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTAuxK(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTAuxK()
		
		public FLR_RESULT radiometrySetExternalFfcUpdateMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetExternalFfcUpdateMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetExternalFfcUpdateMode()
		
		public FLR_RESULT radiometryGetExternalFfcUpdateMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetExternalFfcUpdateMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetExternalFfcUpdateMode()
		
		public FLR_RESULT radiometryGetGG_scale(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGG_scale(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGG_scale()
		
		public FLR_RESULT radiometrySetTempWindow(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempWindow(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempWindow()
		
		public FLR_RESULT radiometryGetTempWindow(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempWindow(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempWindow()
		
		public FLR_RESULT radiometrySetTransmissionWindow(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTransmissionWindow(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTransmissionWindow()
		
		public FLR_RESULT radiometryGetTransmissionWindow(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTransmissionWindow(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTransmissionWindow()
		
		public FLR_RESULT radiometrySetReflectivityWindow(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetReflectivityWindow(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetReflectivityWindow()
		
		public FLR_RESULT radiometryGetReflectivityWindow(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetReflectivityWindow(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetReflectivityWindow()
		
		public FLR_RESULT radiometrySetTempWindowReflection(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempWindowReflection(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempWindowReflection()
		
		public FLR_RESULT radiometryGetTempWindowReflection(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempWindowReflection(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempWindowReflection()
		
		public FLR_RESULT radiometrySetTransmissionAtmosphere(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTransmissionAtmosphere(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTransmissionAtmosphere()
		
		public FLR_RESULT radiometryGetTransmissionAtmosphere(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTransmissionAtmosphere(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTransmissionAtmosphere()
		
		public FLR_RESULT radiometrySetTempAtmosphere(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempAtmosphere(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempAtmosphere()
		
		public FLR_RESULT radiometryGetTempAtmosphere(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempAtmosphere(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempAtmosphere()
		
		public FLR_RESULT radiometrySetEmissivityTarget(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetEmissivityTarget(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEmissivityTarget()
		
		public FLR_RESULT radiometryGetEmissivityTarget(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetEmissivityTarget(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEmissivityTarget()
		
		public FLR_RESULT radiometrySetTempBackground(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTempBackground(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempBackground()
		
		public FLR_RESULT radiometryGetTempBackground(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTempBackground(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempBackground()
		
		public FLR_RESULT radiometryGetRadiometryCapable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRadiometryCapable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRadiometryCapable()
		
		public FLR_RESULT radiometrySetdeltaTempDampingFactor(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetdeltaTempDampingFactor(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetdeltaTempDampingFactor()
		
		public FLR_RESULT radiometryGetdeltaTempDampingFactor(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetdeltaTempDampingFactor(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetdeltaTempDampingFactor()
		
		public FLR_RESULT radiometrySetdeltaTempIntervalTime(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetdeltaTempIntervalTime(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetdeltaTempIntervalTime()
		
		public FLR_RESULT radiometryGetdeltaTempIntervalTime(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetdeltaTempIntervalTime(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetdeltaTempIntervalTime()
		
		public FLR_RESULT radiometrySetdeltaTempMaxValue(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetdeltaTempMaxValue(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetdeltaTempMaxValue()
		
		public FLR_RESULT radiometryGetdeltaTempMaxValue(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetdeltaTempMaxValue(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetdeltaTempMaxValue()
		
		public FLR_RESULT radiometrySetdeltaTempMaxIncrement(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetdeltaTempMaxIncrement(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetdeltaTempMaxIncrement()
		
		public FLR_RESULT radiometryGetdeltaTempMaxIncrement(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetdeltaTempMaxIncrement(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetdeltaTempMaxIncrement()
		
		public FLR_RESULT radiometrySetdeltaTempDampingTime(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetdeltaTempDampingTime(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetdeltaTempDampingTime()
		
		public FLR_RESULT radiometryGetdeltaTempDampingTime(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetdeltaTempDampingTime(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetdeltaTempDampingTime()
		
		public FLR_RESULT radiometryGetResponsivityFpaTemp(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetResponsivityFpaTemp(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetResponsivityFpaTemp()
		
		public FLR_RESULT radiometrySetM_Delta_Lens(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Lens(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Lens()
		
		public FLR_RESULT radiometryGetM_Delta_Lens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Lens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Lens()
		
		public FLR_RESULT radiometrySetB_Delta_Lens(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Lens(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Lens()
		
		public FLR_RESULT radiometryGetB_Delta_Lens(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Lens(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Lens()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_h(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_h(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_h()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_h(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_h(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_h()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_h(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_h(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_h()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_h(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_h(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_h()
		
		public FLR_RESULT radiometrySetGG_Scale_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetGG_Scale_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGG_Scale_HG()
		
		public FLR_RESULT radiometryGetGG_Scale_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGG_Scale_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGG_Scale_HG()
		
		public FLR_RESULT radiometrySetGG_Scale_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetGG_Scale_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetGG_Scale_LG()
		
		public FLR_RESULT radiometryGetGG_Scale_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGG_Scale_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGG_Scale_LG()
		
		public FLR_RESULT radiometrySetRbfoScaledMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetRbfoScaledMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRbfoScaledMode()
		
		public FLR_RESULT radiometryGetRbfoScaledMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetRbfoScaledMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRbfoScaledMode()
		
		public FLR_RESULT radiometryGetUncertaintyFactor(out FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetUncertaintyFactor(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUncertaintyFactor()
		
		public FLR_RESULT radiometryGetTRoomMinThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTRoomMinThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTRoomMinThresh()
		
		public FLR_RESULT radiometryGetTRoomMaxThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTRoomMaxThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTRoomMaxThresh()
		
		public FLR_RESULT radiometryGetTOperatingMinThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTOperatingMinThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTOperatingMinThresh()
		
		public FLR_RESULT radiometryGetTOperatingMaxThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTOperatingMaxThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTOperatingMaxThresh()
		
		public FLR_RESULT radiometryGetStableTempThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetStableTempThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStableTempThresh()
		
		public FLR_RESULT radiometryGetSlowDriftThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetSlowDriftThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSlowDriftThresh()
		
		public FLR_RESULT radiometryGetFfcTempThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetFfcTempThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFfcTempThresh()
		
		public FLR_RESULT radiometryGetTargetTempMinThreshLG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTargetTempMinThreshLG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTargetTempMinThreshLG()
		
		public FLR_RESULT radiometryGetTargetTempMaxThreshLG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTargetTempMaxThreshLG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTargetTempMaxThreshLG()
		
		public FLR_RESULT radiometryGetMFactorThresh(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetMFactorThresh(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMFactorThresh()
		
		public FLR_RESULT radiometryGetTargetTempMinThreshHG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTargetTempMinThreshHG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTargetTempMinThreshHG()
		
		public FLR_RESULT radiometryGetTargetTempMaxThreshHG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTargetTempMaxThreshHG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTargetTempMaxThreshHG()
		
		public FLR_RESULT radiometryGetUncertaintyStatusBits(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetUncertaintyStatusBits(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUncertaintyStatusBits()
		
		public FLR_RESULT radiometrySetTemperatureOffset_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTemperatureOffset_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTemperatureOffset_HG()
		
		public FLR_RESULT radiometryGetTemperatureOffset_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTemperatureOffset_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTemperatureOffset_HG()
		
		public FLR_RESULT radiometrySetTemperatureOffset_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetTemperatureOffset_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTemperatureOffset_LG()
		
		public FLR_RESULT radiometryGetTemperatureOffset_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetTemperatureOffset_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTemperatureOffset_LG()
		
		public FLR_RESULT radiometrySetM_Delta_Lens_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Lens_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Lens_HG()
		
		public FLR_RESULT radiometryGetM_Delta_Lens_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Lens_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Lens_HG()
		
		public FLR_RESULT radiometrySetB_Delta_Lens_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Lens_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Lens_HG()
		
		public FLR_RESULT radiometryGetB_Delta_Lens_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Lens_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Lens_HG()
		
		public FLR_RESULT radiometrySetM_Delta_Lens_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Lens_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Lens_LG()
		
		public FLR_RESULT radiometryGetM_Delta_Lens_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Lens_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Lens_LG()
		
		public FLR_RESULT radiometrySetB_Delta_Lens_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Lens_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Lens_LG()
		
		public FLR_RESULT radiometryGetB_Delta_Lens_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Lens_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Lens_LG()
		
		public FLR_RESULT radiometrySetOffset_Lens_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetOffset_Lens_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOffset_Lens_HG()
		
		public FLR_RESULT radiometryGetOffset_Lens_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetOffset_Lens_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOffset_Lens_HG()
		
		public FLR_RESULT radiometrySetOffset_Lens_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetOffset_Lens_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOffset_Lens_LG()
		
		public FLR_RESULT radiometryGetOffset_Lens_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetOffset_Lens_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOffset_Lens_LG()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_p_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_p_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_p_HG()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_p_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_p_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_p_HG()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_p_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_p_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_p_HG()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_p_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_p_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_p_HG()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_p_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_p_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_p_LG()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_p_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_p_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_p_LG()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_p_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_p_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_p_LG()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_p_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_p_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_p_LG()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_h_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_h_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_h_HG()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_h_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_h_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_h_HG()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_h_HG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_h_HG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_h_HG()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_h_HG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_h_HG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_h_HG()
		
		public FLR_RESULT radiometrySetM_Delta_Sh_h_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetM_Delta_Sh_h_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_Delta_Sh_h_LG()
		
		public FLR_RESULT radiometryGetM_Delta_Sh_h_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetM_Delta_Sh_h_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_Delta_Sh_h_LG()
		
		public FLR_RESULT radiometrySetB_Delta_Sh_h_LG(Double data){
			FLR_RESULT returncode = ClientPackager.RadiometrySetB_Delta_Sh_h_LG(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetB_Delta_Sh_h_LG()
		
		public FLR_RESULT radiometryGetB_Delta_Sh_h_LG(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetB_Delta_Sh_h_LG(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetB_Delta_Sh_h_LG()
		
		public FLR_RESULT radiometryGetGG_RoomTemp(out Double data){
			FLR_RESULT returncode = ClientPackager.RadiometryGetGG_RoomTemp(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetGG_RoomTemp()
		
		// end Module radiometry
	// Begin Module roic
		public FLR_RESULT roicGetFPATemp(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetFPATemp(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPATemp()
		
		public FLR_RESULT roicGetFrameCount(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.RoicGetFrameCount(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFrameCount()
		
		public FLR_RESULT roicGetActiveNormalizationTarget(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetActiveNormalizationTarget(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetActiveNormalizationTarget()
		
		public FLR_RESULT roicSetFPARampState(FLR_ENABLE_E state){
			FLR_RESULT returncode = ClientPackager.RoicSetFPARampState(this, state);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFPARampState()
		
		public FLR_RESULT roicGetFPARampState(out FLR_ENABLE_E state){
			FLR_RESULT returncode = ClientPackager.RoicGetFPARampState(this, out state);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPARampState()
		
		public FLR_RESULT roicGetSensorADC1(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetSensorADC1(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorADC1()
		
		public FLR_RESULT roicGetSensorADC2(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetSensorADC2(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorADC2()
		
		public FLR_RESULT roicSetFPATempOffset(Int16 data){
			FLR_RESULT returncode = ClientPackager.RoicSetFPATempOffset(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFPATempOffset()
		
		public FLR_RESULT roicGetFPATempOffset(out Int16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetFPATempOffset(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPATempOffset()
		
		public FLR_RESULT roicSetFPATempMode(FLR_ROIC_TEMP_MODE_E data){
			FLR_RESULT returncode = ClientPackager.RoicSetFPATempMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFPATempMode()
		
		public FLR_RESULT roicGetFPATempMode(out FLR_ROIC_TEMP_MODE_E data){
			FLR_RESULT returncode = ClientPackager.RoicGetFPATempMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPATempMode()
		
		public FLR_RESULT roicGetFPATempTable(out FLR_ROIC_FPATEMP_TABLE_T table){
			FLR_RESULT returncode = ClientPackager.RoicGetFPATempTable(this, out table);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPATempTable()
		
		public FLR_RESULT roicSetFPATempValue(UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicSetFPATempValue(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFPATempValue()
		
		public FLR_RESULT roicGetFPATempValue(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetFPATempValue(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFPATempValue()
		
		public FLR_RESULT roicGetPreambleError(out UInt32 preambleError){
			FLR_RESULT returncode = ClientPackager.RoicGetPreambleError(this, out preambleError);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPreambleError()
		
		public FLR_RESULT roicInducePreambleError(UInt32 everyNthFrame){
			FLR_RESULT returncode = ClientPackager.RoicInducePreambleError(this, everyNthFrame);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of InducePreambleError()
		
		public FLR_RESULT roicGetRoicStarted(out FLR_ENABLE_E roicStarted){
			FLR_RESULT returncode = ClientPackager.RoicGetRoicStarted(this, out roicStarted);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRoicStarted()
		
		public FLR_RESULT roicSetFrameSkip(UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicSetFrameSkip(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFrameSkip()
		
		public FLR_RESULT roicGetFrameSkip(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.RoicGetFrameSkip(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFrameSkip()
		
		public FLR_RESULT roicSetFrameOneShot(){
			FLR_RESULT returncode = ClientPackager.RoicSetFrameOneShot(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFrameOneShot()
		
		// end Module roic
	// Begin Module scaler
		public FLR_RESULT scalerGetMaxZoom(out UInt32 zoom){
			FLR_RESULT returncode = ClientPackager.ScalerGetMaxZoom(this, out zoom);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxZoom()
		
		public FLR_RESULT scalerSetZoom(FLR_SCALER_ZOOM_PARAMS_T zoomParams){
			FLR_RESULT returncode = ClientPackager.ScalerSetZoom(this, zoomParams);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetZoom()
		
		public FLR_RESULT scalerGetZoom(out FLR_SCALER_ZOOM_PARAMS_T zoomParams){
			FLR_RESULT returncode = ClientPackager.ScalerGetZoom(this, out zoomParams);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetZoom()
		
		public FLR_RESULT scalerSetFractionalZoom(UInt32 zoomNumerator, UInt32 zoomDenominator, UInt32 zoomXCenter, UInt32 zoomYCenter, FLR_ENABLE_E inChangeEnable, UInt32 zoomOutXCenter, UInt32 zoomOutYCenter, FLR_ENABLE_E outChangeEnable){
			FLR_RESULT returncode = ClientPackager.ScalerSetFractionalZoom(this, zoomNumerator, zoomDenominator, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFractionalZoom()
		
		public FLR_RESULT scalerSetIndexZoom(UInt32 zoomIndex, UInt32 zoomXCenter, UInt32 zoomYCenter, FLR_ENABLE_E inChangeEnable, UInt32 zoomOutXCenter, UInt32 zoomOutYCenter, FLR_ENABLE_E outChangeEnable){
			FLR_RESULT returncode = ClientPackager.ScalerSetIndexZoom(this, zoomIndex, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIndexZoom()
		
		// end Module scaler
	// Begin Module scnr
		public FLR_RESULT scnrSetEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrSetEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnableState()
		
		public FLR_RESULT scnrGetEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrGetEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnableState()
		
		public FLR_RESULT scnrSetThColSum(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetThColSum(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThColSum()
		
		public FLR_RESULT scnrGetThColSum(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetThColSum(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThColSum()
		
		public FLR_RESULT scnrSetThPixel(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetThPixel(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThPixel()
		
		public FLR_RESULT scnrGetThPixel(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetThPixel(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixel()
		
		public FLR_RESULT scnrSetMaxCorr(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetMaxCorr(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxCorr()
		
		public FLR_RESULT scnrGetMaxCorr(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetMaxCorr(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxCorr()
		
		public FLR_RESULT scnrGetThPixelApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetThPixelApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixelApplied()
		
		public FLR_RESULT scnrGetMaxCorrApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetMaxCorrApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxCorrApplied()
		
		public FLR_RESULT scnrSetThColSumSafe(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetThColSumSafe(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThColSumSafe()
		
		public FLR_RESULT scnrGetThColSumSafe(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetThColSumSafe(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThColSumSafe()
		
		public FLR_RESULT scnrSetThPixelSafe(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetThPixelSafe(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThPixelSafe()
		
		public FLR_RESULT scnrGetThPixelSafe(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetThPixelSafe(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixelSafe()
		
		public FLR_RESULT scnrSetMaxCorrSafe(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetMaxCorrSafe(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxCorrSafe()
		
		public FLR_RESULT scnrGetMaxCorrSafe(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetMaxCorrSafe(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxCorrSafe()
		
		public FLR_RESULT scnrSetCorrectionMethod(FLR_SCNR_CORR_SELECT_E data){
			FLR_RESULT returncode = ClientPackager.ScnrSetCorrectionMethod(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetCorrectionMethod()
		
		public FLR_RESULT scnrGetCorrectionMethod(out FLR_SCNR_CORR_SELECT_E data){
			FLR_RESULT returncode = ClientPackager.ScnrGetCorrectionMethod(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCorrectionMethod()
		
		public FLR_RESULT scnrSetStdThreshold(UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetStdThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetStdThreshold()
		
		public FLR_RESULT scnrGetStdThreshold(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetStdThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStdThreshold()
		
		public FLR_RESULT scnrSetNFrames(UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetNFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNFrames()
		
		public FLR_RESULT scnrGetNFrames(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetNFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNFrames()
		
		public FLR_RESULT scnrSetResetDesired(UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetResetDesired(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetResetDesired()
		
		public FLR_RESULT scnrGetResetDesired(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetResetDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetResetDesired()
		
		public FLR_RESULT scnrSetM_modeOnly(UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetM_modeOnly(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetM_modeOnly()
		
		public FLR_RESULT scnrGetM_modeOnly(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetM_modeOnly(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetM_modeOnly()
		
		public FLR_RESULT scnrGetMode(out FLR_SCNR_MODE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrGetMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMode()
		
		public FLR_RESULT scnrSetSpecklesEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrSetSpecklesEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpecklesEnableState()
		
		public FLR_RESULT scnrGetSpecklesEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesEnableState()
		
		public FLR_RESULT scnrSetSpecklesThreshold(UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrSetSpecklesThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpecklesThreshold()
		
		public FLR_RESULT scnrGetSpecklesThreshold(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesThreshold()
		
		public FLR_RESULT scnrSetSpecklesRatio(Double data){
			FLR_RESULT returncode = ClientPackager.ScnrSetSpecklesRatio(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpecklesRatio()
		
		public FLR_RESULT scnrGetSpecklesRatio(out Double data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesRatio(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesRatio()
		
		public FLR_RESULT scnrSetSpecklesDF(Double data){
			FLR_RESULT returncode = ClientPackager.ScnrSetSpecklesDF(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpecklesDF()
		
		public FLR_RESULT scnrGetSpecklesDF(out Double data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesDF(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesDF()
		
		public FLR_RESULT scnrGetSpecklesDiffsBufferAddr(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesDiffsBufferAddr(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesDiffsBufferAddr()
		
		public FLR_RESULT scnrGetSpecklesOffsBufferAddr(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesOffsBufferAddr(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesOffsBufferAddr()
		
		public FLR_RESULT scnrSetSpecklesResetDesired(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrSetSpecklesResetDesired(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpecklesResetDesired()
		
		public FLR_RESULT scnrGetSpecklesResetDesired(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.ScnrGetSpecklesResetDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpecklesResetDesired()
		
		// end Module scnr
	// Begin Module sffc
		public FLR_RESULT sffcGetScaleFactor(out Double data){
			FLR_RESULT returncode = ClientPackager.SffcGetScaleFactor(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetScaleFactor()
		
		public FLR_RESULT sffcGetDeltaTempLinearCoeff(out Double data){
			FLR_RESULT returncode = ClientPackager.SffcGetDeltaTempLinearCoeff(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDeltaTempLinearCoeff()
		
		public FLR_RESULT sffcSetDeltaTempLinearCoeff(Double data){
			FLR_RESULT returncode = ClientPackager.SffcSetDeltaTempLinearCoeff(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDeltaTempLinearCoeff()
		
		public FLR_RESULT sffcGetDeltaTempOffsetCoeff(out Double data){
			FLR_RESULT returncode = ClientPackager.SffcGetDeltaTempOffsetCoeff(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDeltaTempOffsetCoeff()
		
		public FLR_RESULT sffcSetDeltaTempOffsetCoeff(Double data){
			FLR_RESULT returncode = ClientPackager.SffcSetDeltaTempOffsetCoeff(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDeltaTempOffsetCoeff()
		
		public FLR_RESULT sffcGetFpaTempLinearCoeff(out Double data){
			FLR_RESULT returncode = ClientPackager.SffcGetFpaTempLinearCoeff(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFpaTempLinearCoeff()
		
		public FLR_RESULT sffcSetFpaTempLinearCoeff(Double data){
			FLR_RESULT returncode = ClientPackager.SffcSetFpaTempLinearCoeff(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFpaTempLinearCoeff()
		
		public FLR_RESULT sffcGetFpaTempOffsetCoeff(out Double data){
			FLR_RESULT returncode = ClientPackager.SffcGetFpaTempOffsetCoeff(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFpaTempOffsetCoeff()
		
		public FLR_RESULT sffcSetFpaTempOffsetCoeff(Double data){
			FLR_RESULT returncode = ClientPackager.SffcSetFpaTempOffsetCoeff(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFpaTempOffsetCoeff()
		
		public FLR_RESULT sffcGetDeltaTempTimeLimitInSecs(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.SffcGetDeltaTempTimeLimitInSecs(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDeltaTempTimeLimitInSecs()
		
		public FLR_RESULT sffcSetDeltaTempTimeLimitInSecs(UInt32 data){
			FLR_RESULT returncode = ClientPackager.SffcSetDeltaTempTimeLimitInSecs(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDeltaTempTimeLimitInSecs()
		
		// end Module sffc
	// Begin Module splashScreen
		public FLR_RESULT splashScreenSetDuration(UInt32 screen_num, UInt32 periodMs){
			FLR_RESULT returncode = ClientPackager.SplashscreenSetDuration(this, screen_num, periodMs);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDuration()
		
		public FLR_RESULT splashScreenSetDataType(UInt32 screen_num, FLR_SPLASHSCREEN_FILETYPE_E filetype){
			FLR_RESULT returncode = ClientPackager.SplashscreenSetDataType(this, screen_num, filetype);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDataType()
		
		public FLR_RESULT splashScreenSetBackground(UInt32 screen_num, UInt32 backgroundColor){
			FLR_RESULT returncode = ClientPackager.SplashscreenSetBackground(this, screen_num, backgroundColor);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetBackground()
		
		public FLR_RESULT splashScreenGetDuration(UInt32 screen_num, out UInt32 periodMs){
			FLR_RESULT returncode = ClientPackager.SplashscreenGetDuration(this, screen_num, out periodMs);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDuration()
		
		public FLR_RESULT splashScreenGetDataType(UInt32 screen_num, out FLR_SPLASHSCREEN_FILETYPE_E filetype){
			FLR_RESULT returncode = ClientPackager.SplashscreenGetDataType(this, screen_num, out filetype);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDataType()
		
		public FLR_RESULT splashScreenGetBackground(UInt32 screen_num, out UInt32 backgroundColor){
			FLR_RESULT returncode = ClientPackager.SplashscreenGetBackground(this, screen_num, out backgroundColor);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBackground()
		
		// end Module splashScreen
	// Begin Module spnr
		public FLR_RESULT spnrSetEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SpnrSetEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnableState()
		
		public FLR_RESULT spnrGetEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SpnrGetEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnableState()
		
		public FLR_RESULT spnrGetState(out FLR_SPNR_STATE_E data){
			FLR_RESULT returncode = ClientPackager.SpnrGetState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetState()
		
		public FLR_RESULT spnrSetFrameDelay(UInt32 data){
			FLR_RESULT returncode = ClientPackager.SpnrSetFrameDelay(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFrameDelay()
		
		public FLR_RESULT spnrGetFrameDelay(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.SpnrGetFrameDelay(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFrameDelay()
		
		public FLR_RESULT spnrGetSFApplied(out Double sf){
			FLR_RESULT returncode = ClientPackager.SpnrGetSFApplied(this, out sf);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSFApplied()
		
		public FLR_RESULT spnrSetPSDKernel(FLR_SPNR_PSD_KERNEL_T data){
			FLR_RESULT returncode = ClientPackager.SpnrSetPSDKernel(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetPSDKernel()
		
		public FLR_RESULT spnrGetPSDKernel(out FLR_SPNR_PSD_KERNEL_T data){
			FLR_RESULT returncode = ClientPackager.SpnrGetPSDKernel(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPSDKernel()
		
		public FLR_RESULT spnrSetSFMin(Double sfmin){
			FLR_RESULT returncode = ClientPackager.SpnrSetSFMin(this, sfmin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSFMin()
		
		public FLR_RESULT spnrGetSFMin(out Double sfmin){
			FLR_RESULT returncode = ClientPackager.SpnrGetSFMin(this, out sfmin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSFMin()
		
		public FLR_RESULT spnrSetSFMax(Double sfmax){
			FLR_RESULT returncode = ClientPackager.SpnrSetSFMax(this, sfmax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSFMax()
		
		public FLR_RESULT spnrGetSFMax(out Double sfmax){
			FLR_RESULT returncode = ClientPackager.SpnrGetSFMax(this, out sfmax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSFMax()
		
		public FLR_RESULT spnrSetDFMin(Double dfmin){
			FLR_RESULT returncode = ClientPackager.SpnrSetDFMin(this, dfmin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDFMin()
		
		public FLR_RESULT spnrGetDFMin(out Double dfmin){
			FLR_RESULT returncode = ClientPackager.SpnrGetDFMin(this, out dfmin);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDFMin()
		
		public FLR_RESULT spnrSetDFMax(Double dfmax){
			FLR_RESULT returncode = ClientPackager.SpnrSetDFMax(this, dfmax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDFMax()
		
		public FLR_RESULT spnrGetDFMax(out Double dfmax){
			FLR_RESULT returncode = ClientPackager.SpnrGetDFMax(this, out dfmax);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDFMax()
		
		public FLR_RESULT spnrSetNormTarget(Double normTarget){
			FLR_RESULT returncode = ClientPackager.SpnrSetNormTarget(this, normTarget);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetNormTarget()
		
		public FLR_RESULT spnrGetNormTarget(out Double normTarget){
			FLR_RESULT returncode = ClientPackager.SpnrGetNormTarget(this, out normTarget);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNormTarget()
		
		public FLR_RESULT spnrGetNormTargetApplied(out Double normTargetApplied){
			FLR_RESULT returncode = ClientPackager.SpnrGetNormTargetApplied(this, out normTargetApplied);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetNormTargetApplied()
		
		public FLR_RESULT spnrSetThPix(UInt16 th_pix){
			FLR_RESULT returncode = ClientPackager.SpnrSetThPix(this, th_pix);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThPix()
		
		public FLR_RESULT spnrGetThPix(out UInt16 th_pix){
			FLR_RESULT returncode = ClientPackager.SpnrGetThPix(this, out th_pix);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPix()
		
		public FLR_RESULT spnrSetThPixSum(UInt16 th_pixSum){
			FLR_RESULT returncode = ClientPackager.SpnrSetThPixSum(this, th_pixSum);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThPixSum()
		
		public FLR_RESULT spnrGetThPixSum(out UInt16 th_pixSum){
			FLR_RESULT returncode = ClientPackager.SpnrGetThPixSum(this, out th_pixSum);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixSum()
		
		public FLR_RESULT spnrSetMaxcorr(UInt16 maxcorr){
			FLR_RESULT returncode = ClientPackager.SpnrSetMaxcorr(this, maxcorr);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxcorr()
		
		public FLR_RESULT spnrGetMaxcorr(out UInt16 maxcorr){
			FLR_RESULT returncode = ClientPackager.SpnrGetMaxcorr(this, out maxcorr);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxcorr()
		
		public FLR_RESULT spnrGetAlgorithm(out FLR_SPNR_ALGORITHM_E data){
			FLR_RESULT returncode = ClientPackager.SpnrGetAlgorithm(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAlgorithm()
		
		public FLR_RESULT spnrSetAlgorithmDesired(FLR_SPNR_ALGORITHM_E data){
			FLR_RESULT returncode = ClientPackager.SpnrSetAlgorithmDesired(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetAlgorithmDesired()
		
		public FLR_RESULT spnrGetAlgorithmDesired(out FLR_SPNR_ALGORITHM_E data){
			FLR_RESULT returncode = ClientPackager.SpnrGetAlgorithmDesired(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAlgorithmDesired()
		
		// end Module spnr
	// Begin Module spotMeter
		public FLR_RESULT spotMeterSetEnable(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SpotmeterSetEnable(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnable()
		
		public FLR_RESULT spotMeterGetEnable(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetEnable(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnable()
		
		public FLR_RESULT spotMeterGetRoiMaxSize(out UInt16 width, out UInt16 height){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetRoiMaxSize(this, out width, out height);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRoiMaxSize()
		
		public FLR_RESULT spotMeterSetRoi(FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.SpotmeterSetRoi(this, roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetRoi()
		
		public FLR_RESULT spotMeterGetRoi(out FLR_ROI_T roi){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetRoi(this, out roi);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRoi()
		
		public FLR_RESULT spotMeterGetSpotStats(out UInt16 mean, out UInt16 deviation, out FLR_SPOTMETER_SPOT_PARAM_T min, out FLR_SPOTMETER_SPOT_PARAM_T max){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetSpotStats(this, out mean, out deviation, out min, out max);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpotStats()
		
		public FLR_RESULT spotMeterSetStatsMode(FLR_SPOTMETER_STATS_TEMP_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.SpotmeterSetStatsMode(this, mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetStatsMode()
		
		public FLR_RESULT spotMeterGetStatsMode(out FLR_SPOTMETER_STATS_TEMP_MODE_E mode){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetStatsMode(this, out mode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStatsMode()
		
		public FLR_RESULT spotMeterGetTempStats(out Double mean, out Double deviation, out FLR_SPOTMETER_STAT_PARAM_TEMP_T min, out FLR_SPOTMETER_STAT_PARAM_TEMP_T max){
			FLR_RESULT returncode = ClientPackager.SpotmeterGetTempStats(this, out mean, out deviation, out min, out max);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempStats()
		
		// end Module spotMeter
	// Begin Module srnr
		public FLR_RESULT srnrSetEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SrnrSetEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnableState()
		
		public FLR_RESULT srnrGetEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SrnrGetEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnableState()
		
		public FLR_RESULT srnrSetThRowSum(UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrSetThRowSum(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThRowSum()
		
		public FLR_RESULT srnrGetThRowSum(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrGetThRowSum(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThRowSum()
		
		public FLR_RESULT srnrSetThPixel(UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrSetThPixel(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetThPixel()
		
		public FLR_RESULT srnrGetThPixel(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrGetThPixel(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixel()
		
		public FLR_RESULT srnrSetMaxCorr(UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrSetMaxCorr(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMaxCorr()
		
		public FLR_RESULT srnrGetMaxCorr(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrGetMaxCorr(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxCorr()
		
		public FLR_RESULT srnrGetThPixelApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrGetThPixelApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetThPixelApplied()
		
		public FLR_RESULT srnrGetMaxCorrApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SrnrGetMaxCorrApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxCorrApplied()
		
		// end Module srnr
	// Begin Module symbology
		public FLR_RESULT symbologySetEnable(FLR_ENABLE_E draw_symbols){
			FLR_RESULT returncode = ClientPackager.SymbologySetEnable(this, draw_symbols);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnable()
		
		public FLR_RESULT symbologyCreateBitmap(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateBitmap(this, ID, pos_X, pos_Y, width, height);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateBitmap()
		
		public FLR_RESULT symbologySendData(Byte ID, Int16 size, Byte[] text){
			FLR_RESULT returncode = ClientPackager.SymbologySendData(this, ID, size, text);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SendData()
		
		public FLR_RESULT symbologyCreateArc(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, Double start_angle, Double end_angle, UInt32 color){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateArc(this, ID, pos_X, pos_Y, width, height, start_angle, end_angle, color);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateArc()
		
		public FLR_RESULT symbologyCreateText(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color, Byte[] text){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateText(this, ID, pos_X, pos_Y, width, height, font, size, alignment, color, text);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateText()
		
		public FLR_RESULT symbologyMoveSprite(Byte ID, Int16 pos_X, Int16 pos_Y){
			FLR_RESULT returncode = ClientPackager.SymbologyMoveSprite(this, ID, pos_X, pos_Y);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of MoveSprite()
		
		public FLR_RESULT symbologyAddToGroup(Byte ID, Byte group_ID){
			FLR_RESULT returncode = ClientPackager.SymbologyAddToGroup(this, ID, group_ID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of AddToGroup()
		
		public FLR_RESULT symbologyRemoveFromGroup(Byte ID, Byte group_ID){
			FLR_RESULT returncode = ClientPackager.SymbologyRemoveFromGroup(this, ID, group_ID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of RemoveFromGroup()
		
		public FLR_RESULT symbologyUpdateAndShow(Byte ID, Byte visible){
			FLR_RESULT returncode = ClientPackager.SymbologyUpdateAndShow(this, ID, visible);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of UpdateAndShow()
		
		public FLR_RESULT symbologyUpdateAndShowGroup(Byte group_ID, Byte visible){
			FLR_RESULT returncode = ClientPackager.SymbologyUpdateAndShowGroup(this, group_ID, visible);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of UpdateAndShowGroup()
		
		public FLR_RESULT symbologyDelete(Byte ID){
			FLR_RESULT returncode = ClientPackager.SymbologyDelete(this, ID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of Delete()
		
		public FLR_RESULT symbologyDeleteGroup(Byte group_ID){
			FLR_RESULT returncode = ClientPackager.SymbologyDeleteGroup(this, group_ID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of DeleteGroup()
		
		public FLR_RESULT symbologyCreateFilledRectangle(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateFilledRectangle(this, ID, pos_X, pos_Y, width, height, color);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateFilledRectangle()
		
		public FLR_RESULT symbologyCreateOutlinedRectangle(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateOutlinedRectangle(this, ID, pos_X, pos_Y, width, height, color);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateOutlinedRectangle()
		
		public FLR_RESULT symbologyCreateBitmapFromPng(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 size){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateBitmapFromPng(this, ID, pos_X, pos_Y, size);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateBitmapFromPng()
		
		public FLR_RESULT symbologyCreateCompressedBitmap(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateCompressedBitmap(this, ID, pos_X, pos_Y, width, height);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateCompressedBitmap()
		
		public FLR_RESULT symbologyCreateBitmapFromPngFile(Byte ID, Int16 pos_X, Int16 pos_Y, Byte[] path){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateBitmapFromPngFile(this, ID, pos_X, pos_Y, path);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateBitmapFromPngFile()
		
		public FLR_RESULT symbologyCreateBitmapFromFile(Byte ID, Int16 pos_X, Int16 pos_Y, Byte[] path, FLR_SYMBOLOGY_IMAGE_TYPE_E imageType){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateBitmapFromFile(this, ID, pos_X, pos_Y, path, imageType);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateBitmapFromFile()
		
		public FLR_RESULT symbologyResetWritePosition(Byte ID){
			FLR_RESULT returncode = ClientPackager.SymbologyResetWritePosition(this, ID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ResetWritePosition()
		
		public FLR_RESULT symbologyMoveByOffset(Byte ID, Int16 off_X, Int16 off_Y){
			FLR_RESULT returncode = ClientPackager.SymbologyMoveByOffset(this, ID, off_X, off_Y);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of MoveByOffset()
		
		public FLR_RESULT symbologyMoveGroupByOffset(Byte ID, Int16 off_X, Int16 off_Y){
			FLR_RESULT returncode = ClientPackager.SymbologyMoveGroupByOffset(this, ID, off_X, off_Y);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of MoveGroupByOffset()
		
		public FLR_RESULT symbologyCreateFilledEllipse(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, UInt32 color){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateFilledEllipse(this, ID, pos_X, pos_Y, width, height, color);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateFilledEllipse()
		
		public FLR_RESULT symbologyCreateLine(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 pos_X2, Int16 pos_Y2, UInt32 color){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateLine(this, ID, pos_X, pos_Y, pos_X2, pos_Y2, color);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateLine()
		
		public FLR_RESULT symbologySetZorder(Byte ID, Byte zorder){
			FLR_RESULT returncode = ClientPackager.SymbologySetZorder(this, ID, zorder);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetZorder()
		
		public FLR_RESULT symbologySaveConfiguration(){
			FLR_RESULT returncode = ClientPackager.SymbologySaveConfiguration(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SaveConfiguration()
		
		public FLR_RESULT symbologyReloadConfiguration(){
			FLR_RESULT returncode = ClientPackager.SymbologyReloadConfiguration(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of ReloadConfiguration()
		
		public FLR_RESULT symbologyGetEnable(out FLR_ENABLE_E draw_symbols){
			FLR_RESULT returncode = ClientPackager.SymbologyGetEnable(this, out draw_symbols);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnable()
		
		public FLR_RESULT symbologySetClonesNumber(Byte ID, Byte numberOfClones){
			FLR_RESULT returncode = ClientPackager.SymbologySetClonesNumber(this, ID, numberOfClones);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetClonesNumber()
		
		public FLR_RESULT symbologyMoveCloneByOffset(Byte ID, Byte cloneID, Int16 pos_X, Int16 pos_Y){
			FLR_RESULT returncode = ClientPackager.SymbologyMoveCloneByOffset(this, ID, cloneID, pos_X, pos_Y);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of MoveCloneByOffset()
		
		public FLR_RESULT symbologyMoveCloneSprite(Byte ID, Byte cloneID, Int16 pos_X, Int16 pos_Y){
			FLR_RESULT returncode = ClientPackager.SymbologyMoveCloneSprite(this, ID, cloneID, pos_X, pos_Y);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of MoveCloneSprite()
		
		public FLR_RESULT symbologySetTransformation(FLR_SYMBOLOGY_TRANSFORMATION_E transformation){
			FLR_RESULT returncode = ClientPackager.SymbologySetTransformation(this, transformation);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTransformation()
		
		public FLR_RESULT symbologyUpdateAllVisible(){
			FLR_RESULT returncode = ClientPackager.SymbologyUpdateAllVisible(this);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of UpdateAllVisible()
		
		public FLR_RESULT symbologySetSizeAndScalingMode(Byte ID, Int16 width, Int16 height, FLR_SYMBOLOGY_SCALING_MODE_E scalingMode){
			FLR_RESULT returncode = ClientPackager.SymbologySetSizeAndScalingMode(this, ID, width, height, scalingMode);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSizeAndScalingMode()
		
		public FLR_RESULT symbologyCreateLineHVT(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 pos_X2, Int16 pos_Y2, UInt32 color1, UInt32 color2, UInt16 dashLen, UInt16 thickness){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateLineHVT(this, ID, pos_X, pos_Y, pos_X2, pos_Y2, color1, color2, dashLen, thickness);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateLineHVT()
		
		public FLR_RESULT symbologyCreateTextHVT(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color1, UInt32 color2, Byte dashLen, Byte[] text){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateTextHVT(this, ID, pos_X, pos_Y, width, height, font, size, alignment, color1, color2, dashLen, text);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateTextHVT()
		
		public FLR_RESULT symbologyCreateTextBg(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, SByte font, Int16 size, FLR_SYMBOLOGY_TEXT_ALIGNMENT_E alignment, UInt32 color, UInt32 bgColor, Byte[] text){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateTextBg(this, ID, pos_X, pos_Y, width, height, font, size, alignment, color, bgColor, text);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateTextBg()
		
		public FLR_RESULT symbologyCreateScaledBitmapFromFile(Byte ID, Int16 pos_X, Int16 pos_Y, Int16 width, Int16 height, FLR_SYMBOLOGY_SCALING_MODE_E scalingMode, Byte[] path, FLR_SYMBOLOGY_IMAGE_TYPE_E imageType){
			FLR_RESULT returncode = ClientPackager.SymbologyCreateScaledBitmapFromFile(this, ID, pos_X, pos_Y, width, height, scalingMode, path, imageType);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of CreateScaledBitmapFromFile()
		
		// end Module symbology
	// Begin Module sysctrl
		public FLR_RESULT sysctrlSetFreezeState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlSetFreezeState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFreezeState()
		
		public FLR_RESULT sysctrlGetFreezeState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlGetFreezeState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFreezeState()
		
		public FLR_RESULT sysctrlGetCameraFrameRate(out UInt32 frameRate){
			FLR_RESULT returncode = ClientPackager.SysctrlGetCameraFrameRate(this, out frameRate);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCameraFrameRate()
		
		public FLR_RESULT sysctrlGetUptimeSecs(out UInt32 uptime){
			FLR_RESULT returncode = ClientPackager.SysctrlGetUptimeSecs(this, out uptime);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUptimeSecs()
		
		public FLR_RESULT sysctrlSetUsbVideoIR16Mode(FLR_SYSCTRL_USBIR16_MODE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlSetUsbVideoIR16Mode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetUsbVideoIR16Mode()
		
		public FLR_RESULT sysctrlGetUsbVideoIR16Mode(out FLR_SYSCTRL_USBIR16_MODE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlGetUsbVideoIR16Mode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetUsbVideoIR16Mode()
		
		public FLR_RESULT sysctrlSetOperatingMode(FLR_SYSCTRL_OPERATING_MODE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlSetOperatingMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOperatingMode()
		
		public FLR_RESULT sysctrlGetOperatingMode(out FLR_SYSCTRL_OPERATING_MODE_E data){
			FLR_RESULT returncode = ClientPackager.SysctrlGetOperatingMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOperatingMode()
		
		public FLR_RESULT sysctrlGetAvgFpaTempCounts(out Double data){
			FLR_RESULT returncode = ClientPackager.SysctrlGetAvgFpaTempCounts(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetAvgFpaTempCounts()
		
		public FLR_RESULT sysctrlSetFpaTempFrames(UInt16 data){
			FLR_RESULT returncode = ClientPackager.SysctrlSetFpaTempFrames(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetFpaTempFrames()
		
		public FLR_RESULT sysctrlGetFpaTempFrames(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.SysctrlGetFpaTempFrames(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetFpaTempFrames()
		
		// end Module sysctrl
	// Begin Module sysinfo
		public FLR_RESULT sysinfoGetMonitorSoftwareRev(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.SysinfoGetMonitorSoftwareRev(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMonitorSoftwareRev()
		
		public FLR_RESULT sysinfoGetMonitorBuildVariant(out FLR_SYSINFO_MONITOR_BUILD_VARIANT_T monitorBuildVariant){
			FLR_RESULT returncode = ClientPackager.SysinfoGetMonitorBuildVariant(this, out monitorBuildVariant);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMonitorBuildVariant()
		
		public FLR_RESULT sysinfoGetProductName(out Byte[] name){
			FLR_RESULT returncode = ClientPackager.SysinfoGetProductName(this, out name);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetProductName()
		
		public FLR_RESULT sysinfoGetCameraSN(out Byte[] number){
			FLR_RESULT returncode = ClientPackager.SysinfoGetCameraSN(this, out number);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetCameraSN()
		
		public FLR_RESULT sysinfoGetBootLocation(out UInt32 bootSwLocation){
			FLR_RESULT returncode = ClientPackager.SysinfoGetBootLocation(this, out bootSwLocation);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBootLocation()
		
		public FLR_RESULT sysinfoGetSwConfigID(out FLR_SYSINFO_SW_CONFIG_ID_E swConfigID){
			FLR_RESULT returncode = ClientPackager.SysinfoGetSwConfigID(this, out swConfigID);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSwConfigID()
		
		public FLR_RESULT sysinfoGetSwPermissions(out FLR_SYSINFO_SW_PERMISSIONS_E swPermissions){
			FLR_RESULT returncode = ClientPackager.SysinfoGetSwPermissions(this, out swPermissions);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSwPermissions()
		
		public FLR_RESULT sysinfoGetIs9HzBuild(out UInt32 is9HzBuild){
			FLR_RESULT returncode = ClientPackager.SysinfoGetIs9HzBuild(this, out is9HzBuild);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIs9HzBuild()
		
		public FLR_RESULT sysinfoGetProductVersion(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.SysinfoGetProductVersion(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetProductVersion()
		
		public FLR_RESULT sysinfoGetMonitorProductRev(out UInt32 major, out UInt32 minor, out UInt32 patch){
			FLR_RESULT returncode = ClientPackager.SysinfoGetMonitorProductRev(this, out major, out minor, out patch);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMonitorProductRev()
		
		public FLR_RESULT sysinfoGetOpticalRevision(out UInt16 revision){
			FLR_RESULT returncode = ClientPackager.SysinfoGetOpticalRevision(this, out revision);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOpticalRevision()
		
		public FLR_RESULT sysinfoGetSensorRevision(out UInt16 revision){
			FLR_RESULT returncode = ClientPackager.SysinfoGetSensorRevision(this, out revision);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSensorRevision()
		
		public FLR_RESULT sysinfoGetProbeTipSN(out Byte[] number){
			FLR_RESULT returncode = ClientPackager.SysinfoGetProbeTipSN(this, out number);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetProbeTipSN()
		
		public FLR_RESULT sysinfoGetMechanicalRevision(out UInt16 revision){
			FLR_RESULT returncode = ClientPackager.SysinfoGetMechanicalRevision(this, out revision);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMechanicalRevision()
		
		// end Module sysinfo
	// Begin Module systemSymbols
		public FLR_RESULT systemSymbolsGetID(FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, out Byte id, out FLR_SYSTEMSYMBOLS_ID_TYPE_E id_type){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsGetID(this, symbol, out id, out id_type);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetID()
		
		public FLR_RESULT systemSymbolsSetID(FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, Byte id, FLR_SYSTEMSYMBOLS_ID_TYPE_E id_type){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsSetID(this, symbol, id, id_type);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetID()
		
		public FLR_RESULT systemSymbolsGetEnable(FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, out FLR_ENABLE_E enabled){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsGetEnable(this, symbol, out enabled);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnable()
		
		public FLR_RESULT systemSymbolsSetEnable(FLR_SYSTEMSYMBOLS_SYMBOL_E symbol, FLR_ENABLE_E enabled){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsSetEnable(this, symbol, enabled);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnable()
		
		public FLR_RESULT systemSymbolsGetSpotConfig(out FLR_SYSTEMSYMBOLS_SPOTCONFIG_T config){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsGetSpotConfig(this, out config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSpotConfig()
		
		public FLR_RESULT systemSymbolsSetSpotConfig(FLR_SYSTEMSYMBOLS_SPOTCONFIG_T config){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsSetSpotConfig(this, config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSpotConfig()
		
		public FLR_RESULT systemSymbolsGetIsoConfig(out FLR_SYSTEMSYMBOLS_ISOCONFIG_T config){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsGetIsoConfig(this, out config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIsoConfig()
		
		public FLR_RESULT systemSymbolsSetIsoConfig(FLR_SYSTEMSYMBOLS_ISOCONFIG_T config){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsSetIsoConfig(this, config);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIsoConfig()
		
		public FLR_RESULT systemSymbolsGetBarConfig(out FLR_SYSTEMSYMBOLS_BARCONFIG_T lowGainConfig, out FLR_SYSTEMSYMBOLS_BARCONFIG_T highGainConfig, out FLR_TEMPERATURE_UNIT_E unit){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsGetBarConfig(this, out lowGainConfig, out highGainConfig, out unit);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetBarConfig()
		
		public FLR_RESULT systemSymbolsSetBarConfig(FLR_SYSTEMSYMBOLS_BARCONFIG_T lowGainConfig, FLR_SYSTEMSYMBOLS_BARCONFIG_T highGainConfig, FLR_TEMPERATURE_UNIT_E unit){
			FLR_RESULT returncode = ClientPackager.SystemsymbolsSetBarConfig(this, lowGainConfig, highGainConfig, unit);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetBarConfig()
		
		// end Module systemSymbols
	// Begin Module telemetry
		public FLR_RESULT telemetrySetState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TelemetrySetState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetState()
		
		public FLR_RESULT telemetryGetState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TelemetryGetState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetState()
		
		public FLR_RESULT telemetrySetLocation(FLR_TELEMETRY_LOC_E data){
			FLR_RESULT returncode = ClientPackager.TelemetrySetLocation(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetLocation()
		
		public FLR_RESULT telemetryGetLocation(out FLR_TELEMETRY_LOC_E data){
			FLR_RESULT returncode = ClientPackager.TelemetryGetLocation(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetLocation()
		
		public FLR_RESULT telemetrySetPacking(FLR_TELEMETRY_PACKING_E data){
			FLR_RESULT returncode = ClientPackager.TelemetrySetPacking(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetPacking()
		
		public FLR_RESULT telemetryGetPacking(out FLR_TELEMETRY_PACKING_E data){
			FLR_RESULT returncode = ClientPackager.TelemetryGetPacking(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPacking()
		
		public FLR_RESULT telemetrySetOrder(FLR_TELEMETRY_ORDER_E data){
			FLR_RESULT returncode = ClientPackager.TelemetrySetOrder(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetOrder()
		
		public FLR_RESULT telemetryGetOrder(out FLR_TELEMETRY_ORDER_E data){
			FLR_RESULT returncode = ClientPackager.TelemetryGetOrder(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetOrder()
		
		// end Module telemetry
	// Begin Module testRamp
		public FLR_RESULT testRampSetType(Byte index, FLR_TESTRAMP_TYPE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampSetType(this, index, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetType()
		
		public FLR_RESULT testRampGetType(Byte index, out FLR_TESTRAMP_TYPE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampGetType(this, index, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetType()
		
		public FLR_RESULT testRampSetSettings(Byte index, FLR_TESTRAMP_SETTINGS_T data){
			FLR_RESULT returncode = ClientPackager.TestrampSetSettings(this, index, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetSettings()
		
		public FLR_RESULT testRampGetSettings(Byte index, out FLR_TESTRAMP_SETTINGS_T data){
			FLR_RESULT returncode = ClientPackager.TestrampGetSettings(this, index, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetSettings()
		
		public FLR_RESULT testRampSetMotionState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampSetMotionState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMotionState()
		
		public FLR_RESULT testRampGetMotionState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampGetMotionState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMotionState()
		
		public FLR_RESULT testRampSetIndex(Byte data){
			FLR_RESULT returncode = ClientPackager.TestrampSetIndex(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetIndex()
		
		public FLR_RESULT testRampGetIndex(out Byte data){
			FLR_RESULT returncode = ClientPackager.TestrampGetIndex(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetIndex()
		
		public FLR_RESULT testRampGetMaxIndex(out Byte data){
			FLR_RESULT returncode = ClientPackager.TestrampGetMaxIndex(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMaxIndex()
		
		public FLR_RESULT testRampSetPN9ContinuousMode(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampSetPN9ContinuousMode(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetPN9ContinuousMode()
		
		public FLR_RESULT testRampGetPN9ContinuousMode(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TestrampGetPN9ContinuousMode(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetPN9ContinuousMode()
		
		// end Module testRamp
	// Begin Module tf
		public FLR_RESULT tfSetEnableState(FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TfSetEnableState(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetEnableState()
		
		public FLR_RESULT tfGetEnableState(out FLR_ENABLE_E data){
			FLR_RESULT returncode = ClientPackager.TfGetEnableState(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetEnableState()
		
		public FLR_RESULT tfSetDelta_nf(UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfSetDelta_nf(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetDelta_nf()
		
		public FLR_RESULT tfGetDelta_nf(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfGetDelta_nf(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDelta_nf()
		
		public FLR_RESULT tfSetTHDeltaMotion(UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfSetTHDeltaMotion(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTHDeltaMotion()
		
		public FLR_RESULT tfGetTHDeltaMotion(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfGetTHDeltaMotion(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTHDeltaMotion()
		
		public FLR_RESULT tfSetWLut(FLR_TF_WLUT_T data){
			FLR_RESULT returncode = ClientPackager.TfSetWLut(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetWLut()
		
		public FLR_RESULT tfGetWLut(out FLR_TF_WLUT_T data){
			FLR_RESULT returncode = ClientPackager.TfGetWLut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetWLut()
		
		public FLR_RESULT tfGetMotionCount(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.TfGetMotionCount(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMotionCount()
		
		public FLR_RESULT tfSetMotionThreshold(UInt32 data){
			FLR_RESULT returncode = ClientPackager.TfSetMotionThreshold(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetMotionThreshold()
		
		public FLR_RESULT tfGetMotionThreshold(out UInt32 data){
			FLR_RESULT returncode = ClientPackager.TfGetMotionThreshold(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetMotionThreshold()
		
		public FLR_RESULT tfGetDelta_nfApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfGetDelta_nfApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetDelta_nfApplied()
		
		public FLR_RESULT tfGetTHDeltaMotionApplied(out UInt16 data){
			FLR_RESULT returncode = ClientPackager.TfGetTHDeltaMotionApplied(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTHDeltaMotionApplied()
		
		public FLR_RESULT tfSetTempSignalCompFactorLut(FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.TfSetTempSignalCompFactorLut(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetTempSignalCompFactorLut()
		
		public FLR_RESULT tfGetTempSignalCompFactorLut(out FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T data){
			FLR_RESULT returncode = ClientPackager.TfGetTempSignalCompFactorLut(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetTempSignalCompFactorLut()
		
		public FLR_RESULT tfGetRnf(out UInt16 rnf){
			FLR_RESULT returncode = ClientPackager.TfGetRnf(this, out rnf);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetRnf()
		
		// end Module tf
	// Begin Module uart
		public FLR_RESULT uartSetStartupBaudRate(FLR_UART_STARTUP_BAUDRATE_E data){
			FLR_RESULT returncode = ClientPackager.UartSetStartupBaudRate(this, data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of SetStartupBaudRate()
		
		public FLR_RESULT uartGetStartupBaudRate(out FLR_UART_STARTUP_BAUDRATE_E data){
			FLR_RESULT returncode = ClientPackager.UartGetStartupBaudRate(this, out data);
			// Check for any errorcode
			if((UInt32) returncode != 0){
				return returncode;
			}
			return FLR_RESULT.R_SUCCESS;
		} // End of GetStartupBaudRate()
		
		// end Module uart
	} // end class SDK
} // end namespace Boson.SDK
