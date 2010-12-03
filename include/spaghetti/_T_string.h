#ifndef spaghetti_T_string_h
#define spaghetti_T_string_h

#ifndef _SPAG_NON_STANDALONE_MODULE

#   include <string.h>
#   include <tchar.h>

/**
 * M$ �W���̃Z�[�t�֐����g�p���܂��B
 */
#   ifdef _MSC_VER
#       define      _SPAG_USE_SAFE_FUNCTION
#   endif  /* def _MSC_VER */
#   define     _SPAG_USE_INLINE_FUNCTION
#endif  /* ndef _NON_STANDALONE_MODULE */


////////////////////////////////////////////////////////////////////////////////
//
// �v���g�^�C�v�錾�B
//
/**
 * �w�肳�ꂽ������̒�����Ԃ��܂��B
 */
size_t _T_strlen(const _TCHAR* s);


/**
 * 2 �̕�������������Ƃ��Ĕ�r���܂��B
 *      @return 2 �̕�����̊֌W�������l�B
 */
int _T_stricmp(const _TCHAR* _1, const _TCHAR* _2);


/**
 * dest �� src ���R�s�[���܂��B
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
 * dest �� size ������ src ���R�s�[���܂��B
 */
_TCHAR* _T_strncpy(_TCHAR* dest, const _TCHAR*  src, size_t size);


_TCHAR* _S_strncpy(_TCHAR* dest, size_t dest_length, const _TCHAR* src, size_t src_length);


#if defined(_SPAG_USE_INLINE_FUNCTION)
#   include "_T_string.inl"
#endif  /* defined(_SPAG_USE_INLINE_FUNCTION) */



#endif  /* spaghetti_T_string_h */
