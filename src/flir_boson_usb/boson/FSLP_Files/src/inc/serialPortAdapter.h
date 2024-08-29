#ifndef _SERIALPORT_ADAPTER_H
#define _SERIALPORT_ADAPTER_H

#include <stdlib.h>
#include <stdint.h>

#ifdef _WIN32
#define FLR_EXPORT __declspec(dllexport)
#else
#define FLR_EXPORT
#endif


//helper function to change human readable names like:
// "/dev/ttyACM0" or "COM21" to port numbers
// -1 is only expected error return.
FLR_EXPORT int32_t FSLP_lookup_port_id( char *port_name, int32_t len );

// open port by id, using specified baud_rate.
// passes library errors up, 0 on success.
FLR_EXPORT uint8_t FSLP_open_port(int32_t port_id, int32_t baud_rate);

// close port via id
FLR_EXPORT void FSLP_close_port(int32_t port_id);

// read single byte with timeout.
// -1 on timeout, 0-255 for valid byte value
int16_t FSLP_read_byte_with_timeout(int32_t port_id, double timeout);

// flush tx buffer
void FSLP_flush_write_queue(int32_t port_id);

// internal config option to flush after every byte vs after whole buffer.
// OPTIONAL to implement.
// #define WRITE_BUFFER_AS_SINGLE_BYTES

// write buffer of bytes
// return number of bytes written
int FSLP_write_buffer(int32_t port_id, uint8_t *frame_buf, int32_t len);

#endif //_SERIALPORT_ADAPTER_H