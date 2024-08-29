#  /////////////////////////////////////////////////////
#  // DO NOT EDIT.  This is a machine generated file. //
#  /////////////////////////////////////////////////////


from .Client_Packager import *
from .EnumTypes import *
from .ReturnCodes import FLR_RESULT
from functools import wraps

MaxMemoryChunk = 256

def exception_wrapper(func):
    @wraps(func)
    def wrapper(self, *args, **kwargs):
        response = func(self, *args, **kwargs)
        if self.ex:
            if type(response) is tuple:
                if type(response[0]) is not FLR_RESULT:
                    raise AssertionError("Invalid return code encountered.")
                if response[0] is FLR_RESULT.R_SUCCESS:
                    return response[1] if len(response) == 2 else response[1:]
                raise Exception(response[0])
            else:
                if type(response) is not FLR_RESULT:
                    raise AssertionError("Invalid return code encountered.")
                if response is FLR_RESULT.R_SUCCESS:
                    return
                raise Exception(response)
        return response
    return wrapper

from ..CommunicationFiles.CommonFslp import CommonFslp, FSLP_TYPE_E

class pyClient(Packager):
    def __init__(self, manualport=None, manualbaud=None, useDll=True, useAA=False, aaPath=None, ex=False, fslp=None, **kwargs):
        if None == fslp:
            # init an fslp
            if useDll:
                fslpType = FSLP_TYPE_E.FSLP_DLL_SERIAL
            else:
                if useAA:
                    fslpType = FSLP_TYPE_E.FSLP_I2C
                else:
                    fslpType = FSLP_TYPE_E.FSLP_PY_SERIAL

            fslp = CommonFslp.getFslp(manualport, manualbaud, fslpType, aaPath)
            fslp.port.open()

        # else, we already have an fslp object
        super().__init__(fslp)
        self.ex = ex
        self._api_names = []
        
        self._commClosed = False
        self.fslp = fslp

    def LookupAPI(self, search_str, case_sensitive=False):
        '''Usage: results_list[api_names] = cam_instance.LookupAPI(search_str="Foo",case_sensitive=False)
                my_api = getattr(cam_instance,results_list[0])
                my_api(...)
            Inputs: search_str = substring to search for (3 or more characters)
                    case_sensitive = boolean 
            Outputs: results_list, a list of all API names containing substring.
        '''
        if len(search_str) < 3:
            raise ValueError("Search string must contain at least 3 characters")
        
        results_dict = {}
        
        if case_sensitive:
            api_names = [api for api in pyClient.__dict__.keys() if search_str in api and "FLR_" not in api]
        else:
            api_names = [api for api in pyClient.__dict__.keys() if search_str.lower() in api.lower() and "FLR_" not in api]
        
        if len(api_names):
            api_names.sort()
            self._api_names = api_names
        else:
            self._api_names = []
        return api_names

    def RunAPI(self, api_selector, *args, **kwargs):
        '''Usage: result = cam_instance.RunAPI("exampleApiName",arg1, arg2, kwarg1=4,kwarg2=17)
                or
                result = cam_instance.RunAPI(index, *args, **kwargs)
            Inputs: api_selector (string or index)
                        if string, lookup API name and execute.
                        if index, get API name from previous LookupAPI results and execute.
                    args, kwargs are passed through to the API.
            Outputs: result, output (if any) of the API.
        '''
        try:
            api_index = int(api_selector)
            if len(self._api_names):
                return getattr(self,self._api_names[api_index])(*args,**kwargs)
            else:
                raise ValueError("Must run successful LookupAPI call before using index value for RunAPI")
        except ValueError:
            pass
        
        try:
            return getattr(self,api_selector)(*args,**kwargs)
        except AttributeError:
            raise ValueError("Could not find API \"{!s}\" in SDK.".format(api_selector))

    def __enter__(self):
        if not self.fslp.port.isOpen():
            raise AssertionError('Comm port closed.')
        return self

    def __exit__(self, *args):
        self.Close()

    def Close(self):
        if self.fslp.port.isOpen() is True:
            print("Closing com port and freeing serial port instance.")
            self.fslp.port.close()
            self._commClosed = True
        else:
            print("Serial port instance already freed.")
            
    def closeComm(self):
        if self._commClosed is False:
            print("Closing com port.")
            self.fslp.port.close()
            self._commClosed = True
        else:
            print("Com port already closed.")
    
    def reopenComm(self, manualport=None,manualbaud=None):
        if self._commClosed is True:
            print("Re-opening com port.")
            if manualport is not None:
                self.fslp.port.setPortID(manualport)
            if manualbaud is not None:
                self.fslp.port.setPortBuadRate(manualbaud)
            self.fslp.port.open()
            self._commClosed = False
        else:
            print("Com port already open.")

    @exception_wrapper
    def TLinearSetControl(self, data):
        '''Usage: returnCode = SetControl(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_TLinear_SetControl(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetControl()


    @exception_wrapper
    def TLinearGetControl(self):
        '''Usage: returnCode, data = GetControl(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_TLinear_GetControl()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetControl()


    @exception_wrapper
    def TLinearGetLUT(self, mode, offset):
        '''Usage: returnCode, a, b = GetLUT(self, mode, offset)
            Input_01 mode FLR_BOSON_TABLETYPE_E <<FLR_BOSON_TABLETYPE_E>>
            Input_02 offset <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 a[<class 'float'>] 16 <<FLOAT*16>>
            Output_02 b[<class 'float'>] 16 <<FLOAT*16>>
        '''
        returnCode, a, b = self.CLIENT_pkg_TLinear_GetLUT(mode, offset)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, a, b)
    # End of GetLUT()


    @exception_wrapper
    def TLinearRefreshLUT(self, mode):
        '''Usage: returnCode = RefreshLUT(self, mode)
            Input_01 mode FLR_BOSON_TABLETYPE_E <<FLR_BOSON_TABLETYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_TLinear_RefreshLUT(mode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of RefreshLUT()


    @exception_wrapper
    def agcSetPercentPerBin(self, data):
        '''Usage: returnCode = SetPercentPerBin(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetPercentPerBin(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetPercentPerBin()


    @exception_wrapper
    def agcGetPercentPerBin(self):
        '''Usage: returnCode, data = GetPercentPerBin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetPercentPerBin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetPercentPerBin()


    @exception_wrapper
    def agcSetLinearPercent(self, data):
        '''Usage: returnCode = SetLinearPercent(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetLinearPercent(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLinearPercent()


    @exception_wrapper
    def agcGetLinearPercent(self):
        '''Usage: returnCode, data = GetLinearPercent(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetLinearPercent()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetLinearPercent()


    @exception_wrapper
    def agcSetOutlierCut(self, data):
        '''Usage: returnCode = SetOutlierCut(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetOutlierCut(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutlierCut()


    @exception_wrapper
    def agcGetOutlierCut(self):
        '''Usage: returnCode, data = GetOutlierCut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetOutlierCut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOutlierCut()


    @exception_wrapper
    def agcGetDrOut(self):
        '''Usage: returnCode, data = GetDrOut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetDrOut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDrOut()


    @exception_wrapper
    def agcSetMaxGain(self, data):
        '''Usage: returnCode = SetMaxGain(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetMaxGain(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxGain()


    @exception_wrapper
    def agcGetMaxGain(self):
        '''Usage: returnCode, data = GetMaxGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetMaxGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxGain()


    @exception_wrapper
    def agcSetdf(self, data):
        '''Usage: returnCode = Setdf(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_Setdf(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Setdf()


    @exception_wrapper
    def agcGetdf(self):
        '''Usage: returnCode, data = Getdf(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_Getdf()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of Getdf()


    @exception_wrapper
    def agcSetGamma(self, data):
        '''Usage: returnCode = SetGamma(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetGamma(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGamma()


    @exception_wrapper
    def agcGetGamma(self):
        '''Usage: returnCode, data = GetGamma(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetGamma()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGamma()


    @exception_wrapper
    def agcGetFirstBin(self):
        '''Usage: returnCode, data = GetFirstBin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetFirstBin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFirstBin()


    @exception_wrapper
    def agcGetLastBin(self):
        '''Usage: returnCode, data = GetLastBin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetLastBin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetLastBin()


    @exception_wrapper
    def agcSetDetailHeadroom(self, data):
        '''Usage: returnCode = SetDetailHeadroom(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetDetailHeadroom(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDetailHeadroom()


    @exception_wrapper
    def agcGetDetailHeadroom(self):
        '''Usage: returnCode, data = GetDetailHeadroom(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetDetailHeadroom()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDetailHeadroom()


    @exception_wrapper
    def agcSetd2br(self, data):
        '''Usage: returnCode = Setd2br(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_Setd2br(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Setd2br()


    @exception_wrapper
    def agcGetd2br(self):
        '''Usage: returnCode, data = Getd2br(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_Getd2br()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of Getd2br()


    @exception_wrapper
    def agcSetSigmaR(self, data):
        '''Usage: returnCode = SetSigmaR(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetSigmaR(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSigmaR()


    @exception_wrapper
    def agcGetSigmaR(self):
        '''Usage: returnCode, data = GetSigmaR(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetSigmaR()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSigmaR()


    @exception_wrapper
    def agcSetUseEntropy(self, data):
        '''Usage: returnCode = SetUseEntropy(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetUseEntropy(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetUseEntropy()


    @exception_wrapper
    def agcGetUseEntropy(self):
        '''Usage: returnCode, data = GetUseEntropy(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetUseEntropy()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetUseEntropy()


    @exception_wrapper
    def agcSetROI(self, roi):
        '''Usage: returnCode = SetROI(self, roi)
            Input_01 roi FLR_ROI_T <<FLR_ROI_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetROI(roi)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetROI()


    @exception_wrapper
    def agcGetROI(self):
        '''Usage: returnCode, roi = GetROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 roi FLR_ROI_T <<FLR_ROI_T>>
        '''
        returnCode, roi = self.CLIENT_pkg_agc_GetROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, roi)
    # End of GetROI()


    @exception_wrapper
    def agcGetMaxGainApplied(self):
        '''Usage: returnCode, data = GetMaxGainApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetMaxGainApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxGainApplied()


    @exception_wrapper
    def agcGetSigmaRApplied(self):
        '''Usage: returnCode, data = GetSigmaRApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetSigmaRApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSigmaRApplied()


    @exception_wrapper
    def agcSetOutlierCutBalance(self, data):
        '''Usage: returnCode = SetOutlierCutBalance(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetOutlierCutBalance(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutlierCutBalance()


    @exception_wrapper
    def agcGetOutlierCutBalance(self):
        '''Usage: returnCode, data = GetOutlierCutBalance(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetOutlierCutBalance()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOutlierCutBalance()


    @exception_wrapper
    def agcGetOutlierCutApplied(self):
        '''Usage: returnCode, percentHigh, percentLow = GetOutlierCutApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 percentHigh <class 'float'> <<FLOAT>>
            Output_02 percentLow <class 'float'> <<FLOAT>>
        '''
        returnCode, percentHigh, percentLow = self.CLIENT_pkg_agc_GetOutlierCutApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, percentHigh, percentLow)
    # End of GetOutlierCutApplied()


    @exception_wrapper
    def agcGetTfThresholds(self):
        '''Usage: returnCode, tf_thresholdMin, tf_thresholdMax = GetTfThresholds(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 tf_thresholdMin <class 'int'> <<UINT_16>>
            Output_02 tf_thresholdMax <class 'int'> <<UINT_16>>
        '''
        returnCode, tf_thresholdMin, tf_thresholdMax = self.CLIENT_pkg_agc_GetTfThresholds()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, tf_thresholdMin, tf_thresholdMax)
    # End of GetTfThresholds()


    @exception_wrapper
    def agcSetTfThresholds(self, tf_thresholdMin, tf_thresholdMax):
        '''Usage: returnCode = SetTfThresholds(self, tf_thresholdMin, tf_thresholdMax)
            Input_01 tf_thresholdMin <class 'int'> <<UINT_16>>
            Input_02 tf_thresholdMax <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetTfThresholds(tf_thresholdMin, tf_thresholdMax)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTfThresholds()


    @exception_wrapper
    def agcGetMode(self):
        '''Usage: returnCode, mode = GetMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mode FLR_AGC_MODE_E <<FLR_AGC_MODE_E>>
        '''
        returnCode, mode = self.CLIENT_pkg_agc_GetMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, mode)
    # End of GetMode()


    @exception_wrapper
    def agcSetMode(self, mode):
        '''Usage: returnCode = SetMode(self, mode)
            Input_01 mode FLR_AGC_MODE_E <<FLR_AGC_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetMode(mode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMode()


    @exception_wrapper
    def agcSetHighTempAlarmValues(self, lowGain, highGain, pixPopulation):
        '''Usage: returnCode = SetHighTempAlarmValues(self, lowGain, highGain, pixPopulation)
            Input_01 lowGain <class 'int'> <<UINT_32>>
            Input_02 highGain <class 'int'> <<UINT_32>>
            Input_03 pixPopulation <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetHighTempAlarmValues(lowGain, highGain, pixPopulation)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetHighTempAlarmValues()


    @exception_wrapper
    def agcGetContrast(self):
        '''Usage: returnCode, contrast = GetContrast(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 contrast <class 'int'> <<INT_32>>
        '''
        returnCode, contrast = self.CLIENT_pkg_agc_GetContrast()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, contrast)
    # End of GetContrast()


    @exception_wrapper
    def agcSetContrast(self, contrast):
        '''Usage: returnCode = SetContrast(self, contrast)
            Input_01 contrast <class 'int'> <<INT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetContrast(contrast)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetContrast()


    @exception_wrapper
    def agcGetBrightnessBias(self):
        '''Usage: returnCode, brightnessBias = GetBrightnessBias(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 brightnessBias <class 'int'> <<INT_32>>
        '''
        returnCode, brightnessBias = self.CLIENT_pkg_agc_GetBrightnessBias()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, brightnessBias)
    # End of GetBrightnessBias()


    @exception_wrapper
    def agcSetBrightnessBias(self, brightnessBias):
        '''Usage: returnCode = SetBrightnessBias(self, brightnessBias)
            Input_01 brightnessBias <class 'int'> <<INT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetBrightnessBias(brightnessBias)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetBrightnessBias()


    @exception_wrapper
    def agcGetBrightness(self):
        '''Usage: returnCode, brightness = GetBrightness(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 brightness <class 'int'> <<INT_32>>
        '''
        returnCode, brightness = self.CLIENT_pkg_agc_GetBrightness()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, brightness)
    # End of GetBrightness()


    @exception_wrapper
    def agcSetBrightness(self, brightness):
        '''Usage: returnCode = SetBrightness(self, brightness)
            Input_01 brightness <class 'int'> <<INT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetBrightness(brightness)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetBrightness()


    @exception_wrapper
    def agcSetMaxGainForLowGain(self, data):
        '''Usage: returnCode = SetMaxGainForLowGain(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_agc_SetMaxGainForLowGain(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxGainForLowGain()


    @exception_wrapper
    def agcGetMaxGainForLowGain(self):
        '''Usage: returnCode, data = GetMaxGainForLowGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_agc_GetMaxGainForLowGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxGainForLowGain()


    @exception_wrapper
    def bosonGetCameraSN(self):
        '''Usage: returnCode, data = GetCameraSN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetCameraSN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetCameraSN()


    @exception_wrapper
    def bosonGetCameraPN(self):
        '''Usage: returnCode, data = GetCameraPN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_BOSON_PARTNUMBER_T <<FLR_BOSON_PARTNUMBER_T>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetCameraPN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetCameraPN()


    @exception_wrapper
    def bosonGetSensorSN(self):
        '''Usage: returnCode, data = GetSensorSN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetSensorSN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSensorSN()


    @exception_wrapper
    def bosonRunFFC(self):
        '''Usage: returnCode = RunFFC(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_RunFFC()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of RunFFC()


    @exception_wrapper
    def bosonSetFFCTempThreshold(self, data):
        '''Usage: returnCode = SetFFCTempThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCTempThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCTempThreshold()


    @exception_wrapper
    def bosonGetFFCTempThreshold(self):
        '''Usage: returnCode, data = GetFFCTempThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFFCTempThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFCTempThreshold()


    @exception_wrapper
    def bosonSetFFCFrameThreshold(self, data):
        '''Usage: returnCode = SetFFCFrameThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCFrameThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCFrameThreshold()


    @exception_wrapper
    def bosonGetFFCFrameThreshold(self):
        '''Usage: returnCode, data = GetFFCFrameThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFFCFrameThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFCFrameThreshold()


    @exception_wrapper
    def bosonGetFFCInProgress(self):
        '''Usage: returnCode, data = GetFFCInProgress(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFFCInProgress()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFCInProgress()


    @exception_wrapper
    def bosonReboot(self):
        '''Usage: returnCode = Reboot(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_Reboot()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Reboot()


    @exception_wrapper
    def bosonSetFFCMode(self, ffcMode):
        '''Usage: returnCode = SetFFCMode(self, ffcMode)
            Input_01 ffcMode FLR_BOSON_FFCMODE_E <<FLR_BOSON_FFCMODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCMode(ffcMode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCMode()


    @exception_wrapper
    def bosonGetFFCMode(self):
        '''Usage: returnCode, ffcMode = GetFFCMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 ffcMode FLR_BOSON_FFCMODE_E <<FLR_BOSON_FFCMODE_E>>
        '''
        returnCode, ffcMode = self.CLIENT_pkg_boson_GetFFCMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ffcMode)
    # End of GetFFCMode()


    @exception_wrapper
    def bosonSetGainMode(self, gainMode):
        '''Usage: returnCode = SetGainMode(self, gainMode)
            Input_01 gainMode FLR_BOSON_GAINMODE_E <<FLR_BOSON_GAINMODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetGainMode(gainMode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainMode()


    @exception_wrapper
    def bosonGetGainMode(self):
        '''Usage: returnCode, gainMode = GetGainMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 gainMode FLR_BOSON_GAINMODE_E <<FLR_BOSON_GAINMODE_E>>
        '''
        returnCode, gainMode = self.CLIENT_pkg_boson_GetGainMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, gainMode)
    # End of GetGainMode()


    @exception_wrapper
    def bosonWriteDynamicHeaderToFlash(self):
        '''Usage: returnCode = WriteDynamicHeaderToFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteDynamicHeaderToFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteDynamicHeaderToFlash()


    @exception_wrapper
    def bosonReadDynamicHeaderFromFlash(self):
        '''Usage: returnCode = ReadDynamicHeaderFromFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_ReadDynamicHeaderFromFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ReadDynamicHeaderFromFlash()


    @exception_wrapper
    def bosonRestoreFactoryDefaultsFromFlash(self):
        '''Usage: returnCode = RestoreFactoryDefaultsFromFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_RestoreFactoryDefaultsFromFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of RestoreFactoryDefaultsFromFlash()


    @exception_wrapper
    def bosonRestoreFactoryBadPixelsFromFlash(self):
        '''Usage: returnCode = RestoreFactoryBadPixelsFromFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_RestoreFactoryBadPixelsFromFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of RestoreFactoryBadPixelsFromFlash()


    @exception_wrapper
    def bosonWriteBadPixelsToFlash(self):
        '''Usage: returnCode = WriteBadPixelsToFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteBadPixelsToFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteBadPixelsToFlash()


    @exception_wrapper
    def bosonGetSoftwareRev(self):
        '''Usage: returnCode, major, minor, patch = GetSoftwareRev(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_boson_GetSoftwareRev()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetSoftwareRev()


    @exception_wrapper
    def bosonSetBadPixelLocation(self, row, col):
        '''Usage: returnCode = SetBadPixelLocation(self, row, col)
            Input_01 row <class 'int'> <<UINT_32>>
            Input_02 col <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetBadPixelLocation(row, col)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetBadPixelLocation()


    @exception_wrapper
    def bosonlookupFPATempDegCx10(self):
        '''Usage: returnCode, data = lookupFPATempDegCx10(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_lookupFPATempDegCx10()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of lookupFPATempDegCx10()


    @exception_wrapper
    def bosonlookupFPATempDegKx10(self):
        '''Usage: returnCode, data = lookupFPATempDegKx10(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_lookupFPATempDegKx10()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of lookupFPATempDegKx10()


    @exception_wrapper
    def bosonWriteLensNvFfcToFlash(self):
        '''Usage: returnCode = WriteLensNvFfcToFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteLensNvFfcToFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteLensNvFfcToFlash()


    @exception_wrapper
    def bosonWriteLensGainToFlash(self):
        '''Usage: returnCode = WriteLensGainToFlash(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteLensGainToFlash()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteLensGainToFlash()


    @exception_wrapper
    def bosonSetLensNumber(self, lensNumber):
        '''Usage: returnCode = SetLensNumber(self, lensNumber)
            Input_01 lensNumber <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetLensNumber(lensNumber)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLensNumber()


    @exception_wrapper
    def bosonGetLensNumber(self):
        '''Usage: returnCode, lensNumber = GetLensNumber(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 lensNumber <class 'int'> <<UINT_32>>
        '''
        returnCode, lensNumber = self.CLIENT_pkg_boson_GetLensNumber()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, lensNumber)
    # End of GetLensNumber()


    @exception_wrapper
    def bosonSetTableNumber(self, tableNumber):
        '''Usage: returnCode = SetTableNumber(self, tableNumber)
            Input_01 tableNumber <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetTableNumber(tableNumber)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTableNumber()


    @exception_wrapper
    def bosonGetTableNumber(self):
        '''Usage: returnCode, tableNumber = GetTableNumber(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 tableNumber <class 'int'> <<UINT_32>>
        '''
        returnCode, tableNumber = self.CLIENT_pkg_boson_GetTableNumber()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, tableNumber)
    # End of GetTableNumber()


    @exception_wrapper
    def bosonGetSensorPN(self):
        '''Usage: returnCode, sensorPN = GetSensorPN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 sensorPN FLR_BOSON_SENSOR_PARTNUMBER_T <<FLR_BOSON_SENSOR_PARTNUMBER_T>>
        '''
        returnCode, sensorPN = self.CLIENT_pkg_boson_GetSensorPN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, sensorPN)
    # End of GetSensorPN()


    @exception_wrapper
    def bosonSetGainSwitchParams(self, parm_struct):
        '''Usage: returnCode = SetGainSwitchParams(self, parm_struct)
            Input_01 parm_struct FLR_BOSON_GAIN_SWITCH_PARAMS_T <<FLR_BOSON_GAIN_SWITCH_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetGainSwitchParams(parm_struct)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainSwitchParams()


    @exception_wrapper
    def bosonGetGainSwitchParams(self):
        '''Usage: returnCode, parm_struct = GetGainSwitchParams(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 parm_struct FLR_BOSON_GAIN_SWITCH_PARAMS_T <<FLR_BOSON_GAIN_SWITCH_PARAMS_T>>
        '''
        returnCode, parm_struct = self.CLIENT_pkg_boson_GetGainSwitchParams()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, parm_struct)
    # End of GetGainSwitchParams()


    @exception_wrapper
    def bosonGetSwitchToHighGainFlag(self):
        '''Usage: returnCode, switchToHighGainFlag = GetSwitchToHighGainFlag(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 switchToHighGainFlag <class 'int'> <<UCHAR>>
        '''
        returnCode, switchToHighGainFlag = self.CLIENT_pkg_boson_GetSwitchToHighGainFlag()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, switchToHighGainFlag)
    # End of GetSwitchToHighGainFlag()


    @exception_wrapper
    def bosonGetSwitchToLowGainFlag(self):
        '''Usage: returnCode, switchToLowGainFlag = GetSwitchToLowGainFlag(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 switchToLowGainFlag <class 'int'> <<UCHAR>>
        '''
        returnCode, switchToLowGainFlag = self.CLIENT_pkg_boson_GetSwitchToLowGainFlag()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, switchToLowGainFlag)
    # End of GetSwitchToLowGainFlag()


    @exception_wrapper
    def bosonGetCLowToHighPercent(self):
        '''Usage: returnCode, cLowToHighPercent = GetCLowToHighPercent(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 cLowToHighPercent <class 'int'> <<UINT_32>>
        '''
        returnCode, cLowToHighPercent = self.CLIENT_pkg_boson_GetCLowToHighPercent()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, cLowToHighPercent)
    # End of GetCLowToHighPercent()


    @exception_wrapper
    def bosonGetMaxNUCTables(self):
        '''Usage: returnCode, maxNUCTables = GetMaxNUCTables(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 maxNUCTables <class 'int'> <<UINT_32>>
        '''
        returnCode, maxNUCTables = self.CLIENT_pkg_boson_GetMaxNUCTables()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, maxNUCTables)
    # End of GetMaxNUCTables()


    @exception_wrapper
    def bosonGetMaxLensTables(self):
        '''Usage: returnCode, maxLensTables = GetMaxLensTables(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 maxLensTables <class 'int'> <<UINT_32>>
        '''
        returnCode, maxLensTables = self.CLIENT_pkg_boson_GetMaxLensTables()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, maxLensTables)
    # End of GetMaxLensTables()


    @exception_wrapper
    def bosonGetFfcWaitCloseFrames(self):
        '''Usage: returnCode, data = GetFfcWaitCloseFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFfcWaitCloseFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcWaitCloseFrames()


    @exception_wrapper
    def bosonSetFfcWaitCloseFrames(self, data):
        '''Usage: returnCode = SetFfcWaitCloseFrames(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFfcWaitCloseFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFfcWaitCloseFrames()


    @exception_wrapper
    def bosonCheckForTableSwitch(self):
        '''Usage: returnCode = CheckForTableSwitch(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_CheckForTableSwitch()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CheckForTableSwitch()


    @exception_wrapper
    def bosonGetDesiredTableNumber(self):
        '''Usage: returnCode, desiredTableNumber = GetDesiredTableNumber(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 desiredTableNumber <class 'int'> <<UINT_32>>
        '''
        returnCode, desiredTableNumber = self.CLIENT_pkg_boson_GetDesiredTableNumber()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, desiredTableNumber)
    # End of GetDesiredTableNumber()


    @exception_wrapper
    def bosonGetFfcStatus(self):
        '''Usage: returnCode, ffcStatus = GetFfcStatus(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 ffcStatus FLR_BOSON_FFCSTATUS_E <<FLR_BOSON_FFCSTATUS_E>>
        '''
        returnCode, ffcStatus = self.CLIENT_pkg_boson_GetFfcStatus()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ffcStatus)
    # End of GetFfcStatus()


    @exception_wrapper
    def bosonGetFfcDesired(self):
        '''Usage: returnCode, ffcDesired = GetFfcDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 ffcDesired <class 'int'> <<UINT_32>>
        '''
        returnCode, ffcDesired = self.CLIENT_pkg_boson_GetFfcDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ffcDesired)
    # End of GetFfcDesired()


    @exception_wrapper
    def bosonGetSwRevInHeader(self):
        '''Usage: returnCode, major, minor, patch = GetSwRevInHeader(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_boson_GetSwRevInHeader()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetSwRevInHeader()


    @exception_wrapper
    def bosonGetLastFFCFrameCount(self):
        '''Usage: returnCode, frameCount = GetLastFFCFrameCount(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 frameCount <class 'int'> <<UINT_32>>
        '''
        returnCode, frameCount = self.CLIENT_pkg_boson_GetLastFFCFrameCount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, frameCount)
    # End of GetLastFFCFrameCount()


    @exception_wrapper
    def bosonGetLastFFCTempDegKx10(self):
        '''Usage: returnCode, temp = GetLastFFCTempDegKx10(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 temp <class 'int'> <<UINT_16>>
        '''
        returnCode, temp = self.CLIENT_pkg_boson_GetLastFFCTempDegKx10()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, temp)
    # End of GetLastFFCTempDegKx10()


    @exception_wrapper
    def bosonGetTableSwitchDesired(self):
        '''Usage: returnCode, tableSwitchDesired = GetTableSwitchDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 tableSwitchDesired <class 'int'> <<UINT_16>>
        '''
        returnCode, tableSwitchDesired = self.CLIENT_pkg_boson_GetTableSwitchDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, tableSwitchDesired)
    # End of GetTableSwitchDesired()


    @exception_wrapper
    def bosonGetOverTempThreshold(self):
        '''Usage: returnCode, temperatureInC = GetOverTempThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 temperatureInC <class 'float'> <<FLOAT>>
        '''
        returnCode, temperatureInC = self.CLIENT_pkg_boson_GetOverTempThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, temperatureInC)
    # End of GetOverTempThreshold()


    @exception_wrapper
    def bosonGetLowPowerMode(self):
        '''Usage: returnCode, lowPowerMode = GetLowPowerMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 lowPowerMode <class 'int'> <<UINT_16>>
        '''
        returnCode, lowPowerMode = self.CLIENT_pkg_boson_GetLowPowerMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, lowPowerMode)
    # End of GetLowPowerMode()


    @exception_wrapper
    def bosonGetOverTempEventOccurred(self):
        '''Usage: returnCode, overTempEventOccurred = GetOverTempEventOccurred(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 overTempEventOccurred <class 'int'> <<UINT_16>>
        '''
        returnCode, overTempEventOccurred = self.CLIENT_pkg_boson_GetOverTempEventOccurred()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, overTempEventOccurred)
    # End of GetOverTempEventOccurred()


    @exception_wrapper
    def bosonSetPermitThermalShutdownOverride(self, permitThermalShutdownOverride):
        '''Usage: returnCode = SetPermitThermalShutdownOverride(self, permitThermalShutdownOverride)
            Input_01 permitThermalShutdownOverride FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetPermitThermalShutdownOverride(permitThermalShutdownOverride)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetPermitThermalShutdownOverride()


    @exception_wrapper
    def bosonGetPermitThermalShutdownOverride(self):
        '''Usage: returnCode, permitThermalShutdownOverride = GetPermitThermalShutdownOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 permitThermalShutdownOverride FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, permitThermalShutdownOverride = self.CLIENT_pkg_boson_GetPermitThermalShutdownOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, permitThermalShutdownOverride)
    # End of GetPermitThermalShutdownOverride()


    @exception_wrapper
    def bosonGetMyriadTemp(self):
        '''Usage: returnCode, myriadTemp = GetMyriadTemp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 myriadTemp <class 'float'> <<FLOAT>>
        '''
        returnCode, myriadTemp = self.CLIENT_pkg_boson_GetMyriadTemp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, myriadTemp)
    # End of GetMyriadTemp()


    @exception_wrapper
    def bosonGetNvFFCNucTableNumberLens0(self):
        '''Usage: returnCode, nvFFCNucTableNumberLens0 = GetNvFFCNucTableNumberLens0(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 nvFFCNucTableNumberLens0 <class 'int'> <<INT_32>>
        '''
        returnCode, nvFFCNucTableNumberLens0 = self.CLIENT_pkg_boson_GetNvFFCNucTableNumberLens0()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, nvFFCNucTableNumberLens0)
    # End of GetNvFFCNucTableNumberLens0()


    @exception_wrapper
    def bosonGetNvFFCNucTableNumberLens1(self):
        '''Usage: returnCode, nvFFCNucTableNumberLens1 = GetNvFFCNucTableNumberLens1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 nvFFCNucTableNumberLens1 <class 'int'> <<INT_32>>
        '''
        returnCode, nvFFCNucTableNumberLens1 = self.CLIENT_pkg_boson_GetNvFFCNucTableNumberLens1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, nvFFCNucTableNumberLens1)
    # End of GetNvFFCNucTableNumberLens1()


    @exception_wrapper
    def bosonGetNvFFCFPATempDegKx10Lens0(self):
        '''Usage: returnCode, nvFFCFPATempDegKx10Lens0 = GetNvFFCFPATempDegKx10Lens0(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 nvFFCFPATempDegKx10Lens0 <class 'int'> <<UINT_16>>
        '''
        returnCode, nvFFCFPATempDegKx10Lens0 = self.CLIENT_pkg_boson_GetNvFFCFPATempDegKx10Lens0()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, nvFFCFPATempDegKx10Lens0)
    # End of GetNvFFCFPATempDegKx10Lens0()


    @exception_wrapper
    def bosonGetNvFFCFPATempDegKx10Lens1(self):
        '''Usage: returnCode, nvFFCFPATempDegKx10Lens1 = GetNvFFCFPATempDegKx10Lens1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 nvFFCFPATempDegKx10Lens1 <class 'int'> <<UINT_16>>
        '''
        returnCode, nvFFCFPATempDegKx10Lens1 = self.CLIENT_pkg_boson_GetNvFFCFPATempDegKx10Lens1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, nvFFCFPATempDegKx10Lens1)
    # End of GetNvFFCFPATempDegKx10Lens1()


    @exception_wrapper
    def bosonSetFFCWarnTimeInSecx10(self, ffcWarnTime):
        '''Usage: returnCode = SetFFCWarnTimeInSecx10(self, ffcWarnTime)
            Input_01 ffcWarnTime <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCWarnTimeInSecx10(ffcWarnTime)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCWarnTimeInSecx10()


    @exception_wrapper
    def bosonGetFFCWarnTimeInSecx10(self):
        '''Usage: returnCode, ffcWarnTime = GetFFCWarnTimeInSecx10(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 ffcWarnTime <class 'int'> <<UINT_16>>
        '''
        returnCode, ffcWarnTime = self.CLIENT_pkg_boson_GetFFCWarnTimeInSecx10()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ffcWarnTime)
    # End of GetFFCWarnTimeInSecx10()


    @exception_wrapper
    def bosonGetOverTempEventCounter(self):
        '''Usage: returnCode, overTempEventCounter = GetOverTempEventCounter(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 overTempEventCounter <class 'int'> <<UINT_32>>
        '''
        returnCode, overTempEventCounter = self.CLIENT_pkg_boson_GetOverTempEventCounter()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, overTempEventCounter)
    # End of GetOverTempEventCounter()


    @exception_wrapper
    def bosonSetOverTempTimerInSec(self, overTempTimerInSec):
        '''Usage: returnCode = SetOverTempTimerInSec(self, overTempTimerInSec)
            Input_01 overTempTimerInSec <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetOverTempTimerInSec(overTempTimerInSec)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOverTempTimerInSec()


    @exception_wrapper
    def bosonGetOverTempTimerInSec(self):
        '''Usage: returnCode, overTempTimerInSec = GetOverTempTimerInSec(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 overTempTimerInSec <class 'int'> <<UINT_16>>
        '''
        returnCode, overTempTimerInSec = self.CLIENT_pkg_boson_GetOverTempTimerInSec()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, overTempTimerInSec)
    # End of GetOverTempTimerInSec()


    @exception_wrapper
    def bosonUnloadCurrentLensCorrections(self):
        '''Usage: returnCode = UnloadCurrentLensCorrections(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_UnloadCurrentLensCorrections()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of UnloadCurrentLensCorrections()


    @exception_wrapper
    def bosonSetTimeForQuickFFCsInSecs(self, timeForQuickFFCsInSecs):
        '''Usage: returnCode = SetTimeForQuickFFCsInSecs(self, timeForQuickFFCsInSecs)
            Input_01 timeForQuickFFCsInSecs <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetTimeForQuickFFCsInSecs(timeForQuickFFCsInSecs)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTimeForQuickFFCsInSecs()


    @exception_wrapper
    def bosonGetTimeForQuickFFCsInSecs(self):
        '''Usage: returnCode, timeForQuickFFCsInSecs = GetTimeForQuickFFCsInSecs(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 timeForQuickFFCsInSecs <class 'int'> <<UINT_32>>
        '''
        returnCode, timeForQuickFFCsInSecs = self.CLIENT_pkg_boson_GetTimeForQuickFFCsInSecs()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, timeForQuickFFCsInSecs)
    # End of GetTimeForQuickFFCsInSecs()


    @exception_wrapper
    def bosonReloadCurrentLensCorrections(self):
        '''Usage: returnCode = ReloadCurrentLensCorrections(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_ReloadCurrentLensCorrections()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ReloadCurrentLensCorrections()


    @exception_wrapper
    def bosonGetBootTimestamps(self):
        '''Usage: returnCode, FirstLight, StartInit, BosonExecDone, Timestamp4 = GetBootTimestamps(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 FirstLight <class 'float'> <<FLOAT>>
            Output_02 StartInit <class 'float'> <<FLOAT>>
            Output_03 BosonExecDone <class 'float'> <<FLOAT>>
            Output_04 Timestamp4 <class 'float'> <<FLOAT>>
        '''
        returnCode, FirstLight, StartInit, BosonExecDone, Timestamp4 = self.CLIENT_pkg_boson_GetBootTimestamps()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None)
        
        return ( returnCode, FirstLight, StartInit, BosonExecDone, Timestamp4)
    # End of GetBootTimestamps()


    @exception_wrapper
    def bosonSetExtSyncMode(self, mode):
        '''Usage: returnCode = SetExtSyncMode(self, mode)
            Input_01 mode FLR_BOSON_EXT_SYNC_MODE_E <<FLR_BOSON_EXT_SYNC_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetExtSyncMode(mode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetExtSyncMode()


    @exception_wrapper
    def bosonGetExtSyncMode(self):
        '''Usage: returnCode, mode = GetExtSyncMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mode FLR_BOSON_EXT_SYNC_MODE_E <<FLR_BOSON_EXT_SYNC_MODE_E>>
        '''
        returnCode, mode = self.CLIENT_pkg_boson_GetExtSyncMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, mode)
    # End of GetExtSyncMode()


    @exception_wrapper
    def bosonGetLastCommand(self):
        '''Usage: returnCode, sequenceNum, cmdID = GetLastCommand(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 sequenceNum <class 'int'> <<UINT_32>>
            Output_02 cmdID <class 'int'> <<UINT_32>>
        '''
        returnCode, sequenceNum, cmdID = self.CLIENT_pkg_boson_GetLastCommand()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, sequenceNum, cmdID)
    # End of GetLastCommand()


    @exception_wrapper
    def bosonGetSensorHostCalVersion(self):
        '''Usage: returnCode, version = GetSensorHostCalVersion(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 version <class 'int'> <<UINT_32>>
        '''
        returnCode, version = self.CLIENT_pkg_boson_GetSensorHostCalVersion()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, version)
    # End of GetSensorHostCalVersion()


    @exception_wrapper
    def bosonSetDesiredStartupTableNumber(self, table):
        '''Usage: returnCode = SetDesiredStartupTableNumber(self, table)
            Input_01 table <class 'int'> <<INT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetDesiredStartupTableNumber(table)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDesiredStartupTableNumber()


    @exception_wrapper
    def bosonGetDesiredStartupTableNumber(self):
        '''Usage: returnCode, table = GetDesiredStartupTableNumber(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 table <class 'int'> <<INT_32>>
        '''
        returnCode, table = self.CLIENT_pkg_boson_GetDesiredStartupTableNumber()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, table)
    # End of GetDesiredStartupTableNumber()


    @exception_wrapper
    def bosonSetNvFFCMeanValueLens0(self, meanValue):
        '''Usage: returnCode = SetNvFFCMeanValueLens0(self, meanValue)
            Input_01 meanValue <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetNvFFCMeanValueLens0(meanValue)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNvFFCMeanValueLens0()


    @exception_wrapper
    def bosonGetNvFFCMeanValueLens0(self):
        '''Usage: returnCode, meanValue = GetNvFFCMeanValueLens0(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 meanValue <class 'float'> <<FLOAT>>
        '''
        returnCode, meanValue = self.CLIENT_pkg_boson_GetNvFFCMeanValueLens0()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, meanValue)
    # End of GetNvFFCMeanValueLens0()


    @exception_wrapper
    def bosonSetNvFFCMeanValueLens1(self, meanValue):
        '''Usage: returnCode = SetNvFFCMeanValueLens1(self, meanValue)
            Input_01 meanValue <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetNvFFCMeanValueLens1(meanValue)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNvFFCMeanValueLens1()


    @exception_wrapper
    def bosonGetNvFFCMeanValueLens1(self):
        '''Usage: returnCode, meanValue = GetNvFFCMeanValueLens1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 meanValue <class 'float'> <<FLOAT>>
        '''
        returnCode, meanValue = self.CLIENT_pkg_boson_GetNvFFCMeanValueLens1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, meanValue)
    # End of GetNvFFCMeanValueLens1()


    @exception_wrapper
    def bosonSetInvertImage(self, invertImage):
        '''Usage: returnCode = SetInvertImage(self, invertImage)
            Input_01 invertImage FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetInvertImage(invertImage)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetInvertImage()


    @exception_wrapper
    def bosonGetInvertImage(self):
        '''Usage: returnCode, invertImage = GetInvertImage(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 invertImage FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, invertImage = self.CLIENT_pkg_boson_GetInvertImage()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, invertImage)
    # End of GetInvertImage()


    @exception_wrapper
    def bosonSetRevertImage(self, revertImage):
        '''Usage: returnCode = SetRevertImage(self, revertImage)
            Input_01 revertImage FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetRevertImage(revertImage)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRevertImage()


    @exception_wrapper
    def bosonGetRevertImage(self):
        '''Usage: returnCode, revertImage = GetRevertImage(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 revertImage FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, revertImage = self.CLIENT_pkg_boson_GetRevertImage()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, revertImage)
    # End of GetRevertImage()


    @exception_wrapper
    def bosonGetTimeStamp(self, timeStampType):
        '''Usage: returnCode, timeStamp = GetTimeStamp(self, timeStampType)
            Input_01 timeStampType FLR_BOSON_TIMESTAMPTYPE_E <<FLR_BOSON_TIMESTAMPTYPE_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 timeStamp <class 'float'> <<FLOAT>>
        '''
        returnCode, timeStamp = self.CLIENT_pkg_boson_GetTimeStamp(timeStampType)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, timeStamp)
    # End of GetTimeStamp()


    @exception_wrapper
    def bosonGetISPFrameCount(self):
        '''Usage: returnCode, ispFrameCount = GetISPFrameCount(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 ispFrameCount <class 'int'> <<UINT_32>>
        '''
        returnCode, ispFrameCount = self.CLIENT_pkg_boson_GetISPFrameCount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ispFrameCount)
    # End of GetISPFrameCount()


    @exception_wrapper
    def bosonWriteUserBadPixelsToAllTables(self):
        '''Usage: returnCode = WriteUserBadPixelsToAllTables(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteUserBadPixelsToAllTables()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteUserBadPixelsToAllTables()


    @exception_wrapper
    def bosonWriteFactoryBadPixelsToAllTables(self):
        '''Usage: returnCode = WriteFactoryBadPixelsToAllTables(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_WriteFactoryBadPixelsToAllTables()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteFactoryBadPixelsToAllTables()


    @exception_wrapper
    def bosonGetTempDiodeStatus(self):
        '''Usage: returnCode, status = GetTempDiodeStatus(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 status FLR_BOSON_TEMP_DIODE_STATUS_E <<FLR_BOSON_TEMP_DIODE_STATUS_E>>
        '''
        returnCode, status = self.CLIENT_pkg_boson_GetTempDiodeStatus()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, status)
    # End of GetTempDiodeStatus()


    @exception_wrapper
    def bosonClearFactoryBadPixelsInDDR(self):
        '''Usage: returnCode = ClearFactoryBadPixelsInDDR(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_ClearFactoryBadPixelsInDDR()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ClearFactoryBadPixelsInDDR()


    @exception_wrapper
    def bosonGetFfcWaitOpenFrames(self):
        '''Usage: returnCode, data = GetFfcWaitOpenFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFfcWaitOpenFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcWaitOpenFrames()


    @exception_wrapper
    def bosonSetFfcWaitOpenFrames(self, data):
        '''Usage: returnCode = SetFfcWaitOpenFrames(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFfcWaitOpenFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFfcWaitOpenFrames()


    @exception_wrapper
    def bosonGetFfcWaitOpenFlagSettleFrames(self):
        '''Usage: returnCode, data = GetFfcWaitOpenFlagSettleFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFfcWaitOpenFlagSettleFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcWaitOpenFlagSettleFrames()


    @exception_wrapper
    def bosonSetFfcWaitOpenFlagSettleFrames(self, data):
        '''Usage: returnCode = SetFfcWaitOpenFlagSettleFrames(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFfcWaitOpenFlagSettleFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFfcWaitOpenFlagSettleFrames()


    @exception_wrapper
    def bosonGetTauExtFfcCompatibilityMode(self):
        '''Usage: returnCode, data = GetTauExtFfcCompatibilityMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetTauExtFfcCompatibilityMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTauExtFfcCompatibilityMode()


    @exception_wrapper
    def bosonSetTauExtFfcCompatibilityMode(self, data):
        '''Usage: returnCode = SetTauExtFfcCompatibilityMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetTauExtFfcCompatibilityMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTauExtFfcCompatibilityMode()


    @exception_wrapper
    def bosonGetInitialTableSelectionTempOffset(self):
        '''Usage: returnCode, data = GetInitialTableSelectionTempOffset(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetInitialTableSelectionTempOffset()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetInitialTableSelectionTempOffset()


    @exception_wrapper
    def bosonSetInitialTableSelectionTempOffset(self, data):
        '''Usage: returnCode = SetInitialTableSelectionTempOffset(self, data)
            Input_01 data <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetInitialTableSelectionTempOffset(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetInitialTableSelectionTempOffset()


    @exception_wrapper
    def bosonGetImageValid(self):
        '''Usage: returnCode, data = GetImageValid(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetImageValid()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetImageValid()


    @exception_wrapper
    def bosonGetCurrentTableType(self):
        '''Usage: returnCode, data = GetCurrentTableType(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_BOSON_TABLETYPE_E <<FLR_BOSON_TABLETYPE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetCurrentTableType()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetCurrentTableType()


    @exception_wrapper
    def bosonGetGainSwitchFrameThreshold(self):
        '''Usage: returnCode, data = GetGainSwitchFrameThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetGainSwitchFrameThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGainSwitchFrameThreshold()


    @exception_wrapper
    def bosonSetGainSwitchFrameThreshold(self, data):
        '''Usage: returnCode = SetGainSwitchFrameThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetGainSwitchFrameThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainSwitchFrameThreshold()


    @exception_wrapper
    def bosonGetGainSwitchHysteresisTime(self):
        '''Usage: returnCode, data = GetGainSwitchHysteresisTime(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetGainSwitchHysteresisTime()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGainSwitchHysteresisTime()


    @exception_wrapper
    def bosonSetGainSwitchHysteresisTime(self, data):
        '''Usage: returnCode = SetGainSwitchHysteresisTime(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetGainSwitchHysteresisTime(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainSwitchHysteresisTime()


    @exception_wrapper
    def bosonGetGainSwitchDesired(self):
        '''Usage: returnCode, data = GetGainSwitchDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetGainSwitchDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGainSwitchDesired()


    @exception_wrapper
    def bosonGetGainSwitchRadiometricParams(self):
        '''Usage: returnCode, parm_struct = GetGainSwitchRadiometricParams(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 parm_struct FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T <<FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T>>
        '''
        returnCode, parm_struct = self.CLIENT_pkg_boson_GetGainSwitchRadiometricParams()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, parm_struct)
    # End of GetGainSwitchRadiometricParams()


    @exception_wrapper
    def bosonSetGainSwitchRadiometricParams(self, parm_struct):
        '''Usage: returnCode = SetGainSwitchRadiometricParams(self, parm_struct)
            Input_01 parm_struct FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T <<FLR_BOSON_GAIN_SWITCH_RADIOMETRIC_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetGainSwitchRadiometricParams(parm_struct)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainSwitchRadiometricParams()


    @exception_wrapper
    def bosonSetSaturationOverrideMode(self, data):
        '''Usage: returnCode = SetSaturationOverrideMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetSaturationOverrideMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSaturationOverrideMode()


    @exception_wrapper
    def bosonGetSaturationOverrideMode(self):
        '''Usage: returnCode, data = GetSaturationOverrideMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetSaturationOverrideMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSaturationOverrideMode()


    @exception_wrapper
    def bosonSetSaturationOverrideValue(self, data):
        '''Usage: returnCode = SetSaturationOverrideValue(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetSaturationOverrideValue(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSaturationOverrideValue()


    @exception_wrapper
    def bosonGetSaturationOverrideValue(self):
        '''Usage: returnCode, data = GetSaturationOverrideValue(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetSaturationOverrideValue()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSaturationOverrideValue()


    @exception_wrapper
    def bosonSetffcHighLowGainThresholdMode(self, data):
        '''Usage: returnCode = SetffcHighLowGainThresholdMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetffcHighLowGainThresholdMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetffcHighLowGainThresholdMode()


    @exception_wrapper
    def bosonGetffcHighLowGainThresholdMode(self):
        '''Usage: returnCode, data = GetffcHighLowGainThresholdMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetffcHighLowGainThresholdMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetffcHighLowGainThresholdMode()


    @exception_wrapper
    def bosonSetFFCTempThresholdLowGain(self, data):
        '''Usage: returnCode = SetFFCTempThresholdLowGain(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCTempThresholdLowGain(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCTempThresholdLowGain()


    @exception_wrapper
    def bosonGetFFCTempThresholdLowGain(self):
        '''Usage: returnCode, data = GetFFCTempThresholdLowGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFFCTempThresholdLowGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFCTempThresholdLowGain()


    @exception_wrapper
    def bosonSetFFCFrameThresholdLowGain(self, data):
        '''Usage: returnCode = SetFFCFrameThresholdLowGain(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_boson_SetFFCFrameThresholdLowGain(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFCFrameThresholdLowGain()


    @exception_wrapper
    def bosonGetFFCFrameThresholdLowGain(self):
        '''Usage: returnCode, data = GetFFCFrameThresholdLowGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_boson_GetFFCFrameThresholdLowGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFCFrameThresholdLowGain()


    @exception_wrapper
    def bprGetState(self):
        '''Usage: returnCode, data = GetState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_bpr_GetState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetState()


    @exception_wrapper
    def bprSetState(self, data):
        '''Usage: returnCode = SetState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_bpr_SetState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetState()


    @exception_wrapper
    def bprGetStats(self):
        '''Usage: returnCode, threeby, fiveby, rows, budget, used = GetStats(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 threeby <class 'int'> <<UINT_32>>
            Output_02 fiveby <class 'int'> <<UINT_32>>
            Output_03 rows <class 'int'> <<UINT_32>>
            Output_04 budget <class 'int'> <<UINT_32>>
            Output_05 used <class 'int'> <<UINT_32>>
        '''
        returnCode, threeby, fiveby, rows, budget, used = self.CLIENT_pkg_bpr_GetStats()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None)
        
        return ( returnCode, threeby, fiveby, rows, budget, used)
    # End of GetStats()


    @exception_wrapper
    def bprGetDisplayMode(self):
        '''Usage: returnCode, data = GetDisplayMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_BPR_DISPLAY_MODE_E <<FLR_BPR_DISPLAY_MODE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_bpr_GetDisplayMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDisplayMode()


    @exception_wrapper
    def bprSetDisplayMode(self, data):
        '''Usage: returnCode = SetDisplayMode(self, data)
            Input_01 data FLR_BPR_DISPLAY_MODE_E <<FLR_BPR_DISPLAY_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_bpr_SetDisplayMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDisplayMode()


    @exception_wrapper
    def bprGetDisplayModeMinValue(self):
        '''Usage: returnCode, data = GetDisplayModeMinValue(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_bpr_GetDisplayModeMinValue()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDisplayModeMinValue()


    @exception_wrapper
    def bprSetDisplayModeMinValue(self, data):
        '''Usage: returnCode = SetDisplayModeMinValue(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_bpr_SetDisplayModeMinValue(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDisplayModeMinValue()


    @exception_wrapper
    def bprGetDisplayModeMaxValue(self):
        '''Usage: returnCode, data = GetDisplayModeMaxValue(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_bpr_GetDisplayModeMaxValue()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDisplayModeMaxValue()


    @exception_wrapper
    def bprSetDisplayModeMaxValue(self, data):
        '''Usage: returnCode = SetDisplayModeMaxValue(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_bpr_SetDisplayModeMaxValue(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDisplayModeMaxValue()


    @exception_wrapper
    def bprGetWorkBufIndex(self):
        '''Usage: returnCode, data = GetWorkBufIndex(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_bpr_GetWorkBufIndex()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetWorkBufIndex()


    @exception_wrapper
    def bprSetWorkBufIndex(self, data):
        '''Usage: returnCode = SetWorkBufIndex(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_bpr_SetWorkBufIndex(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetWorkBufIndex()


    @exception_wrapper
    def bprGetWorkBufStats(self):
        '''Usage: returnCode, threeby, fiveby, rows, budget, used = GetWorkBufStats(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 threeby <class 'int'> <<UINT_32>>
            Output_02 fiveby <class 'int'> <<UINT_32>>
            Output_03 rows <class 'int'> <<UINT_32>>
            Output_04 budget <class 'int'> <<UINT_32>>
            Output_05 used <class 'int'> <<UINT_32>>
        '''
        returnCode, threeby, fiveby, rows, budget, used = self.CLIENT_pkg_bpr_GetWorkBufStats()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None)
        
        return ( returnCode, threeby, fiveby, rows, budget, used)
    # End of GetWorkBufStats()


    @exception_wrapper
    def captureSingleFrame(self):
        '''Usage: returnCode = SingleFrame(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_capture_SingleFrame()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SingleFrame()


    @exception_wrapper
    def captureFrames(self, data):
        '''Usage: returnCode = Frames(self, data)
            Input_01 data FLR_CAPTURE_SETTINGS_T <<FLR_CAPTURE_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_capture_Frames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Frames()


    @exception_wrapper
    def captureSingleFrameWithSrc(self, data):
        '''Usage: returnCode = SingleFrameWithSrc(self, data)
            Input_01 data FLR_CAPTURE_SRC_E <<FLR_CAPTURE_SRC_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_capture_SingleFrameWithSrc(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SingleFrameWithSrc()


    @exception_wrapper
    def captureSingleFrameToFile(self):
        '''Usage: returnCode = SingleFrameToFile(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_capture_SingleFrameToFile()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SingleFrameToFile()


    @exception_wrapper
    def captureGetStatus(self):
        '''Usage: returnCode, status = GetStatus(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 status FLR_CAPTURE_STATUS_T <<FLR_CAPTURE_STATUS_T>>
        '''
        returnCode, status = self.CLIENT_pkg_capture_GetStatus()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, status)
    # End of GetStatus()


    @exception_wrapper
    def colorLutSetControl(self, data):
        '''Usage: returnCode = SetControl(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_colorLut_SetControl(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetControl()


    @exception_wrapper
    def colorLutGetControl(self):
        '''Usage: returnCode, data = GetControl(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_colorLut_GetControl()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetControl()


    @exception_wrapper
    def colorLutSetId(self, data):
        '''Usage: returnCode = SetId(self, data)
            Input_01 data FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_colorLut_SetId(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetId()


    @exception_wrapper
    def colorLutGetId(self):
        '''Usage: returnCode, data = GetId(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
        '''
        returnCode, data = self.CLIENT_pkg_colorLut_GetId()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetId()


    @exception_wrapper
    def colorLutSetOutlineColor(self, red, green, blue):
        '''Usage: returnCode = SetOutlineColor(self, red, green, blue)
            Input_01 red <class 'int'> <<UCHAR>>
            Input_02 green <class 'int'> <<UCHAR>>
            Input_03 blue <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_colorLut_SetOutlineColor(red, green, blue)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutlineColor()


    @exception_wrapper
    def colorLutGetOutlineColor(self):
        '''Usage: returnCode, red, green, blue = GetOutlineColor(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 red <class 'int'> <<UCHAR>>
            Output_02 green <class 'int'> <<UCHAR>>
            Output_03 blue <class 'int'> <<UCHAR>>
        '''
        returnCode, red, green, blue = self.CLIENT_pkg_colorLut_GetOutlineColor()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, red, green, blue)
    # End of GetOutlineColor()


    @exception_wrapper
    def dummyBadCommand(self):
        '''Usage: returnCode = BadCommand(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dummy_BadCommand()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of BadCommand()


    @exception_wrapper
    def dvoSetAnalogVideoState(self, analogVideoState):
        '''Usage: returnCode = SetAnalogVideoState(self, analogVideoState)
            Input_01 analogVideoState FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetAnalogVideoState(analogVideoState)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetAnalogVideoState()


    @exception_wrapper
    def dvoGetAnalogVideoState(self):
        '''Usage: returnCode, analogVideoState = GetAnalogVideoState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 analogVideoState FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, analogVideoState = self.CLIENT_pkg_dvo_GetAnalogVideoState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, analogVideoState)
    # End of GetAnalogVideoState()


    @exception_wrapper
    def dvoSetOutputFormat(self, format):
        '''Usage: returnCode = SetOutputFormat(self, format)
            Input_01 format FLR_DVO_OUTPUT_FORMAT_E <<FLR_DVO_OUTPUT_FORMAT_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetOutputFormat(format)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutputFormat()


    @exception_wrapper
    def dvoGetOutputFormat(self):
        '''Usage: returnCode, format = GetOutputFormat(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 format FLR_DVO_OUTPUT_FORMAT_E <<FLR_DVO_OUTPUT_FORMAT_E>>
        '''
        returnCode, format = self.CLIENT_pkg_dvo_GetOutputFormat()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, format)
    # End of GetOutputFormat()


    @exception_wrapper
    def dvoSetOutputYCbCrSettings(self, settings):
        '''Usage: returnCode = SetOutputYCbCrSettings(self, settings)
            Input_01 settings FLR_DVO_YCBCR_SETTINGS_T <<FLR_DVO_YCBCR_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetOutputYCbCrSettings(settings)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutputYCbCrSettings()


    @exception_wrapper
    def dvoGetOutputYCbCrSettings(self):
        '''Usage: returnCode, settings = GetOutputYCbCrSettings(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 settings FLR_DVO_YCBCR_SETTINGS_T <<FLR_DVO_YCBCR_SETTINGS_T>>
        '''
        returnCode, settings = self.CLIENT_pkg_dvo_GetOutputYCbCrSettings()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, settings)
    # End of GetOutputYCbCrSettings()


    @exception_wrapper
    def dvoSetOutputRGBSettings(self, settings):
        '''Usage: returnCode = SetOutputRGBSettings(self, settings)
            Input_01 settings FLR_DVO_RGB_SETTINGS_T <<FLR_DVO_RGB_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetOutputRGBSettings(settings)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutputRGBSettings()


    @exception_wrapper
    def dvoGetOutputRGBSettings(self):
        '''Usage: returnCode, settings = GetOutputRGBSettings(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 settings FLR_DVO_RGB_SETTINGS_T <<FLR_DVO_RGB_SETTINGS_T>>
        '''
        returnCode, settings = self.CLIENT_pkg_dvo_GetOutputRGBSettings()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, settings)
    # End of GetOutputRGBSettings()


    @exception_wrapper
    def dvoApplyCustomSettings(self):
        '''Usage: returnCode = ApplyCustomSettings(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_ApplyCustomSettings()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ApplyCustomSettings()


    @exception_wrapper
    def dvoSetDisplayMode(self, displayMode):
        '''Usage: returnCode = SetDisplayMode(self, displayMode)
            Input_01 displayMode FLR_DVO_DISPLAY_MODE_E <<FLR_DVO_DISPLAY_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetDisplayMode(displayMode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDisplayMode()


    @exception_wrapper
    def dvoGetDisplayMode(self):
        '''Usage: returnCode, displayMode = GetDisplayMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 displayMode FLR_DVO_DISPLAY_MODE_E <<FLR_DVO_DISPLAY_MODE_E>>
        '''
        returnCode, displayMode = self.CLIENT_pkg_dvo_GetDisplayMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, displayMode)
    # End of GetDisplayMode()


    @exception_wrapper
    def dvoSetType(self, tap):
        '''Usage: returnCode = SetType(self, tap)
            Input_01 tap FLR_DVO_TYPE_E <<FLR_DVO_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetType(tap)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetType()


    @exception_wrapper
    def dvoGetType(self):
        '''Usage: returnCode, tap = GetType(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 tap FLR_DVO_TYPE_E <<FLR_DVO_TYPE_E>>
        '''
        returnCode, tap = self.CLIENT_pkg_dvo_GetType()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, tap)
    # End of GetType()


    @exception_wrapper
    def dvoSetVideoStandard(self, videoStandard):
        '''Usage: returnCode = SetVideoStandard(self, videoStandard)
            Input_01 videoStandard FLR_DVO_VIDEO_STANDARD_E <<FLR_DVO_VIDEO_STANDARD_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetVideoStandard(videoStandard)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetVideoStandard()


    @exception_wrapper
    def dvoGetVideoStandard(self):
        '''Usage: returnCode, videoStandard = GetVideoStandard(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 videoStandard FLR_DVO_VIDEO_STANDARD_E <<FLR_DVO_VIDEO_STANDARD_E>>
        '''
        returnCode, videoStandard = self.CLIENT_pkg_dvo_GetVideoStandard()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, videoStandard)
    # End of GetVideoStandard()


    @exception_wrapper
    def dvoSetCheckVideoDacPresent(self, checkVideoDacPresent):
        '''Usage: returnCode = SetCheckVideoDacPresent(self, checkVideoDacPresent)
            Input_01 checkVideoDacPresent FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetCheckVideoDacPresent(checkVideoDacPresent)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetCheckVideoDacPresent()


    @exception_wrapper
    def dvoGetCheckVideoDacPresent(self):
        '''Usage: returnCode, checkVideoDacPresent = GetCheckVideoDacPresent(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 checkVideoDacPresent FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, checkVideoDacPresent = self.CLIENT_pkg_dvo_GetCheckVideoDacPresent()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, checkVideoDacPresent)
    # End of GetCheckVideoDacPresent()


    @exception_wrapper
    def dvoSetCustomLcdConfig(self, id, config):
        '''Usage: returnCode = SetCustomLcdConfig(self, id, config)
            Input_01 id FLR_DVO_LCD_CONFIG_ID_E <<FLR_DVO_LCD_CONFIG_ID_E>>
            Input_02 config FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetCustomLcdConfig(id, config)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetCustomLcdConfig()


    @exception_wrapper
    def dvoGetCustomLcdConfig(self, id):
        '''Usage: returnCode, config = GetCustomLcdConfig(self, id)
            Input_01 id FLR_DVO_LCD_CONFIG_ID_E <<FLR_DVO_LCD_CONFIG_ID_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 config FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
        '''
        returnCode, config = self.CLIENT_pkg_dvo_GetCustomLcdConfig(id)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, config)
    # End of GetCustomLcdConfig()


    @exception_wrapper
    def dvoSetLCDConfig(self, id):
        '''Usage: returnCode = SetLCDConfig(self, id)
            Input_01 id FLR_DVO_LCD_CONFIG_ID_E <<FLR_DVO_LCD_CONFIG_ID_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetLCDConfig(id)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLCDConfig()


    @exception_wrapper
    def dvoGetLCDConfig(self):
        '''Usage: returnCode, id = GetLCDConfig(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 id FLR_DVO_LCD_CONFIG_ID_E <<FLR_DVO_LCD_CONFIG_ID_E>>
        '''
        returnCode, id = self.CLIENT_pkg_dvo_GetLCDConfig()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, id)
    # End of GetLCDConfig()


    @exception_wrapper
    def dvoGetClockInfo(self):
        '''Usage: returnCode, horizontalSyncWidth, verticalSyncWidth, clocksPerRowPeriod, horizontalFrontPorch, horizontalBackPorch, frontTelemetryPixels, rearTelemetryPixels, videoColumns, validColumns, telemetryRows, videoRows, validRows, verticalFrontPorch, verticalBackPorch, rowPeriodsPerFrame, clocksPerFrame, clockRateInMHz, frameRateInHz, validOnRisingEdge, dataWidthInBits = GetClockInfo(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 horizontalSyncWidth <class 'int'> <<UINT_32>>
            Output_02 verticalSyncWidth <class 'int'> <<UINT_32>>
            Output_03 clocksPerRowPeriod <class 'int'> <<UINT_32>>
            Output_04 horizontalFrontPorch <class 'int'> <<UINT_32>>
            Output_05 horizontalBackPorch <class 'int'> <<UINT_32>>
            Output_06 frontTelemetryPixels <class 'int'> <<UINT_32>>
            Output_07 rearTelemetryPixels <class 'int'> <<UINT_32>>
            Output_08 videoColumns <class 'int'> <<UINT_32>>
            Output_09 validColumns <class 'int'> <<UINT_32>>
            Output_10 telemetryRows <class 'int'> <<UINT_32>>
            Output_11 videoRows <class 'int'> <<UINT_32>>
            Output_12 validRows <class 'int'> <<UINT_32>>
            Output_13 verticalFrontPorch <class 'int'> <<UINT_32>>
            Output_14 verticalBackPorch <class 'int'> <<UINT_32>>
            Output_15 rowPeriodsPerFrame <class 'int'> <<UINT_32>>
            Output_16 clocksPerFrame <class 'int'> <<UINT_32>>
            Output_17 clockRateInMHz <class 'float'> <<FLOAT>>
            Output_18 frameRateInHz <class 'float'> <<FLOAT>>
            Output_19 validOnRisingEdge <class 'int'> <<UINT_32>>
            Output_20 dataWidthInBits <class 'int'> <<UINT_32>>
        '''
        returnCode, horizontalSyncWidth, verticalSyncWidth, clocksPerRowPeriod, horizontalFrontPorch, horizontalBackPorch, frontTelemetryPixels, rearTelemetryPixels, videoColumns, validColumns, telemetryRows, videoRows, validRows, verticalFrontPorch, verticalBackPorch, rowPeriodsPerFrame, clocksPerFrame, clockRateInMHz, frameRateInHz, validOnRisingEdge, dataWidthInBits = self.CLIENT_pkg_dvo_GetClockInfo()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None)
        
        return ( returnCode, horizontalSyncWidth, verticalSyncWidth, clocksPerRowPeriod, horizontalFrontPorch, horizontalBackPorch, frontTelemetryPixels, rearTelemetryPixels, videoColumns, validColumns, telemetryRows, videoRows, validRows, verticalFrontPorch, verticalBackPorch, rowPeriodsPerFrame, clocksPerFrame, clockRateInMHz, frameRateInHz, validOnRisingEdge, dataWidthInBits)
    # End of GetClockInfo()


    @exception_wrapper
    def dvoSetAllCustomLcdConfigs(self, config0, config1):
        '''Usage: returnCode = SetAllCustomLcdConfigs(self, config0, config1)
            Input_01 config0 FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
            Input_02 config1 FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetAllCustomLcdConfigs(config0, config1)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetAllCustomLcdConfigs()


    @exception_wrapper
    def dvoGetAllCustomLcdConfigs(self):
        '''Usage: returnCode, config0, config1 = GetAllCustomLcdConfigs(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 config0 FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
            Output_02 config1 FLR_DVO_LCD_CONFIG_T <<FLR_DVO_LCD_CONFIG_T>>
        '''
        returnCode, config0, config1 = self.CLIENT_pkg_dvo_GetAllCustomLcdConfigs()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, config0, config1)
    # End of GetAllCustomLcdConfigs()


    @exception_wrapper
    def dvoSetOutputIr16Format(self, format):
        '''Usage: returnCode = SetOutputIr16Format(self, format)
            Input_01 format FLR_DVO_OUTPUT_IR16_FORMAT_E <<FLR_DVO_OUTPUT_IR16_FORMAT_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetOutputIr16Format(format)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOutputIr16Format()


    @exception_wrapper
    def dvoGetOutputIr16Format(self):
        '''Usage: returnCode, format = GetOutputIr16Format(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 format FLR_DVO_OUTPUT_IR16_FORMAT_E <<FLR_DVO_OUTPUT_IR16_FORMAT_E>>
        '''
        returnCode, format = self.CLIENT_pkg_dvo_GetOutputIr16Format()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, format)
    # End of GetOutputIr16Format()


    @exception_wrapper
    def dvoSetLcdClockRate(self, clockRate):
        '''Usage: returnCode = SetLcdClockRate(self, clockRate)
            Input_01 clockRate FLR_DVO_LCD_CLOCK_RATE_E <<FLR_DVO_LCD_CLOCK_RATE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetLcdClockRate(clockRate)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLcdClockRate()


    @exception_wrapper
    def dvoGetLcdClockRate(self):
        '''Usage: returnCode, clockRate = GetLcdClockRate(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 clockRate FLR_DVO_LCD_CLOCK_RATE_E <<FLR_DVO_LCD_CLOCK_RATE_E>>
        '''
        returnCode, clockRate = self.CLIENT_pkg_dvo_GetLcdClockRate()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, clockRate)
    # End of GetLcdClockRate()


    @exception_wrapper
    def dvoSetLcdVideoFrameRate(self, framerate):
        '''Usage: returnCode = SetLcdVideoFrameRate(self, framerate)
            Input_01 framerate <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_dvo_SetLcdVideoFrameRate(framerate)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLcdVideoFrameRate()


    @exception_wrapper
    def dvoGetLcdVideoFrameRate(self):
        '''Usage: returnCode, framerate = GetLcdVideoFrameRate(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 framerate <class 'int'> <<UINT_32>>
        '''
        returnCode, framerate = self.CLIENT_pkg_dvo_GetLcdVideoFrameRate()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, framerate)
    # End of GetLcdVideoFrameRate()


    @exception_wrapper
    def fileOpsDir(self):
        '''Usage: returnCode, dirent = Dir(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 dirent[<class 'int'>] 128 <<UCHAR*128>>
        '''
        returnCode, dirent = self.CLIENT_pkg_fileOps_Dir()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, dirent)
    # End of Dir()


    @exception_wrapper
    def fileOpsCd(self, path):
        '''Usage: returnCode, pwd = Cd(self, path)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 pwd[<class 'int'>] 128 <<UCHAR*128>>
        '''
        returnCode, pwd = self.CLIENT_pkg_fileOps_Cd(path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, pwd)
    # End of Cd()


    @exception_wrapper
    def fileOpsMd(self, path):
        '''Usage: returnCode = Md(self, path)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Md(path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Md()


    @exception_wrapper
    def fileOpsFopen(self, path, mode):
        '''Usage: returnCode, id = Fopen(self, path, mode)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Input_02 mode[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 id <class 'int'> <<UINT_32>>
        '''
        returnCode, id = self.CLIENT_pkg_fileOps_Fopen(path, mode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, id)
    # End of Fopen()


    @exception_wrapper
    def fileOpsFclose(self, id):
        '''Usage: returnCode = Fclose(self, id)
            Input_01 id <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Fclose(id)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Fclose()


    @exception_wrapper
    def fileOpsFread(self, id, length):
        '''Usage: returnCode, buf, ret = Fread(self, id, length)
            Input_01 id <class 'int'> <<UINT_32>>
            Input_02 length <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 buf[<class 'int'>] 128 <<UCHAR*128>>
            Output_02 ret <class 'int'> <<UINT_32>>
        '''
        returnCode, buf, ret = self.CLIENT_pkg_fileOps_Fread(id, length)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, buf, ret)
    # End of Fread()


    @exception_wrapper
    def fileOpsFwrite(self, id, length, buf):
        '''Usage: returnCode, ret = Fwrite(self, id, length, buf)
            Input_01 id <class 'int'> <<UINT_32>>
            Input_02 length <class 'int'> <<UINT_32>>
            Input_03 buf[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 ret <class 'int'> <<UINT_32>>
        '''
        returnCode, ret = self.CLIENT_pkg_fileOps_Fwrite(id, length, buf)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, ret)
    # End of Fwrite()


    @exception_wrapper
    def fileOpsFtell(self, id):
        '''Usage: returnCode, offset = Ftell(self, id)
            Input_01 id <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 offset <class 'int'> <<UINT_32>>
        '''
        returnCode, offset = self.CLIENT_pkg_fileOps_Ftell(id)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, offset)
    # End of Ftell()


    @exception_wrapper
    def fileOpsFseek(self, id, offset, origin):
        '''Usage: returnCode = Fseek(self, id, offset, origin)
            Input_01 id <class 'int'> <<UINT_32>>
            Input_02 offset <class 'int'> <<UINT_32>>
            Input_03 origin <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Fseek(id, offset, origin)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Fseek()


    @exception_wrapper
    def fileOpsFtruncate(self, id, length):
        '''Usage: returnCode = Ftruncate(self, id, length)
            Input_01 id <class 'int'> <<UINT_32>>
            Input_02 length <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Ftruncate(id, length)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Ftruncate()


    @exception_wrapper
    def fileOpsRmdir(self, path):
        '''Usage: returnCode = Rmdir(self, path)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Rmdir(path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Rmdir()


    @exception_wrapper
    def fileOpsRm(self, path):
        '''Usage: returnCode = Rm(self, path)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Rm(path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Rm()


    @exception_wrapper
    def fileOpsRename(self, oldpath, newpath):
        '''Usage: returnCode = Rename(self, oldpath, newpath)
            Input_01 oldpath[<class 'int'>] 128 <<UCHAR*128>>
            Input_02 newpath[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_fileOps_Rename(oldpath, newpath)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Rename()


    @exception_wrapper
    def fileOpsGetFileSize(self, path):
        '''Usage: returnCode, fileLength = GetFileSize(self, path)
            Input_01 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 fileLength <class 'int'> <<UINT_32>>
        '''
        returnCode, fileLength = self.CLIENT_pkg_fileOps_GetFileSize(path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, fileLength)
    # End of GetFileSize()


    @exception_wrapper
    def flashIOSetProtectionState(self, protectionState):
        '''Usage: returnCode = SetProtectionState(self, protectionState)
            Input_01 protectionState FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_flashIO_SetProtectionState(protectionState)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetProtectionState()


    @exception_wrapper
    def flashIOGetProtectionState(self):
        '''Usage: returnCode, protectionState = GetProtectionState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 protectionState FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, protectionState = self.CLIENT_pkg_flashIO_GetProtectionState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, protectionState)
    # End of GetProtectionState()


    @exception_wrapper
    def flashMapFsGetHeaderVersion(self):
        '''Usage: returnCode, major, minor, patch = GetHeaderVersion(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_flashMapFs_GetHeaderVersion()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetHeaderVersion()


    @exception_wrapper
    def gaoSetGainState(self, data):
        '''Usage: returnCode = SetGainState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetGainState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGainState()


    @exception_wrapper
    def gaoGetGainState(self):
        '''Usage: returnCode, data = GetGainState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetGainState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGainState()


    @exception_wrapper
    def gaoSetFfcState(self, data):
        '''Usage: returnCode = SetFfcState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetFfcState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFfcState()


    @exception_wrapper
    def gaoGetFfcState(self):
        '''Usage: returnCode, data = GetFfcState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetFfcState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcState()


    @exception_wrapper
    def gaoSetTempCorrectionState(self, data):
        '''Usage: returnCode = SetTempCorrectionState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetTempCorrectionState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempCorrectionState()


    @exception_wrapper
    def gaoGetTempCorrectionState(self):
        '''Usage: returnCode, data = GetTempCorrectionState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetTempCorrectionState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempCorrectionState()


    @exception_wrapper
    def gaoSetIConstL(self, data):
        '''Usage: returnCode = SetIConstL(self, data)
            Input_01 data <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetIConstL(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIConstL()


    @exception_wrapper
    def gaoGetIConstL(self):
        '''Usage: returnCode, data = GetIConstL(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetIConstL()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetIConstL()


    @exception_wrapper
    def gaoSetIConstM(self, data):
        '''Usage: returnCode = SetIConstM(self, data)
            Input_01 data <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetIConstM(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIConstM()


    @exception_wrapper
    def gaoGetIConstM(self):
        '''Usage: returnCode, data = GetIConstM(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetIConstM()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetIConstM()


    @exception_wrapper
    def gaoSetAveragerState(self, data):
        '''Usage: returnCode = SetAveragerState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetAveragerState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetAveragerState()


    @exception_wrapper
    def gaoGetAveragerState(self):
        '''Usage: returnCode, data = GetAveragerState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetAveragerState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAveragerState()


    @exception_wrapper
    def gaoSetNumFFCFrames(self, data):
        '''Usage: returnCode = SetNumFFCFrames(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetNumFFCFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNumFFCFrames()


    @exception_wrapper
    def gaoGetNumFFCFrames(self):
        '''Usage: returnCode, data = GetNumFFCFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetNumFFCFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetNumFFCFrames()


    @exception_wrapper
    def gaoGetAveragerThreshold(self):
        '''Usage: returnCode, data = GetAveragerThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetAveragerThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAveragerThreshold()


    @exception_wrapper
    def gaoSetRnsState(self, data):
        '''Usage: returnCode = SetRnsState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsState()


    @exception_wrapper
    def gaoGetRnsState(self):
        '''Usage: returnCode, data = GetRnsState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsState()


    @exception_wrapper
    def gaoSetTestRampState(self, data):
        '''Usage: returnCode = SetTestRampState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetTestRampState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTestRampState()


    @exception_wrapper
    def gaoGetTestRampState(self):
        '''Usage: returnCode, data = GetTestRampState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetTestRampState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTestRampState()


    @exception_wrapper
    def gaoSetSffcState(self, data):
        '''Usage: returnCode = SetSffcState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetSffcState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSffcState()


    @exception_wrapper
    def gaoGetSffcState(self):
        '''Usage: returnCode, data = GetSffcState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetSffcState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSffcState()


    @exception_wrapper
    def gaoSetNucType(self, nucType):
        '''Usage: returnCode = SetNucType(self, nucType)
            Input_01 nucType FLR_GAO_NUC_TYPE_E <<FLR_GAO_NUC_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetNucType(nucType)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNucType()


    @exception_wrapper
    def gaoGetNucType(self):
        '''Usage: returnCode, nucType = GetNucType(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 nucType FLR_GAO_NUC_TYPE_E <<FLR_GAO_NUC_TYPE_E>>
        '''
        returnCode, nucType = self.CLIENT_pkg_gao_GetNucType()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, nucType)
    # End of GetNucType()


    @exception_wrapper
    def gaoSetFfcZeroMeanState(self, data):
        '''Usage: returnCode = SetFfcZeroMeanState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetFfcZeroMeanState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFfcZeroMeanState()


    @exception_wrapper
    def gaoGetFfcZeroMeanState(self):
        '''Usage: returnCode, data = GetFfcZeroMeanState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetFfcZeroMeanState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcZeroMeanState()


    @exception_wrapper
    def gaoSetRnsPopThreshold(self, threshold):
        '''Usage: returnCode = SetRnsPopThreshold(self, threshold)
            Input_01 threshold <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsPopThreshold(threshold)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsPopThreshold()


    @exception_wrapper
    def gaoGetRnsPopThreshold(self):
        '''Usage: returnCode, threshold = GetRnsPopThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 threshold <class 'int'> <<UINT_16>>
        '''
        returnCode, threshold = self.CLIENT_pkg_gao_GetRnsPopThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, threshold)
    # End of GetRnsPopThreshold()


    @exception_wrapper
    def gaoSetRnsCloseThreshold(self, threshold):
        '''Usage: returnCode = SetRnsCloseThreshold(self, threshold)
            Input_01 threshold <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsCloseThreshold(threshold)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsCloseThreshold()


    @exception_wrapper
    def gaoGetRnsCloseThreshold(self):
        '''Usage: returnCode, threshold = GetRnsCloseThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 threshold <class 'int'> <<UINT_16>>
        '''
        returnCode, threshold = self.CLIENT_pkg_gao_GetRnsCloseThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, threshold)
    # End of GetRnsCloseThreshold()


    @exception_wrapper
    def gaoSetRnsTooFewQuit(self, data):
        '''Usage: returnCode = SetRnsTooFewQuit(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsTooFewQuit(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsTooFewQuit()


    @exception_wrapper
    def gaoGetRnsTooFewQuit(self):
        '''Usage: returnCode, data = GetRnsTooFewQuit(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsTooFewQuit()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsTooFewQuit()


    @exception_wrapper
    def gaoSetRnsTooFew(self, data):
        '''Usage: returnCode = SetRnsTooFew(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsTooFew(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsTooFew()


    @exception_wrapper
    def gaoGetRnsTooFew(self):
        '''Usage: returnCode, data = GetRnsTooFew(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsTooFew()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsTooFew()


    @exception_wrapper
    def gaoSetRnsMinCorrection(self, data):
        '''Usage: returnCode = SetRnsMinCorrection(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsMinCorrection(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsMinCorrection()


    @exception_wrapper
    def gaoGetRnsMinCorrection(self):
        '''Usage: returnCode, data = GetRnsMinCorrection(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsMinCorrection()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsMinCorrection()


    @exception_wrapper
    def gaoSetRnsDamping(self, data):
        '''Usage: returnCode = SetRnsDamping(self, data)
            Input_01 data <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsDamping(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsDamping()


    @exception_wrapper
    def gaoGetRnsDamping(self):
        '''Usage: returnCode, data = GetRnsDamping(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UCHAR>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsDamping()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsDamping()


    @exception_wrapper
    def gaoSetRnsFrameHysteresis(self, data):
        '''Usage: returnCode = SetRnsFrameHysteresis(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsFrameHysteresis(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsFrameHysteresis()


    @exception_wrapper
    def gaoGetRnsFrameHysteresis(self):
        '''Usage: returnCode, data = GetRnsFrameHysteresis(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsFrameHysteresis()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsFrameHysteresis()


    @exception_wrapper
    def gaoSetRnsBadDamping(self, data):
        '''Usage: returnCode = SetRnsBadDamping(self, data)
            Input_01 data <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsBadDamping(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsBadDamping()


    @exception_wrapper
    def gaoGetRnsBadDamping(self):
        '''Usage: returnCode, data = GetRnsBadDamping(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UCHAR>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsBadDamping()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsBadDamping()


    @exception_wrapper
    def gaoSetRnsNumGoodDampingThreshold(self, data):
        '''Usage: returnCode = SetRnsNumGoodDampingThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsNumGoodDampingThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsNumGoodDampingThreshold()


    @exception_wrapper
    def gaoGetRnsNumGoodDampingThreshold(self):
        '''Usage: returnCode, data = GetRnsNumGoodDampingThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsNumGoodDampingThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsNumGoodDampingThreshold()


    @exception_wrapper
    def gaoGetRnsFfcDesired(self):
        '''Usage: returnCode, data = GetRnsFfcDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetRnsFfcDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRnsFfcDesired()


    @exception_wrapper
    def gaoGetAveragerDesiredState(self):
        '''Usage: returnCode, data = GetAveragerDesiredState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetAveragerDesiredState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAveragerDesiredState()


    @exception_wrapper
    def gaoSetRnsThDamp(self, thDamp):
        '''Usage: returnCode = SetRnsThDamp(self, thDamp)
            Input_01 thDamp <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsThDamp(thDamp)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsThDamp()


    @exception_wrapper
    def gaoGetRnsThDamp(self):
        '''Usage: returnCode, thDamp = GetRnsThDamp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 thDamp <class 'int'> <<UINT_16>>
        '''
        returnCode, thDamp = self.CLIENT_pkg_gao_GetRnsThDamp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, thDamp)
    # End of GetRnsThDamp()


    @exception_wrapper
    def gaoSetRnsThException(self, thException):
        '''Usage: returnCode = SetRnsThException(self, thException)
            Input_01 thException <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsThException(thException)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsThException()


    @exception_wrapper
    def gaoGetRnsThException(self):
        '''Usage: returnCode, thException = GetRnsThException(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 thException <class 'int'> <<UINT_16>>
        '''
        returnCode, thException = self.CLIENT_pkg_gao_GetRnsThException()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, thException)
    # End of GetRnsThException()


    @exception_wrapper
    def gaoSetRnsThBad(self, thBad):
        '''Usage: returnCode = SetRnsThBad(self, thBad)
            Input_01 thBad <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsThBad(thBad)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsThBad()


    @exception_wrapper
    def gaoGetRnsThBad(self):
        '''Usage: returnCode, thBad = GetRnsThBad(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 thBad <class 'int'> <<UINT_16>>
        '''
        returnCode, thBad = self.CLIENT_pkg_gao_GetRnsThBad()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, thBad)
    # End of GetRnsThBad()


    @exception_wrapper
    def gaoSetRnsThBadInitial(self, thBadInitial):
        '''Usage: returnCode = SetRnsThBadInitial(self, thBadInitial)
            Input_01 thBadInitial <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsThBadInitial(thBadInitial)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsThBadInitial()


    @exception_wrapper
    def gaoGetRnsThBadInitial(self):
        '''Usage: returnCode, thBadInitial = GetRnsThBadInitial(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 thBadInitial <class 'int'> <<UINT_16>>
        '''
        returnCode, thBadInitial = self.CLIENT_pkg_gao_GetRnsThBadInitial()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, thBadInitial)
    # End of GetRnsThBadInitial()


    @exception_wrapper
    def gaoSetRnsThAllowedExceptions(self, thAllowedExceptions):
        '''Usage: returnCode = SetRnsThAllowedExceptions(self, thAllowedExceptions)
            Input_01 thAllowedExceptions <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetRnsThAllowedExceptions(thAllowedExceptions)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRnsThAllowedExceptions()


    @exception_wrapper
    def gaoGetRnsThAllowedExceptions(self):
        '''Usage: returnCode, thAllowedExceptions = GetRnsThAllowedExceptions(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 thAllowedExceptions <class 'int'> <<UINT_16>>
        '''
        returnCode, thAllowedExceptions = self.CLIENT_pkg_gao_GetRnsThAllowedExceptions()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, thAllowedExceptions)
    # End of GetRnsThAllowedExceptions()


    @exception_wrapper
    def gaoGetRnsFramesExceptionLimitReached(self):
        '''Usage: returnCode, framesReached = GetRnsFramesExceptionLimitReached(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 framesReached <class 'int'> <<UINT_32>>
        '''
        returnCode, framesReached = self.CLIENT_pkg_gao_GetRnsFramesExceptionLimitReached()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, framesReached)
    # End of GetRnsFramesExceptionLimitReached()


    @exception_wrapper
    def gaoGetAppliedClip(self):
        '''Usage: returnCode, data = GetAppliedClip(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetAppliedClip()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAppliedClip()


    @exception_wrapper
    def gaoSetAppliedClipEnable(self, data):
        '''Usage: returnCode = SetAppliedClipEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_gao_SetAppliedClipEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetAppliedClipEnable()


    @exception_wrapper
    def gaoGetAppliedClipEnable(self):
        '''Usage: returnCode, data = GetAppliedClipEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_gao_GetAppliedClipEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAppliedClipEnable()


    @exception_wrapper
    def imageStatsGetTotalHistPixelsInROI(self):
        '''Usage: returnCode, totalPixelsInROI = GetTotalHistPixelsInROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 totalPixelsInROI <class 'int'> <<UINT_32>>
        '''
        returnCode, totalPixelsInROI = self.CLIENT_pkg_imageStats_GetTotalHistPixelsInROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, totalPixelsInROI)
    # End of GetTotalHistPixelsInROI()


    @exception_wrapper
    def imageStatsGetPopBelowLowToHighThresh(self):
        '''Usage: returnCode, popBelowLowToHighThresh = GetPopBelowLowToHighThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 popBelowLowToHighThresh <class 'int'> <<UINT_32>>
        '''
        returnCode, popBelowLowToHighThresh = self.CLIENT_pkg_imageStats_GetPopBelowLowToHighThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, popBelowLowToHighThresh)
    # End of GetPopBelowLowToHighThresh()


    @exception_wrapper
    def imageStatsGetPopAboveHighToLowThresh(self):
        '''Usage: returnCode, popAboveHighToLowThresh = GetPopAboveHighToLowThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 popAboveHighToLowThresh <class 'int'> <<UINT_32>>
        '''
        returnCode, popAboveHighToLowThresh = self.CLIENT_pkg_imageStats_GetPopAboveHighToLowThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, popAboveHighToLowThresh)
    # End of GetPopAboveHighToLowThresh()


    @exception_wrapper
    def imageStatsSetROI(self, roi):
        '''Usage: returnCode = SetROI(self, roi)
            Input_01 roi FLR_ROI_T <<FLR_ROI_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_imageStats_SetROI(roi)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetROI()


    @exception_wrapper
    def imageStatsGetROI(self):
        '''Usage: returnCode, roi = GetROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 roi FLR_ROI_T <<FLR_ROI_T>>
        '''
        returnCode, roi = self.CLIENT_pkg_imageStats_GetROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, roi)
    # End of GetROI()


    @exception_wrapper
    def imageStatsGetFirstBin(self):
        '''Usage: returnCode, firstBin = GetFirstBin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 firstBin <class 'int'> <<UINT_16>>
        '''
        returnCode, firstBin = self.CLIENT_pkg_imageStats_GetFirstBin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, firstBin)
    # End of GetFirstBin()


    @exception_wrapper
    def imageStatsGetLastBin(self):
        '''Usage: returnCode, lastBin = GetLastBin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 lastBin <class 'int'> <<UINT_16>>
        '''
        returnCode, lastBin = self.CLIENT_pkg_imageStats_GetLastBin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, lastBin)
    # End of GetLastBin()


    @exception_wrapper
    def imageStatsGetMean(self):
        '''Usage: returnCode, mean = GetMean(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mean <class 'int'> <<UINT_16>>
        '''
        returnCode, mean = self.CLIENT_pkg_imageStats_GetMean()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, mean)
    # End of GetMean()


    @exception_wrapper
    def imageStatsGetFirstBinInROI(self):
        '''Usage: returnCode, firstBinInROI = GetFirstBinInROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 firstBinInROI <class 'int'> <<UINT_16>>
        '''
        returnCode, firstBinInROI = self.CLIENT_pkg_imageStats_GetFirstBinInROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, firstBinInROI)
    # End of GetFirstBinInROI()


    @exception_wrapper
    def imageStatsGetLastBinInROI(self):
        '''Usage: returnCode, lastBinInROI = GetLastBinInROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 lastBinInROI <class 'int'> <<UINT_16>>
        '''
        returnCode, lastBinInROI = self.CLIENT_pkg_imageStats_GetLastBinInROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, lastBinInROI)
    # End of GetLastBinInROI()


    @exception_wrapper
    def imageStatsGetMeanInROI(self):
        '''Usage: returnCode, meanInROI = GetMeanInROI(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 meanInROI <class 'int'> <<UINT_16>>
        '''
        returnCode, meanInROI = self.CLIENT_pkg_imageStats_GetMeanInROI()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, meanInROI)
    # End of GetMeanInROI()


    @exception_wrapper
    def imageStatsGetImageStats(self):
        '''Usage: returnCode, meanIntensity, peakIntensity, baseIntensity = GetImageStats(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 meanIntensity <class 'int'> <<UINT_16>>
            Output_02 peakIntensity <class 'int'> <<UINT_16>>
            Output_03 baseIntensity <class 'int'> <<UINT_16>>
        '''
        returnCode, meanIntensity, peakIntensity, baseIntensity = self.CLIENT_pkg_imageStats_GetImageStats()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, meanIntensity, peakIntensity, baseIntensity)
    # End of GetImageStats()


    @exception_wrapper
    def isothermGetEnable(self):
        '''Usage: returnCode, isothermEnable = GetEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 isothermEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, isothermEnable = self.CLIENT_pkg_isotherm_GetEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, isothermEnable)
    # End of GetEnable()


    @exception_wrapper
    def isothermSetEnable(self, isothermEnable):
        '''Usage: returnCode = SetEnable(self, isothermEnable)
            Input_01 isothermEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetEnable(isothermEnable)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnable()


    @exception_wrapper
    def isothermSetTemps(self, table, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5):
        '''Usage: returnCode = SetTemps(self, table, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Input_02 thIsoT1 <class 'int'> <<INT_32>>
            Input_03 thIsoT2 <class 'int'> <<INT_32>>
            Input_04 thIsoT3 <class 'int'> <<INT_32>>
            Input_05 thIsoT4 <class 'int'> <<INT_32>>
            Input_06 thIsoT5 <class 'int'> <<INT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetTemps(table, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTemps()


    @exception_wrapper
    def isothermGetTemps(self, table):
        '''Usage: returnCode, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5 = GetTemps(self, table)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 thIsoT1 <class 'int'> <<INT_32>>
            Output_02 thIsoT2 <class 'int'> <<INT_32>>
            Output_03 thIsoT3 <class 'int'> <<INT_32>>
            Output_04 thIsoT4 <class 'int'> <<INT_32>>
            Output_05 thIsoT5 <class 'int'> <<INT_32>>
        '''
        returnCode, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5 = self.CLIENT_pkg_isotherm_GetTemps(table)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None)
        
        return ( returnCode, thIsoT1, thIsoT2, thIsoT3, thIsoT4, thIsoT5)
    # End of GetTemps()


    @exception_wrapper
    def isothermSetIsoColorValues(self, table, region0, region1, region2, region3, region4, region5):
        '''Usage: returnCode = SetIsoColorValues(self, table, region0, region1, region2, region3, region4, region5)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Input_02 region0 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Input_03 region1 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Input_04 region2 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Input_05 region3 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Input_06 region4 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Input_07 region5 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetIsoColorValues(table, region0, region1, region2, region3, region4, region5)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIsoColorValues()


    @exception_wrapper
    def isothermGetIsoColorValues(self, table):
        '''Usage: returnCode, region0, region1, region2, region3, region4, region5 = GetIsoColorValues(self, table)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 region0 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_02 region1 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_03 region2 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_04 region3 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_05 region4 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
            Output_06 region5 FLR_ISOTHERM_COLORS_T <<FLR_ISOTHERM_COLORS_T>>
        '''
        returnCode, region0, region1, region2, region3, region4, region5 = self.CLIENT_pkg_isotherm_GetIsoColorValues(table)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None, None)
        
        return ( returnCode, region0, region1, region2, region3, region4, region5)
    # End of GetIsoColorValues()


    @exception_wrapper
    def isothermSetRegionMode(self, table, region0, region1, region2, region3, region4, region5):
        '''Usage: returnCode = SetRegionMode(self, table, region0, region1, region2, region3, region4, region5)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Input_02 region0 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Input_03 region1 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Input_04 region2 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Input_05 region3 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Input_06 region4 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Input_07 region5 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetRegionMode(table, region0, region1, region2, region3, region4, region5)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRegionMode()


    @exception_wrapper
    def isothermGetRegionMode(self, table):
        '''Usage: returnCode, region0, region1, region2, region3, region4, region5 = GetRegionMode(self, table)
            Input_01 table FLR_ISOTHERM_GAIN_E <<FLR_ISOTHERM_GAIN_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 region0 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_02 region1 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_03 region2 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_04 region3 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_05 region4 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
            Output_06 region5 FLR_ISOTHERM_REGION_E <<FLR_ISOTHERM_REGION_E>>
        '''
        returnCode, region0, region1, region2, region3, region4, region5 = self.CLIENT_pkg_isotherm_GetRegionMode(table)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None, None, None)
        
        return ( returnCode, region0, region1, region2, region3, region4, region5)
    # End of GetRegionMode()


    @exception_wrapper
    def isothermGetUnit(self):
        '''Usage: returnCode, unit = GetUnit(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 unit FLR_ISOTHERM_UNIT_E <<FLR_ISOTHERM_UNIT_E>>
        '''
        returnCode, unit = self.CLIENT_pkg_isotherm_GetUnit()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, unit)
    # End of GetUnit()


    @exception_wrapper
    def isothermSetUnit(self, unit):
        '''Usage: returnCode = SetUnit(self, unit)
            Input_01 unit FLR_ISOTHERM_UNIT_E <<FLR_ISOTHERM_UNIT_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetUnit(unit)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetUnit()


    @exception_wrapper
    def isothermGetSettingsLowGain(self):
        '''Usage: returnCode, settings = GetSettingsLowGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 settings FLR_ISOTHERM_SETTINGS_T <<FLR_ISOTHERM_SETTINGS_T>>
        '''
        returnCode, settings = self.CLIENT_pkg_isotherm_GetSettingsLowGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, settings)
    # End of GetSettingsLowGain()


    @exception_wrapper
    def isothermSetSettingsLowGain(self, settings):
        '''Usage: returnCode = SetSettingsLowGain(self, settings)
            Input_01 settings FLR_ISOTHERM_SETTINGS_T <<FLR_ISOTHERM_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetSettingsLowGain(settings)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSettingsLowGain()


    @exception_wrapper
    def isothermGetSettingsHighGain(self):
        '''Usage: returnCode, settings = GetSettingsHighGain(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 settings FLR_ISOTHERM_SETTINGS_T <<FLR_ISOTHERM_SETTINGS_T>>
        '''
        returnCode, settings = self.CLIENT_pkg_isotherm_GetSettingsHighGain()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, settings)
    # End of GetSettingsHighGain()


    @exception_wrapper
    def isothermSetSettingsHighGain(self, settings):
        '''Usage: returnCode = SetSettingsHighGain(self, settings)
            Input_01 settings FLR_ISOTHERM_SETTINGS_T <<FLR_ISOTHERM_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetSettingsHighGain(settings)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSettingsHighGain()


    @exception_wrapper
    def isothermSetColorLutId(self, colorLutIdLowGain, colorLutIdHighGain):
        '''Usage: returnCode = SetColorLutId(self, colorLutIdLowGain, colorLutIdHighGain)
            Input_01 colorLutIdLowGain FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
            Input_02 colorLutIdHighGain FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_isotherm_SetColorLutId(colorLutIdLowGain, colorLutIdHighGain)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetColorLutId()


    @exception_wrapper
    def isothermGetColorLutId(self):
        '''Usage: returnCode, colorLutIdLowGain, colorLutIdHighGain = GetColorLutId(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 colorLutIdLowGain FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
            Output_02 colorLutIdHighGain FLR_COLORLUT_ID_E <<FLR_COLORLUT_ID_E>>
        '''
        returnCode, colorLutIdLowGain, colorLutIdHighGain = self.CLIENT_pkg_isotherm_GetColorLutId()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, colorLutIdLowGain, colorLutIdHighGain)
    # End of GetColorLutId()


    @exception_wrapper
    def jffs2Mount(self):
        '''Usage: returnCode = Mount(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_jffs2_Mount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Mount()


    @exception_wrapper
    def jffs2Unmount(self):
        '''Usage: returnCode = Unmount(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_jffs2_Unmount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Unmount()


    @exception_wrapper
    def jffs2GetState(self):
        '''Usage: returnCode, state = GetState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 state FLR_JFFS2_STATE_E <<FLR_JFFS2_STATE_E>>
        '''
        returnCode, state = self.CLIENT_pkg_jffs2_GetState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, state)
    # End of GetState()


    @exception_wrapper
    def lfsrSetApplyOffsetEnableState(self, data):
        '''Usage: returnCode = SetApplyOffsetEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetApplyOffsetEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetApplyOffsetEnableState()


    @exception_wrapper
    def lfsrGetApplyOffsetEnableState(self):
        '''Usage: returnCode, data = GetApplyOffsetEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetApplyOffsetEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetApplyOffsetEnableState()


    @exception_wrapper
    def lfsrSetMaxIterations(self, data):
        '''Usage: returnCode = SetMaxIterations(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetMaxIterations(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxIterations()


    @exception_wrapper
    def lfsrGetMaxIterations(self):
        '''Usage: returnCode, data = GetMaxIterations(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetMaxIterations()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxIterations()


    @exception_wrapper
    def lfsrSetDf(self, data):
        '''Usage: returnCode = SetDf(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetDf(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDf()


    @exception_wrapper
    def lfsrGetDf(self):
        '''Usage: returnCode, data = GetDf(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetDf()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDf()


    @exception_wrapper
    def lfsrSetLambda1(self, data):
        '''Usage: returnCode = SetLambda1(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetLambda1(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLambda1()


    @exception_wrapper
    def lfsrGetLambda1(self):
        '''Usage: returnCode, data = GetLambda1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetLambda1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetLambda1()


    @exception_wrapper
    def lfsrSetLambda2(self, data):
        '''Usage: returnCode = SetLambda2(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetLambda2(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLambda2()


    @exception_wrapper
    def lfsrGetLambda2(self):
        '''Usage: returnCode, data = GetLambda2(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetLambda2()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetLambda2()


    @exception_wrapper
    def lfsrSetHaltEnable(self, data):
        '''Usage: returnCode = SetHaltEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetHaltEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetHaltEnable()


    @exception_wrapper
    def lfsrGetHaltEnable(self):
        '''Usage: returnCode, data = GetHaltEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetHaltEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetHaltEnable()


    @exception_wrapper
    def lfsrSetRandomMethod(self, data):
        '''Usage: returnCode = SetRandomMethod(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetRandomMethod(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRandomMethod()


    @exception_wrapper
    def lfsrGetRandomMethod(self):
        '''Usage: returnCode, data = GetRandomMethod(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetRandomMethod()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRandomMethod()


    @exception_wrapper
    def lfsrSetSingleStepEnable(self, data):
        '''Usage: returnCode = SetSingleStepEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetSingleStepEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSingleStepEnable()


    @exception_wrapper
    def lfsrGetSingleStepEnable(self):
        '''Usage: returnCode, data = GetSingleStepEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetSingleStepEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSingleStepEnable()


    @exception_wrapper
    def lfsrSetR_LocalBump(self, data):
        '''Usage: returnCode = SetR_LocalBump(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetR_LocalBump(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetR_LocalBump()


    @exception_wrapper
    def lfsrGetR_LocalBump(self):
        '''Usage: returnCode, data = GetR_LocalBump(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetR_LocalBump()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetR_LocalBump()


    @exception_wrapper
    def lfsrSetR_CornerBump(self, data):
        '''Usage: returnCode = SetR_CornerBump(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetR_CornerBump(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetR_CornerBump()


    @exception_wrapper
    def lfsrGetR_CornerBump(self):
        '''Usage: returnCode, data = GetR_CornerBump(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetR_CornerBump()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetR_CornerBump()


    @exception_wrapper
    def lfsrSetFFC_ResetEnable(self, data):
        '''Usage: returnCode = SetFFC_ResetEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetFFC_ResetEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFFC_ResetEnable()


    @exception_wrapper
    def lfsrGetFFC_ResetEnable(self):
        '''Usage: returnCode, data = GetFFC_ResetEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetFFC_ResetEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFFC_ResetEnable()


    @exception_wrapper
    def lfsrSetNormalizeAtCenterSpotState(self, data):
        '''Usage: returnCode = SetNormalizeAtCenterSpotState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_lfsr_SetNormalizeAtCenterSpotState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNormalizeAtCenterSpotState()


    @exception_wrapper
    def lfsrGetNormalizeAtCenterSpotState(self):
        '''Usage: returnCode, data = GetNormalizeAtCenterSpotState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_lfsr_GetNormalizeAtCenterSpotState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetNormalizeAtCenterSpotState()


    @exception_wrapper
    def memReadCapture(self, bufferNum, offset, sizeInBytes):
        '''Usage: returnCode, data = ReadCapture(self, bufferNum, offset, sizeInBytes)
            Input_01 bufferNum <class 'int'> <<UCHAR>>
            Input_02 offset <class 'int'> <<UINT_32>>
            Input_03 sizeInBytes <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'bytearray'> <<BYTEARRAY>>
        '''
        if(sizeInBytes > MaxMemoryChunk):
            return FLR_RESULT.FLR_DATA_SIZE_ERROR, None
        returnCode, data = self.CLIENT_pkg_mem_ReadCapture(bufferNum, offset, sizeInBytes)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of ReadCapture()


    @exception_wrapper
    def memGetCaptureSize(self):
        '''Usage: returnCode, bytes, rows, columns = GetCaptureSize(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 bytes <class 'int'> <<UINT_32>>
            Output_02 rows <class 'int'> <<UINT_16>>
            Output_03 columns <class 'int'> <<UINT_16>>
        '''
        returnCode, bytes, rows, columns = self.CLIENT_pkg_mem_GetCaptureSize()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, bytes, rows, columns)
    # End of GetCaptureSize()


    @exception_wrapper
    def memWriteFlash(self, location, index, offset, sizeInBytes, data):
        '''Usage: returnCode = WriteFlash(self, location, index, offset, sizeInBytes, data)
            Input_01 location FLR_MEM_LOCATION_E <<FLR_MEM_LOCATION_E>>
            Input_02 index <class 'int'> <<UCHAR>>
            Input_03 offset <class 'int'> <<UINT_32>>
            Input_04 sizeInBytes <class 'int'> <<UINT_16>>
            Input_05 data <class 'bytearray'> <<BYTEARRAY>>
            Output_00 returnCode <FLR_RESULT>
        '''
        if(sizeInBytes > MaxMemoryChunk):
            return FLR_RESULT.FLR_DATA_SIZE_ERROR
        returnCode = self.CLIENT_pkg_mem_WriteFlash(location, index, offset, sizeInBytes, data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of WriteFlash()


    @exception_wrapper
    def memReadFlash(self, location, index, offset, sizeInBytes):
        '''Usage: returnCode, data = ReadFlash(self, location, index, offset, sizeInBytes)
            Input_01 location FLR_MEM_LOCATION_E <<FLR_MEM_LOCATION_E>>
            Input_02 index <class 'int'> <<UCHAR>>
            Input_03 offset <class 'int'> <<UINT_32>>
            Input_04 sizeInBytes <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'bytearray'> <<BYTEARRAY>>
        '''
        if(sizeInBytes > MaxMemoryChunk):
            return FLR_RESULT.FLR_DATA_SIZE_ERROR, None
        returnCode, data = self.CLIENT_pkg_mem_ReadFlash(location, index, offset, sizeInBytes)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of ReadFlash()


    @exception_wrapper
    def memGetFlashSize(self, location):
        '''Usage: returnCode, bytes = GetFlashSize(self, location)
            Input_01 location FLR_MEM_LOCATION_E <<FLR_MEM_LOCATION_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 bytes <class 'int'> <<UINT_32>>
        '''
        returnCode, bytes = self.CLIENT_pkg_mem_GetFlashSize(location)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, bytes)
    # End of GetFlashSize()


    @exception_wrapper
    def memEraseFlash(self, location, index):
        '''Usage: returnCode = EraseFlash(self, location, index)
            Input_01 location FLR_MEM_LOCATION_E <<FLR_MEM_LOCATION_E>>
            Input_02 index <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_mem_EraseFlash(location, index)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of EraseFlash()


    @exception_wrapper
    def memEraseFlashPartial(self, location, index, offset, length):
        '''Usage: returnCode = EraseFlashPartial(self, location, index, offset, length)
            Input_01 location FLR_MEM_LOCATION_E <<FLR_MEM_LOCATION_E>>
            Input_02 index <class 'int'> <<UCHAR>>
            Input_03 offset <class 'int'> <<UINT_32>>
            Input_04 length <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_mem_EraseFlashPartial(location, index, offset, length)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of EraseFlashPartial()


    @exception_wrapper
    def memReadCurrentGain(self, offset, sizeInBytes):
        '''Usage: returnCode, data = ReadCurrentGain(self, offset, sizeInBytes)
            Input_01 offset <class 'int'> <<UINT_32>>
            Input_02 sizeInBytes <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'bytearray'> <<BYTEARRAY>>
        '''
        if(sizeInBytes > MaxMemoryChunk):
            return FLR_RESULT.FLR_DATA_SIZE_ERROR, None
        returnCode, data = self.CLIENT_pkg_mem_ReadCurrentGain(offset, sizeInBytes)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of ReadCurrentGain()


    @exception_wrapper
    def memGetGainSize(self):
        '''Usage: returnCode, bytes, rows, columns = GetGainSize(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 bytes <class 'int'> <<UINT_32>>
            Output_02 rows <class 'int'> <<UINT_16>>
            Output_03 columns <class 'int'> <<UINT_16>>
        '''
        returnCode, bytes, rows, columns = self.CLIENT_pkg_mem_GetGainSize()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, bytes, rows, columns)
    # End of GetGainSize()


    @exception_wrapper
    def memGetCaptureSizeSrc(self, src):
        '''Usage: returnCode, bytes, rows, columns = GetCaptureSizeSrc(self, src)
            Input_01 src FLR_CAPTURE_SRC_E <<FLR_CAPTURE_SRC_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 bytes <class 'int'> <<UINT_32>>
            Output_02 rows <class 'int'> <<UINT_16>>
            Output_03 columns <class 'int'> <<UINT_16>>
        '''
        returnCode, bytes, rows, columns = self.CLIENT_pkg_mem_GetCaptureSizeSrc(src)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, bytes, rows, columns)
    # End of GetCaptureSizeSrc()


    @exception_wrapper
    def memReadCaptureSrc(self, src, bufferNum, offset, sizeInBytes):
        '''Usage: returnCode, data = ReadCaptureSrc(self, src, bufferNum, offset, sizeInBytes)
            Input_01 src FLR_CAPTURE_SRC_E <<FLR_CAPTURE_SRC_E>>
            Input_02 bufferNum <class 'int'> <<UCHAR>>
            Input_03 offset <class 'int'> <<UINT_32>>
            Input_04 sizeInBytes <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'bytearray'> <<BYTEARRAY>>
        '''
        if(sizeInBytes > MaxMemoryChunk):
            return FLR_RESULT.FLR_DATA_SIZE_ERROR, None
        returnCode, data = self.CLIENT_pkg_mem_ReadCaptureSrc(src, bufferNum, offset, sizeInBytes)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of ReadCaptureSrc()


    @exception_wrapper
    def radiometrySetTempStableEnable(self, data):
        '''Usage: returnCode = SetTempStableEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempStableEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempStableEnable()


    @exception_wrapper
    def radiometryGetTempStableEnable(self):
        '''Usage: returnCode, data = GetTempStableEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempStableEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempStableEnable()


    @exception_wrapper
    def radiometrySetFNumberLens0(self, data):
        '''Usage: returnCode = SetFNumberLens0(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetFNumberLens0(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFNumberLens0()


    @exception_wrapper
    def radiometryGetFNumberLens0(self):
        '''Usage: returnCode, data = GetFNumberLens0(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetFNumberLens0()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFNumberLens0()


    @exception_wrapper
    def radiometrySetFNumberLens1(self, data):
        '''Usage: returnCode = SetFNumberLens1(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetFNumberLens1(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFNumberLens1()


    @exception_wrapper
    def radiometryGetFNumberLens1(self):
        '''Usage: returnCode, data = GetFNumberLens1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetFNumberLens1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFNumberLens1()


    @exception_wrapper
    def radiometrySetTauLens0(self, data):
        '''Usage: returnCode = SetTauLens0(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTauLens0(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTauLens0()


    @exception_wrapper
    def radiometryGetTauLens0(self):
        '''Usage: returnCode, data = GetTauLens0(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTauLens0()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTauLens0()


    @exception_wrapper
    def radiometrySetTauLens1(self, data):
        '''Usage: returnCode = SetTauLens1(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTauLens1(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTauLens1()


    @exception_wrapper
    def radiometryGetTauLens1(self):
        '''Usage: returnCode, data = GetTauLens1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTauLens1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTauLens1()


    @exception_wrapper
    def radiometryGetGlobalGainDesired(self):
        '''Usage: returnCode, data = GetGlobalGainDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalGainDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalGainDesired()


    @exception_wrapper
    def radiometryGetGlobalOffsetDesired(self):
        '''Usage: returnCode, data = GetGlobalOffsetDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalOffsetDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalOffsetDesired()


    @exception_wrapper
    def radiometryGetGlobalGainApplied(self):
        '''Usage: returnCode, data = GetGlobalGainApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalGainApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalGainApplied()


    @exception_wrapper
    def radiometryGetGlobalOffsetApplied(self):
        '''Usage: returnCode, data = GetGlobalOffsetApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalOffsetApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalOffsetApplied()


    @exception_wrapper
    def radiometrySetTComponentOverrideMode(self, data):
        '''Usage: returnCode = SetTComponentOverrideMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTComponentOverrideMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTComponentOverrideMode()


    @exception_wrapper
    def radiometryGetTComponentOverrideMode(self):
        '''Usage: returnCode, data = GetTComponentOverrideMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTComponentOverrideMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTComponentOverrideMode()


    @exception_wrapper
    def radiometrySetGlobalGainOverride(self, data):
        '''Usage: returnCode = SetGlobalGainOverride(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetGlobalGainOverride(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGlobalGainOverride()


    @exception_wrapper
    def radiometryGetGlobalGainOverride(self):
        '''Usage: returnCode, data = GetGlobalGainOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalGainOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalGainOverride()


    @exception_wrapper
    def radiometrySetGlobalOffsetOverride(self, data):
        '''Usage: returnCode = SetGlobalOffsetOverride(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetGlobalOffsetOverride(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGlobalOffsetOverride()


    @exception_wrapper
    def radiometryGetGlobalOffsetOverride(self):
        '''Usage: returnCode, data = GetGlobalOffsetOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalOffsetOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalOffsetOverride()


    @exception_wrapper
    def radiometrySetGlobalParamOverrideMode(self, data):
        '''Usage: returnCode = SetGlobalParamOverrideMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetGlobalParamOverrideMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGlobalParamOverrideMode()


    @exception_wrapper
    def radiometryGetGlobalParamOverrideMode(self):
        '''Usage: returnCode, data = GetGlobalParamOverrideMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGlobalParamOverrideMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGlobalParamOverrideMode()


    @exception_wrapper
    def radiometrySetRBFOHighGainDefault(self, data):
        '''Usage: returnCode = SetRBFOHighGainDefault(self, data)
            Input_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetRBFOHighGainDefault(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRBFOHighGainDefault()


    @exception_wrapper
    def radiometryGetRBFOHighGainDefault(self):
        '''Usage: returnCode, data = GetRBFOHighGainDefault(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRBFOHighGainDefault()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRBFOHighGainDefault()


    @exception_wrapper
    def radiometrySetRBFOLowGainDefault(self, data):
        '''Usage: returnCode = SetRBFOLowGainDefault(self, data)
            Input_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetRBFOLowGainDefault(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRBFOLowGainDefault()


    @exception_wrapper
    def radiometryGetRBFOLowGainDefault(self):
        '''Usage: returnCode, data = GetRBFOLowGainDefault(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRBFOLowGainDefault()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRBFOLowGainDefault()


    @exception_wrapper
    def radiometrySetRBFOHighGainFactory(self, data):
        '''Usage: returnCode = SetRBFOHighGainFactory(self, data)
            Input_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetRBFOHighGainFactory(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRBFOHighGainFactory()


    @exception_wrapper
    def radiometryGetRBFOHighGainFactory(self):
        '''Usage: returnCode, data = GetRBFOHighGainFactory(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRBFOHighGainFactory()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRBFOHighGainFactory()


    @exception_wrapper
    def radiometrySetRBFOLowGainFactory(self, data):
        '''Usage: returnCode = SetRBFOLowGainFactory(self, data)
            Input_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetRBFOLowGainFactory(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRBFOLowGainFactory()


    @exception_wrapper
    def radiometryGetRBFOLowGainFactory(self):
        '''Usage: returnCode, data = GetRBFOLowGainFactory(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_RBFO_PARAMS_T <<FLR_RADIOMETRY_RBFO_PARAMS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRBFOLowGainFactory()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRBFOLowGainFactory()


    @exception_wrapper
    def radiometrySetDampingFactor(self, data):
        '''Usage: returnCode = SetDampingFactor(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetDampingFactor(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDampingFactor()


    @exception_wrapper
    def radiometryGetDampingFactor(self):
        '''Usage: returnCode, data = GetDampingFactor(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetDampingFactor()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDampingFactor()


    @exception_wrapper
    def radiometryGetGoMEQ(self):
        '''Usage: returnCode, data = GetGoMEQ(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGoMEQ()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGoMEQ()


    @exception_wrapper
    def radiometryGetGoMShutter(self):
        '''Usage: returnCode, data = GetGoMShutter(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGoMShutter()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGoMShutter()


    @exception_wrapper
    def radiometryGetGoMLens(self):
        '''Usage: returnCode, data = GetGoMLens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGoMLens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGoMLens()


    @exception_wrapper
    def radiometryGetGoMLG(self):
        '''Usage: returnCode, data = GetGoMLG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGoMLG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGoMLG()


    @exception_wrapper
    def radiometryGetGoMFFC(self):
        '''Usage: returnCode, data = GetGoMFFC(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGoMFFC()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGoMFFC()


    @exception_wrapper
    def radiometryGetTempLensHousing(self):
        '''Usage: returnCode, data = GetTempLensHousing(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempLensHousing()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempLensHousing()


    @exception_wrapper
    def radiometryGetTempShutterHousing(self):
        '''Usage: returnCode, data = GetTempShutterHousing(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempShutterHousing()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempShutterHousing()


    @exception_wrapper
    def radiometryGetTempShutterPaddle(self):
        '''Usage: returnCode, data = GetTempShutterPaddle(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempShutterPaddle()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempShutterPaddle()


    @exception_wrapper
    def radiometrySetFNumberShutterHousing(self, data):
        '''Usage: returnCode = SetFNumberShutterHousing(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetFNumberShutterHousing(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFNumberShutterHousing()


    @exception_wrapper
    def radiometryGetFNumberShutterHousing(self):
        '''Usage: returnCode, data = GetFNumberShutterHousing(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetFNumberShutterHousing()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFNumberShutterHousing()


    @exception_wrapper
    def radiometrySetEmissivityShutterHousing(self, data):
        '''Usage: returnCode = SetEmissivityShutterHousing(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetEmissivityShutterHousing(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEmissivityShutterHousing()


    @exception_wrapper
    def radiometryGetEmissivityShutterHousing(self):
        '''Usage: returnCode, data = GetEmissivityShutterHousing(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetEmissivityShutterHousing()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEmissivityShutterHousing()


    @exception_wrapper
    def radiometrySetM_DTfpa_Lens(self, data):
        '''Usage: returnCode = SetM_DTfpa_Lens(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_DTfpa_Lens(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_DTfpa_Lens()


    @exception_wrapper
    def radiometryGetM_DTfpa_Lens(self):
        '''Usage: returnCode, data = GetM_DTfpa_Lens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_DTfpa_Lens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_DTfpa_Lens()


    @exception_wrapper
    def radiometrySetOffset_Lens(self, data):
        '''Usage: returnCode = SetOffset_Lens(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetOffset_Lens(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOffset_Lens()


    @exception_wrapper
    def radiometryGetOffset_Lens(self):
        '''Usage: returnCode, data = GetOffset_Lens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetOffset_Lens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOffset_Lens()


    @exception_wrapper
    def radiometrySetM_Recursive_Lens(self, data):
        '''Usage: returnCode = SetM_Recursive_Lens(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Recursive_Lens(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Recursive_Lens()


    @exception_wrapper
    def radiometryGetM_Recursive_Lens(self):
        '''Usage: returnCode, data = GetM_Recursive_Lens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Recursive_Lens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Recursive_Lens()


    @exception_wrapper
    def radiometryGetGgFfc(self):
        '''Usage: returnCode, data = GetGgFfc(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGgFfc()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGgFfc()


    @exception_wrapper
    def radiometryGetCountsFromTemp(self, rbfoType, temp):
        '''Usage: returnCode, counts = GetCountsFromTemp(self, rbfoType, temp)
            Input_01 rbfoType FLR_RADIOMETRY_RBFO_TYPE_E <<FLR_RADIOMETRY_RBFO_TYPE_E>>
            Input_02 temp <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 counts <class 'int'> <<UINT_16>>
        '''
        returnCode, counts = self.CLIENT_pkg_radiometry_GetCountsFromTemp(rbfoType, temp)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, counts)
    # End of GetCountsFromTemp()


    @exception_wrapper
    def radiometryGetTempFromCounts(self, rbfoType, counts):
        '''Usage: returnCode, temp = GetTempFromCounts(self, rbfoType, counts)
            Input_01 rbfoType FLR_RADIOMETRY_RBFO_TYPE_E <<FLR_RADIOMETRY_RBFO_TYPE_E>>
            Input_02 counts <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 temp <class 'float'> <<FLOAT>>
        '''
        returnCode, temp = self.CLIENT_pkg_radiometry_GetTempFromCounts(rbfoType, counts)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, temp)
    # End of GetTempFromCounts()


    @exception_wrapper
    def radiometrySetTempLensHousingOverride(self, data):
        '''Usage: returnCode = SetTempLensHousingOverride(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempLensHousingOverride(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempLensHousingOverride()


    @exception_wrapper
    def radiometryGetTempLensHousingOverride(self):
        '''Usage: returnCode, data = GetTempLensHousingOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempLensHousingOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempLensHousingOverride()


    @exception_wrapper
    def radiometrySetTempShutterHousingOverride(self, data):
        '''Usage: returnCode = SetTempShutterHousingOverride(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempShutterHousingOverride(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempShutterHousingOverride()


    @exception_wrapper
    def radiometryGetTempShutterHousingOverride(self):
        '''Usage: returnCode, data = GetTempShutterHousingOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempShutterHousingOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempShutterHousingOverride()


    @exception_wrapper
    def radiometrySetTempShutterPaddleOverride(self, data):
        '''Usage: returnCode = SetTempShutterPaddleOverride(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempShutterPaddleOverride(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempShutterPaddleOverride()


    @exception_wrapper
    def radiometryGetTempShutterPaddleOverride(self):
        '''Usage: returnCode, data = GetTempShutterPaddleOverride(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempShutterPaddleOverride()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempShutterPaddleOverride()


    @exception_wrapper
    def radiometrySetSignalFactorLut(self, data):
        '''Usage: returnCode = SetSignalFactorLut(self, data)
            Input_01 data FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T <<FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetSignalFactorLut(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSignalFactorLut()


    @exception_wrapper
    def radiometryGetSignalFactorLut(self):
        '''Usage: returnCode, data = GetSignalFactorLut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T <<FLR_RADIOMETRY_SIGNAL_COMP_FACTOR_LUT_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetSignalFactorLut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSignalFactorLut()


    @exception_wrapper
    def radiometrySetNoiseFactorLut(self, data):
        '''Usage: returnCode = SetNoiseFactorLut(self, data)
            Input_01 data FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T <<FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetNoiseFactorLut(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNoiseFactorLut()


    @exception_wrapper
    def radiometryGetNoiseFactorLut(self):
        '''Usage: returnCode, data = GetNoiseFactorLut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T <<FLR_RADIOMETRY_NOISE_COMP_FACTOR_LUT_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetNoiseFactorLut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetNoiseFactorLut()


    @exception_wrapper
    def radiometrySetM_tfpaK(self, data):
        '''Usage: returnCode = SetM_tfpaK(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_tfpaK(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_tfpaK()


    @exception_wrapper
    def radiometryGetM_tfpaK(self):
        '''Usage: returnCode, data = GetM_tfpaK(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_tfpaK()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_tfpaK()


    @exception_wrapper
    def radiometrySetB_tfpaK(self, data):
        '''Usage: returnCode = SetB_tfpaK(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_tfpaK(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_tfpaK()


    @exception_wrapper
    def radiometryGetB_tfpaK(self):
        '''Usage: returnCode, data = GetB_tfpaK(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_tfpaK()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_tfpaK()


    @exception_wrapper
    def radiometrySetTAuxParams(self, data):
        '''Usage: returnCode = SetTAuxParams(self, data)
            Input_01 data FLR_RADIOMETRY_TAUX_PARAMS_T <<FLR_RADIOMETRY_TAUX_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTAuxParams(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTAuxParams()


    @exception_wrapper
    def radiometryGetTAuxParams(self):
        '''Usage: returnCode, data = GetTAuxParams(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_TAUX_PARAMS_T <<FLR_RADIOMETRY_TAUX_PARAMS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTAuxParams()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTAuxParams()


    @exception_wrapper
    def radiometrySetM_tAux(self, data):
        '''Usage: returnCode = SetM_tAux(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_tAux(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_tAux()


    @exception_wrapper
    def radiometryGetM_tAux(self):
        '''Usage: returnCode, data = GetM_tAux(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_tAux()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_tAux()


    @exception_wrapper
    def radiometrySetB_tAux(self, data):
        '''Usage: returnCode = SetB_tAux(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_tAux(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_tAux()


    @exception_wrapper
    def radiometryGetB_tAux(self):
        '''Usage: returnCode, data = GetB_tAux(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_tAux()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_tAux()


    @exception_wrapper
    def radiometrySetTsource_FFC(self, data):
        '''Usage: returnCode = SetTsource_FFC(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTsource_FFC(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTsource_FFC()


    @exception_wrapper
    def radiometryGetTsource_FFC(self):
        '''Usage: returnCode, data = GetTsource_FFC(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTsource_FFC()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTsource_FFC()


    @exception_wrapper
    def radiometrySetM_DTfpa_Sh_h(self, data):
        '''Usage: returnCode = SetM_DTfpa_Sh_h(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_DTfpa_Sh_h(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_DTfpa_Sh_h()


    @exception_wrapper
    def radiometryGetM_DTfpa_Sh_h(self):
        '''Usage: returnCode, data = GetM_DTfpa_Sh_h(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_DTfpa_Sh_h()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_DTfpa_Sh_h()


    @exception_wrapper
    def radiometrySetOffset_Sh_h(self, data):
        '''Usage: returnCode = SetOffset_Sh_h(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetOffset_Sh_h(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOffset_Sh_h()


    @exception_wrapper
    def radiometryGetOffset_Sh_h(self):
        '''Usage: returnCode, data = GetOffset_Sh_h(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetOffset_Sh_h()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOffset_Sh_h()


    @exception_wrapper
    def radiometrySetM_Recursive_Sh_h(self, data):
        '''Usage: returnCode = SetM_Recursive_Sh_h(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Recursive_Sh_h(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Recursive_Sh_h()


    @exception_wrapper
    def radiometryGetM_Recursive_Sh_h(self):
        '''Usage: returnCode, data = GetM_Recursive_Sh_h(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Recursive_Sh_h()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Recursive_Sh_h()


    @exception_wrapper
    def radiometrySetM_DTfpa_Sh_p(self, data):
        '''Usage: returnCode = SetM_DTfpa_Sh_p(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_DTfpa_Sh_p(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_DTfpa_Sh_p()


    @exception_wrapper
    def radiometryGetM_DTfpa_Sh_p(self):
        '''Usage: returnCode, data = GetM_DTfpa_Sh_p(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_DTfpa_Sh_p()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_DTfpa_Sh_p()


    @exception_wrapper
    def radiometrySetOffset_Sh_p(self, data):
        '''Usage: returnCode = SetOffset_Sh_p(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetOffset_Sh_p(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOffset_Sh_p()


    @exception_wrapper
    def radiometryGetOffset_Sh_p(self):
        '''Usage: returnCode, data = GetOffset_Sh_p(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetOffset_Sh_p()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOffset_Sh_p()


    @exception_wrapper
    def radiometrySetM_Recursive_Sh_p(self, data):
        '''Usage: returnCode = SetM_Recursive_Sh_p(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Recursive_Sh_p(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Recursive_Sh_p()


    @exception_wrapper
    def radiometryGetM_Recursive_Sh_p(self):
        '''Usage: returnCode, data = GetM_Recursive_Sh_p(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Recursive_Sh_p()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Recursive_Sh_p()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_p(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_p(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_p(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_p()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_p(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_p(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_p()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_p()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_p(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_p(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_p(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_p()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_p(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_p(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_p()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_p()


    @exception_wrapper
    def radiometryGetDtTfpaK(self):
        '''Usage: returnCode, data = GetDtTfpaK(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetDtTfpaK()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDtTfpaK()


    @exception_wrapper
    def radiometryGetDtTfpaK_Damp(self):
        '''Usage: returnCode, data = GetDtTfpaK_Damp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetDtTfpaK_Damp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDtTfpaK_Damp()


    @exception_wrapper
    def radiometryGetTAuxK(self):
        '''Usage: returnCode, data = GetTAuxK(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTAuxK()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTAuxK()


    @exception_wrapper
    def radiometrySetExternalFfcUpdateMode(self, data):
        '''Usage: returnCode = SetExternalFfcUpdateMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetExternalFfcUpdateMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetExternalFfcUpdateMode()


    @exception_wrapper
    def radiometryGetExternalFfcUpdateMode(self):
        '''Usage: returnCode, data = GetExternalFfcUpdateMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetExternalFfcUpdateMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetExternalFfcUpdateMode()


    @exception_wrapper
    def radiometryGetGG_scale(self):
        '''Usage: returnCode, data = GetGG_scale(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGG_scale()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGG_scale()


    @exception_wrapper
    def radiometrySetTempWindow(self, data):
        '''Usage: returnCode = SetTempWindow(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempWindow(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempWindow()


    @exception_wrapper
    def radiometryGetTempWindow(self):
        '''Usage: returnCode, data = GetTempWindow(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempWindow()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempWindow()


    @exception_wrapper
    def radiometrySetTransmissionWindow(self, data):
        '''Usage: returnCode = SetTransmissionWindow(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTransmissionWindow(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTransmissionWindow()


    @exception_wrapper
    def radiometryGetTransmissionWindow(self):
        '''Usage: returnCode, data = GetTransmissionWindow(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTransmissionWindow()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTransmissionWindow()


    @exception_wrapper
    def radiometrySetReflectivityWindow(self, data):
        '''Usage: returnCode = SetReflectivityWindow(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetReflectivityWindow(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetReflectivityWindow()


    @exception_wrapper
    def radiometryGetReflectivityWindow(self):
        '''Usage: returnCode, data = GetReflectivityWindow(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetReflectivityWindow()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetReflectivityWindow()


    @exception_wrapper
    def radiometrySetTempWindowReflection(self, data):
        '''Usage: returnCode = SetTempWindowReflection(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempWindowReflection(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempWindowReflection()


    @exception_wrapper
    def radiometryGetTempWindowReflection(self):
        '''Usage: returnCode, data = GetTempWindowReflection(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempWindowReflection()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempWindowReflection()


    @exception_wrapper
    def radiometrySetTransmissionAtmosphere(self, data):
        '''Usage: returnCode = SetTransmissionAtmosphere(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTransmissionAtmosphere(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTransmissionAtmosphere()


    @exception_wrapper
    def radiometryGetTransmissionAtmosphere(self):
        '''Usage: returnCode, data = GetTransmissionAtmosphere(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTransmissionAtmosphere()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTransmissionAtmosphere()


    @exception_wrapper
    def radiometrySetTempAtmosphere(self, data):
        '''Usage: returnCode = SetTempAtmosphere(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempAtmosphere(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempAtmosphere()


    @exception_wrapper
    def radiometryGetTempAtmosphere(self):
        '''Usage: returnCode, data = GetTempAtmosphere(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempAtmosphere()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempAtmosphere()


    @exception_wrapper
    def radiometrySetEmissivityTarget(self, data):
        '''Usage: returnCode = SetEmissivityTarget(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetEmissivityTarget(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEmissivityTarget()


    @exception_wrapper
    def radiometryGetEmissivityTarget(self):
        '''Usage: returnCode, data = GetEmissivityTarget(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetEmissivityTarget()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEmissivityTarget()


    @exception_wrapper
    def radiometrySetTempBackground(self, data):
        '''Usage: returnCode = SetTempBackground(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTempBackground(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempBackground()


    @exception_wrapper
    def radiometryGetTempBackground(self):
        '''Usage: returnCode, data = GetTempBackground(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTempBackground()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempBackground()


    @exception_wrapper
    def radiometryGetRadiometryCapable(self):
        '''Usage: returnCode, data = GetRadiometryCapable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRadiometryCapable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRadiometryCapable()


    @exception_wrapper
    def radiometrySetdeltaTempDampingFactor(self, data):
        '''Usage: returnCode = SetdeltaTempDampingFactor(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetdeltaTempDampingFactor(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetdeltaTempDampingFactor()


    @exception_wrapper
    def radiometryGetdeltaTempDampingFactor(self):
        '''Usage: returnCode, data = GetdeltaTempDampingFactor(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetdeltaTempDampingFactor()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetdeltaTempDampingFactor()


    @exception_wrapper
    def radiometrySetdeltaTempIntervalTime(self, data):
        '''Usage: returnCode = SetdeltaTempIntervalTime(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetdeltaTempIntervalTime(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetdeltaTempIntervalTime()


    @exception_wrapper
    def radiometryGetdeltaTempIntervalTime(self):
        '''Usage: returnCode, data = GetdeltaTempIntervalTime(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetdeltaTempIntervalTime()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetdeltaTempIntervalTime()


    @exception_wrapper
    def radiometrySetdeltaTempMaxValue(self, data):
        '''Usage: returnCode = SetdeltaTempMaxValue(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetdeltaTempMaxValue(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetdeltaTempMaxValue()


    @exception_wrapper
    def radiometryGetdeltaTempMaxValue(self):
        '''Usage: returnCode, data = GetdeltaTempMaxValue(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetdeltaTempMaxValue()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetdeltaTempMaxValue()


    @exception_wrapper
    def radiometrySetdeltaTempMaxIncrement(self, data):
        '''Usage: returnCode = SetdeltaTempMaxIncrement(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetdeltaTempMaxIncrement(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetdeltaTempMaxIncrement()


    @exception_wrapper
    def radiometryGetdeltaTempMaxIncrement(self):
        '''Usage: returnCode, data = GetdeltaTempMaxIncrement(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetdeltaTempMaxIncrement()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetdeltaTempMaxIncrement()


    @exception_wrapper
    def radiometrySetdeltaTempDampingTime(self, data):
        '''Usage: returnCode = SetdeltaTempDampingTime(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetdeltaTempDampingTime(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetdeltaTempDampingTime()


    @exception_wrapper
    def radiometryGetdeltaTempDampingTime(self):
        '''Usage: returnCode, data = GetdeltaTempDampingTime(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetdeltaTempDampingTime()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetdeltaTempDampingTime()


    @exception_wrapper
    def radiometryGetResponsivityFpaTemp(self):
        '''Usage: returnCode, data = GetResponsivityFpaTemp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetResponsivityFpaTemp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetResponsivityFpaTemp()


    @exception_wrapper
    def radiometrySetM_Delta_Lens(self, data):
        '''Usage: returnCode = SetM_Delta_Lens(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Lens(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Lens()


    @exception_wrapper
    def radiometryGetM_Delta_Lens(self):
        '''Usage: returnCode, data = GetM_Delta_Lens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Lens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Lens()


    @exception_wrapper
    def radiometrySetB_Delta_Lens(self, data):
        '''Usage: returnCode = SetB_Delta_Lens(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Lens(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Lens()


    @exception_wrapper
    def radiometryGetB_Delta_Lens(self):
        '''Usage: returnCode, data = GetB_Delta_Lens(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Lens()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Lens()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_h(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_h(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_h(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_h()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_h(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_h(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_h()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_h()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_h(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_h(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_h(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_h()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_h(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_h(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_h()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_h()


    @exception_wrapper
    def radiometrySetGG_Scale_HG(self, data):
        '''Usage: returnCode = SetGG_Scale_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetGG_Scale_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGG_Scale_HG()


    @exception_wrapper
    def radiometryGetGG_Scale_HG(self):
        '''Usage: returnCode, data = GetGG_Scale_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGG_Scale_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGG_Scale_HG()


    @exception_wrapper
    def radiometrySetGG_Scale_LG(self, data):
        '''Usage: returnCode = SetGG_Scale_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetGG_Scale_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetGG_Scale_LG()


    @exception_wrapper
    def radiometryGetGG_Scale_LG(self):
        '''Usage: returnCode, data = GetGG_Scale_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGG_Scale_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGG_Scale_LG()


    @exception_wrapper
    def radiometrySetRbfoScaledMode(self, data):
        '''Usage: returnCode = SetRbfoScaledMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetRbfoScaledMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRbfoScaledMode()


    @exception_wrapper
    def radiometryGetRbfoScaledMode(self):
        '''Usage: returnCode, data = GetRbfoScaledMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetRbfoScaledMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetRbfoScaledMode()


    @exception_wrapper
    def radiometryGetUncertaintyFactor(self):
        '''Usage: returnCode, data = GetUncertaintyFactor(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E <<FLR_RADIOMETRY_UNCERTAINTY_FACTOR_E>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetUncertaintyFactor()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetUncertaintyFactor()


    @exception_wrapper
    def radiometryGetTRoomMinThresh(self):
        '''Usage: returnCode, data = GetTRoomMinThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTRoomMinThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTRoomMinThresh()


    @exception_wrapper
    def radiometryGetTRoomMaxThresh(self):
        '''Usage: returnCode, data = GetTRoomMaxThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTRoomMaxThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTRoomMaxThresh()


    @exception_wrapper
    def radiometryGetTOperatingMinThresh(self):
        '''Usage: returnCode, data = GetTOperatingMinThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTOperatingMinThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTOperatingMinThresh()


    @exception_wrapper
    def radiometryGetTOperatingMaxThresh(self):
        '''Usage: returnCode, data = GetTOperatingMaxThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTOperatingMaxThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTOperatingMaxThresh()


    @exception_wrapper
    def radiometryGetStableTempThresh(self):
        '''Usage: returnCode, data = GetStableTempThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetStableTempThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetStableTempThresh()


    @exception_wrapper
    def radiometryGetSlowDriftThresh(self):
        '''Usage: returnCode, data = GetSlowDriftThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetSlowDriftThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSlowDriftThresh()


    @exception_wrapper
    def radiometryGetFfcTempThresh(self):
        '''Usage: returnCode, data = GetFfcTempThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetFfcTempThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFfcTempThresh()


    @exception_wrapper
    def radiometryGetTargetTempMinThreshLG(self):
        '''Usage: returnCode, data = GetTargetTempMinThreshLG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTargetTempMinThreshLG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTargetTempMinThreshLG()


    @exception_wrapper
    def radiometryGetTargetTempMaxThreshLG(self):
        '''Usage: returnCode, data = GetTargetTempMaxThreshLG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTargetTempMaxThreshLG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTargetTempMaxThreshLG()


    @exception_wrapper
    def radiometryGetMFactorThresh(self):
        '''Usage: returnCode, data = GetMFactorThresh(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetMFactorThresh()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMFactorThresh()


    @exception_wrapper
    def radiometryGetTargetTempMinThreshHG(self):
        '''Usage: returnCode, data = GetTargetTempMinThreshHG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTargetTempMinThreshHG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTargetTempMinThreshHG()


    @exception_wrapper
    def radiometryGetTargetTempMaxThreshHG(self):
        '''Usage: returnCode, data = GetTargetTempMaxThreshHG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTargetTempMaxThreshHG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTargetTempMaxThreshHG()


    @exception_wrapper
    def radiometryGetUncertaintyStatusBits(self):
        '''Usage: returnCode, data = GetUncertaintyStatusBits(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetUncertaintyStatusBits()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetUncertaintyStatusBits()


    @exception_wrapper
    def radiometrySetTemperatureOffset_HG(self, data):
        '''Usage: returnCode = SetTemperatureOffset_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTemperatureOffset_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTemperatureOffset_HG()


    @exception_wrapper
    def radiometryGetTemperatureOffset_HG(self):
        '''Usage: returnCode, data = GetTemperatureOffset_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTemperatureOffset_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTemperatureOffset_HG()


    @exception_wrapper
    def radiometrySetTemperatureOffset_LG(self, data):
        '''Usage: returnCode = SetTemperatureOffset_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetTemperatureOffset_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTemperatureOffset_LG()


    @exception_wrapper
    def radiometryGetTemperatureOffset_LG(self):
        '''Usage: returnCode, data = GetTemperatureOffset_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetTemperatureOffset_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTemperatureOffset_LG()


    @exception_wrapper
    def radiometrySetM_Delta_Lens_HG(self, data):
        '''Usage: returnCode = SetM_Delta_Lens_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Lens_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Lens_HG()


    @exception_wrapper
    def radiometryGetM_Delta_Lens_HG(self):
        '''Usage: returnCode, data = GetM_Delta_Lens_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Lens_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Lens_HG()


    @exception_wrapper
    def radiometrySetB_Delta_Lens_HG(self, data):
        '''Usage: returnCode = SetB_Delta_Lens_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Lens_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Lens_HG()


    @exception_wrapper
    def radiometryGetB_Delta_Lens_HG(self):
        '''Usage: returnCode, data = GetB_Delta_Lens_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Lens_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Lens_HG()


    @exception_wrapper
    def radiometrySetM_Delta_Lens_LG(self, data):
        '''Usage: returnCode = SetM_Delta_Lens_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Lens_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Lens_LG()


    @exception_wrapper
    def radiometryGetM_Delta_Lens_LG(self):
        '''Usage: returnCode, data = GetM_Delta_Lens_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Lens_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Lens_LG()


    @exception_wrapper
    def radiometrySetB_Delta_Lens_LG(self, data):
        '''Usage: returnCode = SetB_Delta_Lens_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Lens_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Lens_LG()


    @exception_wrapper
    def radiometryGetB_Delta_Lens_LG(self):
        '''Usage: returnCode, data = GetB_Delta_Lens_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Lens_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Lens_LG()


    @exception_wrapper
    def radiometrySetOffset_Lens_HG(self, data):
        '''Usage: returnCode = SetOffset_Lens_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetOffset_Lens_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOffset_Lens_HG()


    @exception_wrapper
    def radiometryGetOffset_Lens_HG(self):
        '''Usage: returnCode, data = GetOffset_Lens_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetOffset_Lens_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOffset_Lens_HG()


    @exception_wrapper
    def radiometrySetOffset_Lens_LG(self, data):
        '''Usage: returnCode = SetOffset_Lens_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetOffset_Lens_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOffset_Lens_LG()


    @exception_wrapper
    def radiometryGetOffset_Lens_LG(self):
        '''Usage: returnCode, data = GetOffset_Lens_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetOffset_Lens_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOffset_Lens_LG()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_p_HG(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_p_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_p_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_p_HG()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_p_HG(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_p_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_p_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_p_HG()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_p_HG(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_p_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_p_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_p_HG()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_p_HG(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_p_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_p_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_p_HG()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_p_LG(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_p_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_p_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_p_LG()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_p_LG(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_p_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_p_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_p_LG()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_p_LG(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_p_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_p_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_p_LG()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_p_LG(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_p_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_p_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_p_LG()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_h_HG(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_h_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_h_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_h_HG()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_h_HG(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_h_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_h_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_h_HG()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_h_HG(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_h_HG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_h_HG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_h_HG()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_h_HG(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_h_HG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_h_HG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_h_HG()


    @exception_wrapper
    def radiometrySetM_Delta_Sh_h_LG(self, data):
        '''Usage: returnCode = SetM_Delta_Sh_h_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetM_Delta_Sh_h_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_Delta_Sh_h_LG()


    @exception_wrapper
    def radiometryGetM_Delta_Sh_h_LG(self):
        '''Usage: returnCode, data = GetM_Delta_Sh_h_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetM_Delta_Sh_h_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_Delta_Sh_h_LG()


    @exception_wrapper
    def radiometrySetB_Delta_Sh_h_LG(self, data):
        '''Usage: returnCode = SetB_Delta_Sh_h_LG(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_radiometry_SetB_Delta_Sh_h_LG(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetB_Delta_Sh_h_LG()


    @exception_wrapper
    def radiometryGetB_Delta_Sh_h_LG(self):
        '''Usage: returnCode, data = GetB_Delta_Sh_h_LG(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetB_Delta_Sh_h_LG()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetB_Delta_Sh_h_LG()


    @exception_wrapper
    def radiometryGetGG_RoomTemp(self):
        '''Usage: returnCode, data = GetGG_RoomTemp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_radiometry_GetGG_RoomTemp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetGG_RoomTemp()


    @exception_wrapper
    def roicGetFPATemp(self):
        '''Usage: returnCode, data = GetFPATemp(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFPATemp()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFPATemp()


    @exception_wrapper
    def roicGetFrameCount(self):
        '''Usage: returnCode, data = GetFrameCount(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFrameCount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFrameCount()


    @exception_wrapper
    def roicGetActiveNormalizationTarget(self):
        '''Usage: returnCode, data = GetActiveNormalizationTarget(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetActiveNormalizationTarget()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetActiveNormalizationTarget()


    @exception_wrapper
    def roicSetFPARampState(self, state):
        '''Usage: returnCode = SetFPARampState(self, state)
            Input_01 state FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFPARampState(state)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFPARampState()


    @exception_wrapper
    def roicGetFPARampState(self):
        '''Usage: returnCode, state = GetFPARampState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 state FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, state = self.CLIENT_pkg_roic_GetFPARampState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, state)
    # End of GetFPARampState()


    @exception_wrapper
    def roicGetSensorADC1(self):
        '''Usage: returnCode, data = GetSensorADC1(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetSensorADC1()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSensorADC1()


    @exception_wrapper
    def roicGetSensorADC2(self):
        '''Usage: returnCode, data = GetSensorADC2(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetSensorADC2()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSensorADC2()


    @exception_wrapper
    def roicSetFPATempOffset(self, data):
        '''Usage: returnCode = SetFPATempOffset(self, data)
            Input_01 data <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFPATempOffset(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFPATempOffset()


    @exception_wrapper
    def roicGetFPATempOffset(self):
        '''Usage: returnCode, data = GetFPATempOffset(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<INT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFPATempOffset()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFPATempOffset()


    @exception_wrapper
    def roicSetFPATempMode(self, data):
        '''Usage: returnCode = SetFPATempMode(self, data)
            Input_01 data FLR_ROIC_TEMP_MODE_E <<FLR_ROIC_TEMP_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFPATempMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFPATempMode()


    @exception_wrapper
    def roicGetFPATempMode(self):
        '''Usage: returnCode, data = GetFPATempMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ROIC_TEMP_MODE_E <<FLR_ROIC_TEMP_MODE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFPATempMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFPATempMode()


    @exception_wrapper
    def roicGetFPATempTable(self):
        '''Usage: returnCode, table = GetFPATempTable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 table FLR_ROIC_FPATEMP_TABLE_T <<FLR_ROIC_FPATEMP_TABLE_T>>
        '''
        returnCode, table = self.CLIENT_pkg_roic_GetFPATempTable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, table)
    # End of GetFPATempTable()


    @exception_wrapper
    def roicSetFPATempValue(self, data):
        '''Usage: returnCode = SetFPATempValue(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFPATempValue(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFPATempValue()


    @exception_wrapper
    def roicGetFPATempValue(self):
        '''Usage: returnCode, data = GetFPATempValue(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFPATempValue()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFPATempValue()


    @exception_wrapper
    def roicGetPreambleError(self):
        '''Usage: returnCode, preambleError = GetPreambleError(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 preambleError <class 'int'> <<UINT_32>>
        '''
        returnCode, preambleError = self.CLIENT_pkg_roic_GetPreambleError()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, preambleError)
    # End of GetPreambleError()


    @exception_wrapper
    def roicInducePreambleError(self, everyNthFrame):
        '''Usage: returnCode = InducePreambleError(self, everyNthFrame)
            Input_01 everyNthFrame <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_InducePreambleError(everyNthFrame)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of InducePreambleError()


    @exception_wrapper
    def roicGetRoicStarted(self):
        '''Usage: returnCode, roicStarted = GetRoicStarted(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 roicStarted FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, roicStarted = self.CLIENT_pkg_roic_GetRoicStarted()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, roicStarted)
    # End of GetRoicStarted()


    @exception_wrapper
    def roicSetFrameSkip(self, data):
        '''Usage: returnCode = SetFrameSkip(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFrameSkip(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFrameSkip()


    @exception_wrapper
    def roicGetFrameSkip(self):
        '''Usage: returnCode, data = GetFrameSkip(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_roic_GetFrameSkip()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFrameSkip()


    @exception_wrapper
    def roicSetFrameOneShot(self):
        '''Usage: returnCode = SetFrameOneShot(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_roic_SetFrameOneShot()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFrameOneShot()


    @exception_wrapper
    def scalerGetMaxZoom(self):
        '''Usage: returnCode, zoom = GetMaxZoom(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 zoom <class 'int'> <<UINT_32>>
        '''
        returnCode, zoom = self.CLIENT_pkg_scaler_GetMaxZoom()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, zoom)
    # End of GetMaxZoom()


    @exception_wrapper
    def scalerSetZoom(self, zoomParams):
        '''Usage: returnCode = SetZoom(self, zoomParams)
            Input_01 zoomParams FLR_SCALER_ZOOM_PARAMS_T <<FLR_SCALER_ZOOM_PARAMS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scaler_SetZoom(zoomParams)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetZoom()


    @exception_wrapper
    def scalerGetZoom(self):
        '''Usage: returnCode, zoomParams = GetZoom(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 zoomParams FLR_SCALER_ZOOM_PARAMS_T <<FLR_SCALER_ZOOM_PARAMS_T>>
        '''
        returnCode, zoomParams = self.CLIENT_pkg_scaler_GetZoom()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, zoomParams)
    # End of GetZoom()


    @exception_wrapper
    def scalerSetFractionalZoom(self, zoomNumerator, zoomDenominator, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable):
        '''Usage: returnCode = SetFractionalZoom(self, zoomNumerator, zoomDenominator, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable)
            Input_01 zoomNumerator <class 'int'> <<UINT_32>>
            Input_02 zoomDenominator <class 'int'> <<UINT_32>>
            Input_03 zoomXCenter <class 'int'> <<UINT_32>>
            Input_04 zoomYCenter <class 'int'> <<UINT_32>>
            Input_05 inChangeEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
            Input_06 zoomOutXCenter <class 'int'> <<UINT_32>>
            Input_07 zoomOutYCenter <class 'int'> <<UINT_32>>
            Input_08 outChangeEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scaler_SetFractionalZoom(zoomNumerator, zoomDenominator, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFractionalZoom()


    @exception_wrapper
    def scalerSetIndexZoom(self, zoomIndex, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable):
        '''Usage: returnCode = SetIndexZoom(self, zoomIndex, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable)
            Input_01 zoomIndex <class 'int'> <<UINT_32>>
            Input_02 zoomXCenter <class 'int'> <<UINT_32>>
            Input_03 zoomYCenter <class 'int'> <<UINT_32>>
            Input_04 inChangeEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
            Input_05 zoomOutXCenter <class 'int'> <<UINT_32>>
            Input_06 zoomOutYCenter <class 'int'> <<UINT_32>>
            Input_07 outChangeEnable FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scaler_SetIndexZoom(zoomIndex, zoomXCenter, zoomYCenter, inChangeEnable, zoomOutXCenter, zoomOutYCenter, outChangeEnable)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIndexZoom()


    @exception_wrapper
    def scnrSetEnableState(self, data):
        '''Usage: returnCode = SetEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnableState()


    @exception_wrapper
    def scnrGetEnableState(self):
        '''Usage: returnCode, data = GetEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEnableState()


    @exception_wrapper
    def scnrSetThColSum(self, data):
        '''Usage: returnCode = SetThColSum(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetThColSum(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThColSum()


    @exception_wrapper
    def scnrGetThColSum(self):
        '''Usage: returnCode, data = GetThColSum(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetThColSum()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThColSum()


    @exception_wrapper
    def scnrSetThPixel(self, data):
        '''Usage: returnCode = SetThPixel(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetThPixel(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThPixel()


    @exception_wrapper
    def scnrGetThPixel(self):
        '''Usage: returnCode, data = GetThPixel(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetThPixel()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThPixel()


    @exception_wrapper
    def scnrSetMaxCorr(self, data):
        '''Usage: returnCode = SetMaxCorr(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetMaxCorr(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxCorr()


    @exception_wrapper
    def scnrGetMaxCorr(self):
        '''Usage: returnCode, data = GetMaxCorr(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetMaxCorr()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxCorr()


    @exception_wrapper
    def scnrGetThPixelApplied(self):
        '''Usage: returnCode, data = GetThPixelApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetThPixelApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThPixelApplied()


    @exception_wrapper
    def scnrGetMaxCorrApplied(self):
        '''Usage: returnCode, data = GetMaxCorrApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetMaxCorrApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxCorrApplied()


    @exception_wrapper
    def scnrSetThColSumSafe(self, data):
        '''Usage: returnCode = SetThColSumSafe(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetThColSumSafe(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThColSumSafe()


    @exception_wrapper
    def scnrGetThColSumSafe(self):
        '''Usage: returnCode, data = GetThColSumSafe(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetThColSumSafe()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThColSumSafe()


    @exception_wrapper
    def scnrSetThPixelSafe(self, data):
        '''Usage: returnCode = SetThPixelSafe(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetThPixelSafe(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThPixelSafe()


    @exception_wrapper
    def scnrGetThPixelSafe(self):
        '''Usage: returnCode, data = GetThPixelSafe(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetThPixelSafe()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThPixelSafe()


    @exception_wrapper
    def scnrSetMaxCorrSafe(self, data):
        '''Usage: returnCode = SetMaxCorrSafe(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetMaxCorrSafe(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxCorrSafe()


    @exception_wrapper
    def scnrGetMaxCorrSafe(self):
        '''Usage: returnCode, data = GetMaxCorrSafe(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetMaxCorrSafe()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxCorrSafe()


    @exception_wrapper
    def scnrSetCorrectionMethod(self, data):
        '''Usage: returnCode = SetCorrectionMethod(self, data)
            Input_01 data FLR_SCNR_CORR_SELECT_E <<FLR_SCNR_CORR_SELECT_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetCorrectionMethod(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetCorrectionMethod()


    @exception_wrapper
    def scnrGetCorrectionMethod(self):
        '''Usage: returnCode, data = GetCorrectionMethod(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SCNR_CORR_SELECT_E <<FLR_SCNR_CORR_SELECT_E>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetCorrectionMethod()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetCorrectionMethod()


    @exception_wrapper
    def scnrSetStdThreshold(self, data):
        '''Usage: returnCode = SetStdThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetStdThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetStdThreshold()


    @exception_wrapper
    def scnrGetStdThreshold(self):
        '''Usage: returnCode, data = GetStdThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetStdThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetStdThreshold()


    @exception_wrapper
    def scnrSetNFrames(self, data):
        '''Usage: returnCode = SetNFrames(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetNFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNFrames()


    @exception_wrapper
    def scnrGetNFrames(self):
        '''Usage: returnCode, data = GetNFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetNFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetNFrames()


    @exception_wrapper
    def scnrSetResetDesired(self, data):
        '''Usage: returnCode = SetResetDesired(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetResetDesired(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetResetDesired()


    @exception_wrapper
    def scnrGetResetDesired(self):
        '''Usage: returnCode, data = GetResetDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetResetDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetResetDesired()


    @exception_wrapper
    def scnrSetM_modeOnly(self, data):
        '''Usage: returnCode = SetM_modeOnly(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetM_modeOnly(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetM_modeOnly()


    @exception_wrapper
    def scnrGetM_modeOnly(self):
        '''Usage: returnCode, data = GetM_modeOnly(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetM_modeOnly()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetM_modeOnly()


    @exception_wrapper
    def scnrGetMode(self):
        '''Usage: returnCode, data = GetMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SCNR_MODE_E <<FLR_SCNR_MODE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMode()


    @exception_wrapper
    def scnrSetSpecklesEnableState(self, data):
        '''Usage: returnCode = SetSpecklesEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetSpecklesEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpecklesEnableState()


    @exception_wrapper
    def scnrGetSpecklesEnableState(self):
        '''Usage: returnCode, data = GetSpecklesEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesEnableState()


    @exception_wrapper
    def scnrSetSpecklesThreshold(self, data):
        '''Usage: returnCode = SetSpecklesThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetSpecklesThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpecklesThreshold()


    @exception_wrapper
    def scnrGetSpecklesThreshold(self):
        '''Usage: returnCode, data = GetSpecklesThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesThreshold()


    @exception_wrapper
    def scnrSetSpecklesRatio(self, data):
        '''Usage: returnCode = SetSpecklesRatio(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetSpecklesRatio(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpecklesRatio()


    @exception_wrapper
    def scnrGetSpecklesRatio(self):
        '''Usage: returnCode, data = GetSpecklesRatio(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesRatio()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesRatio()


    @exception_wrapper
    def scnrSetSpecklesDF(self, data):
        '''Usage: returnCode = SetSpecklesDF(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetSpecklesDF(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpecklesDF()


    @exception_wrapper
    def scnrGetSpecklesDF(self):
        '''Usage: returnCode, data = GetSpecklesDF(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesDF()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesDF()


    @exception_wrapper
    def scnrGetSpecklesDiffsBufferAddr(self):
        '''Usage: returnCode, data = GetSpecklesDiffsBufferAddr(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesDiffsBufferAddr()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesDiffsBufferAddr()


    @exception_wrapper
    def scnrGetSpecklesOffsBufferAddr(self):
        '''Usage: returnCode, data = GetSpecklesOffsBufferAddr(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesOffsBufferAddr()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesOffsBufferAddr()


    @exception_wrapper
    def scnrSetSpecklesResetDesired(self, data):
        '''Usage: returnCode = SetSpecklesResetDesired(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_scnr_SetSpecklesResetDesired(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpecklesResetDesired()


    @exception_wrapper
    def scnrGetSpecklesResetDesired(self):
        '''Usage: returnCode, data = GetSpecklesResetDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_scnr_GetSpecklesResetDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSpecklesResetDesired()


    @exception_wrapper
    def sffcGetScaleFactor(self):
        '''Usage: returnCode, data = GetScaleFactor(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetScaleFactor()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetScaleFactor()


    @exception_wrapper
    def sffcGetDeltaTempLinearCoeff(self):
        '''Usage: returnCode, data = GetDeltaTempLinearCoeff(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetDeltaTempLinearCoeff()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDeltaTempLinearCoeff()


    @exception_wrapper
    def sffcSetDeltaTempLinearCoeff(self, data):
        '''Usage: returnCode = SetDeltaTempLinearCoeff(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sffc_SetDeltaTempLinearCoeff(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDeltaTempLinearCoeff()


    @exception_wrapper
    def sffcGetDeltaTempOffsetCoeff(self):
        '''Usage: returnCode, data = GetDeltaTempOffsetCoeff(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetDeltaTempOffsetCoeff()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDeltaTempOffsetCoeff()


    @exception_wrapper
    def sffcSetDeltaTempOffsetCoeff(self, data):
        '''Usage: returnCode = SetDeltaTempOffsetCoeff(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sffc_SetDeltaTempOffsetCoeff(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDeltaTempOffsetCoeff()


    @exception_wrapper
    def sffcGetFpaTempLinearCoeff(self):
        '''Usage: returnCode, data = GetFpaTempLinearCoeff(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetFpaTempLinearCoeff()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFpaTempLinearCoeff()


    @exception_wrapper
    def sffcSetFpaTempLinearCoeff(self, data):
        '''Usage: returnCode = SetFpaTempLinearCoeff(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sffc_SetFpaTempLinearCoeff(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFpaTempLinearCoeff()


    @exception_wrapper
    def sffcGetFpaTempOffsetCoeff(self):
        '''Usage: returnCode, data = GetFpaTempOffsetCoeff(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetFpaTempOffsetCoeff()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFpaTempOffsetCoeff()


    @exception_wrapper
    def sffcSetFpaTempOffsetCoeff(self, data):
        '''Usage: returnCode = SetFpaTempOffsetCoeff(self, data)
            Input_01 data <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sffc_SetFpaTempOffsetCoeff(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFpaTempOffsetCoeff()


    @exception_wrapper
    def sffcGetDeltaTempTimeLimitInSecs(self):
        '''Usage: returnCode, data = GetDeltaTempTimeLimitInSecs(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_sffc_GetDeltaTempTimeLimitInSecs()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDeltaTempTimeLimitInSecs()


    @exception_wrapper
    def sffcSetDeltaTempTimeLimitInSecs(self, data):
        '''Usage: returnCode = SetDeltaTempTimeLimitInSecs(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sffc_SetDeltaTempTimeLimitInSecs(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDeltaTempTimeLimitInSecs()


    @exception_wrapper
    def splashScreenSetDuration(self, screen_num, periodMs):
        '''Usage: returnCode = SetDuration(self, screen_num, periodMs)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Input_02 periodMs <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_splashScreen_SetDuration(screen_num, periodMs)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDuration()


    @exception_wrapper
    def splashScreenSetDataType(self, screen_num, filetype):
        '''Usage: returnCode = SetDataType(self, screen_num, filetype)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Input_02 filetype FLR_SPLASHSCREEN_FILETYPE_E <<FLR_SPLASHSCREEN_FILETYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_splashScreen_SetDataType(screen_num, filetype)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDataType()


    @exception_wrapper
    def splashScreenSetBackground(self, screen_num, backgroundColor):
        '''Usage: returnCode = SetBackground(self, screen_num, backgroundColor)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Input_02 backgroundColor <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_splashScreen_SetBackground(screen_num, backgroundColor)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetBackground()


    @exception_wrapper
    def splashScreenGetDuration(self, screen_num):
        '''Usage: returnCode, periodMs = GetDuration(self, screen_num)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 periodMs <class 'int'> <<UINT_32>>
        '''
        returnCode, periodMs = self.CLIENT_pkg_splashScreen_GetDuration(screen_num)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, periodMs)
    # End of GetDuration()


    @exception_wrapper
    def splashScreenGetDataType(self, screen_num):
        '''Usage: returnCode, filetype = GetDataType(self, screen_num)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 filetype FLR_SPLASHSCREEN_FILETYPE_E <<FLR_SPLASHSCREEN_FILETYPE_E>>
        '''
        returnCode, filetype = self.CLIENT_pkg_splashScreen_GetDataType(screen_num)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, filetype)
    # End of GetDataType()


    @exception_wrapper
    def splashScreenGetBackground(self, screen_num):
        '''Usage: returnCode, backgroundColor = GetBackground(self, screen_num)
            Input_01 screen_num <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 backgroundColor <class 'int'> <<UINT_32>>
        '''
        returnCode, backgroundColor = self.CLIENT_pkg_splashScreen_GetBackground(screen_num)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, backgroundColor)
    # End of GetBackground()


    @exception_wrapper
    def spnrSetEnableState(self, data):
        '''Usage: returnCode = SetEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnableState()


    @exception_wrapper
    def spnrGetEnableState(self):
        '''Usage: returnCode, data = GetEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEnableState()


    @exception_wrapper
    def spnrGetState(self):
        '''Usage: returnCode, data = GetState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SPNR_STATE_E <<FLR_SPNR_STATE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetState()


    @exception_wrapper
    def spnrSetFrameDelay(self, data):
        '''Usage: returnCode = SetFrameDelay(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetFrameDelay(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFrameDelay()


    @exception_wrapper
    def spnrGetFrameDelay(self):
        '''Usage: returnCode, data = GetFrameDelay(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetFrameDelay()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFrameDelay()


    @exception_wrapper
    def spnrGetSFApplied(self):
        '''Usage: returnCode, sf = GetSFApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 sf <class 'float'> <<FLOAT>>
        '''
        returnCode, sf = self.CLIENT_pkg_spnr_GetSFApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, sf)
    # End of GetSFApplied()


    @exception_wrapper
    def spnrSetPSDKernel(self, data):
        '''Usage: returnCode = SetPSDKernel(self, data)
            Input_01 data FLR_SPNR_PSD_KERNEL_T <<FLR_SPNR_PSD_KERNEL_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetPSDKernel(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetPSDKernel()


    @exception_wrapper
    def spnrGetPSDKernel(self):
        '''Usage: returnCode, data = GetPSDKernel(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SPNR_PSD_KERNEL_T <<FLR_SPNR_PSD_KERNEL_T>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetPSDKernel()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetPSDKernel()


    @exception_wrapper
    def spnrSetSFMin(self, sfmin):
        '''Usage: returnCode = SetSFMin(self, sfmin)
            Input_01 sfmin <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetSFMin(sfmin)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSFMin()


    @exception_wrapper
    def spnrGetSFMin(self):
        '''Usage: returnCode, sfmin = GetSFMin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 sfmin <class 'float'> <<FLOAT>>
        '''
        returnCode, sfmin = self.CLIENT_pkg_spnr_GetSFMin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, sfmin)
    # End of GetSFMin()


    @exception_wrapper
    def spnrSetSFMax(self, sfmax):
        '''Usage: returnCode = SetSFMax(self, sfmax)
            Input_01 sfmax <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetSFMax(sfmax)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSFMax()


    @exception_wrapper
    def spnrGetSFMax(self):
        '''Usage: returnCode, sfmax = GetSFMax(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 sfmax <class 'float'> <<FLOAT>>
        '''
        returnCode, sfmax = self.CLIENT_pkg_spnr_GetSFMax()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, sfmax)
    # End of GetSFMax()


    @exception_wrapper
    def spnrSetDFMin(self, dfmin):
        '''Usage: returnCode = SetDFMin(self, dfmin)
            Input_01 dfmin <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetDFMin(dfmin)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDFMin()


    @exception_wrapper
    def spnrGetDFMin(self):
        '''Usage: returnCode, dfmin = GetDFMin(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 dfmin <class 'float'> <<FLOAT>>
        '''
        returnCode, dfmin = self.CLIENT_pkg_spnr_GetDFMin()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, dfmin)
    # End of GetDFMin()


    @exception_wrapper
    def spnrSetDFMax(self, dfmax):
        '''Usage: returnCode = SetDFMax(self, dfmax)
            Input_01 dfmax <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetDFMax(dfmax)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDFMax()


    @exception_wrapper
    def spnrGetDFMax(self):
        '''Usage: returnCode, dfmax = GetDFMax(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 dfmax <class 'float'> <<FLOAT>>
        '''
        returnCode, dfmax = self.CLIENT_pkg_spnr_GetDFMax()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, dfmax)
    # End of GetDFMax()


    @exception_wrapper
    def spnrSetNormTarget(self, normTarget):
        '''Usage: returnCode = SetNormTarget(self, normTarget)
            Input_01 normTarget <class 'float'> <<FLOAT>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetNormTarget(normTarget)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetNormTarget()


    @exception_wrapper
    def spnrGetNormTarget(self):
        '''Usage: returnCode, normTarget = GetNormTarget(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 normTarget <class 'float'> <<FLOAT>>
        '''
        returnCode, normTarget = self.CLIENT_pkg_spnr_GetNormTarget()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, normTarget)
    # End of GetNormTarget()


    @exception_wrapper
    def spnrGetNormTargetApplied(self):
        '''Usage: returnCode, normTargetApplied = GetNormTargetApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 normTargetApplied <class 'float'> <<FLOAT>>
        '''
        returnCode, normTargetApplied = self.CLIENT_pkg_spnr_GetNormTargetApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, normTargetApplied)
    # End of GetNormTargetApplied()


    @exception_wrapper
    def spnrSetThPix(self, th_pix):
        '''Usage: returnCode = SetThPix(self, th_pix)
            Input_01 th_pix <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetThPix(th_pix)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThPix()


    @exception_wrapper
    def spnrGetThPix(self):
        '''Usage: returnCode, th_pix = GetThPix(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 th_pix <class 'int'> <<UINT_16>>
        '''
        returnCode, th_pix = self.CLIENT_pkg_spnr_GetThPix()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, th_pix)
    # End of GetThPix()


    @exception_wrapper
    def spnrSetThPixSum(self, th_pixSum):
        '''Usage: returnCode = SetThPixSum(self, th_pixSum)
            Input_01 th_pixSum <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetThPixSum(th_pixSum)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThPixSum()


    @exception_wrapper
    def spnrGetThPixSum(self):
        '''Usage: returnCode, th_pixSum = GetThPixSum(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 th_pixSum <class 'int'> <<UINT_16>>
        '''
        returnCode, th_pixSum = self.CLIENT_pkg_spnr_GetThPixSum()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, th_pixSum)
    # End of GetThPixSum()


    @exception_wrapper
    def spnrSetMaxcorr(self, maxcorr):
        '''Usage: returnCode = SetMaxcorr(self, maxcorr)
            Input_01 maxcorr <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetMaxcorr(maxcorr)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxcorr()


    @exception_wrapper
    def spnrGetMaxcorr(self):
        '''Usage: returnCode, maxcorr = GetMaxcorr(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 maxcorr <class 'int'> <<UINT_16>>
        '''
        returnCode, maxcorr = self.CLIENT_pkg_spnr_GetMaxcorr()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, maxcorr)
    # End of GetMaxcorr()


    @exception_wrapper
    def spnrGetAlgorithm(self):
        '''Usage: returnCode, data = GetAlgorithm(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SPNR_ALGORITHM_E <<FLR_SPNR_ALGORITHM_E>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetAlgorithm()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAlgorithm()


    @exception_wrapper
    def spnrSetAlgorithmDesired(self, data):
        '''Usage: returnCode = SetAlgorithmDesired(self, data)
            Input_01 data FLR_SPNR_ALGORITHM_E <<FLR_SPNR_ALGORITHM_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spnr_SetAlgorithmDesired(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetAlgorithmDesired()


    @exception_wrapper
    def spnrGetAlgorithmDesired(self):
        '''Usage: returnCode, data = GetAlgorithmDesired(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SPNR_ALGORITHM_E <<FLR_SPNR_ALGORITHM_E>>
        '''
        returnCode, data = self.CLIENT_pkg_spnr_GetAlgorithmDesired()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAlgorithmDesired()


    @exception_wrapper
    def spotMeterSetEnable(self, data):
        '''Usage: returnCode = SetEnable(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spotMeter_SetEnable(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnable()


    @exception_wrapper
    def spotMeterGetEnable(self):
        '''Usage: returnCode, data = GetEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_spotMeter_GetEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEnable()


    @exception_wrapper
    def spotMeterGetRoiMaxSize(self):
        '''Usage: returnCode, width, height = GetRoiMaxSize(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 width <class 'int'> <<UINT_16>>
            Output_02 height <class 'int'> <<UINT_16>>
        '''
        returnCode, width, height = self.CLIENT_pkg_spotMeter_GetRoiMaxSize()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, width, height)
    # End of GetRoiMaxSize()


    @exception_wrapper
    def spotMeterSetRoi(self, roi):
        '''Usage: returnCode = SetRoi(self, roi)
            Input_01 roi FLR_ROI_T <<FLR_ROI_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spotMeter_SetRoi(roi)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetRoi()


    @exception_wrapper
    def spotMeterGetRoi(self):
        '''Usage: returnCode, roi = GetRoi(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 roi FLR_ROI_T <<FLR_ROI_T>>
        '''
        returnCode, roi = self.CLIENT_pkg_spotMeter_GetRoi()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, roi)
    # End of GetRoi()


    @exception_wrapper
    def spotMeterGetSpotStats(self):
        '''Usage: returnCode, mean, deviation, min, max = GetSpotStats(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mean <class 'int'> <<UINT_16>>
            Output_02 deviation <class 'int'> <<UINT_16>>
            Output_03 min FLR_SPOTMETER_SPOT_PARAM_T <<FLR_SPOTMETER_SPOT_PARAM_T>>
            Output_04 max FLR_SPOTMETER_SPOT_PARAM_T <<FLR_SPOTMETER_SPOT_PARAM_T>>
        '''
        returnCode, mean, deviation, min, max = self.CLIENT_pkg_spotMeter_GetSpotStats()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None)
        
        return ( returnCode, mean, deviation, min, max)
    # End of GetSpotStats()


    @exception_wrapper
    def spotMeterSetStatsMode(self, mode):
        '''Usage: returnCode = SetStatsMode(self, mode)
            Input_01 mode FLR_SPOTMETER_STATS_TEMP_MODE_E <<FLR_SPOTMETER_STATS_TEMP_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_spotMeter_SetStatsMode(mode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetStatsMode()


    @exception_wrapper
    def spotMeterGetStatsMode(self):
        '''Usage: returnCode, mode = GetStatsMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mode FLR_SPOTMETER_STATS_TEMP_MODE_E <<FLR_SPOTMETER_STATS_TEMP_MODE_E>>
        '''
        returnCode, mode = self.CLIENT_pkg_spotMeter_GetStatsMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, mode)
    # End of GetStatsMode()


    @exception_wrapper
    def spotMeterGetTempStats(self):
        '''Usage: returnCode, mean, deviation, min, max = GetTempStats(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 mean <class 'float'> <<FLOAT>>
            Output_02 deviation <class 'float'> <<FLOAT>>
            Output_03 min FLR_SPOTMETER_STAT_PARAM_TEMP_T <<FLR_SPOTMETER_STAT_PARAM_TEMP_T>>
            Output_04 max FLR_SPOTMETER_STAT_PARAM_TEMP_T <<FLR_SPOTMETER_STAT_PARAM_TEMP_T>>
        '''
        returnCode, mean, deviation, min, max = self.CLIENT_pkg_spotMeter_GetTempStats()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None, None)
        
        return ( returnCode, mean, deviation, min, max)
    # End of GetTempStats()


    @exception_wrapper
    def srnrSetEnableState(self, data):
        '''Usage: returnCode = SetEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_srnr_SetEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnableState()


    @exception_wrapper
    def srnrGetEnableState(self):
        '''Usage: returnCode, data = GetEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEnableState()


    @exception_wrapper
    def srnrSetThRowSum(self, data):
        '''Usage: returnCode = SetThRowSum(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_srnr_SetThRowSum(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThRowSum()


    @exception_wrapper
    def srnrGetThRowSum(self):
        '''Usage: returnCode, data = GetThRowSum(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetThRowSum()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThRowSum()


    @exception_wrapper
    def srnrSetThPixel(self, data):
        '''Usage: returnCode = SetThPixel(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_srnr_SetThPixel(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetThPixel()


    @exception_wrapper
    def srnrGetThPixel(self):
        '''Usage: returnCode, data = GetThPixel(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetThPixel()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThPixel()


    @exception_wrapper
    def srnrSetMaxCorr(self, data):
        '''Usage: returnCode = SetMaxCorr(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_srnr_SetMaxCorr(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMaxCorr()


    @exception_wrapper
    def srnrGetMaxCorr(self):
        '''Usage: returnCode, data = GetMaxCorr(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetMaxCorr()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxCorr()


    @exception_wrapper
    def srnrGetThPixelApplied(self):
        '''Usage: returnCode, data = GetThPixelApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetThPixelApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetThPixelApplied()


    @exception_wrapper
    def srnrGetMaxCorrApplied(self):
        '''Usage: returnCode, data = GetMaxCorrApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_srnr_GetMaxCorrApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxCorrApplied()


    @exception_wrapper
    def symbologySetEnable(self, draw_symbols):
        '''Usage: returnCode = SetEnable(self, draw_symbols)
            Input_01 draw_symbols FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SetEnable(draw_symbols)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnable()


    @exception_wrapper
    def symbologyCreateBitmap(self, ID, pos_X, pos_Y, width, height):
        '''Usage: returnCode = CreateBitmap(self, ID, pos_X, pos_Y, width, height)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateBitmap(ID, pos_X, pos_Y, width, height)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateBitmap()


    @exception_wrapper
    def symbologySendData(self, ID, size, text):
        '''Usage: returnCode = SendData(self, ID, size, text)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 size <class 'int'> <<INT_16>>
            Input_03 text[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SendData(ID, size, text)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SendData()


    @exception_wrapper
    def symbologyCreateArc(self, ID, pos_X, pos_Y, width, height, start_angle, end_angle, color):
        '''Usage: returnCode = CreateArc(self, ID, pos_X, pos_Y, width, height, start_angle, end_angle, color)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 start_angle <class 'float'> <<FLOAT>>
            Input_07 end_angle <class 'float'> <<FLOAT>>
            Input_08 color <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateArc(ID, pos_X, pos_Y, width, height, start_angle, end_angle, color)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateArc()


    @exception_wrapper
    def symbologyCreateText(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, text):
        '''Usage: returnCode = CreateText(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, text)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 font <class 'int'> <<CHAR>>
            Input_07 size <class 'int'> <<INT_16>>
            Input_08 alignment FLR_SYMBOLOGY_TEXT_ALIGNMENT_E <<FLR_SYMBOLOGY_TEXT_ALIGNMENT_E>>
            Input_09 color <class 'int'> <<UINT_32>>
            Input_10 text[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateText(ID, pos_X, pos_Y, width, height, font, size, alignment, color, text)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateText()


    @exception_wrapper
    def symbologyMoveSprite(self, ID, pos_X, pos_Y):
        '''Usage: returnCode = MoveSprite(self, ID, pos_X, pos_Y)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_MoveSprite(ID, pos_X, pos_Y)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of MoveSprite()


    @exception_wrapper
    def symbologyAddToGroup(self, ID, group_ID):
        '''Usage: returnCode = AddToGroup(self, ID, group_ID)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 group_ID <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_AddToGroup(ID, group_ID)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of AddToGroup()


    @exception_wrapper
    def symbologyRemoveFromGroup(self, ID, group_ID):
        '''Usage: returnCode = RemoveFromGroup(self, ID, group_ID)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 group_ID <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_RemoveFromGroup(ID, group_ID)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of RemoveFromGroup()


    @exception_wrapper
    def symbologyUpdateAndShow(self, ID, visible):
        '''Usage: returnCode = UpdateAndShow(self, ID, visible)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 visible <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_UpdateAndShow(ID, visible)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of UpdateAndShow()


    @exception_wrapper
    def symbologyUpdateAndShowGroup(self, group_ID, visible):
        '''Usage: returnCode = UpdateAndShowGroup(self, group_ID, visible)
            Input_01 group_ID <class 'int'> <<UCHAR>>
            Input_02 visible <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_UpdateAndShowGroup(group_ID, visible)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of UpdateAndShowGroup()


    @exception_wrapper
    def symbologyDelete(self, ID):
        '''Usage: returnCode = Delete(self, ID)
            Input_01 ID <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_Delete(ID)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of Delete()


    @exception_wrapper
    def symbologyDeleteGroup(self, group_ID):
        '''Usage: returnCode = DeleteGroup(self, group_ID)
            Input_01 group_ID <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_DeleteGroup(group_ID)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of DeleteGroup()


    @exception_wrapper
    def symbologyCreateFilledRectangle(self, ID, pos_X, pos_Y, width, height, color):
        '''Usage: returnCode = CreateFilledRectangle(self, ID, pos_X, pos_Y, width, height, color)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 color <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateFilledRectangle(ID, pos_X, pos_Y, width, height, color)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateFilledRectangle()


    @exception_wrapper
    def symbologyCreateOutlinedRectangle(self, ID, pos_X, pos_Y, width, height, color):
        '''Usage: returnCode = CreateOutlinedRectangle(self, ID, pos_X, pos_Y, width, height, color)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 color <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateOutlinedRectangle(ID, pos_X, pos_Y, width, height, color)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateOutlinedRectangle()


    @exception_wrapper
    def symbologyCreateBitmapFromPng(self, ID, pos_X, pos_Y, size):
        '''Usage: returnCode = CreateBitmapFromPng(self, ID, pos_X, pos_Y, size)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 size <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateBitmapFromPng(ID, pos_X, pos_Y, size)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateBitmapFromPng()


    @exception_wrapper
    def symbologyCreateCompressedBitmap(self, ID, pos_X, pos_Y, width, height):
        '''Usage: returnCode = CreateCompressedBitmap(self, ID, pos_X, pos_Y, width, height)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateCompressedBitmap(ID, pos_X, pos_Y, width, height)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateCompressedBitmap()


    @exception_wrapper
    def symbologyCreateBitmapFromPngFile(self, ID, pos_X, pos_Y, path):
        '''Usage: returnCode = CreateBitmapFromPngFile(self, ID, pos_X, pos_Y, path)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 path[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateBitmapFromPngFile(ID, pos_X, pos_Y, path)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateBitmapFromPngFile()


    @exception_wrapper
    def symbologyCreateBitmapFromFile(self, ID, pos_X, pos_Y, path, imageType):
        '''Usage: returnCode = CreateBitmapFromFile(self, ID, pos_X, pos_Y, path, imageType)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 path[<class 'int'>] 128 <<UCHAR*128>>
            Input_05 imageType FLR_SYMBOLOGY_IMAGE_TYPE_E <<FLR_SYMBOLOGY_IMAGE_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateBitmapFromFile(ID, pos_X, pos_Y, path, imageType)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateBitmapFromFile()


    @exception_wrapper
    def symbologyResetWritePosition(self, ID):
        '''Usage: returnCode = ResetWritePosition(self, ID)
            Input_01 ID <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_ResetWritePosition(ID)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ResetWritePosition()


    @exception_wrapper
    def symbologyMoveByOffset(self, ID, off_X, off_Y):
        '''Usage: returnCode = MoveByOffset(self, ID, off_X, off_Y)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 off_X <class 'int'> <<INT_16>>
            Input_03 off_Y <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_MoveByOffset(ID, off_X, off_Y)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of MoveByOffset()


    @exception_wrapper
    def symbologyMoveGroupByOffset(self, ID, off_X, off_Y):
        '''Usage: returnCode = MoveGroupByOffset(self, ID, off_X, off_Y)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 off_X <class 'int'> <<INT_16>>
            Input_03 off_Y <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_MoveGroupByOffset(ID, off_X, off_Y)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of MoveGroupByOffset()


    @exception_wrapper
    def symbologyCreateFilledEllipse(self, ID, pos_X, pos_Y, width, height, color):
        '''Usage: returnCode = CreateFilledEllipse(self, ID, pos_X, pos_Y, width, height, color)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 color <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateFilledEllipse(ID, pos_X, pos_Y, width, height, color)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateFilledEllipse()


    @exception_wrapper
    def symbologyCreateLine(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color):
        '''Usage: returnCode = CreateLine(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 pos_X2 <class 'int'> <<INT_16>>
            Input_05 pos_Y2 <class 'int'> <<INT_16>>
            Input_06 color <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateLine(ID, pos_X, pos_Y, pos_X2, pos_Y2, color)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateLine()


    @exception_wrapper
    def symbologySetZorder(self, ID, zorder):
        '''Usage: returnCode = SetZorder(self, ID, zorder)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 zorder <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SetZorder(ID, zorder)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetZorder()


    @exception_wrapper
    def symbologySaveConfiguration(self):
        '''Usage: returnCode = SaveConfiguration(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SaveConfiguration()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SaveConfiguration()


    @exception_wrapper
    def symbologyReloadConfiguration(self):
        '''Usage: returnCode = ReloadConfiguration(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_ReloadConfiguration()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of ReloadConfiguration()


    @exception_wrapper
    def symbologyGetEnable(self):
        '''Usage: returnCode, draw_symbols = GetEnable(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 draw_symbols FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, draw_symbols = self.CLIENT_pkg_symbology_GetEnable()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, draw_symbols)
    # End of GetEnable()


    @exception_wrapper
    def symbologySetClonesNumber(self, ID, numberOfClones):
        '''Usage: returnCode = SetClonesNumber(self, ID, numberOfClones)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 numberOfClones <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SetClonesNumber(ID, numberOfClones)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetClonesNumber()


    @exception_wrapper
    def symbologyMoveCloneByOffset(self, ID, cloneID, pos_X, pos_Y):
        '''Usage: returnCode = MoveCloneByOffset(self, ID, cloneID, pos_X, pos_Y)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 cloneID <class 'int'> <<UCHAR>>
            Input_03 pos_X <class 'int'> <<INT_16>>
            Input_04 pos_Y <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_MoveCloneByOffset(ID, cloneID, pos_X, pos_Y)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of MoveCloneByOffset()


    @exception_wrapper
    def symbologyMoveCloneSprite(self, ID, cloneID, pos_X, pos_Y):
        '''Usage: returnCode = MoveCloneSprite(self, ID, cloneID, pos_X, pos_Y)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 cloneID <class 'int'> <<UCHAR>>
            Input_03 pos_X <class 'int'> <<INT_16>>
            Input_04 pos_Y <class 'int'> <<INT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_MoveCloneSprite(ID, cloneID, pos_X, pos_Y)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of MoveCloneSprite()


    @exception_wrapper
    def symbologySetTransformation(self, transformation):
        '''Usage: returnCode = SetTransformation(self, transformation)
            Input_01 transformation FLR_SYMBOLOGY_TRANSFORMATION_E <<FLR_SYMBOLOGY_TRANSFORMATION_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SetTransformation(transformation)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTransformation()


    @exception_wrapper
    def symbologyUpdateAllVisible(self):
        '''Usage: returnCode = UpdateAllVisible(self)
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_UpdateAllVisible()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of UpdateAllVisible()


    @exception_wrapper
    def symbologySetSizeAndScalingMode(self, ID, width, height, scalingMode):
        '''Usage: returnCode = SetSizeAndScalingMode(self, ID, width, height, scalingMode)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 width <class 'int'> <<INT_16>>
            Input_03 height <class 'int'> <<INT_16>>
            Input_04 scalingMode FLR_SYMBOLOGY_SCALING_MODE_E <<FLR_SYMBOLOGY_SCALING_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_SetSizeAndScalingMode(ID, width, height, scalingMode)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSizeAndScalingMode()


    @exception_wrapper
    def symbologyCreateLineHVT(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color1, color2, dashLen, thickness):
        '''Usage: returnCode = CreateLineHVT(self, ID, pos_X, pos_Y, pos_X2, pos_Y2, color1, color2, dashLen, thickness)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 pos_X2 <class 'int'> <<INT_16>>
            Input_05 pos_Y2 <class 'int'> <<INT_16>>
            Input_06 color1 <class 'int'> <<UINT_32>>
            Input_07 color2 <class 'int'> <<UINT_32>>
            Input_08 dashLen <class 'int'> <<UINT_16>>
            Input_09 thickness <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateLineHVT(ID, pos_X, pos_Y, pos_X2, pos_Y2, color1, color2, dashLen, thickness)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateLineHVT()


    @exception_wrapper
    def symbologyCreateTextHVT(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color1, color2, dashLen, text):
        '''Usage: returnCode = CreateTextHVT(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color1, color2, dashLen, text)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 font <class 'int'> <<CHAR>>
            Input_07 size <class 'int'> <<INT_16>>
            Input_08 alignment FLR_SYMBOLOGY_TEXT_ALIGNMENT_E <<FLR_SYMBOLOGY_TEXT_ALIGNMENT_E>>
            Input_09 color1 <class 'int'> <<UINT_32>>
            Input_10 color2 <class 'int'> <<UINT_32>>
            Input_11 dashLen <class 'int'> <<UCHAR>>
            Input_12 text[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateTextHVT(ID, pos_X, pos_Y, width, height, font, size, alignment, color1, color2, dashLen, text)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateTextHVT()


    @exception_wrapper
    def symbologyCreateTextBg(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, bgColor, text):
        '''Usage: returnCode = CreateTextBg(self, ID, pos_X, pos_Y, width, height, font, size, alignment, color, bgColor, text)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 font <class 'int'> <<CHAR>>
            Input_07 size <class 'int'> <<INT_16>>
            Input_08 alignment FLR_SYMBOLOGY_TEXT_ALIGNMENT_E <<FLR_SYMBOLOGY_TEXT_ALIGNMENT_E>>
            Input_09 color <class 'int'> <<UINT_32>>
            Input_10 bgColor <class 'int'> <<UINT_32>>
            Input_11 text[<class 'int'>] 128 <<UCHAR*128>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateTextBg(ID, pos_X, pos_Y, width, height, font, size, alignment, color, bgColor, text)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateTextBg()


    @exception_wrapper
    def symbologyCreateScaledBitmapFromFile(self, ID, pos_X, pos_Y, width, height, scalingMode, path, imageType):
        '''Usage: returnCode = CreateScaledBitmapFromFile(self, ID, pos_X, pos_Y, width, height, scalingMode, path, imageType)
            Input_01 ID <class 'int'> <<UCHAR>>
            Input_02 pos_X <class 'int'> <<INT_16>>
            Input_03 pos_Y <class 'int'> <<INT_16>>
            Input_04 width <class 'int'> <<INT_16>>
            Input_05 height <class 'int'> <<INT_16>>
            Input_06 scalingMode FLR_SYMBOLOGY_SCALING_MODE_E <<FLR_SYMBOLOGY_SCALING_MODE_E>>
            Input_07 path[<class 'int'>] 128 <<UCHAR*128>>
            Input_08 imageType FLR_SYMBOLOGY_IMAGE_TYPE_E <<FLR_SYMBOLOGY_IMAGE_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_symbology_CreateScaledBitmapFromFile(ID, pos_X, pos_Y, width, height, scalingMode, path, imageType)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of CreateScaledBitmapFromFile()


    @exception_wrapper
    def sysctrlSetFreezeState(self, data):
        '''Usage: returnCode = SetFreezeState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sysctrl_SetFreezeState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFreezeState()


    @exception_wrapper
    def sysctrlGetFreezeState(self):
        '''Usage: returnCode, data = GetFreezeState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_sysctrl_GetFreezeState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFreezeState()


    @exception_wrapper
    def sysctrlGetCameraFrameRate(self):
        '''Usage: returnCode, frameRate = GetCameraFrameRate(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 frameRate <class 'int'> <<UINT_32>>
        '''
        returnCode, frameRate = self.CLIENT_pkg_sysctrl_GetCameraFrameRate()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, frameRate)
    # End of GetCameraFrameRate()


    @exception_wrapper
    def sysctrlGetUptimeSecs(self):
        '''Usage: returnCode, uptime = GetUptimeSecs(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 uptime <class 'int'> <<UINT_32>>
        '''
        returnCode, uptime = self.CLIENT_pkg_sysctrl_GetUptimeSecs()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, uptime)
    # End of GetUptimeSecs()


    @exception_wrapper
    def sysctrlSetUsbVideoIR16Mode(self, data):
        '''Usage: returnCode = SetUsbVideoIR16Mode(self, data)
            Input_01 data FLR_SYSCTRL_USBIR16_MODE_E <<FLR_SYSCTRL_USBIR16_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sysctrl_SetUsbVideoIR16Mode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetUsbVideoIR16Mode()


    @exception_wrapper
    def sysctrlGetUsbVideoIR16Mode(self):
        '''Usage: returnCode, data = GetUsbVideoIR16Mode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SYSCTRL_USBIR16_MODE_E <<FLR_SYSCTRL_USBIR16_MODE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_sysctrl_GetUsbVideoIR16Mode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetUsbVideoIR16Mode()


    @exception_wrapper
    def sysctrlSetOperatingMode(self, data):
        '''Usage: returnCode = SetOperatingMode(self, data)
            Input_01 data FLR_SYSCTRL_OPERATING_MODE_E <<FLR_SYSCTRL_OPERATING_MODE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sysctrl_SetOperatingMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOperatingMode()


    @exception_wrapper
    def sysctrlGetOperatingMode(self):
        '''Usage: returnCode, data = GetOperatingMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_SYSCTRL_OPERATING_MODE_E <<FLR_SYSCTRL_OPERATING_MODE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_sysctrl_GetOperatingMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOperatingMode()


    @exception_wrapper
    def sysctrlGetAvgFpaTempCounts(self):
        '''Usage: returnCode, data = GetAvgFpaTempCounts(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'float'> <<FLOAT>>
        '''
        returnCode, data = self.CLIENT_pkg_sysctrl_GetAvgFpaTempCounts()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetAvgFpaTempCounts()


    @exception_wrapper
    def sysctrlSetFpaTempFrames(self, data):
        '''Usage: returnCode = SetFpaTempFrames(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_sysctrl_SetFpaTempFrames(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetFpaTempFrames()


    @exception_wrapper
    def sysctrlGetFpaTempFrames(self):
        '''Usage: returnCode, data = GetFpaTempFrames(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_sysctrl_GetFpaTempFrames()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetFpaTempFrames()


    @exception_wrapper
    def sysinfoGetMonitorSoftwareRev(self):
        '''Usage: returnCode, major, minor, patch = GetMonitorSoftwareRev(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_sysinfo_GetMonitorSoftwareRev()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetMonitorSoftwareRev()


    @exception_wrapper
    def sysinfoGetMonitorBuildVariant(self):
        '''Usage: returnCode, monitorBuildVariant = GetMonitorBuildVariant(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 monitorBuildVariant FLR_SYSINFO_MONITOR_BUILD_VARIANT_T <<FLR_SYSINFO_MONITOR_BUILD_VARIANT_T>>
        '''
        returnCode, monitorBuildVariant = self.CLIENT_pkg_sysinfo_GetMonitorBuildVariant()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, monitorBuildVariant)
    # End of GetMonitorBuildVariant()


    @exception_wrapper
    def sysinfoGetProductName(self):
        '''Usage: returnCode, name = GetProductName(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 name[<class 'int'>] 128 <<UCHAR*128>>
        '''
        returnCode, name = self.CLIENT_pkg_sysinfo_GetProductName()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, name)
    # End of GetProductName()


    @exception_wrapper
    def sysinfoGetCameraSN(self):
        '''Usage: returnCode, number = GetCameraSN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 number[<class 'int'>] 128 <<UCHAR*128>>
        '''
        returnCode, number = self.CLIENT_pkg_sysinfo_GetCameraSN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, number)
    # End of GetCameraSN()


    @exception_wrapper
    def sysinfoGetBootLocation(self):
        '''Usage: returnCode, bootSwLocation = GetBootLocation(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 bootSwLocation <class 'int'> <<UINT_32>>
        '''
        returnCode, bootSwLocation = self.CLIENT_pkg_sysinfo_GetBootLocation()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, bootSwLocation)
    # End of GetBootLocation()


    @exception_wrapper
    def sysinfoGetSwConfigID(self):
        '''Usage: returnCode, swConfigID = GetSwConfigID(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 swConfigID FLR_SYSINFO_SW_CONFIG_ID_E <<FLR_SYSINFO_SW_CONFIG_ID_E>>
        '''
        returnCode, swConfigID = self.CLIENT_pkg_sysinfo_GetSwConfigID()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, swConfigID)
    # End of GetSwConfigID()


    @exception_wrapper
    def sysinfoGetSwPermissions(self):
        '''Usage: returnCode, swPermissions = GetSwPermissions(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 swPermissions FLR_SYSINFO_SW_PERMISSIONS_E <<FLR_SYSINFO_SW_PERMISSIONS_E>>
        '''
        returnCode, swPermissions = self.CLIENT_pkg_sysinfo_GetSwPermissions()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, swPermissions)
    # End of GetSwPermissions()


    @exception_wrapper
    def sysinfoGetIs9HzBuild(self):
        '''Usage: returnCode, is9HzBuild = GetIs9HzBuild(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 is9HzBuild <class 'int'> <<UINT_32>>
        '''
        returnCode, is9HzBuild = self.CLIENT_pkg_sysinfo_GetIs9HzBuild()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, is9HzBuild)
    # End of GetIs9HzBuild()


    @exception_wrapper
    def sysinfoGetProductVersion(self):
        '''Usage: returnCode, major, minor, patch = GetProductVersion(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_sysinfo_GetProductVersion()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetProductVersion()


    @exception_wrapper
    def sysinfoGetMonitorProductRev(self):
        '''Usage: returnCode, major, minor, patch = GetMonitorProductRev(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 major <class 'int'> <<UINT_32>>
            Output_02 minor <class 'int'> <<UINT_32>>
            Output_03 patch <class 'int'> <<UINT_32>>
        '''
        returnCode, major, minor, patch = self.CLIENT_pkg_sysinfo_GetMonitorProductRev()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, major, minor, patch)
    # End of GetMonitorProductRev()


    @exception_wrapper
    def sysinfoGetOpticalRevision(self):
        '''Usage: returnCode, revision = GetOpticalRevision(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 revision <class 'int'> <<UINT_16>>
        '''
        returnCode, revision = self.CLIENT_pkg_sysinfo_GetOpticalRevision()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, revision)
    # End of GetOpticalRevision()


    @exception_wrapper
    def sysinfoGetSensorRevision(self):
        '''Usage: returnCode, revision = GetSensorRevision(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 revision <class 'int'> <<UINT_16>>
        '''
        returnCode, revision = self.CLIENT_pkg_sysinfo_GetSensorRevision()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, revision)
    # End of GetSensorRevision()


    @exception_wrapper
    def sysinfoGetProbeTipSN(self):
        '''Usage: returnCode, number = GetProbeTipSN(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 number[<class 'int'>] 128 <<UCHAR*128>>
        '''
        returnCode, number = self.CLIENT_pkg_sysinfo_GetProbeTipSN()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, number)
    # End of GetProbeTipSN()


    @exception_wrapper
    def sysinfoGetMechanicalRevision(self):
        '''Usage: returnCode, revision = GetMechanicalRevision(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 revision <class 'int'> <<UINT_16>>
        '''
        returnCode, revision = self.CLIENT_pkg_sysinfo_GetMechanicalRevision()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, revision)
    # End of GetMechanicalRevision()


    @exception_wrapper
    def systemSymbolsGetID(self, symbol):
        '''Usage: returnCode, id, id_type = GetID(self, symbol)
            Input_01 symbol FLR_SYSTEMSYMBOLS_SYMBOL_E <<FLR_SYSTEMSYMBOLS_SYMBOL_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 id <class 'int'> <<UCHAR>>
            Output_02 id_type FLR_SYSTEMSYMBOLS_ID_TYPE_E <<FLR_SYSTEMSYMBOLS_ID_TYPE_E>>
        '''
        returnCode, id, id_type = self.CLIENT_pkg_systemSymbols_GetID(symbol)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None)
        
        return ( returnCode, id, id_type)
    # End of GetID()


    @exception_wrapper
    def systemSymbolsSetID(self, symbol, id, id_type):
        '''Usage: returnCode = SetID(self, symbol, id, id_type)
            Input_01 symbol FLR_SYSTEMSYMBOLS_SYMBOL_E <<FLR_SYSTEMSYMBOLS_SYMBOL_E>>
            Input_02 id <class 'int'> <<UCHAR>>
            Input_03 id_type FLR_SYSTEMSYMBOLS_ID_TYPE_E <<FLR_SYSTEMSYMBOLS_ID_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_systemSymbols_SetID(symbol, id, id_type)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetID()


    @exception_wrapper
    def systemSymbolsGetEnable(self, symbol):
        '''Usage: returnCode, enabled = GetEnable(self, symbol)
            Input_01 symbol FLR_SYSTEMSYMBOLS_SYMBOL_E <<FLR_SYSTEMSYMBOLS_SYMBOL_E>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 enabled FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, enabled = self.CLIENT_pkg_systemSymbols_GetEnable(symbol)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, enabled)
    # End of GetEnable()


    @exception_wrapper
    def systemSymbolsSetEnable(self, symbol, enabled):
        '''Usage: returnCode = SetEnable(self, symbol, enabled)
            Input_01 symbol FLR_SYSTEMSYMBOLS_SYMBOL_E <<FLR_SYSTEMSYMBOLS_SYMBOL_E>>
            Input_02 enabled FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_systemSymbols_SetEnable(symbol, enabled)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnable()


    @exception_wrapper
    def systemSymbolsGetSpotConfig(self):
        '''Usage: returnCode, config = GetSpotConfig(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 config FLR_SYSTEMSYMBOLS_SPOTCONFIG_T <<FLR_SYSTEMSYMBOLS_SPOTCONFIG_T>>
        '''
        returnCode, config = self.CLIENT_pkg_systemSymbols_GetSpotConfig()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, config)
    # End of GetSpotConfig()


    @exception_wrapper
    def systemSymbolsSetSpotConfig(self, config):
        '''Usage: returnCode = SetSpotConfig(self, config)
            Input_01 config FLR_SYSTEMSYMBOLS_SPOTCONFIG_T <<FLR_SYSTEMSYMBOLS_SPOTCONFIG_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_systemSymbols_SetSpotConfig(config)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSpotConfig()


    @exception_wrapper
    def systemSymbolsGetIsoConfig(self):
        '''Usage: returnCode, config = GetIsoConfig(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 config FLR_SYSTEMSYMBOLS_ISOCONFIG_T <<FLR_SYSTEMSYMBOLS_ISOCONFIG_T>>
        '''
        returnCode, config = self.CLIENT_pkg_systemSymbols_GetIsoConfig()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, config)
    # End of GetIsoConfig()


    @exception_wrapper
    def systemSymbolsSetIsoConfig(self, config):
        '''Usage: returnCode = SetIsoConfig(self, config)
            Input_01 config FLR_SYSTEMSYMBOLS_ISOCONFIG_T <<FLR_SYSTEMSYMBOLS_ISOCONFIG_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_systemSymbols_SetIsoConfig(config)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIsoConfig()


    @exception_wrapper
    def systemSymbolsGetBarConfig(self):
        '''Usage: returnCode, lowGainConfig, highGainConfig, unit = GetBarConfig(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 lowGainConfig FLR_SYSTEMSYMBOLS_BARCONFIG_T <<FLR_SYSTEMSYMBOLS_BARCONFIG_T>>
            Output_02 highGainConfig FLR_SYSTEMSYMBOLS_BARCONFIG_T <<FLR_SYSTEMSYMBOLS_BARCONFIG_T>>
            Output_03 unit FLR_TEMPERATURE_UNIT_E <<FLR_TEMPERATURE_UNIT_E>>
        '''
        returnCode, lowGainConfig, highGainConfig, unit = self.CLIENT_pkg_systemSymbols_GetBarConfig()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None, None, None)
        
        return ( returnCode, lowGainConfig, highGainConfig, unit)
    # End of GetBarConfig()


    @exception_wrapper
    def systemSymbolsSetBarConfig(self, lowGainConfig, highGainConfig, unit):
        '''Usage: returnCode = SetBarConfig(self, lowGainConfig, highGainConfig, unit)
            Input_01 lowGainConfig FLR_SYSTEMSYMBOLS_BARCONFIG_T <<FLR_SYSTEMSYMBOLS_BARCONFIG_T>>
            Input_02 highGainConfig FLR_SYSTEMSYMBOLS_BARCONFIG_T <<FLR_SYSTEMSYMBOLS_BARCONFIG_T>>
            Input_03 unit FLR_TEMPERATURE_UNIT_E <<FLR_TEMPERATURE_UNIT_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_systemSymbols_SetBarConfig(lowGainConfig, highGainConfig, unit)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetBarConfig()


    @exception_wrapper
    def telemetrySetState(self, data):
        '''Usage: returnCode = SetState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_telemetry_SetState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetState()


    @exception_wrapper
    def telemetryGetState(self):
        '''Usage: returnCode, data = GetState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_telemetry_GetState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetState()


    @exception_wrapper
    def telemetrySetLocation(self, data):
        '''Usage: returnCode = SetLocation(self, data)
            Input_01 data FLR_TELEMETRY_LOC_E <<FLR_TELEMETRY_LOC_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_telemetry_SetLocation(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetLocation()


    @exception_wrapper
    def telemetryGetLocation(self):
        '''Usage: returnCode, data = GetLocation(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TELEMETRY_LOC_E <<FLR_TELEMETRY_LOC_E>>
        '''
        returnCode, data = self.CLIENT_pkg_telemetry_GetLocation()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetLocation()


    @exception_wrapper
    def telemetrySetPacking(self, data):
        '''Usage: returnCode = SetPacking(self, data)
            Input_01 data FLR_TELEMETRY_PACKING_E <<FLR_TELEMETRY_PACKING_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_telemetry_SetPacking(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetPacking()


    @exception_wrapper
    def telemetryGetPacking(self):
        '''Usage: returnCode, data = GetPacking(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TELEMETRY_PACKING_E <<FLR_TELEMETRY_PACKING_E>>
        '''
        returnCode, data = self.CLIENT_pkg_telemetry_GetPacking()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetPacking()


    @exception_wrapper
    def telemetrySetOrder(self, data):
        '''Usage: returnCode = SetOrder(self, data)
            Input_01 data FLR_TELEMETRY_ORDER_E <<FLR_TELEMETRY_ORDER_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_telemetry_SetOrder(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetOrder()


    @exception_wrapper
    def telemetryGetOrder(self):
        '''Usage: returnCode, data = GetOrder(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TELEMETRY_ORDER_E <<FLR_TELEMETRY_ORDER_E>>
        '''
        returnCode, data = self.CLIENT_pkg_telemetry_GetOrder()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetOrder()


    @exception_wrapper
    def testRampSetType(self, index, data):
        '''Usage: returnCode = SetType(self, index, data)
            Input_01 index <class 'int'> <<UCHAR>>
            Input_02 data FLR_TESTRAMP_TYPE_E <<FLR_TESTRAMP_TYPE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_testRamp_SetType(index, data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetType()


    @exception_wrapper
    def testRampGetType(self, index):
        '''Usage: returnCode, data = GetType(self, index)
            Input_01 index <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TESTRAMP_TYPE_E <<FLR_TESTRAMP_TYPE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetType(index)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetType()


    @exception_wrapper
    def testRampSetSettings(self, index, data):
        '''Usage: returnCode = SetSettings(self, index, data)
            Input_01 index <class 'int'> <<UCHAR>>
            Input_02 data FLR_TESTRAMP_SETTINGS_T <<FLR_TESTRAMP_SETTINGS_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_testRamp_SetSettings(index, data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetSettings()


    @exception_wrapper
    def testRampGetSettings(self, index):
        '''Usage: returnCode, data = GetSettings(self, index)
            Input_01 index <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TESTRAMP_SETTINGS_T <<FLR_TESTRAMP_SETTINGS_T>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetSettings(index)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetSettings()


    @exception_wrapper
    def testRampSetMotionState(self, data):
        '''Usage: returnCode = SetMotionState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_testRamp_SetMotionState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMotionState()


    @exception_wrapper
    def testRampGetMotionState(self):
        '''Usage: returnCode, data = GetMotionState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetMotionState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMotionState()


    @exception_wrapper
    def testRampSetIndex(self, data):
        '''Usage: returnCode = SetIndex(self, data)
            Input_01 data <class 'int'> <<UCHAR>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_testRamp_SetIndex(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetIndex()


    @exception_wrapper
    def testRampGetIndex(self):
        '''Usage: returnCode, data = GetIndex(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UCHAR>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetIndex()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetIndex()


    @exception_wrapper
    def testRampGetMaxIndex(self):
        '''Usage: returnCode, data = GetMaxIndex(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UCHAR>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetMaxIndex()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMaxIndex()


    @exception_wrapper
    def testRampSetPN9ContinuousMode(self, data):
        '''Usage: returnCode = SetPN9ContinuousMode(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_testRamp_SetPN9ContinuousMode(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetPN9ContinuousMode()


    @exception_wrapper
    def testRampGetPN9ContinuousMode(self):
        '''Usage: returnCode, data = GetPN9ContinuousMode(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_testRamp_GetPN9ContinuousMode()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetPN9ContinuousMode()


    @exception_wrapper
    def tfSetEnableState(self, data):
        '''Usage: returnCode = SetEnableState(self, data)
            Input_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetEnableState(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetEnableState()


    @exception_wrapper
    def tfGetEnableState(self):
        '''Usage: returnCode, data = GetEnableState(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_ENABLE_E <<FLR_ENABLE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetEnableState()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetEnableState()


    @exception_wrapper
    def tfSetDelta_nf(self, data):
        '''Usage: returnCode = SetDelta_nf(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetDelta_nf(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetDelta_nf()


    @exception_wrapper
    def tfGetDelta_nf(self):
        '''Usage: returnCode, data = GetDelta_nf(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetDelta_nf()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDelta_nf()


    @exception_wrapper
    def tfSetTHDeltaMotion(self, data):
        '''Usage: returnCode = SetTHDeltaMotion(self, data)
            Input_01 data <class 'int'> <<UINT_16>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetTHDeltaMotion(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTHDeltaMotion()


    @exception_wrapper
    def tfGetTHDeltaMotion(self):
        '''Usage: returnCode, data = GetTHDeltaMotion(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetTHDeltaMotion()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTHDeltaMotion()


    @exception_wrapper
    def tfSetWLut(self, data):
        '''Usage: returnCode = SetWLut(self, data)
            Input_01 data FLR_TF_WLUT_T <<FLR_TF_WLUT_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetWLut(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetWLut()


    @exception_wrapper
    def tfGetWLut(self):
        '''Usage: returnCode, data = GetWLut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TF_WLUT_T <<FLR_TF_WLUT_T>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetWLut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetWLut()


    @exception_wrapper
    def tfGetMotionCount(self):
        '''Usage: returnCode, data = GetMotionCount(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetMotionCount()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMotionCount()


    @exception_wrapper
    def tfSetMotionThreshold(self, data):
        '''Usage: returnCode = SetMotionThreshold(self, data)
            Input_01 data <class 'int'> <<UINT_32>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetMotionThreshold(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetMotionThreshold()


    @exception_wrapper
    def tfGetMotionThreshold(self):
        '''Usage: returnCode, data = GetMotionThreshold(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_32>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetMotionThreshold()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetMotionThreshold()


    @exception_wrapper
    def tfGetDelta_nfApplied(self):
        '''Usage: returnCode, data = GetDelta_nfApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetDelta_nfApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetDelta_nfApplied()


    @exception_wrapper
    def tfGetTHDeltaMotionApplied(self):
        '''Usage: returnCode, data = GetTHDeltaMotionApplied(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data <class 'int'> <<UINT_16>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetTHDeltaMotionApplied()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTHDeltaMotionApplied()


    @exception_wrapper
    def tfSetTempSignalCompFactorLut(self, data):
        '''Usage: returnCode = SetTempSignalCompFactorLut(self, data)
            Input_01 data FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T <<FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_tf_SetTempSignalCompFactorLut(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetTempSignalCompFactorLut()


    @exception_wrapper
    def tfGetTempSignalCompFactorLut(self):
        '''Usage: returnCode, data = GetTempSignalCompFactorLut(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T <<FLR_TF_TEMP_SIGNAL_COMP_FACTOR_LUT_T>>
        '''
        returnCode, data = self.CLIENT_pkg_tf_GetTempSignalCompFactorLut()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetTempSignalCompFactorLut()


    @exception_wrapper
    def tfGetRnf(self):
        '''Usage: returnCode, rnf = GetRnf(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 rnf <class 'int'> <<UINT_16>>
        '''
        returnCode, rnf = self.CLIENT_pkg_tf_GetRnf()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, rnf)
    # End of GetRnf()


    @exception_wrapper
    def uartSetStartupBaudRate(self, data):
        '''Usage: returnCode = SetStartupBaudRate(self, data)
            Input_01 data FLR_UART_STARTUP_BAUDRATE_E <<FLR_UART_STARTUP_BAUDRATE_E>>
            Output_00 returnCode <FLR_RESULT>
        '''
        returnCode = self.CLIENT_pkg_uart_SetStartupBaudRate(data)
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode)
        
        return ( returnCode)
    # End of SetStartupBaudRate()


    @exception_wrapper
    def uartGetStartupBaudRate(self):
        '''Usage: returnCode, data = GetStartupBaudRate(self)
            Output_00 returnCode <FLR_RESULT>
            Output_01 data FLR_UART_STARTUP_BAUDRATE_E <<FLR_UART_STARTUP_BAUDRATE_E>>
        '''
        returnCode, data = self.CLIENT_pkg_uart_GetStartupBaudRate()
        
        # Check for any errorcode
        if (returnCode.value):
            return ( returnCode, None)
        
        return ( returnCode, data)
    # End of GetStartupBaudRate()


