#ifndef spaghetti__T_time_h
#define spaghetti__T_time_h

#include <time.h>
#include <tchar.h>

#ifndef _MSC_VER
#   include "_crt_time.h"
#endif  /* ndef _MSC_VER */
#include "_T_string.h"


inline _TCHAR* _T_ctime(_TCHAR* ctime_buffer, size_t buffer_length, const time_t* time);


inline _TCHAR* _T_ctime(_TCHAR* ctime_buffer, size_t buffer_length, const time_t* time)
{
#if defined(_SPAG_USE_SAFE_FUNCTION)
    errno_t error_code = _tctime_s( ctime_buffer,
                                    buffer_length,
                                    time
                                  );
#else
    _TCHAR* tmp_buffer = _tctime( time );
    _T_strncpy( ctime_buffer, tmp_buffer, buffer_length );
#endif  /* defined(_SPAG_USE_SAFE_FUNCTION) */
    return ctime_buffer;
}





#endif  /* spaghetti__T_time_h */
