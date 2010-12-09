#ifndef spaghetti_auto_resource_h
#define spaghetti_auto_resource_h


/**
 * ���\�[�X�t�@�C���Ŏg�p����o�[�W�������쐬���܂��B
 *     @param    Major   ���W���[�o�[�W�����B
 *     @param    Minor   �}�C�i�[�o�[�W�����B
 *     @param    Revison ���r�W�����B
 *     @param    Build   �r���h�B
 */
#define     MAKE_VERSION(Major, Minor, Revison, Build)            Major, Minor, Revison, Build


/**
 * 
 */
#define     STRGEN(x)                           _STRGEN(x)


/**
 * 
 */
#define     _STRGEN(x)                          __STRGEN(x)


/**
 * 
 */
#define     __STRGEN(x)                         #x


/**
 * 
 */
#define     TUNNEL(x)                           _TUNNEL(x)


/**
 * 
 */
#define     _TUNNEL(x)                          __TUNNEL(x)


/**
 * 
 */
#define     __TUNNEL(x)                         x


/**
 * 
 */
#define     SYMBOL_CONCAT(a, b)                 a ## b


/**
 * 
 */
#define     SYMBOL_CONCAT3(a, b, c)             SYMBOL_CONCAT(a, b) ## c


/**
 * 
 */
#define     RESOURCES_NULL                      "\0"


/**
 * 
 */
#define     RESOURCE_SYMBOL(symbol)             STRGEN(symbol)


#endif  /* spaghetti_auto_resource_h */
