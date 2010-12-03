#ifndef spaghetti_T_string_h
#define spaghetti_T_string_h

#ifndef _SPAG_NON_STANDALONE_MODULE

#   include <string.h>
#   include <tchar.h>

/**
 * M$ 標準のセーフ関数を使用します。
 */
#   ifdef _MSC_VER
#       define      _SPAG_USE_SAFE_FUNCTION
#   endif  /* def _MSC_VER */
#   define     _SPAG_USE_INLINE_FUNCTION
#endif  /* ndef _NON_STANDALONE_MODULE */


////////////////////////////////////////////////////////////////////////////////
//
// プロトタイプ宣言。
//
/**
 * 指定された文字列の長さを返します。
 */
size_t _T_strlen(const _TCHAR* s);


/**
 * 2 つの文字列を小文字として比較します。
 *      @return 2 つの文字列の関係を示す値。
 */
int _T_stricmp(const _TCHAR* _1, const _TCHAR* _2);


/**
 * dest に src をコピーします。
 */
_TCHAR* _T_strcpy(_TCHAR* dest, const _TCHAR* src);


/**
 *
 */
_TCHAR* _T_strcat(_TCHAR* dest, const _TCHAR* src);


/**
 *
 */
_TCHAR* _S_strncat(_TCHAR* dest, const _TCHAR*  src, size_t size);


/**
 * dest に size 分だけ src をコピーします。
 */
_TCHAR* _T_strncpy(_TCHAR* dest, const _TCHAR*  src, size_t size);


_TCHAR* _S_strncpy(_TCHAR* dest, size_t dest_length, const _TCHAR* src, size_t src_length);


#if defined(_SPAG_USE_INLINE_FUNCTION)
#   include "_T_string.inl"
#endif  /* defined(_SPAG_USE_INLINE_FUNCTION) */



#endif  /* spaghetti_T_string_h */
