
// Error handling convention
// Returns 0 when no error
// Returns <0 when error


#ifndef FLIR_WIN32_SERIAL_H
#define FLIR_WIN32_SERIAL_H

#include <windows.h>
#include <stdio.h>
#include <stdint.h>
//#include <stdlib.h>
#include <string.h>

// #define HANDLE   	int32_t

// Opens serial port
// Input : port-name 
// Input : baudrate
// Output : handle to the device
// Returns 0 on success
// Returns -1 if cannot open serial port (bad port name?)
// Returns -2 if fail to build config structure
// Returns -3 if failed to apply port config settings
int32_t open_port(char *port_name, uint32_t baudrate, HANDLE *comm_handle);


// Close the serial port handle
// Returns 0 on success
// Returns -1 on error , and errno is updated.
int32_t close_port(HANDLE comm_handle);

// Send buffer of bytes
// Input: serial port handler, pointer to first byte of buffer , number of bytes to send
// Returns 0 on success
// Returns -1 on write error
// Returns -2 on less bytes sent than expected.
int32_t write_buffer(HANDLE comm_handle, uint8_t *data_buffer, int32_t bytes_to_send);

// Read a byte within a period of time
// Returns byte read
// Returns 0 if successful
// Returns -1 if timeout settings were not read
// Returns -2 if timeout settings were not applied
// Returns -3 if timeout or other read error(s) occurred
// read_byte value will be set to 0xFF for all non-successful function returns.
int32_t read_byte_with_timeout(HANDLE comm_handle, int32_t timeout_ms, uint8_t *read_byte);

// Flush TX buffer
// Returns -1 if error
// Returns 0 if OK
int32_t flush_tx_buffer(HANDLE comm_handle);

// Sends break signal
// Returns -1 if error
// Returns 0 if OK
int32_t send_break();

#endif //FLIR_WIN32_SERIAL_H
