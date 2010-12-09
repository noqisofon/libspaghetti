#ifndef spaghetti__crt_time_h
#define spaghetti__crt_time_h

#include <errno.h>
#include <time.h>
#include <tchar.h>

#include "errno_t.h"


inline errno_t localtime_s(struct tm* _Tm, const time_t* time);
inline errno_t ctime_s(char* buffer, size_t numberOfElements, const time_t* time);
inline errno_t arctime_s(char* buffer, size_t numberOfElements, const struct tm* _Tm);


inline errno_t ctime_s(char* buffer, size_t numberOfElements, const time_t* time) {
    if ( buffer == NULL ) {

        return EINVAL;
    } else {
        if ( numberOfElements == 0 ) {
            buffer[0]   = _T('\0');
        } else if ( 0 < numberOfElements && numberOfElements < 26 ) {
            buffer[0]   = _T('\0');
        } else {
            if ( time == NULL ) {
                buffer[0]   = _T('\0');
            } else {
                buffer[0]   = _T('\0');
            }
        }
        return EINVAL;
    }

    _tcsftime( buffer, numberOfElements, _T("%b %a %d %T %Y%n") );

    return errno;
}


inline errno_t localtime_s(struct tm* _Tm, const time_t* time) {
    if ( _TM == NULL ) {

        return EINVAL;
    } else {
        if ( time == NULL ) {
            
        } else if ( *time < 0 || *time > _MAX_TIME64_T ) {
            
        }

        return EINVAL;
    }
    _Tm    = localtime( time );

    return errno;
}


inline errno_t arctime_s(char* buffer, size_t numberOfElements, const struct tm* _Tm)
{
    if ( buffer == NULL ) {

        return EINVAL;
    } else {
        if ( numberOfElements == 0 ) {
        } else {
            buffer[0]   = _T('\0');
        }
        return EINVAL;
    }
    
}


#endif  /* spaghetti__crt_time_h */
