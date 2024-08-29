#ifndef _FSLP_H
#define _FSLP_H

#include <stdint.h>

#include "serialPortAdapter.h"


#ifdef _WIN32
#define FLR_EXPORT __declspec(dllexport)
#else
#define FLR_EXPORT
#endif

FLR_EXPORT void FSLP_send_to_camera(int32_t port_num, uint8_t channel_ID, uint32_t sendBytes, uint8_t *sendPayload);//, uint32_t *receiveBytes, uint8_t *receivePayload);
// FLR_EXPORT void read_command(int32_t port_num, uint8_t channel_ID, uint32_t sendBytes, uint8_t *sendPayload, uint32_t *receiveBytes, uint8_t *receivePayload);
FLR_EXPORT int32_t FSLP_read_frame(int32_t port_num,uint8_t channel_ID, uint16_t start_byte_ms,uint32_t *receiveBytes, uint8_t *receiveBuffer);
FLR_EXPORT void FSLP_read_unframed(int32_t port_num, uint16_t start_byte_ms,uint32_t *receiveBytes, uint8_t *receiveBuffer);
FLR_EXPORT int32_t FSLP_check_data_ready(int32_t port_num, uint8_t *channel_ID, uint16_t start_byte_ms, uint32_t *receiveBytes, const uint8_t **receiveBuffer);

#endif //_FSLP_H
