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
	public class ClientDispatcher {
		internal static Camera.FLR_RESULT dispatcher(Camera parent, UInt32 seqNum, Camera.FLR_FUNCTION fnID, Byte[] sendData, UInt32 sendBytes, Byte[] receiveData, ref UInt32 receiveBytes) {
			
			UInt32 i;
			
			// Allocated buffer with extra space for payload header
			Byte[] sendPayload = new Byte[530];
			UInt16 pyldPtr = 0;
			
			// Write sequence number to first 4 bytes
			Camera.UINT_32ToByte(seqNum, sendPayload, pyldPtr);
			pyldPtr += 4;
			
			// Write function ID to second 4 bytes
			Camera.UINT_32ToByte((UInt32)fnID, sendPayload, pyldPtr);
			pyldPtr += 4;
			
			// Write 0xFFFFFFFF to third 4 bytes
			Camera.UINT_32ToByte(0xFFFFFFFF, sendPayload, pyldPtr);
			pyldPtr += 4;
			
			// Copy sendData to payload buffer
			UInt16 dataPtr = 0;
			if (sendBytes>0){
				for(i = 0;i<sendBytes;i++) {
					sendPayload[pyldPtr++] = sendData[dataPtr++];
				}
			}
			
			// Allocated buffer with extra space for return data
			Byte[] receivePayload = new Byte[530];
			UInt16 inPtr = 0;
			
			receiveBytes=12;
			byte CommandChannel=0x00;
			parent.SendToCamera(CommandChannel,sendBytes+12,sendPayload);//,ref receiveBytes,receivePayload);
			
			for (i=0;i<2;i++){
				inPtr = 0;
				parent.ReadFrame(CommandChannel,ref receiveBytes,receivePayload);
				if (receiveBytes<12){
					if (i==0) {
						Console.WriteLine("Empty or partial payload!\nretrying read.....");
						continue;
					} else {
						return Camera.FLR_RESULT.R_UART_RECEIVE_TIMEOUT;
					}
				}
				
				// Evaluate sequence bytes as UINT_32
				UInt32 returnSequence = Camera.byteToUINT_32( receivePayload, inPtr);
				inPtr += 4;
				
				// Ensure that received sequence matches sent sequence
				if(returnSequence != seqNum) {
					Console.WriteLine("Expected seq: 0x{0:X08}, rec'd seq: 0x{1:X08}",seqNum, returnSequence);
					if (i==0){
						Console.WriteLine("retrying read....");
						continue;
					} else {
						return Camera.FLR_RESULT.R_SDK_DSPCH_SEQUENCE_MISMATCH;
					}
				} else { // sequence okay
					break;
				}
			} // end retry loop
			
			// Evaluate CMD ID bytes as UINT_32 
			UInt32 cmdID = Camera.byteToUINT_32( receivePayload, inPtr);
			inPtr += 4;
			
			// Ensure that received CMD ID matches sent CMD ID
			if(cmdID != (UInt32) fnID){
				return Camera.FLR_RESULT.R_SDK_DSPCH_ID_MISMATCH;
			}
			
			// Evaluate Payload Status bytes as UINT_32
			UInt32 pyldStatus = Camera.byteToUINT_32( receivePayload, inPtr);
			inPtr += 4;
			
			Camera.FLR_RESULT returncode = (Camera.FLR_RESULT) pyldStatus;
			// Check for any errorcode
			if(returncode != Camera.FLR_RESULT.R_SUCCESS){
				return returncode;
			}
			
			// Now have Good Tx, Good Sequence, Good CMD ID, and Good Status.
			// inPtr at Data block, fill receiveData buffer with outPtr
			UInt16 outPtr = 0;
			// decrement receiveBytes by 12 (len of header bytes)
			receiveBytes-=12;
			
			if (receiveBytes>0){
				for(outPtr=0;outPtr<receiveBytes;outPtr++) {
					receiveData[outPtr] = receivePayload[inPtr++];
				}
			}
			
			return Camera.FLR_RESULT.R_SUCCESS;
		} // End dispatcher()

	} // End class ClientDispatcher
} // End of namespace Boson
