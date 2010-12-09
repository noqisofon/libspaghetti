// _T_stdio.inl


#if defined(__UNIX__)
inline errno_t _tfopen_s(FILE** pstream, const _TCHAR* filename, const _TCHAR* mode) {
    errno_t   err;

    if ( !pstream )
        return EINVAL;
    if ( !filename )
        return EINVAL;
    if ( !mode )
        return EINVAL;

    *stream = _tfopen( filename, mode );
    if ( NULL == *stream )
        err = errno;

    return err;
}
#endif  /* defined(__UNIX__) */


inline FILE* _T_fopen(const _TCHAR* filename, const _TCHAR* mode) {
    FILE*    stream = NULL;
#if defined(_SPAG_USE_SAFE_FUNCTION)
    errno_t err = _ftopen_s( &stream, filename, mode );
    if ( !err ) {

        return NULL;
    }
#else
    stream = _tfopen( filename, mode );
#endif  /* defined(_SPAG_USE_SAFE_FUNCTION) */
    return stream;
}
