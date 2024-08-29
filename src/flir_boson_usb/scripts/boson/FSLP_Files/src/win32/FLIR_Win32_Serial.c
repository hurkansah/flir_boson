#include "FLIR_Win32_Serial.h"


// Windows returns TRUE (non-zero) for success and FALSE (zero) for failure.

// Opens serial port
// Input : port-name
// Input : baudrate
// Output : handle to the device
// Returns 0 on success
// Returns -1 if cannot open serial port (bad port name?)
// Returns -2 if fail to build config structure
// Returns -3 if failed to apply port config settings
int32_t open_port(char *port_name, uint32_t baudrate, HANDLE *comm_handle)
{
    HANDLE temp_handle;
    *comm_handle = 0; // initialize output handle to invalid number.
    temp_handle = CreateFile( port_name,
                    GENERIC_READ | GENERIC_WRITE,
                    0,
                    NULL,
                    OPEN_EXISTING,
                    0,//FILE_FLAG_OVERLAPPED, // disable overlapped operation.
                    NULL);
    if (INVALID_HANDLE_VALUE == temp_handle)
    {
        return -1;
    }

    DCB port_settings = {0};

    char settings_buff[36];
    sprintf(settings_buff,"baud=%d parity=N data=8 stop=1",baudrate);
    if (0 == BuildCommDCBA(settings_buff, &port_settings))
    {
        CloseHandle(temp_handle);
        return -2;
    }

    if ( 0 == SetCommState(temp_handle, &port_settings) )
    {
        CloseHandle(temp_handle);
        return -3;
    }

    *comm_handle = temp_handle;
    return 0;

}

// Close the serial port
// Returns 0 on success
// Returns -1 on error
int32_t close_port(HANDLE comm_handle) {
    if (0 == CloseHandle(comm_handle) )
    {
        return 0;
    }
    return -1;
}

// Send buffer of  bytes
// Input: serial port handler, pointer to first byte of buffer , number of bytes to send
// Returns 0 on success
// Returns -1 on write error
// Returns -2 on less bytes sent than expected.
int32_t write_buffer(HANDLE comm_handle, uint8_t *data_buffer, int32_t bytes_to_send)
{
    DWORD bytes_actually_sent = 0;     // No of bytes written to the port

    int32_t write_successful = WriteFile(comm_handle,
                                         data_buffer,
                                         (DWORD) bytes_to_send,
                                         &bytes_actually_sent,
                                         NULL //overlapped control structure
                                   );
    if (0 == write_successful) 
    {
        return -1;
    }
    if ((DWORD)bytes_to_send != bytes_actually_sent)
    {
        return -2;
    }

    return 0;  // Success
}

// Read a byte within a period of time
// Returns byte read
// Returns 0 if successful
// Returns -1 if timeout settings were not read
// Returns -2 if timeout settings were not applied
// Returns -3 if timeout or other read error(s) occurred
// read_byte value will be set to 0xFF for all non-successful function returns.
int32_t read_byte_with_timeout(HANDLE comm_handle, int32_t timeout_ms, uint8_t *read_byte)
{
    *read_byte = 0xFF; // initialize to unsuccessful value.

    COMMTIMEOUTS timeout_config;
    int32_t successful;
    successful = GetCommTimeouts(comm_handle,&timeout_config);
    if (0 == successful)
    {
        return -1;
    }

    //Set single byte timeout, set all packet timeouts to disabled
    timeout_config.ReadIntervalTimeout = (DWORD) timeout_ms;
    timeout_config.ReadTotalTimeoutMultiplier = (DWORD) 1;
    timeout_config.ReadTotalTimeoutConstant = (DWORD) timeout_ms;

    successful = SetCommTimeouts(comm_handle,&timeout_config);
    if (0 == successful)
    {
        return -2;
    }

    DWORD bytes_actually_read = 0;
    successful = ReadFile( comm_handle,
                           read_byte,
                           sizeof(uint8_t),
                           &bytes_actually_read,
                           NULL //overlapped control structure
                         );
    if ((0 == successful) || (1 != bytes_actually_read))
    {
        *read_byte = 0xFF;
        return -3;
    }

    return 0;

}

// Flush TX buffer
// Returns -1 if error
// Returns 0 if OK
int32_t flush_tx_buffer(HANDLE comm_handle)
{
    int successful = FlushFileBuffers(comm_handle);
    if (0 == successful)
    {
        return -1;
    }
    return 0;
}
