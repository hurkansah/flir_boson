#include "timeoutLogic.h"

#if defined(__linux__) || defined(__FreeBSD__)
//pass
#else //windows
int clock_gettime(int _ignore, struct timespec *spec)      //C-file part
{
    __int64 wintime; GetSystemTimeAsFileTime((FILETIME*)&wintime);
    wintime      -=116444736000000000L;  //1jan1601 to 1jan1970
    spec->tv_sec  =wintime / 10000000L;           //seconds
    spec->tv_nsec =wintime % 10000000L *100;      //nano-seconds
    return 0;
}

double difftime(long current, long reference)
{
    return ((double)current - (double)reference);
}

#endif

double diff_timespec(struct timespec *current, struct timespec *reference)
{
    double elapsed_sec = difftime(current->tv_sec, reference->tv_sec);
    elapsed_sec += (((double)current->tv_nsec) - ((double)reference->tv_nsec))/1000000000;
    return elapsed_sec;
}
