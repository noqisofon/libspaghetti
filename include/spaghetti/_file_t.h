#ifndef spaghetti__file_t_h
#define spaghetti__file_t_h

#include <stdio.h>
#include <stdarg.h>
#include <tchar.h>


namespace spaghetti {


    class _file_t {
     public:
        _file_t() : fp_(NULL), is_closed_(false) {
        }
        _file_t(_TCHAR* filename, _TCHAR* mode) : fp_(NULL), is_closed_(false) {
#ifdef _MSC_VER
            errno_t er = ::_tfopen_s( &fp_, filename, mode );
#else
            fp_ = ::_tfopen( filename, mode );
#endif  /* def _MSC_VER */
        }


        ~_file_t() {
            close();
        }

     public:
        operator const FILE* () {
            return fp_;
        }


        const FILE* get_filepointer() const {
            return fp_;
        }


        bool operator == (const _file_t& other) const {
            return other.fp_ == fp_;
        }
        bool operator == (const FILE* const& other) const {
            return other == fp_;
        }


        int puts() {
            return ::_fputts( _T(""), fp_ );
        }
        int puts(const _TCHAR* s) {
            return ::_fputts( s, fp_ );
        }


        int putc(_TCHAR ch) {
            return ::_fputtc( ch, fp_ );
        }


        int print(const _TCHAR* s) {
            return ::_ftprintf( fp_, s );
        }


        int printf(const _TCHAR* format, ...) {
            va_list arguments;
            va_start( arguments, format );
            int result = ::_vftprintf( fp_, format, arguments );
            va_end(arguments);

            return result;
        }


        void close() {
            if ( !is_closed_ ) {
                ::fclose( fp_ );
                is_closed_ = true;
            }
        }


        void attach(FILE* const fp) {
            if ( fp != NULL ) {
                fp_        = fp;
                is_closed_ = false;
            }
        }


        FILE* detach() {
            FILE* result_fp = fp_;
            fp_        = NULL;
            is_closed_ = true;

            return result_fp;
        }


        int tell() const {
            return ::ftell( fp_ );
        }


        int seek(long offset, int origin = SEEK_CUR) {
            return ::fseek( fp_, offset, origin );
        }


        int flush() {
            return ::fflush( fp_ );
        }

     private:
        FILE*  fp_;
        bool   is_closed_;
    };


}


#endif  /* spaghetti__file_t_h */
