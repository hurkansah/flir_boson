#include <stdio.h>
#include <stdint.h>
#include <stdlib.h>
#include "Client_API.h"
#include "EnumTypes.h"
#include "UART_Connector.h"


int main()
{
	uint32_t idx;
	
	FLR_RESULT result;
	result = Initialize(5, 921600); //COM6, 921600 baud (port_number=5 for COM6) 
	printf("Initialize: 0x%08X\n", result);
	if (result)
	{
		printf("Failed to initialize, exiting.\n");
		Close();
		return EXIT_FAILURE;
	}
	printf("\n");
	printf("CameraSN: ");
	uint32_t camera_sn;
	result = bosonGetCameraSN(&camera_sn);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf(" %d \n", camera_sn);
	
	
	printf("\n");
	FLR_DVO_TYPE_E dvo_src;
	result = dvoGetType(&dvo_src);
	printf("DVO Source:  0x%08X -- 0x%08X \n", result, dvo_src);
	
	
	printf("\n");
	uint32_t major, minor, patch;
	printf("SoftwareRev:  ");
	result = bosonGetSoftwareRev(&major, &minor, &patch);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf(" %u.%u.%u \n", major,minor,patch);
	
	printf("\n");
	FLR_BOSON_SENSOR_PARTNUMBER_T part_num;
	printf("PartNum: ");
	result = bosonGetSensorPN(&part_num);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf(" \"%s\"", part_num.value);
	for (idx=0; idx<sizeof(part_num); idx++)
	{
		uint8_t tempchar = part_num.value[idx];
		if ( !(idx%16) )
			printf("\n\t");
		if (tempchar>=32 && tempchar<=125)
		{
			printf(" \"%c\"",tempchar);
		}
		else
		{
			printf("  %02X",tempchar);
		}
	}
	printf("\n");
	
	printf("\n");
	uint8_t data[256];
	printf("Capture Data[0:255]: ");
	//       memReadCapture(index, offset, num_bytes, empty_data_buffer);
	result = memReadCapture(0, 0, 256, data);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf(" -- ");
	for (idx=0; idx<256; idx++)
	{
		if ( !(idx%16) )
			printf("\n\t");
		printf("  %02X",data[idx]);
	}
	printf("\n");
	printf("Erase Flash: location=%d ",FLR_MEM_LENS_DISTORTION);
	//       memEraseFlash(enum, index);
	result = memEraseFlash(FLR_MEM_LENS_DISTORTION, 1);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf("Success.\n");
	
	printf("\n");
	uint8_t flashdata[64];
	printf("Flash Data[0:64]: ");
	//       memReadFlash(enum, index, offset, num_bytes, empty_data_buffer);
	result = memReadFlash(FLR_MEM_LENS_DISTORTION, 1, 0, 64, flashdata);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf("-- ");
	for (idx=0; idx<64; idx++)
	{
		if ( !(idx%16) )
			printf("\n\t");
		printf("  %02X",flashdata[idx]);
	}
	printf("\n");
	
	uint8_t writedata[64];
	for (idx=0; idx<64; idx++)
	{
		writedata[idx] = idx;
	}
	printf("Write Flash: ");
	result = memWriteFlash(FLR_MEM_LENS_DISTORTION, 1, 0, 64, writedata);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf("success.\n");
	
	printf("\n");
	printf("Confirm Flash Data[0:64]: ");
	//       memReadFlash(enum, index, offset, num_bytes, empty_data_buffer);
	result = memReadFlash(FLR_MEM_LENS_DISTORTION, 1, 0, 64, flashdata);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	for (idx=0; idx<64; idx++)
	{
		if ( !(idx%16) )
			printf("\n\t");
		printf("  %02X",flashdata[idx]);
	}
	printf("\n");
	
	printf("\n");
	printf("Erase Flash: ");
	//       memEraseFlash(enum, index);
	result = memEraseFlash(FLR_MEM_LENS_DISTORTION, 1);
	if (result)
	{
		printf("Failed with status 0x%08X, exiting.\n",result);
		Close();
		return EXIT_FAILURE;
	}
	printf("success.\n");
	
	result = bosonRunFFC();
	printf("RunFFC:  0x%08X \n", result);
	
	printf("\n\nClosing...\n");
	Close();
	return EXIT_SUCCESS;

}