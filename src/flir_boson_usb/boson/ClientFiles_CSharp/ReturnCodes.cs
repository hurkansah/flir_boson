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
		public enum FLR_RESULT : int {
			MAX_ERR_CODE = 0x0000FFFF, // 65535
			R_SUCCESS                                = 0, // 0x00000000
			R_UART_UNSPECIFIED_FAILURE               = 1, // 0x00000001
			R_UART_PORT_FAILURE                      = 2, // 0x00000002
			R_UART_RECEIVE_TIMEOUT                   = 3, // 0x00000003
			R_UART_PORT_ALREADY_OPEN                 = 4, // 0x00000004
			R_SDK_API_UNSPECIFIED_FAILURE            = 272, // 0x00000110
			R_SDK_API_NOT_DEFINED                    = 273, // 0x00000111
			R_SDK_PKG_UNSPECIFIED_FAILURE            = 288, // 0x00000120
			R_SDK_PKG_BUFFER_OVERFLOW                = 303, // 0x0000012F
			R_SDK_DSPCH_UNSPECIFIED_FAILURE          = 304, // 0x00000130
			R_SDK_DSPCH_SEQUENCE_MISMATCH            = 305, // 0x00000131
			R_SDK_DSPCH_ID_MISMATCH                  = 306, // 0x00000132
			R_SDK_DSPCH_MALFORMED_STATUS             = 307, // 0x00000133
			R_SDK_TX_UNSPECIFIED_FAILURE             = 320, // 0x00000140
			R_CAM_RX_UNSPECIFIED_FAILURE             = 336, // 0x00000150
			R_CAM_DSPCH_UNSPECIFIED_FAILURE          = 352, // 0x00000160
			R_CAM_DSPCH_BAD_CMD_ID                   = 353, // 0x00000161
			R_CAM_DSPCH_BAD_PAYLOAD_STATUS           = 354, // 0x00000162
			R_CAM_PKG_UNSPECIFIED_FAILURE            = 368, // 0x00000170
			R_CAM_PKG_INSUFFICIENT_BYTES             = 381, // 0x0000017D
			R_CAM_PKG_EXCESS_BYTES                   = 382, // 0x0000017E
			R_CAM_PKG_BUFFER_OVERFLOW                = 383, // 0x0000017F
			R_CAM_API_UNSPECIFIED_FAILURE            = 384, // 0x00000180
			R_CAM_API_INVALID_INPUT                  = 385, // 0x00000181
			R_CAM_TX_UNSPECIFIED_FAILURE             = 400, // 0x00000190
			R_API_RX_UNSPECIFIED_FAILURE             = 416, // 0x000001A0
			R_CAM_FEATURE_NOT_ENABLED                = 432, // 0x000001B0
			FLR_OK                                   = 0, // 0x00000000
			FLR_COMM_OK                              = 0, // 0x00000000
			FLR_ERROR                                = 513, // 0x00000201
			FLR_NOT_READY                            = 514, // 0x00000202
			FLR_RANGE_ERROR                          = 515, // 0x00000203
			FLR_CHECKSUM_ERROR                       = 516, // 0x00000204
			FLR_BAD_ARG_POINTER_ERROR                = 517, // 0x00000205
			FLR_DATA_SIZE_ERROR                      = 518, // 0x00000206
			FLR_UNDEFINED_FUNCTION_ERROR             = 519, // 0x00000207
			FLR_ILLEGAL_ADDRESS_ERROR                = 520, // 0x00000208
			FLR_BAD_OUT_TYPE                         = 521, // 0x00000209
			FLR_BAD_OUT_INTERFACE                    = 522, // 0x0000020A
			FLR_DEPRECATED_FUNCTION_ERROR            = 523, // 0x0000020B
			FLR_COMM_PORT_NOT_OPEN                   = 613, // 0x00000265
			FLR_COMM_INVALID_PORT_ERROR              = 614, // 0x00000266
			FLR_COMM_RANGE_ERROR                     = 615, // 0x00000267
			FLR_ERROR_CREATING_COMM                  = 616, // 0x00000268
			FLR_ERROR_STARTING_COMM                  = 617, // 0x00000269
			FLR_ERROR_CLOSING_COMM                   = 618, // 0x0000026A
			FLR_COMM_CHECKSUM_ERROR                  = 619, // 0x0000026B
			FLR_COMM_NO_DEV                          = 620, // 0x0000026C
			FLR_COMM_TIMEOUT_ERROR                   = 621, // 0x0000026D
			FLR_COMM_ERROR_WRITING_COMM              = 621, // 0x0000026D
			FLR_COMM_ERROR_READING_COMM              = 622, // 0x0000026E
			FLR_COMM_COUNT_ERROR                     = 623, // 0x0000026F
			FLR_OPERATION_CANCELED                   = 638, // 0x0000027E
			FLR_UNDEFINED_ERROR_CODE                 = 639, // 0x0000027F
			FLR_LEN_NOT_SUBBLOCK_BOUNDARY            = 640, // 0x00000280
			FLR_CONFIG_ERROR                         = 641, // 0x00000281
			FLR_I2C_ERROR                            = 642, // 0x00000282
			FLR_CAM_BUSY                             = 643, // 0x00000283
			FLR_HEATER_ERROR                         = 644, // 0x00000284
			FLR_WINDOW_ERROR                         = 645, // 0x00000285
			FLR_VBATT_ERROR                          = 646, // 0x00000286
			R_SYM_UNSPECIFIED_FAILURE                = 768, // 0x00000300
			R_SYM_INVALID_POSITION_ERROR             = 769, // 0x00000301
			FLR_RES_NOT_AVAILABLE                    = 800, // 0x00000320
			FLR_RES_NOT_IMPLEMENTED                  = 801, // 0x00000321
			FLR_RES_RANGE_ERROR                      = 802, // 0x00000322
			FLR_SYSTEMINIT_XX_ERROR                  = 900, // 0x00000384
			FLR_SDIO_XX_ERROR                        = 1000, // 0x000003E8
			FLR_STOR_SD_XX_ERROR                     = 1100, // 0x0000044C
			FLR_USB_VIDEO_XX_ERROR                   = 1200, // 0x000004B0
			FLR_USB_CDC_XX_ERROR                     = 1300, // 0x00000514
			FLR_USB_MSD_XX_ERROR                     = 1400, // 0x00000578
			FLR_NET_XX_ERROR                         = 1500, // 0x000005DC
			FLR_BT_XX_ERROR                          = 1600, // 0x00000640
			FLR_FLASH_XX_ERROR                       = 1700, // 0x000006A4
			FLR_FLASHHDR_ERASED                      = 1800, // 0x00000708
			FLR_FLASHHDR_PARTIAL_WRITE               = 1801, // 0x00000709
			FLR_FLASHHDR_WRONG_FOOTER_ID             = 1802, // 0x0000070A
			FLR_FLASHHDR_WRONG_FOOTER_METADATA       = 1803, // 0x0000070B
			FLR_FLASHHDR_WRONG_FOOTER_TYPE           = 1804, // 0x0000070C
			FLR_FLASHHDR_WRONG_HEADER_SIZE           = 1805, // 0x0000070D
			FLR_FLASHHDR_FOOTER_CRC_ERROR            = 1806, // 0x0000070E
		}

	} // End partial class Camera

} // end namespace Boson
