# -*- coding: utf-8 -*-
"""
Created on Tue Feb  9 08:32:22 2016

@author: jimamura
"""
from enum import IntEnum
#FLR_RESULT names must be <= 40 characters!
class FLR_RESULT(IntEnum) :
#   0x0001 -> 0x00FF is allocated to Ben’s UART code (host & client)
#   0x0100 -> 0x01FF is allocated to Autogen/SDK 
#   0x0200 -> 0x02FF is allocated to camera/implementation specific codes (Neela)
#   0x0300 -> 0x03FF is allocated to symbology/graphics specific codes (Jeff, Mobica)
    R_SUCCESS = 0
    
    R_UART_UNSPECIFIED_FAILURE = 0x0001
    R_UART_PORT_FAILURE = 0x0002
    R_UART_RECEIVE_TIMEOUT = 0x0003
    R_UART_PORT_ALREADY_OPEN = 0x0004
    
    
    R_SDK_API_UNSPECIFIED_FAILURE = 0x0110
    R_SDK_API_NOT_DEFINED = 0x0111
    
    R_SDK_PKG_UNSPECIFIED_FAILURE = 0x0120
    R_SDK_PKG_BUFFER_OVERFLOW = 0x012F
    
    R_SDK_DSPCH_UNSPECIFIED_FAILURE = 0x0130
    R_SDK_DSPCH_SEQUENCE_MISMATCH = 0x0131
    R_SDK_DSPCH_ID_MISMATCH = 0x0132
    R_SDK_DSPCH_MALFORMED_STATUS = 0x0133
    
    R_SDK_TX_UNSPECIFIED_FAILURE = 0x0140
    
    R_CAM_RX_UNSPECIFIED_FAILURE = 0x0150
    
    R_CAM_DSPCH_UNSPECIFIED_FAILURE = 0x0160
    R_CAM_DSPCH_BAD_CMD_ID = 0x0161
    R_CAM_DSPCH_BAD_PAYLOAD_STATUS = 0x0162
    
    R_CAM_PKG_UNSPECIFIED_FAILURE = 0x0170
    R_CAM_PKG_INSUFFICIENT_BYTES = 0x017D
    R_CAM_PKG_EXCESS_BYTES = 0x017E
    R_CAM_PKG_BUFFER_OVERFLOW = 0x017F
    
    R_CAM_API_UNSPECIFIED_FAILURE = 0x0180
    R_CAM_API_INVALID_INPUT = 0x0181
    
    R_CAM_TX_UNSPECIFIED_FAILURE = 0x0190
    
    R_API_RX_UNSPECIFIED_FAILURE = 0x01A0

    R_CAM_FEATURE_NOT_ENABLED = 0x01B0
    
    FLR_OK                            = R_SUCCESS     #/*!< Camera ok */
    FLR_COMM_OK                       = FLR_OK  #/*!< Camera comm ok (same as FLR_OK) */

    FLR_ERROR                         = 0x0201    #/*!< Camera general error */
    FLR_NOT_READY                     = 0x0202    #/*!< Camera not ready error */
    FLR_RANGE_ERROR                   = 0x0203    #/*!< Camera range error */
    FLR_CHECKSUM_ERROR                = 0x0204    #/*!< Camera checksum error */
    FLR_BAD_ARG_POINTER_ERROR         = 0x0205    #/*!< Camera Bad arguement error */
    FLR_DATA_SIZE_ERROR               = 0x0206    #/*!< Camera byte count error */
    FLR_UNDEFINED_FUNCTION_ERROR      = 0x0207    #/*!< Camera undefined function error */
    FLR_ILLEGAL_ADDRESS_ERROR         = 0x0208
    FLR_BAD_OUT_TYPE                  = 0x0209    #/*!< Incorrect ISP source */
    FLR_BAD_OUT_INTERFACE             = 0x020A    #/*!< Incorrect Output interface */
    FLR_DEPRECATED_FUNCTION_ERROR     = 0x020B    #/*!< Camera deprecated function error */

    #/* Comm Errors */
    FLR_COMM_PORT_NOT_OPEN            = 0x0265  #/*!< Comm port not open */
    FLR_COMM_INVALID_PORT_ERROR       = 0x0266  #/*!< Comm port no such port error */
    FLR_COMM_RANGE_ERROR              = 0x0267  #/*!< Comm port range error */
    FLR_ERROR_CREATING_COMM           = 0x0268  #/*!< Error creating comm */
    FLR_ERROR_STARTING_COMM           = 0x0269  #/*!< Error starting comm */
    FLR_ERROR_CLOSING_COMM            = 0x026A  #/*!< Error closing comm */
    FLR_COMM_CHECKSUM_ERROR           = 0x026B  #/*!< Comm checksum error */
    FLR_COMM_NO_DEV                   = 0x026C  #/*!< No comm device */
    FLR_COMM_TIMEOUT_ERROR            = 0x026D  #/*!< Comm timeout error */
    FLR_COMM_ERROR_WRITING_COMM       = 0x026D  #/*!< Error writing comm */
    FLR_COMM_ERROR_READING_COMM       = 0x026E  #/*!< Error reading comm */
    FLR_COMM_COUNT_ERROR              = 0x026F  #/*!< Comm byte count error */

    #/* Other Errors */
    FLR_OPERATION_CANCELED            = 0x027E  #/*!< Camera operation canceled */
    FLR_UNDEFINED_ERROR_CODE          = 0x027F   #/*!< Undefined error */
    FLR_LEN_NOT_SUBBLOCK_BOUNDARY     = 0x0280
    FLR_CONFIG_ERROR                  = 0x0281   #/*!< Configuration not valid */
    FLR_I2C_ERROR                     = 0x0282   #/*!< I2C comm error */
    FLR_CAM_BUSY                      = 0x0283   #/*!< Camera busy doing other operations */
    FLR_HEATER_ERROR                  = 0x0284   #/*!< heater error */
    FLR_WINDOW_ERROR                  = 0x0285   #/*!< window error */
    FLR_VBATT_ERROR                   = 0x0286   #/*!< battery error */
    
    # Symbology and other Graphics errors
    R_SYM_UNSPECIFIED_FAILURE       = 0x0300
    R_SYM_INVALID_POSITION_ERROR    = 0x0301

    # Resource Manager section
    FLR_RES_NOT_AVAILABLE                   = 800 #//!< The specified resource is not installed in the system
    FLR_RES_NOT_IMPLEMENTED                 = 801 #//!< For development stage - to make sure nothing slips through
    FLR_RES_RANGE_ERROR                     = 802 #//!< parameter range error in the resource manager

    #/// Modules' specific codes
    #/// SYSTEM_INIT module section
    FLR_SYSTEMINIT_XX_ERROR                  = 900
    
    #/// SDIO module section (for SD storage, WiFi SDIO, BT SDIO, etc)
    FLR_SDIO_XX_ERROR                        = 1000

    #/// Storage SD module section
    FLR_STOR_SD_XX_ERROR                     = 1100
    
    #/// USB Video module section
    FLR_USB_VIDEO_XX_ERROR                   = 1200
    
    #/// USB CDC module section
    FLR_USB_CDC_XX_ERROR                     = 1300
    
    #/// USB MSD module section
    FLR_USB_MSD_XX_ERROR                     = 1400
    
    #/// Network module section
    FLR_NET_XX_ERROR                         = 1500
    
    #/// Bluetooth module section
    FLR_BT_XX_ERROR                          = 1600

    #/// Flash subsystem section
    FLR_FLASH_XX_ERROR                       = 1700

    #/// Flash header subsystem section
    FLR_FLASHHDR_ERASED                 = 1800 #/*!< Flash erased */
    FLR_FLASHHDR_PARTIAL_WRITE          = 1801 #/*!< Error on writing header, only part of header has been written correctly */
    FLR_FLASHHDR_WRONG_FOOTER_ID        = 1802 #/*!< Wrong footer ID */
    FLR_FLASHHDR_WRONG_FOOTER_METADATA  = 1803 #/*!< Wrong footer metadata format */
    FLR_FLASHHDR_WRONG_FOOTER_TYPE      = 1804 #/*!< Wrong footer type */
    FLR_FLASHHDR_WRONG_HEADER_SIZE      = 1805 #/*!< Wrong size of header stored in the footer */
    FLR_FLASHHDR_FOOTER_CRC_ERROR       = 1806 #/*!< Incorrect CRC in the footer */
