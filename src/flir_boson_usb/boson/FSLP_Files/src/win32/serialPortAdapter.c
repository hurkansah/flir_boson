#include "serialPortAdapter.h"
//specific implementation of serial port
#include "FLIR_Win32_Serial.h"
//platform agnostic timeout
// #include "timeoutLogic.h" not needed for current serial library.

#define DO_DEBUG_TRACE(x...)    //printf(x)

#define KNOWN_PORTS 48

static HANDLE port_handles[KNOWN_PORTS] = {0};
static char port_names[KNOWN_PORTS][6] = {
    "COM1", "COM2","COM3","COM4",
    "COM5", "COM6","COM7","COM8",
    "COM9", "COM10","COM11","COM12",
    "COM13", "COM14","COM15","COM16",
    "COM17", "COM18","COM19","COM20",
    "COM21", "COM22","COM23","COM24",
    "COM25", "COM26","COM27","COM28",
    "COM29", "COM30","COM31","COM32",
    "COM33", "COM34","COM35","COM36",
    "COM37", "COM38","COM39","COM40",
    "COM41", "COM42","COM43","COM44",
    "COM45", "COM46","COM47","COM48",
};

int32_t FSLP_lookup_port_id( char *port_name, int32_t len ){

    if (len > 5)
    {
        //no port names >16 characters
        return -1;
    }

    int32_t port_id = -1;
    for (port_id=0; port_id<KNOWN_PORTS; port_id++)
    {
        if ( 0 == strncmp(port_names[port_id],port_name,len) )
        {
            return port_id;
        }
    }
    return -1;
}

uint8_t FSLP_open_port(int32_t port_id, int32_t baud_rate){
    char full_port_name[16];
    sprintf(full_port_name, "\\\\.\\%s",port_names[port_id]);
    int32_t success = open_port( full_port_name, baud_rate, &(port_handles[port_id]));
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
    int32_t timeout_ms = (int32_t) timeout*1e3; //seconds * 1e3
    int32_t timeout_occurred; 

    timeout_occurred = read_byte_with_timeout(port_handles[port_id], timeout_ms, &in_byte);

    if (0 != timeout_occurred) {
        return (int16_t)-1;
    }

    return (int16_t) in_byte;
}

void FSLP_flush_write_buffer(int32_t port_id)
{
    flush_tx_buffer(port_handles[port_id]);
}


#ifdef WRITE_BUFFER_AS_SINGLE_BYTES // use single byte writes
    #error "NOT Implemented!"
#else // use buffer access function writes

    int32_t FSLP_write_buffer(int32_t port_id, uint8_t *frame_buf, int32_t len)
    {
        int32_t result;
        result = write_buffer(port_handles[port_id], frame_buf, len);
        FSLP_flush_write_buffer(port_id);
        return (len + result); //returns len if successful, len-1 or len-2 according to FLIR_Win32_Serial interface.
    }
#endif// WRITE_BUFFER_AS_SINGLE_BYTES vs frame writes

