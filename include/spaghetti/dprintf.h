#ifndef spaghetti_dprintf_h
#define spaghetti_dprintf_h


#if defined(_WIN32)

#   ifndef dprintf

#   include <tchar.h>
#   include <windows.h>

/**
 * @def _DPRINTF_MSG_LENGTH
 * Visual Studio のデバッグ窓の横幅に対応する文字数(バイト数ではありません)。
 */
#       define     _DPRINTF_MSG_LENGTH     256

/*
 * デバッグビルドのときだけ、VS の出力窓にメッセージを出します。
 */
#       if defined(_DEBUG)
static 


inline int _D_printf_real(const _TCHAR* format, ...) {
    _TCHAR  message_buffer[_DPRINTF_MSG_LENGTH];

    va_list arguments;
    va_start(arguments, format);
    int result = _vsntprintf( message_buffer, _DPRINTF_MSG_LENGTH, format, arguments );
    va_end(arguments);

    OutputDebugString( message_buffer );

    return result;
}
#           define      dprintf         _D_printf_real
#       else
#           define      dprintf         __noop
#       endif  /* defined(_DEBUG) */


#   endif  /* dprintf */


#endif  /* _WIN32 */


#endif  /* spaghetti_dprintf_h */
