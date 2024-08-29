# -*- coding: utf-8 -*-
"""
Created on Thu Dec 31 14:28:13 2015

@author: jimamura
"""
import ctypes, os, sys
import _ctypes
try:
    from .Factory_BOSON_GECKO import *
    from . import Factory_INIUtils#, BASE_BosonGecko
    FOUND_INI = True
except:
    FOUND_INI = False

class UART():
    def __init__(self,dllPath = None,**kwargs):
        self.isClosed = False
        self.portOpen = False
        self.port_num = -1
        self._default_timeout_ms = 1000
        self.current_timeout_ms = self._default_timeout_ms
        if (not "posix" in os.name):
            dll_name = "FSLP_64.dll"
        else:
            dll_name = "FSLP_64.so"

        if dllPath:
            loadpath = os.path.join(dllPath,dll_name)
        else:
            loadpath = os.path.join(os.path.dirname(__file__),dll_name)
        
        try:
            self.__library = ctypes.cdll.LoadLibrary(loadpath)
            self.__dllHandle = self.__library._handle
            self.camsend = self.__library.__getattr__("FSLP_send_to_camera")
            self.camread = self.__library.__getattr__("FSLP_read_frame")
            self.camunframed = self.__library.__getattr__("FSLP_read_unframed")
#            try:
#                self.poll_frame = self.__library.__getattr__("poll_general_frame")
#            except:
#                self.poll_frame = None
            self.port_open = self.__library.__getattr__("FSLP_open_port")
            self.port_close = self.__library.__getattr__("FSLP_close_port")
            self.lookup_port_name = self.__library.__getattr__("FSLP_lookup_port_id")
        except OSError as e:
            print("dllPath = {!s}".format(dllPath))
            print("filePath = {!s}".format(os.path.dirname(__file__)))
            print("dllName = {!s}".format(dll_name))
            raise e
    
    def SetTimeout(self,timeout):
        ''' Set the timeout for an FSLP command to respond with the first byte.
        Allowable range is 1 to 65535 ms. 
        Default is 1000, controlled by _default_timeout_ms.
        '''
        if timeout==abs(int(timeout )) and timeout <=65535:
            self.current_timeout_ms = timeout
        else:
            raise ValueError("timeout={} is not an integer number of milliseconds between 1-65535".format(timeout))
    
    def UnsetTimeout(self):
        ''' Set the timeout for FSLP command back to default value. '''
        if self._default_timeout_ms==abs(int(self._default_timeout_ms )) and self._default_timeout_ms <=65535:
            self.current_timeout_ms = self._default_timeout_ms
        else:
            raise ValueError("Somehow you corrupted the self._default_timeout_ms")
    
    def SendToCamera(self,ClientToCam,clientBytes,expectedReceiveBytes):
        ''' Send ClientToCam with len()=clientBytes to camera, 
        receive CamToClient with len()=camBytes
        '''
        if (not self.isClosed) and self.portOpen:
            sendBuffer = (ctypes.c_uint8*clientBytes)()
#            print("   Sent:\t{!s}".format(ClientToCam))
            for i,dat in enumerate(ClientToCam):
                sendBuffer[i] = dat
            sendBytes = ctypes.c_uint16(clientBytes)
            receiveBuffer = (ctypes.c_uint8*2048)(*[0xFF]*2048)
            receiveBytes = ctypes.c_uint16(expectedReceiveBytes)
            channel_ID = ctypes.c_uint8(0x00)
            start_byte_ms = ctypes.c_uint16(1000)
            self.camsend(ctypes.c_int32(self.port_num),channel_ID,sendBytes,sendBuffer)
            self.camread(ctypes.c_int32(self.port_num),channel_ID,start_byte_ms,ctypes.byref(receiveBytes),receiveBuffer)
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes =  bytearray(returnBuffer)
#            print("   Recd:\t{!s}".format(returnBytes))
            return returnBytes
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")
    
    def SendFrame(self,ChannelID,ClientToCam,clientBytes):
        ''' Send ClientToCam with len()=clientBytes to camera on specified Channel ID.'''
        if (not self.isClosed) and self.portOpen:
            sendBuffer = (ctypes.c_uint8*clientBytes)()
            for i,dat in enumerate(ClientToCam):
                sendBuffer[i] = dat
            sendBytes = ctypes.c_uint16(clientBytes)
            channel_ID = ctypes.c_uint8(ChannelID)
            self.camsend(ctypes.c_int32(self.port_num),channel_ID,sendBytes,sendBuffer)
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")
    
    def ReadFrame(self,ChannelID,expectedReceiveBytes):
        ''' Receive CamToClient with len()=camBytes from camera on specified Channel ID.
        self.current_timeout_ms (default 1000) will set a timeout in milliseconds (for the first byte).
        '''
        if (not self.isClosed) and self.portOpen:
            receiveBuffer = (ctypes.c_uint8*2048)(*[0xFF]*2048)
            receiveBytes = ctypes.c_uint16(expectedReceiveBytes)
            channel_ID = ctypes.c_uint8(ChannelID)
            start_byte_ms = ctypes.c_uint16(self.current_timeout_ms)
            self.camread(ctypes.c_int32(self.port_num),channel_ID,start_byte_ms,ctypes.byref(receiveBytes),receiveBuffer)
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes =  bytearray(returnBuffer)
            return returnBytes
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")
    
    def PollDebug(self, channel_ID):
        ''' Send ClientToCam with len()=clientBytes to camera, 
        receive CamToClient with len()=camBytes
        '''
        if (not self.isClosed) and self.portOpen:
            receiveBuffer = (ctypes.c_uint8*2048)(*[0xFF]*2048)
            receiveBytes = ctypes.c_uint16(0)
            channelID = ctypes.c_uint8(channel_ID)
            start_byte_ms = ctypes.c_uint16(25)
                                    #(int32_t port_num,uint8_t *channel_ID,uint32_t *receiveBytes, uint8_t *receiveBuffer);
            self.camread(ctypes.c_int32(self.port_num),channelID,start_byte_ms,ctypes.byref(receiveBytes),receiveBuffer)
            if receiveBytes.value == 0:
                return bytearray()
            
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes =  bytearray(returnBuffer)
#            print("   Recd:\t{!s}".format(returnBytes))
            return returnBytes
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")
    
    def DumpUnframed(self):
        ''' Send ClientToCam with len()=clientBytes to camera, 
        receive CamToClient with len()=camBytes
        '''
        if (not self.isClosed) and self.portOpen:
            receiveBuffer = (ctypes.c_uint8*2048)(*[0xFF]*2048)
            receiveBytes = ctypes.c_uint16(0)
            start_byte_ms = ctypes.c_uint16(25)
            self.camunframed(ctypes.c_int32(self.port_num),start_byte_ms,ctypes.byref(receiveBytes),receiveBuffer)
            if receiveBytes.value == 0:
                return bytearray()
            
            returnBuffer = []
            for i in range(receiveBytes.value):
                returnBuffer.append(receiveBuffer[i])
            returnBytes =  bytearray(returnBuffer)
#            print("   Recd:\t{!s}".format(returnBytes))
            return returnBytes
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")
    
    def close(self):
        self.isClosed = True
        del(self.__library)
        if (not "posix" in os.name): 
            _ctypes.FreeLibrary(self.__dllHandle)

    def OpenPort(self,ini_name = "CameraSerialConfig.ini",manual_port=None,manual_baud=None):
        ''' Send ClientToCam with len()=clientBytes to camera, 
        receive CamToClient with len()=camBytes
        '''
        if FOUND_INI:
            if hasattr(sys, 'frozen'):
                infolder = os.path.dirname(os.path.abspath(sys.executable))
            else:
                infolder = os.path.dirname(os.path.abspath(__file__))
            iniPath = os.path.join(infolder, ini_name)
            configDict = Factory_INIUtils.readTestCameraINI(iniPath)
    #        timeout  = int(configDict[INI_TIMEOUT])
            portname = str(configDict[INI_COM_PORT])
        else:
            if not manual_port:
                raise ValueError("Must provide manual_port=\"COM<n>\", manual_port=\"/dev/ttyACM<n>\" or manual_port=<z> argument")
        
        if manual_port is not None:
            portname = str(manual_port)
        
        try: 
            portnum = int(portname)
        except ValueError:
            portbuffer  = (ctypes.c_uint8*16)()
            for i,dat in enumerate(portname.encode('ascii')):
                portbuffer[i] = dat
            
            portnum = self.lookup_port_name(portbuffer,len(portname))
        self.port_num = portnum
        if FOUND_INI:
            baudrate = int(configDict[INI_BAUDRATE])
        else:
            baudrate = 921600
        if manual_baud:
            baudrate = int(manual_baud)
        
        print("PortNum: {:d} // {!s}\nBaudRate: {:d}".format(portnum,portname,baudrate))
#        print(configDict)
        ret = self.port_open(ctypes.c_int(portnum),ctypes.c_int(baudrate))
        if ret == 0:
            self.portOpen = True
            print("Port open")
        else:
            raise IOError("Failed to open port #{:d} with error {:d}!".format(portnum,ret))
    
    def ClosePort(self):
        self.port_close(ctypes.c_int32(self.port_num))


import serial,time
#import pdb

def debugprint(*args,**kwargs):
    #print(*args, **kwargs)
    return

class PyUART():
    def __init__(self):
        self.isClosed = False
        self.portOpen = False
        self.port_num = -1
        self.port = None
        self.readTimeout = 5
        self.FRAME_BUF_SIZ = 4000
        self.START_FRAME_BYTE = bytes([0x8E])
        self.ESCAPE_BYTE = bytes([0x9E])
        self.END_FRAME_BYTE = bytes([0xAE])
        self.ESCAPED_START_FRAME_BYTE = bytes([0x81])
        self.ESCAPED_ESCAPE_BYTE = bytes([0x91])
        self.ESCAPED_END_FRAME_BYTE = bytes([0xA1])
        self.g_frame_buf = bytearray()
        self.ccitt_16Table = [
            0x0000, 0x1021, 0x2042, 0x3063, 0x4084, 0x50A5, 0x60C6, 0x70E7,
            0x8108, 0x9129, 0xA14A, 0xB16B, 0xC18C, 0xD1AD, 0xE1CE, 0xF1EF,
            0x1231, 0x0210, 0x3273, 0x2252, 0x52B5, 0x4294, 0x72F7, 0x62D6,
            0x9339, 0x8318, 0xB37B, 0xA35A, 0xD3BD, 0xC39C, 0xF3FF, 0xE3DE,
            0x2462, 0x3443, 0x0420, 0x1401, 0x64E6, 0x74C7, 0x44A4, 0x5485,
            0xA56A, 0xB54B, 0x8528, 0x9509, 0xE5EE, 0xF5CF, 0xC5AC, 0xD58D,
            0x3653, 0x2672, 0x1611, 0x0630, 0x76D7, 0x66F6, 0x5695, 0x46B4,
            0xB75B, 0xA77A, 0x9719, 0x8738, 0xF7DF, 0xE7FE, 0xD79D, 0xC7BC,
            0x48C4, 0x58E5, 0x6886, 0x78A7, 0x0840, 0x1861, 0x2802, 0x3823,
            0xC9CC, 0xD9ED, 0xE98E, 0xF9AF, 0x8948, 0x9969, 0xA90A, 0xB92B,
            0x5AF5, 0x4AD4, 0x7AB7, 0x6A96, 0x1A71, 0x0A50, 0x3A33, 0x2A12,
            0xDBFD, 0xCBDC, 0xFBBF, 0xEB9E, 0x9B79, 0x8B58, 0xBB3B, 0xAB1A,
            0x6CA6, 0x7C87, 0x4CE4, 0x5CC5, 0x2C22, 0x3C03, 0x0C60, 0x1C41,
            0xEDAE, 0xFD8F, 0xCDEC, 0xDDCD, 0xAD2A, 0xBD0B, 0x8D68, 0x9D49,
            0x7E97, 0x6EB6, 0x5ED5, 0x4EF4, 0x3E13, 0x2E32, 0x1E51, 0x0E70,
            0xFF9F, 0xEFBE, 0xDFDD, 0xCFFC, 0xBF1B, 0xAF3A, 0x9F59, 0x8F78,
            0x9188, 0x81A9, 0xB1CA, 0xA1EB, 0xD10C, 0xC12D, 0xF14E, 0xE16F,
            0x1080, 0x00A1, 0x30C2, 0x20E3, 0x5004, 0x4025, 0x7046, 0x6067,
            0x83B9, 0x9398, 0xA3FB, 0xB3DA, 0xC33D, 0xD31C, 0xE37F, 0xF35E,
            0x02B1, 0x1290, 0x22F3, 0x32D2, 0x4235, 0x5214, 0x6277, 0x7256,
            0xB5EA, 0xA5CB, 0x95A8, 0x8589, 0xF56E, 0xE54F, 0xD52C, 0xC50D,
            0x34E2, 0x24C3, 0x14A0, 0x0481, 0x7466, 0x6447, 0x5424, 0x4405,
            0xA7DB, 0xB7FA, 0x8799, 0x97B8, 0xE75F, 0xF77E, 0xC71D, 0xD73C,
            0x26D3, 0x36F2, 0x0691, 0x16B0, 0x6657, 0x7676, 0x4615, 0x5634,
            0xD94C, 0xC96D, 0xF90E, 0xE92F, 0x99C8, 0x89E9, 0xB98A, 0xA9AB,
            0x5844, 0x4865, 0x7806, 0x6827, 0x18C0, 0x08E1, 0x3882, 0x28A3,
            0xCB7D, 0xDB5C, 0xEB3F, 0xFB1E, 0x8BF9, 0x9BD8, 0xABBB, 0xBB9A,
            0x4A75, 0x5A54, 0x6A37, 0x7A16, 0x0AF1, 0x1AD0, 0x2AB3, 0x3A92,
            0xFD2E, 0xED0F, 0xDD6C, 0xCD4D, 0xBDAA, 0xAD8B, 0x9DE8, 0x8DC9,
            0x7C26, 0x6C07, 0x5C64, 0x4C45, 0x3CA2, 0x2C83, 0x1CE0, 0x0CC1,
            0xEF1F, 0xFF3E, 0xCF5D, 0xDF7C, 0xAF9B, 0xBFBA, 0x8FD9, 0x9FF8,
            0x6E17, 0x7E36, 0x4E55, 0x5E74, 0x2E93, 0x3EB2, 0x0ED1, 0x1EF0
        ]

    def ByteCRC16(self, value, crcin):
        bottom_byte = (crcin << 8) & 0xFFFF
        top_byte = (crcin >> 8) & 0xFFFF
        value = value & 0xFF
        tbl_index = top_byte ^ value & 0xFF
        crcout = bottom_byte ^ self.ccitt_16Table[tbl_index]
        return crcout

    def CalcCRC16Bytes(self, count, buffer):
        crc = 0x1d0f
        if (not isinstance(buffer, bytes) and not isinstance(buffer, bytearray)):
            raise Exception("Type error in CalcCRC16Bytes")
        for cur_byte in buffer[:count]:
            crc = self.ByteCRC16(cur_byte, crc)
        return crc

    def SetTimeout(self,timeout):
        ''' Set the timeout for an FSLP command to respond with the first byte.
        Allowable range is 1 to 65535 ms. 
        Default is 1000, controlled by _default_timeout_ms.
        '''
        print("Timeouts not supported in pyUART. yet...")

    def UnsetTimeout(self):
        ''' Set the timeout for FSLP command back to default value. '''
        print("Timeouts not supported in pyUART. yet...")

    def SendToCamera(self,ClientToCam,clientBytes,expectedReceiveBytes):
        raise Exception("SendToCamera not currently implemented for PyUART")

    def SendFrame(self,ChannelID,payload,clientBytes):
        ''' Send ClientToCam with len()=clientBytes to camera,
        receive CamToClient with len()=camBytes
        '''
        if ((not self.isClosed) and (self.portOpen)):
            # Calculate and tack on the CRC for the payload (un-escaped)
            temppayload = bytearray([ChannelID])
            temppayload.extend(payload)
            payload_crc = self.CalcCRC16Bytes(len(temppayload), temppayload)
            # print("CRC = 0x{:04x}".format(payload_crc))
            temppayload.extend([(payload_crc >> 8) & 0xff])
            temppayload.extend([payload_crc & 0xff])

            packet = bytearray()
            packet.extend(self.START_FRAME_BYTE)
            for i in range(0, len(temppayload)):
                if (temppayload[i] == self.START_FRAME_BYTE[0]):
                    packet.extend(self.ESCAPE_BYTE)
                    packet.extend(self.ESCAPED_START_FRAME_BYTE)
                elif (temppayload[i] == self.END_FRAME_BYTE[0]):
                    packet.extend(self.ESCAPE_BYTE)
                    packet.extend(self.ESCAPED_END_FRAME_BYTE)
                elif (temppayload[i] == self.ESCAPE_BYTE[0]):
                    packet.extend(self.ESCAPE_BYTE)
                    packet.extend(self.ESCAPED_ESCAPE_BYTE)
                else:
                    packet.extend([temppayload[i]])

            packet.extend(self.END_FRAME_BYTE)
            debugprint("sending " + str(len(packet)) + " bytes:" + " ".join(map(lambda b: format(b, "02x"), packet)))
            self.port.write(packet)
            # self.port.flush()
        else:
            raise Exception("Attempting to access closed DLL or closed COM port!")

    def ReadFrame(self,ChannelID,expectedReceiveBytes):
        ''' Send ClientToCam with len()=clientBytes to camera,
        receive CamToClient with len()=camBytes
        '''
        unframedBytes = bytearray()
        packet = bytearray()
        inFrame = False
        if (not self.isClosed) and self.port.isOpen():
            startTime = time.time()
            while True :
                byte = self.port.read(1)
                debugprint("Read a byte " + str(byte))
                if ((time.time() - startTime) > self.readTimeout):
                    raise Exception("Timed out in PyUART ReadFrame")
                if (byte == self.START_FRAME_BYTE):
                    debugprint("inframe")
                    inFrame = True
                    continue
                if (inFrame):
                    if (byte == self.ESCAPE_BYTE):
                        byte = self.port.read(1)
                        if (byte == self.ESCAPED_START_FRAME_BYTE):
                            packet.extend(self.START_FRAME_BYTE)
                        elif (byte == self.ESCAPED_END_FRAME_BYTE):
                            packet.extend(self.END_FRAME_BYTE)
                        elif (byte == self.ESCAPED_ESCAPE_BYTE):
                            packet.extend(self.ESCAPE_BYTE)
                        else:
                            raise Exception("Packet corrupt.  Improperly escaped bytes encountered.")
                    elif (byte == self.END_FRAME_BYTE):
                        debugprint("endframe")
                        break
                    else:
                        packet.extend(byte)
                else:
                    unframedBytes.extend(byte)
            debugprint("received " + str(len(packet)) + " bytes:" + " ".join(map(lambda b: format(b, "02x"), packet)))
            packetCRC = self.CalcCRC16Bytes( (len(packet) - 2), packet)
            packetCRC = bytes([packetCRC>>8, packetCRC&0x00FF])
            if (packetCRC == packet[-2:]):
                #if (payload[0] != ChannelID):
                #    raise Exception("Response for wrong channel received.")
                #if ((len(payload) - 3) != expectedReceiveBytes):
                #    raise Exception("Did not receive expected number of bytes.")
                returnBytes = packet[1:-2]  # No start byte, no end byte, no channel id, and no CRC
                return returnBytes
            else:
                raise Exception("Packet corrupt.  CRC doesn't match expected.")
        else:
            raise Exception("Attempting write to unopened PyUART")

    def PollDebug(self, channel_ID):
        ''' Send ClientToCam with len()=clientBytes to camera,
        receive CamToClient with len()=camBytes
        '''
        raise Exception("PollDebug not currently implemented for PyUART")

    def DumpUnframed(self):
        ''' Send ClientToCam with len()=clientBytes to camera,
        receive CamToClient with len()=camBytes
        '''
        raise Exception("DumpUnframed not currently implemented for PyUART")

    def close(self):
        self.isClosed = True
        self.ClosePort()

    def OpenPort(self,ini_name = "CameraSerialConfig.ini",manual_port=None,manual_baud=None):
        ''' Send ClientToCam with len()=clientBytes to camera,
        receive CamToClient with len()=camBytes
        '''
        if FOUND_INI:
            if hasattr(sys, 'frozen'):
                infolder = os.path.dirname(os.path.abspath(sys.executable))
            else:
                infolder = os.path.dirname(os.path.abspath(__file__))
            iniPath = os.path.join(infolder, ini_name)
            configDict = Factory_INIUtils.readTestCameraINI(iniPath)
            #        timeout  = int(configDict[INI_TIMEOUT])
            portname = str(configDict[INI_COM_PORT])
        else:
            if not manual_port:
                raise ValueError("Must provide manual_port=\"COM<n>\" or manual_port=<n-1> argument")

        if manual_port is not None:
            portname = str(manual_port)


        if "COM" in portname:
            portnum = int(portname.replace("COM",""))-1
            self.portname = portname
        else:
            portnum = int(portname)
            self.portname = "COM" + str(portnum + 1 )
        self.port_num = portnum
        if FOUND_INI:
            baudrate = int(configDict[INI_BAUDRATE])
        else:
            baudrate = 921600
        if manual_baud:
            baudrate = int(manual_baud)

        print("PortNum: {:d} // {!s}\nBaudRate: {:d}".format(portnum,portname,baudrate))
        #        print(configDict)
        self.port = serial.Serial()
        self.port.port = str(self.portname)
        self.port.baudrate = baudrate
        self.port.parity = 'N'
        self.port.stopbits = 1
        self.port.bytesize = 8
        self.port.timeout = 10
        self.port.open()
        self.portOpen = self.port.isOpen()

        if (self.portOpen):
            print("Port open")
        else:
            raise IOError("Failed to open COM port {:d}!".format(ret))

    def ClosePort(self):
        self.port.close()

