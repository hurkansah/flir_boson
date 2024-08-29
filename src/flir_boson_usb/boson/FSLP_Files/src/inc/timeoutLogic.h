#ifndef _TIMEOUT_LOGIC_H
#define _TIMEOUT_LOGIC_H
#if defined(__linux__) || defined(__FreeBSD__)

#include <time.h>
#include <unistd.h>
#include <sys/time.h>

#else  //on windows

#include <Windows.h>
#define CLOCK_MONOTONIC 0
struct timespec { long tv_sec; long tv_nsec; };    //header part
int clock_gettime(int _ignore, struct timespec *spec);      //C-file part
double difftime(long current, long reference);

#endif

double diff_timespec(struct timespec *current, struct timespec *reference);

#endif //_TIMEOUT_LOGIC_H