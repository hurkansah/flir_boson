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
using System;
using Boson;


namespace UART_Example {
	class Program {
		static void Main(string[] args) {


            Camera TestCam1 = new Camera();
            UInt16 MAX_CHUNK_SIZE = 256;// 100; //512
			Console.WriteLine("Initializing Camera!");
			TestCam1.Initialize("COM16",921600);  // serial port number (COM11 = portnum 10), baudrate

            byte capture_index = 0;
            Camera.FLR_CAPTURE_SETTINGS_T cap_settings = new Camera.FLR_CAPTURE_SETTINGS_T();
            cap_settings.dataSrc = Camera.FLR_CAPTURE_SRC_E.FLR_CAPTURE_SRC_TNF;
			cap_settings.numFrames = 1;
            cap_settings.bufferIndex = capture_index;

            Camera.FLR_RESULT returncode = TestCam1.captureFrames(cap_settings);
            if (returncode != Camera.FLR_RESULT.R_SUCCESS)
            {
                Console.Write("ImageCapture({1:G},{2:G},{3:G})  returned Error: {0:G} (0x{0:X})\n", returncode, cap_settings.dataSrc, cap_settings.numFrames, cap_settings.bufferIndex);
                TestCam1.Close();
                return;
            }
            else
            {
                Console.Write("ImageCapture({1:G},{2:G},{3:G})  Success!: {0:G} (0x{0:X})\n", returncode, cap_settings.dataSrc, cap_settings.numFrames, cap_settings.bufferIndex);
            }
            
             
            UInt32 offset,size,chunks;
            UInt16 rows, columns;
			UInt32 error_count = 0;
			
            returncode = TestCam1.memGetCaptureSize(out size, out rows, out columns);
            byte[] imgbuff = new byte[size];
            byte[] chunkdata;

			// Check for any errorcode

            if (returncode != Camera.FLR_RESULT.R_SUCCESS)
            {
                Console.Write("Get Capture Size() returned Error: {0:G} (0x{0:X})\n", returncode);
				TestCam1.Close();
				return;
			} else {
                Console.Write("Get Capture Size() returned Status: {0:G} (0x{0:X})\n", returncode);
                Console.Write("Capture Size() : 0x{0:X}, {1:G}x{2:G}\n", size, columns, rows);
			}
			
			chunks = (UInt32) ((size/MAX_CHUNK_SIZE)+0.5);
			Console.Write("Num offsets =  {0}\n", chunks);
            System.Diagnostics.Stopwatch systimer2 = new System.Diagnostics.Stopwatch();

            Console.WriteLine("\nStarting read Test:");
            systimer2.Restart();
			UInt16 sizeInBytes;
            for (offset=0;offset<size;offset+=MAX_CHUNK_SIZE){
				if ((size - offset ) > MAX_CHUNK_SIZE) {
					sizeInBytes= MAX_CHUNK_SIZE;
				} else {
					sizeInBytes = (UInt16)(size - offset );
				}

                returncode = TestCam1.memReadCapture(capture_index, offset, sizeInBytes, out chunkdata);
                // Check for any errorcode
                if (returncode != Camera.FLR_RESULT.R_SUCCESS)
                {
                    Console.Write("memReadCapture(offset:0x{1:X}) returned Error: {0:G} (0x{0:X})\n", returncode, offset);
                }
                else
                {
                    Console.Write("memReadCapture(offset:0x{0:X}) Okay.\n",  offset);
                    //for (int i = 0; i < sizeInBytes; i++)
                    //{
                    //    imgbuff[offset + i] = chunkdata[i];
                    //}
                }
            }
            Console.WriteLine("memReadCapture total time = {0}s", ((float)systimer2.ElapsedMilliseconds) / 1000.0);
            Console.WriteLine("memReadCapture total bytes = {0}", (size));
            Console.WriteLine("Effective Rate = {0:G3} kBps", 1000.0 * (size / 1024.0) / ((float)systimer2.ElapsedMilliseconds));
            Console.WriteLine();


            capture_index = 1;
            cap_settings.dataSrc = Camera.FLR_CAPTURE_SRC_E.FLR_CAPTURE_SRC_TNF;
            cap_settings.numFrames = 1;
            cap_settings.bufferIndex = capture_index;

            returncode = TestCam1.captureFrames(cap_settings);
            if (returncode != Camera.FLR_RESULT.R_SUCCESS)
            {
                Console.Write("ImageCapture({1:G},{2:G},{3:G}) returned Error: {0:G} (0x{0:X})\n", returncode, cap_settings.dataSrc, cap_settings.numFrames, cap_settings.bufferIndex);
                TestCam1.Close();
                return;
            }
            else
            {
                Console.Write("ImageCapture({1:G},{2:G},{3:G})  Success!: {0:G} (0x{0:X})\n", returncode, cap_settings.dataSrc, cap_settings.numFrames, cap_settings.bufferIndex);
            }



            returncode = TestCam1.memGetCaptureSize(out size, out rows, out columns);
            byte[] imgbuff2 = new byte[size];

            // Check for any errorcode

            if (returncode != Camera.FLR_RESULT.R_SUCCESS)
            {
                Console.Write("Get Capture Size() returned Error: {0:G} (0x{0:X})\n", returncode);
                TestCam1.Close();
                return;
            }
            else
            {
                Console.Write("Get Capture Size() returned Status: {0:G} (0x{0:X})\n", returncode);
                Console.Write("Capture Size() : 0x{0:X}, {1:G}x{2:G}\n", size, columns, rows);
            }

            chunks = (UInt32)((size / MAX_CHUNK_SIZE) + 0.5);
            Console.Write("Num offsets =  {0}\n", chunks);

            Console.WriteLine("\nStarting read Test(2):");
            systimer2.Restart();
            for (offset = 0; offset < chunks; offset++)
            {
                if ((size - offset * MAX_CHUNK_SIZE) > MAX_CHUNK_SIZE)
                {
                    sizeInBytes = MAX_CHUNK_SIZE;
                }
                else
                {
                    sizeInBytes = (UInt16)(size - offset * MAX_CHUNK_SIZE);
                }

                returncode = TestCam1.memReadCapture(capture_index, offset, sizeInBytes, out chunkdata);
                // Check for any errorcode
                if (returncode != Camera.FLR_RESULT.R_SUCCESS)
                {
                    Console.Write("memReadCapture(offset:0x{1:X}) returned Error: {0:G} (0x{0:X})\n", returncode, offset);
                }
                else
                {
                    Console.Write("memReadCapture(offset:0x{0:X}) Okay.\n", offset);
                    //for (int i = 0; i < sizeInBytes; i++)
                    //{
                    //    imgbuff[offset * MAX_CHUNK_SIZE + i] = chunkdata[i];
                    //}
                }
            }
            Console.WriteLine("memReadCapture total time = {0}s", ((float)systimer2.ElapsedMilliseconds) / 1000.0);
            Console.WriteLine("memReadCapture total bytes = {0}", (size));
            Console.WriteLine("Effective Rate = {0:G3} kBps", 1000.0 * (size / 1024.0) / ((float)systimer2.ElapsedMilliseconds));
            Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("\nFinalizing Camera!");
            //TestCam1.Close();
            //return;

            Camera.FLR_MEM_LOCATION_E location_enum = Camera.FLR_MEM_LOCATION_E.FLR_MEM_LENS_GAIN;
            byte location_idx = 1;
            UInt32 flashsize;
            returncode = TestCam1.memGetFlashSize(location_enum, out flashsize);
            Console.Write("Flash Size() : {0:X}\n", flashsize);
            byte[] inputdata = new byte[flashsize];
            for (int i = 0; i < flashsize; i+=2)
            {
                //write little endian 0x2000 = 8192 = unity gain
                inputdata[i] = 0x00;
                inputdata[i + 1] = 0x20;
            }

            chunks = (UInt32)((flashsize / MAX_CHUNK_SIZE) + 0.5);
            byte[][] data = new byte[chunks][];

            for (int idx = 0; idx < chunks; idx++)
            {
                data[idx] = new byte[MAX_CHUNK_SIZE];
                if ((size - idx * MAX_CHUNK_SIZE) > MAX_CHUNK_SIZE)
                {
                    sizeInBytes = MAX_CHUNK_SIZE;
                }
                else
                {
                    sizeInBytes = (UInt16)(size - idx * MAX_CHUNK_SIZE);
                }
                for (int idx2 = 0; idx2 < sizeInBytes; idx2++)
                {
                    data[idx][idx2] = inputdata[idx * MAX_CHUNK_SIZE + idx2];
                }
            }
            

            returncode = TestCam1.memEraseFlash(location_enum,location_idx);
            if (returncode != Camera.FLR_RESULT.R_SUCCESS)
            {
                System.Threading.Thread.Sleep(2000);
                Console.Write("EraseFlash() returned Error: {0:G} (0x{0:X})\nRetrying EraseFlash()....\n", returncode);
                System.Threading.Thread.Sleep(4000);
                returncode = TestCam1.memEraseFlash(location_enum, location_idx);
                if (returncode != Camera.FLR_RESULT.R_SUCCESS)
                {
                    Console.Write("EraseFlash() returned Error: {0:G} (0x{0:X})\n", returncode);
                }
                else
                {
                    Console.Write("EraseFlash() returned Status: {0:G} (0x{0:X})\n", returncode);
                }
            }
            else
            {
                Console.Write("EraseFlash() returned Status: {0:G} (0x{0:X})\n", returncode);
            }

            Console.WriteLine("\nStarting Write Test:");
            systimer2.Restart();
            for (UInt16 chunk_idx = 0; chunk_idx < chunks; chunk_idx++)
            {
                offset = (UInt32)(chunk_idx * MAX_CHUNK_SIZE);
                if ((flashsize - offset) > MAX_CHUNK_SIZE)
                {
                    sizeInBytes = MAX_CHUNK_SIZE;
                }
                else
                {
                    sizeInBytes = (UInt16)(flashsize - offset);
                }
                returncode = TestCam1.memWriteFlash(location_enum,location_idx, offset, sizeInBytes, data[chunk_idx]);
                // Check for any errorcode
                if ((returncode != Camera.FLR_RESULT.R_SUCCESS))
                {
                    Console.Write("memWriteFlash({1:X}) returned Error: {0:G} (0x{0:X})\n", returncode, offset);
                }
            }
            Console.WriteLine("memWrite total time = {0}s", ((float)systimer2.ElapsedMilliseconds) / 1000.0);
            Console.WriteLine("memWrite total bytes = {0}", (flashsize));
            Console.WriteLine("Effective Rate = {0:G3} kBps", 1000.0 * (flashsize / 1024.0) / ((float)systimer2.ElapsedMilliseconds));
            Console.WriteLine();

            error_count = 0;
            byte[] verify_data;

            Console.WriteLine("\nStarting Verify/Readback Test:");
            systimer2.Restart();

            for (UInt16 chunk_idx = 0; chunk_idx < chunks; chunk_idx++)
            {
                offset = (UInt32)(chunk_idx * MAX_CHUNK_SIZE);
                if ((flashsize - offset) > MAX_CHUNK_SIZE)
                {
                    sizeInBytes = MAX_CHUNK_SIZE;
                }
                else
                {
                    sizeInBytes = (UInt16)(flashsize - offset);
                }
                returncode = TestCam1.memReadFlash(location_enum, location_idx, offset, sizeInBytes, out verify_data);
                // Check for any errorcode
                if ((returncode != Camera.FLR_RESULT.R_SUCCESS))
                {
                    Console.Write("memWriteFlash({1:X}) returned Error: {0:G} (0x{0:X})\n", returncode, offset);
                }
                else
                {
                    for (int j = 0; j < sizeInBytes; j++)
                    {
                        if (data[chunk_idx][j] != verify_data[j])
                        {
                            error_count++;
                            if (error_count<1024)
                                Console.Write("verify(byte:{1:G}) was different: expected: {1:X} got: {2:X}\n", offset, data[chunk_idx][j] ,verify_data[j]);
                            if (error_count == 1024)
                                Console.Write("verify errors only printed up to 1024 times.\n");
                        }
                    }
                }
            }
            Console.WriteLine("Verify total time = {0}s", ((float)systimer2.ElapsedMilliseconds) / 1000.0);
            Console.WriteLine("Verify total bytes = {0}", (flashsize));
            Console.WriteLine("Effective Rate = {0:G3} kBps", 1000.0 * (flashsize / 1024.0) / ((float)systimer2.ElapsedMilliseconds));
            Console.WriteLine();


            Console.WriteLine("\nFinalizing Camera!");
            TestCam1.Close();
			
		} // End main()
	} // End class Program
} // End namespace UART_Example