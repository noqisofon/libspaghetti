#ifndef spaghetti__T_stdio_h
#define spaghetti__T_stdio_h

#include <stdio.h>
#include <tchar.h>

#if defined(__UNIX__)
#   include "errno_t.h"
#endif  /* defined(__UNIX__) */


#if defined(__UNIX__)
errno_t _tfopen_s(FILE** pstream, const _TCHAR* filename, const _TCHAR* mode);
#endif  /* defined(__UNIX__) */


FILE* _T_fopen(const _TCHAR* filename, const _TCHAR* mode);


#if defined(_SPAG_USE_INLINE_FUNCTION)
#   include "_T_stdio.inl"
#endif  /* defined(_SPAG_USE_INLINE_FUNCTION) */


#endif  /* spaghetti__T_stdio_h */
