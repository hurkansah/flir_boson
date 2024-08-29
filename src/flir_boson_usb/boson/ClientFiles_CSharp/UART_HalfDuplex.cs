
/******************************************************************************/
/*                                                                            */
/*  Copyright (C) 2015, FLIR Systems                                          */
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

//#define VERBOSE_PRINT
//#define DEBUGPRINT

using System;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using Boson;

namespace Boson {

//Conditionally define console print debug class because it's not production validated
#if DEBUGPRINT || VERBOSE_PRINT
	/// <summary>
	/// Hefty dosage of magic numbers and dark wizardry from the internet
	/// Allows for this DLL or subassembly to spawn a console
	/// Undoes visual studio magic redirection so that Console.WriteLine(...) 
	/// goes to the new console instead of to a nonexistent debugger window.
	/// </summary>
	internal static class NativeMethods
	{
		public const int STDOUT_MAGIC_NUMBER = -11;

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetStdHandle(int nStdHandle);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool SetStdHandle(int nStdHandle, IntPtr hHandle);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFile([MarshalAs(UnmanagedType.LPTStr)] string filename,
												[MarshalAs(UnmanagedType.U4)]     uint access,
												[MarshalAs(UnmanagedType.U4)]     FileShare share,
																				 IntPtr securityAttributes,
												[MarshalAs(UnmanagedType.U4)]     FileMode creationDisposition,
												[MarshalAs(UnmanagedType.U4)]     FileAttributes flagsAndAttributes,
																				 IntPtr templateFile);

		public const uint GENERIC_WRITE = 0x40000000;
		public const uint GENERIC_READ = 0x80000000;

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int FreeConsole();

		internal static void OverrideRedirection()
		{
			var hOut = GetStdHandle(STDOUT_MAGIC_NUMBER);
			var hRealOut = CreateFile("CONOUT$", GENERIC_READ | GENERIC_WRITE, FileShare.Write, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
			if (hRealOut != hOut)
			{
				SetStdHandle(STDOUT_MAGIC_NUMBER, hRealOut);
				Console.SetOut(new StreamWriter(Console.OpenStandardOutput(), Console.OutputEncoding) { AutoFlush = true });
			}
		}
	}
#endif // DEBUGPRINT or VERBOSE_PRINT

	partial class Camera{
		
		private SerialPort myUART = null;
		private FLR_SLP myFSLP = null;
		private FLR_SLP.CHANNEL_T chan_ptr,unframed_ptr;
		private UInt16 current_timeout_ms = 2000;
		public void Initialize(string PortName, UInt32 BaudRate){
#if DEBUGPRINT || VERBOSE_PRINT
			NativeMethods.AllocConsole();
			NativeMethods.OverrideRedirection();
			Console.WriteLine("Debug Console, PORT {0} ...",PortName);
#endif
			myUART = new SerialPort(PortName,(Int32)BaudRate,Parity.None, 8, StopBits.One);
			//myUART.Encoding = System.Text.UTF8Encoding;
			myUART.Open();
			if (!myUART.IsOpen){
				throw new System.IO.IOException("Port initialization failed!");
			}
			myFSLP = new FLR_SLP();
			myFSLP.initialize_channels();
			int _ignore = myFSLP.get_channel(0x00, ref chan_ptr);
			myFSLP.get_unframed(ref unframed_ptr);
		}
		public void Close(){
			myUART.Close();
			myUART.Dispose();
#if DEBUGPRINT || VERBOSE_PRINT
			NativeMethods.FreeConsole();
#endif
		}
		public void SendToCamera(byte channel_ID,UInt32 clientBytes,byte[] ClientToCam){ //,ref UInt32 ReceiveBytes,byte[] CamToClient){
			if (myUART.IsOpen){
				myFSLP.send_to_camera(myUART,channel_ID,clientBytes,ClientToCam);//, ref ReceiveBytes, CamToClient);
			} else {
				throw new System.IO.IOException("Attempting to access closed COM port!");
			}
		}
		
		public void ReadFrame(byte channel_ID,ref UInt32 ReceiveBytes,byte[] CamToClient){
			if (myUART.IsOpen){
				myFSLP.read_frame(myUART,channel_ID,current_timeout_ms, ref ReceiveBytes, CamToClient);
			} else {
				throw new System.IO.IOException("Attempting to access closed COM port!");
			}
		}
		
		public void ReadUnframed(byte channel_ID,ref UInt32 ReceiveBytes,byte[] CamToClient){
			if (myUART.IsOpen){
				myFSLP.read_unframed(myUART,channel_ID,100, ref ReceiveBytes, CamToClient);
			} else {
				throw new System.IO.IOException("Attempting to access closed COM port!");
			}
		}
		
		public void GetTimeoutMs(out Int32 timeout){
			if (myUART.IsOpen){
				timeout = current_timeout_ms;
			} else {
				throw new System.IO.IOException("Attempting to access closed COM port!");
			}
		}
		public void SetTimeoutMs(Int32 timeout){
			
			if (myUART.IsOpen){
				if ((timeout <= 0) || (timeout > 60*1000)) { 
					throw new ArgumentOutOfRangeException("Timeout accepts values from 1 to 60,000ms.");
				} else {
					current_timeout_ms = (UInt16)timeout;
				}
			} else {
				throw new System.IO.IOException("Attempting to access closed COM port!");
			}
		}
	} // end partial class Camera
	
	internal class FLR_SLP{
		const byte ESCAPE_BYTE 	    	= 0x9E;
		const byte START_FRAME_BYTE 	= 0x8E;
		const byte END_FRAME_BYTE 		= 0xAE;
		const byte ESCAPED_ESCAPE_BYTE 	    	= 0x91;
		const byte ESCAPED_START_FRAME_BYTE 	= 0x81;
		const byte ESCAPED_END_FRAME_BYTE 		= 0xA1;

		const Int32 FRAME_BUF_SIZ 		= 2048;

		const Int32 FRAME_TIMEOUT_MSEC	= 2000;
		const Int32 POLL_TIMEOUT_MSEC	= 25;
		const Int32 BYTE_TIMEOUT_MSEC	= 5;

		const Int32 FRAME_START_IDX 	= 1;
		const Int32 NUM_FRAMING_BYTES 	= 3;
		const Int32 CRC_START_IDX  		= 0;
		
		byte[] in_frame_buf =  new byte[FRAME_BUF_SIZ];
		byte[] out_frame_buf =  new byte[FRAME_BUF_SIZ];
		
		const UInt16 CHANNEL_BUF_SIZ = 32000;
		
		public class CHANNEL_T {
			public byte channel { get; set; }
			public UInt16 start { get; set; }
			public UInt16 len { get; set; }
			public byte[] buff { get; set; }
		};
		
		private enum FRAME_STATUS {
			UNFRAMED = 0,
			CORRECT_FRAME = 1,
			OTHER_FRAME = 2,
		};

		FRAME_STATUS am_in_frame;
		byte other_frame_ID = 0x00;
		
		byte is_initialized = 0;
		
		const byte NUM_CHANNELS = 4;

		CHANNEL_T[] channel_list = new CHANNEL_T[NUM_CHANNELS];
		CHANNEL_T chan_ptr, unframed_ptr;
		
		System.Diagnostics.Stopwatch systimer = new System.Diagnostics.Stopwatch();
		
		
		public void initialize_channels(){
			if (is_initialized == 0 ) 
			{
				CHANNEL_T chan_ptr;
				channel_list[0] = new CHANNEL_T();
				chan_ptr = channel_list[0];
				chan_ptr.channel = 0x00; // unframed "channel" always slot 0
				chan_ptr.len = 0;
				chan_ptr.start = 0;
				chan_ptr.buff = new byte[CHANNEL_BUF_SIZ];
				channel_list[1] = new CHANNEL_T();
				chan_ptr = channel_list[1];
				chan_ptr.channel = 0x00; // command channel
				chan_ptr.len = 0;
				chan_ptr.start = 0;
				chan_ptr.buff = new byte[CHANNEL_BUF_SIZ];
				channel_list[2] = new CHANNEL_T();
				chan_ptr = channel_list[2];
				chan_ptr.channel = 0x99; // "0x99" debug channel
				chan_ptr.len = 0;
				chan_ptr.start = 0;
				chan_ptr.buff = new byte[CHANNEL_BUF_SIZ];
				channel_list[3] = new CHANNEL_T();
				chan_ptr = channel_list[3];
				chan_ptr.channel = 0x63; // "99" alt debug channel
				chan_ptr.len = 0;
				chan_ptr.start = 0;
				chan_ptr.buff = new byte[CHANNEL_BUF_SIZ];
				
				is_initialized = 1;
			}
		}
		
		public void get_unframed(ref CHANNEL_T return_channel){
			return_channel = channel_list[0];
			return;
		}
		
		public Int16 get_channel(byte channel_ID, ref CHANNEL_T return_channel){
			Int16 i;
			for (i=1;i<NUM_CHANNELS;i++){
				if (channel_ID == channel_list[i].channel){
					return_channel = channel_list[i];
					return channel_ID;
				}
			}
			return -1;
		}		
		
		public void add_byte(byte inbyte, CHANNEL_T channel_ptr){
			UInt32 index;
			UInt16 start = (channel_ptr.start);
			if (channel_ptr.len != CHANNEL_BUF_SIZ){
				index = (UInt32) start + channel_ptr.len;
				(channel_ptr.buff)[index] = inbyte;
				(channel_ptr.len)++;
			} else {
				channel_ptr.buff[start] = inbyte;
				channel_ptr.start = (UInt16) ((start + 1) % CHANNEL_BUF_SIZ);
			}
		}
		
		public Int32 get_byte(out byte outbyte, CHANNEL_T channel_ptr){
			//return remaining length if success, -1 if channel already empty
			if (channel_ptr.len == 0) {
				outbyte = 0x00;
				return -1;
			} else {
				outbyte = (channel_ptr.buff)[(channel_ptr.start)];
				(channel_ptr.start)++;
				return --(channel_ptr.len);
			}
		}
		
		
		Int32 read_byte(SerialPort comport)
		{
			//set timeout in milliseconds
			comport.ReadTimeout = BYTE_TIMEOUT_MSEC;
			Int32 returnval;
			try
			{
				returnval = comport.ReadByte();
			}
			catch (TimeoutException)
			{
				returnval = -1;
			}
			return returnval ;
		}

		private Boolean check_timeouts(Int64 curr_ms, UInt16 timeout, UInt32 timeout2)
		{
			return ((curr_ms >= timeout) || (curr_ms >= timeout2));
		}

		public void read_frame(SerialPort comport,byte channel_ID,UInt16 start_byte_ms, ref UInt32 receiveBytes, byte[] receiveBuffer)
		{
			Int32 byte_idx = 0;
			Int32 tempval = 0;
			byte c,found_complete_frame=0, in_escape=0;
			UInt16 calc_crc =0x1D0F;
			UInt16 timeout = start_byte_ms;
			UInt32 max_timeout = (UInt32)start_byte_ms + (UInt32)FRAME_TIMEOUT_MSEC;
#if DEBUGPRINT
			Console.WriteLine("Read Timeout = {0} ms", timeout);
#endif
			tempval = get_channel(channel_ID, ref chan_ptr);
			get_unframed(ref unframed_ptr);

			if (tempval > 0 && chan_ptr.len > 0){
#if VERBOSE_PRINT
				int i,j;
				Console.Write("POLL buffer start = {0}, len = {1} \n",chan_ptr.start,chan_ptr.len);
				Console.Write("current buffer[20] : ");
				for (j=0; j<20; j++){
					i = ( (chan_ptr.start + j ) % CHANNEL_BUF_SIZ);
					Console.Write(" {0:X02}",chan_ptr.buff[i]);
				}
				Console.Write("\n");
#endif
				while(chan_ptr.len > 0){
					tempval = get_byte(out c,chan_ptr);
					if (tempval < 0){
						break;
					}
					if (c == START_FRAME_BYTE)
					{	
#if VERBOSE_PRINT || DEBUGPRINT
						Console.Write("     POLL_RX_BUF StartByte \n ");
#endif
						timeout = FRAME_TIMEOUT_MSEC;
						byte_idx = 0;
						am_in_frame = FRAME_STATUS.CORRECT_FRAME;
						continue;
					}
					if (am_in_frame != FRAME_STATUS.UNFRAMED) {
						
						if (c == ESCAPE_BYTE)
						{
							in_escape = 1;
							tempval = get_byte(out c,chan_ptr);
							if (tempval < 0){
								break;
							}
							switch (c)
							{
								case ESCAPED_END_FRAME_BYTE:
									c = END_FRAME_BYTE;
									break;
								case ESCAPED_START_FRAME_BYTE:
									c = START_FRAME_BYTE;
									break;
								case ESCAPED_ESCAPE_BYTE:
									c = ESCAPE_BYTE;
									break;
								default:
									break;
							}
							in_frame_buf[byte_idx++] = c;
#if VERBOSE_PRINT
							Console.Write(" {0:X02}",c);
#endif
							continue;
						}

						if (c == END_FRAME_BYTE)
						{
							am_in_frame = FRAME_STATUS.UNFRAMED;
							/*
							 * Check CRC: if good end loop.  If bad, start looking for start byte.
							 * Check Frame Status:  If zero, end loop.  If non-zero, start looking for start byte.
							 */
							 
							/*
							 * byte_idx - 3 = total frame length - channel_ID byte - crc_bytes[2]
							 * &(frame_buf[1]) is first byte after channel_ID byte
							 */
							calc_crc = calcFlirCRC16Bytes((UInt32)(byte_idx - 2), CRC_START_IDX,in_frame_buf);

							if ( (((calc_crc >> 8) &0xFF) != in_frame_buf[byte_idx - 2]) || ((calc_crc &0xFF) != in_frame_buf[byte_idx - 1]) )
							{
								Console.Write("\nFailed packet integrity check (calc) {0:X02}{1:X02} !=  (recd) {2:X02}{3:X02}\n",((calc_crc >> 8) &0xFF),(calc_crc&0xFF),in_frame_buf[byte_idx - 2],in_frame_buf[byte_idx - 1]);
								Console.Write("RAW Receive Packet: ");
								for (tempval=0;tempval<byte_idx;tempval++){
									Console.Write(" {0:X02}",in_frame_buf[tempval]);
								}
								Console.Write("\n");
								// Console.Write("     Failed time %f:\n",elapsed_sec);
								// failedcrc = 1;
								byte_idx = 0;
								
								timeout=start_byte_ms;
								continue;
							}
#if VERBOSE_PRINT
							else {
								Console.Write("\n");
							}
#endif
							found_complete_frame = 1;
							break;
						}
						
						in_frame_buf[byte_idx++] = c;
#if VERBOSE_PRINT
						Console.Write(" {0:X02}",c);
#endif
						continue;
					}
				}
			}
			
			if (found_complete_frame != 0) {
#if VERBOSE_PRINT || DEBUGPRINT
				Console.Write("Found Complete Frame in channel_buf_{0:G02}\n",chan_ptr.channel);
				Console.Write("current buffer start = {0}, len = {1} \n",chan_ptr.start,chan_ptr.len);
#endif
				extract_payload(in_frame_buf,FRAME_START_IDX, (UInt32)(byte_idx - NUM_FRAMING_BYTES), receiveBuffer, ref receiveBytes);
				return;
			} 
#if VERBOSE_PRINT
			Console.Write("Entering serial loop...\n");
#endif
			
			systimer.Restart();
			while(true)
			{
				if (byte_idx == FRAME_BUF_SIZ)
				{
					// Buffer overrun
					receiveBytes = 0;
					return;
				}

				
				if (check_timeouts(systimer.ElapsedMilliseconds, timeout, max_timeout))
				{
					if (am_in_frame == FRAME_STATUS.CORRECT_FRAME) {
						Console.Write("ReadFrameTimeout after: {0} ms\n",systimer.ElapsedMilliseconds);
						Console.Write("partial rx frame[{0}] : ",byte_idx);
						for (tempval=0; tempval<byte_idx; tempval++){
							Console.Write(" {0:X02}",in_frame_buf[tempval]);
						}
						Console.Write("\n");
					} else {
#if VERBOSE_PRINT || DEBUGPRINT
						Console.Write("Timed out after {0} ms, waited {1} ms\n",systimer.ElapsedMilliseconds,timeout);
#endif
					}
					am_in_frame = FRAME_STATUS.UNFRAMED;
					receiveBytes =  0;
					return;
				} 
				
				if ((in_escape!=0) && (am_in_frame==FRAME_STATUS.CORRECT_FRAME)){
					//carryover escape character from buffer
					tempval = ESCAPE_BYTE;
				} else {
					tempval = read_byte(comport);
				}
				
				if (tempval<0) {
//#if VERBOSE_PRINT
//					Console.Write("ReadByteTimeout: {0}\n",systimer.ElapsedMilliseconds);
//#endif
					continue; //byte read timeout.
				} else {
					c = (byte) tempval;
				}
				
				if ((c & 0xFF) == (START_FRAME_BYTE & 0xFF))
				{
#if VERBOSE_PRINT || DEBUGPRINT
					Console.Write("     StartByte time {0}:\n     ",systimer.ElapsedMilliseconds/1000.0);
#endif
					byte_idx = 0;
					timeout = (UInt16)(FRAME_TIMEOUT_MSEC + systimer.ElapsedMilliseconds);
					// frame_buf[byte_idx++] = c;
					do {
						if (check_timeouts(systimer.ElapsedMilliseconds, timeout, max_timeout)) continue;
						tempval = read_byte(comport);
					} while (tempval < 0);
					c = (byte) (tempval & 0xFF);
					
					byte needs_escape = 0;
					if (c == ESCAPE_BYTE){
						needs_escape = 1;
						do {
							if (check_timeouts(systimer.ElapsedMilliseconds, timeout, max_timeout)) continue;
							tempval = read_byte(comport);
						} while (tempval < 0);
						c = (byte) (tempval & 0xFF);
					}
					
					if (c == channel_ID) {
						//found correct frame
						am_in_frame = FRAME_STATUS.CORRECT_FRAME;
						in_frame_buf[byte_idx++] = c;
					} else {
						am_in_frame = FRAME_STATUS.OTHER_FRAME;
						other_frame_ID = c;
						tempval = get_channel(other_frame_ID, ref chan_ptr);
						if (tempval < 0){
							chan_ptr = unframed_ptr;
							am_in_frame = FRAME_STATUS.UNFRAMED;
						}
						add_byte(START_FRAME_BYTE,chan_ptr);
						if(needs_escape!=0) add_byte(ESCAPE_BYTE,chan_ptr);
						add_byte(c,chan_ptr);
					}
					continue;
				}
				
				if (am_in_frame == FRAME_STATUS.CORRECT_FRAME) {
					if ((c & 0xFF) == (ESCAPE_BYTE & 0xFF))
					{
						in_escape = 1;
						
						do
						{
							if (check_timeouts(systimer.ElapsedMilliseconds, timeout, max_timeout)) continue;
							tempval = (byte)read_byte(comport);
						} while (tempval < 0);
						c = (byte)tempval;
						switch (c){
							case ESCAPED_END_FRAME_BYTE:
								c = END_FRAME_BYTE;
								break;
							case ESCAPED_START_FRAME_BYTE:
								c = START_FRAME_BYTE;
								break;
							case ESCAPED_ESCAPE_BYTE:
								c = ESCAPE_BYTE;
								break;
							default:
								break;
						}
						in_frame_buf[byte_idx++] = c;
						in_escape = 0;
#if VERBOSE_PRINT
						Console.Write(" {0:X02}",c);
#endif
						continue;
					}

					if ((c & 0xFF) == (END_FRAME_BYTE & 0xFF))
					{
#if VERBOSE_PRINT || DEBUGPRINT
						Console.Write("\n     EndByte time {0}:\n", systimer.ElapsedMilliseconds / 1000.0);
#endif
						// frame_buf[byte_idx++] = c;

						/*
						 * Check CRC: if good end loop.  If bad, start looking for start byte.
						 * Check Frame Status:  If zero, end loop.  If non-zero, start looking for start byte.
						 */
						am_in_frame = FRAME_STATUS.UNFRAMED;
						calc_crc = calcFlirCRC16Bytes((UInt32) (byte_idx-2),(UInt16) CRC_START_IDX , in_frame_buf);

						if ( (((calc_crc >> 8) &0xFF) != in_frame_buf[byte_idx - 2]) || ((calc_crc &0xFF) != in_frame_buf[byte_idx - 1]) )
						{
							Console.Write("Failed packet Integrity check (calc){0:X02}{1:X02} != (pkt){2:X02}{3:X02}\n",((calc_crc >> 8) &0xFF),(calc_crc&0xFF),in_frame_buf[byte_idx - 2],in_frame_buf[byte_idx - 1]);
							Console.Write("byte count = {0}, crc len = {1}\n", byte_idx, byte_idx - NUM_FRAMING_BYTES);
							Console.Write("RAW Receive Packet: ");
							for (tempval=0;tempval<byte_idx;tempval++){
								Console.Write(" {0:X02}",in_frame_buf[tempval]);
							}
							Console.Write("\n");
							// Console.Write("     Failed time %f:\n",elapsed_sec);
							// failedcrc = 1;
							byte_idx = 0;
							systimer.Restart();
							timeout = start_byte_ms;
							continue;
						}
#if VERBOSE_PRINT
						else{
							Console.Write("\n");
						}
#endif
						found_complete_frame = 1;
						break;
					}

					in_frame_buf[byte_idx++] = c;
#if VERBOSE_PRINT
					Console.Write(" {0:X02}",c);
#endif
				}else if(am_in_frame == FRAME_STATUS.OTHER_FRAME) {
					if ((c & 0xFF) == (ESCAPE_BYTE & 0xFF)) {
						in_escape = 1;
						add_byte(c,chan_ptr);
						do {
							if (systimer.ElapsedMilliseconds>timeout) continue;
							tempval = read_byte(comport);
						} while (tempval < 0);
						c = (byte) tempval;
						add_byte(c,chan_ptr);
						in_escape = 0;
						
					} else if ((c & 0xFF) == (END_FRAME_BYTE & 0xFF)) {
						add_byte(c,chan_ptr);
						am_in_frame = FRAME_STATUS.UNFRAMED;
					}
#if VERBOSE_PRINT
					Console.Write("({0:G02}:{1:X02})",chan_ptr.channel,c);
#endif
					continue;
				} else { //Unframed data
#if VERBOSE_PRINT
					Console.Write("(U:{0:X02})",chan_ptr.channel,c);
#endif
					add_byte(c,unframed_ptr);
				}
			}
			
			if (found_complete_frame > 0) {
				extract_payload(in_frame_buf,FRAME_START_IDX, (UInt32)(byte_idx - NUM_FRAMING_BYTES), receiveBuffer, ref receiveBytes);
				return;
			} else {
				receiveBytes =  0;
				return;
			}
		}

		public void read_unframed(SerialPort comport,byte channel_ID, UInt16 start_byte_ms,ref UInt32 receiveBytes, byte[] receiveBuffer)
		{
			int tempval = 0;
			// frame_state am_in_frame = FRAME_STATUS.UNFRAMED;
			byte c;
			UInt16 timeout = start_byte_ms;
			
			get_unframed(ref unframed_ptr);
			
			receiveBytes =  0;
			
			systimer.Restart();
#if VERBOSE_PRINT
			Console.Write(" Unframed Data: ");
#endif
			while(unframed_ptr.len > 0){
				
				if (receiveBytes == FRAME_BUF_SIZ) return;
				
				tempval = get_byte(out c,unframed_ptr);
				if (tempval < 0){
					break;
				}
					
				receiveBuffer[receiveBytes++] = c;
#if VERBOSE_PRINT
				Console.Write(" {0:X02}",c);
#endif
			}
#if VERBOSE_PRINT
			Console.Write("...\n");
#endif
		}
		
		void extract_payload(byte[] raw_payload_buf,UInt32 offset, UInt32 raw_payload_len, byte[] payload_buf, ref UInt32 payload_len)
		{
			UInt32 i;

			for(payload_len=0, i=0; i < raw_payload_len; i++)
			{
				// if (raw_payload_buf[i] == ESCAPE_BYTE) i++;
				payload_buf[payload_len++] = raw_payload_buf[i+offset];
			}
		}


		static UInt32 create_frame(byte[] frame_buf,byte channel_ID, byte[] payload, UInt32 payload_len)
		{
			UInt32 i;
			UInt32 out_len = 0;
			UInt32 crc_out = 0x1D0F; //New initial conditions for boson V0.0.6560 and newer
			frame_buf[out_len++] = (byte) START_FRAME_BYTE;
			frame_buf[out_len++] = (byte) channel_ID;
			crc_out = ByteCRC16((UInt16) channel_ID, (UInt16) crc_out);
			
			if ((payload_len + 2 + NUM_FRAMING_BYTES) > FRAME_BUF_SIZ)
				return (0);

			for(i=0; i < payload_len; i++)
			{
				if ((payload[i] == START_FRAME_BYTE) || (payload[i] == END_FRAME_BYTE) || (payload[i] == ESCAPE_BYTE))
					frame_buf[out_len++] = ESCAPE_BYTE;
					Byte c = payload[i];
					crc_out = ByteCRC16((UInt16) c, (UInt16) crc_out);
					switch (c)
					{
						case END_FRAME_BYTE:
							c = ESCAPED_END_FRAME_BYTE;
							break;
						case START_FRAME_BYTE:
							c = ESCAPED_START_FRAME_BYTE;
							break;
						case ESCAPE_BYTE:
							c = ESCAPED_ESCAPE_BYTE;
							break;
						default:
							break;
					}
				frame_buf[out_len++] = c;

				if ((out_len + 3) > FRAME_BUF_SIZ)
					return (0);
			}

			// crc_out = calcFlirCRC16Bytes(out_len, frame_buf);
			byte crcbyte = (byte)((crc_out >> 8) & 0xFF);
			if ((crcbyte == START_FRAME_BYTE) || (crcbyte == END_FRAME_BYTE) || (crcbyte == ESCAPE_BYTE)) {
				frame_buf[out_len++] = ESCAPE_BYTE;
				Byte c = crcbyte;
				switch (c)
				{
					case END_FRAME_BYTE:
						c = ESCAPED_END_FRAME_BYTE;
						break;
					case START_FRAME_BYTE:
						c = ESCAPED_START_FRAME_BYTE;
						break;
					case ESCAPE_BYTE:
						c = ESCAPED_ESCAPE_BYTE;
						break;
					default:
						break;
				}
				frame_buf[out_len++] = c;
			} else {
				frame_buf[out_len++] = crcbyte;
			}
				
			crcbyte = (byte)(crc_out & 0xFF);
			if ((crcbyte == START_FRAME_BYTE) || (crcbyte == END_FRAME_BYTE) || (crcbyte == ESCAPE_BYTE)) {
				frame_buf[out_len++] = ESCAPE_BYTE;
				Byte c = crcbyte;
				switch (c)
				{
					case END_FRAME_BYTE:
						c = ESCAPED_END_FRAME_BYTE;
						break;
					case START_FRAME_BYTE:
						c = ESCAPED_START_FRAME_BYTE;
						break;
					case ESCAPE_BYTE:
						c = ESCAPED_ESCAPE_BYTE;
						break;
					default:
						break;
				}
				frame_buf[out_len++] = c;
			} else {
				frame_buf[out_len++] = crcbyte;
			}
			frame_buf[out_len++] = END_FRAME_BYTE;

			return(out_len);
		}

		void write_frame(SerialPort comport,byte[] frame_buf, UInt32 len)
		{
#if VERBOSE_PRINT
			Int32 i;
			Console.Write("Writing Frame: ");
			for(i=0; i<len; i++){
				Console.Write(" {0:X02}",frame_buf[i]);
			}
			Console.Write("...\n");
#elif DEBUGPRINT
			Int32 i;
			Console.Write("Writing Frame: ");
			for (i = 2; i < 14; i++)
			{
				Console.Write(" {0:X02}", frame_buf[i]);
			}
			Console.Write("...\n");
#endif
			comport.Write(frame_buf,0,(Int32)len);
			while (comport.BytesToWrite > 0);
		}
												//, ref UInt32 receiveBytes, byte[] receivePayload)
		public void send_to_camera(SerialPort comport,byte channel_ID, UInt32 sendBytes, byte[] sendPayload)
		{
			UInt32 out_len;//, in_payload_len, out_payload_len;
			//comport.DiscardInBuffer();
			out_len = create_frame(out_frame_buf,channel_ID, sendPayload, sendBytes);
			write_frame(comport,out_frame_buf, out_len);
			// bytes_read = read_frame(comport, 0x00,1000,in_frame_buf);
			// if (bytes_read > 0) { //successful read
				// // Console.Write("  Good Read: %d bytes\n",bytes_read);
				// if ((in_frame_buf[1] | in_frame_buf[2]) == 0 ) { //no frame error
					// // Console.Write("  GoodFrame\n");
					// extract_payload(in_frame_buf,(UInt32) FRAME_START_IDX, (UInt32)(bytes_read - NUM_FRAMING_BYTES), receivePayload, ref receiveBytes);
				// } else { // some frame error
					// Console.Write("  BadFrameStatus\n");
					// // receiveBytes = 0;
					// for (i=0;i<8;i++){ 
						// receivePayload[i] = sendPayload[i];// fill sequence and command fields
						// // receiveBytes++; // increment receiveBytes
					// }
					// receivePayload[8] = 0x00; 
					// receivePayload[9] = 0x00; //all return codes start 0x0000
					// receivePayload[10] = in_frame_buf[2]; // copy frame status byte[0]
					// receivePayload[11] = in_frame_buf[3]; // copy frame status byte[1]
					// receiveBytes =12;
				// }	
			// } else { //timeout
				// Console.Write("  timeout\n");
				// // *receiveBytes = 0;
				// for (i=0;i<8;i++){ 
					// receivePayload[i] = sendPayload[i];// fill sequence and command fields
					// // (*receiveBytes)++; // increment receiveBytes
				// }
				// receivePayload[8] = 0x00; 
				// receivePayload[9] = 0x00; //all return codes start 0x0000
				// receivePayload[10] = 0x00; 
				// receivePayload[11] = 0x03; // FLR_RESULT.R_UART_RECEIVE_TIMEOUT == 0x00000003
				// receiveBytes = 12;
			// }
		}//end send_to_camera
		
		static UInt16[] ccitt_16Table = new UInt16[]{
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
		};
		
		static UInt16 ByteCRC16(UInt16 value, UInt16 crcin)
		{
			return (UInt16)((crcin << 8) ^  ccitt_16Table[((crcin >> 8) ^ (value)) & 0xFF]);
		}
		static UInt16 calcFlirCRC16Bytes(UInt32 count, UInt32 offset, byte[] buffer)
		{

			UInt16 crc = 0x1D0F;
			UInt16 i = 0;

			do
			{
				UInt16 value = (UInt16) buffer[offset+i];
				crc = ByteCRC16(value, crc);
				i++;
			}
			while ( --count != 0);

			return (UInt16) crc;
		}
	}// end internal class FLR_SLP
} // end namespace Boson