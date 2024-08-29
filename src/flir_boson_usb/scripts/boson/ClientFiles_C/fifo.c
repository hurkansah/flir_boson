/******************************************************************************/
/*                                                                            */
/*  Copyright (C) 2017, FLIR Systems                                          */
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

/**
 * @file   fifo.c
 * @author Artur Tynecki
 * @date   May, 2017
 * @brief  FIFO implementation source file
 *
 */

/******************************************************************************/
/** INCLUDE FILES                                                            **/
/******************************************************************************/
#include <stdlib.h>
#include <string.h>
#include <stdio.h>

#include "fifo.h"

/******************************************************************************/
/** EXPORTED DEFINES                                                         **/
/******************************************************************************/
#define DO_TRACE(s, x...)                //printf("%s: " s, __FUNCTION__, ##x)
#define DO_INIT_TRACE(s, x...)           //printf("%s: " s, __FUNCTION__, ##x)
#define DO_DATA_SERVICE_TRACE(s, x...)   //printf("%s: " s, __FUNCTION__, ##x)
#define DEBUG_ERR(s, x...)               printf("%s: " s, __FUNCTION__, ##x)
#define DEBUG_WARN(s, x...)              //printf("%s: " s, __FUNCTION__, ##x)

#define MIN(a,b) ((a) < (b) ? (a) : (b))

/******************************************************************************/
/** EXPORTED PUBLIC FUNCTIONS                                                **/
/******************************************************************************/

/******************************************************************************/
fifo_p fifoCreate(uint32_t size)
{
    fifo_p fifo;

    if(size < 1)
    {
       DEBUG_ERR("Incorrect argument - buffer size smaller than 1\n");
        return NULL;
    }

    fifo = malloc(sizeof(fifo_t));
    if(!fifo)
    {
        DEBUG_ERR("Fifo structure memory allocation error occurred\n");
        return NULL;
    }

    fifo->head = fifo->tail =  fifo->length = 0;
    fifo->buffer = malloc(size * sizeof(uint8_t));
    if(!fifo->buffer)
    {
        free(fifo);
        DEBUG_ERR("Fifo buffer memory allocation error occurred\n");
        return NULL;
    }
    fifo->size = size;
    memset(fifo->buffer, 0, sizeof(fifo->buffer));

    if(pthread_mutex_init(&fifo->buffer_mutex, NULL) != 0)
    {
        free(fifo->buffer);
        free(fifo);
        DEBUG_ERR("Mutex initalization error occurred\n");
        return NULL;
    }

    return fifo;
}

/******************************************************************************/
void fifoDestroy(fifo_p fifo)
{
    if(!fifo)
    {
        free(fifo->buffer);
        free(fifo);
    }
}

/******************************************************************************/
FLR_RESULT fifoWrite(fifo_p fifo, uint8_t* data, uint32_t data_len, uint32_t* data_len_out)
{
    uint32_t part;
    int ret = 0;

    if(!fifo || !data || !data_len || !data_len_out)
    {
       DEBUG_ERR("Incorrect arguments\n");
        return FLR_ERROR;
    }

    /** check buffer is full */
    if(fifo->length == fifo->size)
    {
        *data_len_out = 0;
        return FLR_OK;
    }

    ret = pthread_mutex_lock(&fifo->buffer_mutex);
    if(ret != 0)
    {
        DEBUG_ERR("Lock FIFO mutex error occurred [%d]\n", ret);
        return FLR_ERROR;
    }

    /* set possible data length to write */
    data_len = MIN(data_len, (fifo->size - fifo->length));
    *data_len_out = data_len;

    /* set data from head to buffer end or tail */
    part = MIN(data_len, fifo->size - fifo->head);
    memcpy(&fifo->buffer[fifo->head], data, part);
    fifo->head += part;

    /* set data from buffer beginning if it is necessary */
    if(part < data_len)
    {
        memcpy(fifo->buffer, data + part, data_len - part);
        fifo->head = data_len - part;
    }

    if(fifo->head == fifo->size)
    {
        fifo->head = 0;
    }

    /* update buffer length */
    fifo->length+=data_len;

    ret = pthread_mutex_unlock(&fifo->buffer_mutex);
    if(ret != 0)
    {
        DEBUG_ERR("Unlock FIFO mutex error occurred [%d]\n", ret);
        return FLR_ERROR;
    }

    return FLR_OK;
}

/******************************************************************************/
FLR_RESULT fifoRead(fifo_p fifo, uint8_t* data, uint32_t data_len, uint32_t* data_len_out)
{
    uint32_t part;
    int ret = 0;

    if(!fifo || !data || !data_len || !data_len_out)
    {
        DEBUG_ERR("Incorrect arguments\n");
        return FLR_ERROR;
    }

    /** check buffer is empty */
    if(fifo->length == 0)
    {
        *data_len_out = 0;
        return FLR_OK;
    }

    ret = pthread_mutex_lock(&fifo->buffer_mutex);
    if(ret != 0)
    {
        DEBUG_ERR("Lock FIFO mutex error occurred [%d]\n", ret);
        return FLR_ERROR;
    }

    /* set possible data length to read */
    data_len = MIN(data_len, fifo->length);
    *data_len_out = data_len;

    /* get data from tail to buffer end or head */
    part = MIN(data_len, fifo->size - fifo->tail);
    memcpy(data, &fifo->buffer[fifo->tail], part);
    fifo->tail += part;

    /* get data from buffer beginning if it is necessary */
    if(part < data_len)
    {
        memcpy(&data[part], fifo->buffer, data_len - part);
        fifo->tail = data_len - part;
    }

    if(fifo->tail == fifo->size)
    {
        fifo->tail = 0;
    }

    /* update buffer length */
    fifo->length-=data_len;

    ret = pthread_mutex_unlock(&fifo->buffer_mutex);
    if(ret != 0)
    {
        DEBUG_ERR("Unlock FIFO mutex error occurred [%d]\n", ret);
        return FLR_ERROR;
    }

    return FLR_OK;
}
