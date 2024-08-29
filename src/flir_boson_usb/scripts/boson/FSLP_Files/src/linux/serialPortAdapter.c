#include "serialPortAdapter.h"
//specific implementation of serial port
#include "serial.h"
//platform agnostic timeout
// #include "timeoutLogic.h" not needed for current serial library.
#include <stdio.h>

#define DO_DEBUG_TRACE(x...)    //printf(x)

#define KNOWN_PORTS 48

static HANDLE port_handles[KNOWN_PORTS] = {0};
static char port_names[KNOWN_PORTS][16] = {
    "/dev/ttyUSB0", "/dev/ttyUSB1","/dev/ttyUSB2","/dev/ttyUSB3",
    "/dev/ttyUSB4","/dev/ttyUSB5","/dev/ttyUSB6", "/dev/ttyUSB7",
    "/dev/ttyUSB8","/dev/ttyUSB9","/dev/ttyUSB10","/dev/ttyUSB11",
    "/dev/ttyUSB12","/dev/ttyUSB13","/dev/ttyUSB14","/dev/ttyUSB15",
    "/dev/ttyACM0","/dev/ttyACM1","/dev/ttyACM2","/dev/ttyACM3",
    "/dev/ttyACM4","/dev/ttyACM5","/dev/ttyACM6","/dev/ttyACM7",
    "/dev/ttyACM8","/dev/ttyACM9","/dev/ttyACM10","/dev/ttyACM11",
    "/dev/ttyACM12","/dev/ttyACM13","/dev/ttyACM14","/dev/ttyACM15",
    "/dev/ttyS0","/dev/ttyS1","/dev/ttyS2","/dev/ttyS3",
    "/dev/ttyS4","/dev/ttyS5","/dev/ttyS6","/dev/ttyS7",
    "/dev/ttyS8","/dev/ttyS9","/dev/ttyS10","/dev/ttyS11",
    "/dev/ttyS12","/dev/ttyS13","/dev/ttyS14","/dev/ttyS15",
};

int32_t FSLP_lookup_port_id( char *port_name, int32_t len ){
    int32_t port_id = -1;
    if (len > 15)
    {
        //no port names >16 characters
        return -1;
    }

    for (int32_t port_id=0; port_id<KNOWN_PORTS; port_id++)
    {
        if ( 0 == strncmp(port_names[port_id],port_name,len) )
        {
            return port_id;
        }
    }
    return -1;
}

uint8_t FSLP_open_port(int32_t port_id, int32_t baud_rate){
    char settings_buff[16];
    sprintf(settings_buff,"%d,8,n,1",baud_rate);
    PortSettingsType port_settings = str2ps(port_names[port_id], settings_buff);
    int32_t success = open_port(port_settings, &(port_handles[port_id]) );
    if (0 != success)
    {
        port_handles[port_id] = 0;
    }
    return (uint8_t) success; // 0 == success.
}

void FSLP_close_port(int32_t port_id){
    int32_t ignore = close_port(port_handles[port_id]);
    port_handles[port_id] = 0;
}

//Return type is int16_t, so that the full uint8_t value can be represented
// without overlapping with negative error codes.
int16_t FSLP_read_byte_with_timeout(int32_t port_id, double timeout)
{
    uint8_t in_byte = 0x00;
    int32_t timeout_us = (int32_t) timeout*1e6; //seconds * 1e6
    int32_t timeout_occurred = 0; 

    in_byte = read_byte_time( port_handles[port_id] , timeout_us, &timeout_occurred);

    if (0 != timeout_occurred) {
        return -1;
    }

    return (int16_t) in_byte;
}

void FSLP_flush_write_buffer(int32_t port_id)
{
    flush_buffer_tx(port_handles[port_id]);
}


#ifdef WRITE_BUFFER_AS_SINGLE_BYTES // use single byte writes
    #error "NOT Implemented!"
#else // use buffer access function writes

    int32_t FSLP_write_buffer(int32_t port_id, uint8_t *frame_buf, int32_t len)
    {
        int32_t result;
        result = send_buffer(port_handles[port_id], frame_buf, (uint16_t) len); 
        FSLP_flush_write_buffer(port_id);
        if (0==result)
        {
            // per serialPortAdapter.h, return num bytes sent
            // send_buffer returns 0 for success, -1 for failure.
            // Need to translate error space.
            return len;
        }
        else
        {
            return 0;
        }
    }
#endif// WRITE_BUFFER_AS_SINGLE_BYTES vs frame writes

