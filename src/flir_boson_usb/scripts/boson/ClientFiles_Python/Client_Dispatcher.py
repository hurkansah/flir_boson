#  /////////////////////////////////////////////////////
#  // DO NOT EDIT.  This is a machine generated file. //
#  /////////////////////////////////////////////////////


from .Serializer_BuiltIn import UINT_32ToByte, byteToUINT_32
from .ReturnCodes import FLR_RESULT
from .EnumTypes import *
import os

def CLIENT_dispatch(seqNum, fnID, sendData, sendBytes, expectedReceiveBytes, fslp):
    # Allocate buffer with extra space for payload header
    sendPayload = bytearray(sendBytes+12)
    pyldPtr = 0
    
    # Write sequence number to first 4 bytes
    UINT_32ToByte(seqNum, sendPayload, pyldPtr)
    pyldPtr += 4
    
    # Write function ID to second 4 bytes
    UINT_32ToByte(fnID, sendPayload, pyldPtr)
    pyldPtr += 4
    
    # Write 0xFFFFFFFF to third 4 bytes
    UINT_32ToByte(0xFFFFFFFF, sendPayload, pyldPtr)
    pyldPtr += 4
    
    # Copy sendData to payload buffer
    for byte in sendData:
        sendPayload[pyldPtr] = byte
        pyldPtr += 1
    
    SendToCamera = fslp.sendToCamera
    SendFrame = fslp.sendFrame
    ReadFrame = fslp.readFrame
    CommandChannel = 0x00
    #receivePayload = SendToCamera(sendPayload,sendBytes+12,expectedReceiveBytes+12)
    SendFrame(CommandChannel,sendPayload,sendBytes+12)
    inPtr = 0
    for i in range(2):
        inPtr = 0
        receivePayload = ReadFrame(CommandChannel,expectedReceiveBytes+12)
        if len(receivePayload)<12:
            if (i==0):
                print("Empty or partial payload!\nretrying read.....")
                continue
            else:
                return FLR_RESULT.R_UART_RECEIVE_TIMEOUT,None
        
        
        # Evaluate sequence bytes as UINT_32
        returnSequence = byteToUINT_32(receivePayload,inPtr)
        inPtr += 4
        
        # Ensure that received sequence matches sent sequence
        if(returnSequence != seqNum):
            print("Expected seq: 0x{:08X}, rec'd seq: 0x{:08X}".format(seqNum, returnSequence))
            print(str(receivePayload))
            if (i==0):
                print("retrying read....")
                continue
            else:
                return (FLR_RESULT.R_SDK_DSPCH_SEQUENCE_MISMATCH, None)
        else: #sequence okay
            break
        
    # Evaluate CMD ID bytes as UINT_32 
    cmdID = byteToUINT_32( receivePayload, inPtr)
    inPtr += 4
    
    # Ensure that received CMD ID matches sent CMD ID
    if(cmdID != fnID):
        return FLR_RESULT.R_SDK_DSPCH_ID_MISMATCH, None
    
    # Evaluate Payload Status bytes as UINT_32
    pyldStatus = byteToUINT_32( receivePayload, inPtr)
    if pyldStatus!=0:
        print("payload status = {0:d} = 0x{0:08X}".format(pyldStatus))
    inPtr += 4
    
    try:
        returnCode = FLR_RESULT(pyldStatus)
    except ValueError:
        returnCode = FLR_RESULT.R_SDK_DSPCH_MALFORMED_STATUS
    # Check for any errorcode
    if(returnCode.value):
        return returnCode, None
    
    
    # Now have Good Tx, Good Sequence, Good CMD ID, and Good Status.
    # inPtr at Data block, fill receiveData buffer with outPtr
    return returnCode, receivePayload[inPtr:inPtr+expectedReceiveBytes]
# End CLIENT_dispatch()
