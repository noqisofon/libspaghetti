
inline size_t _T_strlen(const _TCHAR* s) {
    return _tcslen( s );
}



inline int _T_stricmp(const _TCHAR* _1, const _TCHAR* _2) {
    return _tcsicmp( _1, _2 );
}



inline _TCHAR* _T_strcpy(_TCHAR* dest, const _TCHAR* src) {
    return _T_strncpy( dest, src, _T_strlen( dest ) );
}


inline _TCHAR* _T_strncpy(_TCHAR* dest, const _TCHAR* src, size_t size) {
#   if defined(_SPAG_USE_SAFE_FUNCTION)
    return _S_strncpy( dest, size, src, size );
#   else
    return _tcsncpy( dest, src, size );
#   endif  /* defined(_SPAG_USE_SAFE_FUNCTION) */
}


inline _TCHAR* _S_strncpy( _TCHAR* dest, size_t dest_length, const _TCHAR* src, size_t src_length ) {
#   if defined(_SPAG_USE_SAFE_FUNCTION)
    _tcsncpy_s( dest, dest_length, src, src_length );
#else
    _tcsncpy( dest, src, dest_length );
#endif
    return dest;
}


inline _TCHAR* _T_strcat(_TCHAR* dest, const _TCHAR* src) {
#   if defined(_SPAG_USE_SAFE_FUNCTION)
    _tcscat_s( dest, _T_strlen( src ), src );

    return dest;
#   else
    return _tcscat( dest, src );
#   endif  /* defined(_SPAG_USE_SAFE_FUNCTION) */
}


inline _TCHAR* _S_strncat(_TCHAR* dest, const _TCHAR* src, size_t size) {
#   if defined(_SPAG_USE_SAFE_FUNCTION)
    _tcsncat_s( dest, _T_strlen(dest), src, size );

    return dest;
#   else
    return _tcsncat( dest, src, size );
#   endif  /* defined(_SPAG_USE_SAFE_FUNCTION) */
}
