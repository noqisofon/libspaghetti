////////////////////////////////////////////////////////////////////////////////
// 
// ビット演算マクロ。
//
/**
 * @def _USE_MACROIN_INLINE_FUNCTION
 * マクロ関数の内容を同じ内容のインライン関数を呼ぶように切り替えます。
 */
#if defined(_USE_MACROIN_INLINE_FUNCTION)
inline unsigned char shift_long(unsigned long x) {
    return __STATIC_CAST(unsigned char,  0x000000ffu & x);
}
inline unsigned char shift_long(unsigned long x, size_t shift) {
    return __STATIC_CAST( unsigned char,  0x000000ffu & ( x >> (8 * shift) ) );
}
inline long make_long(unsigned char w, unsigned char x, unsigned char y, unsigned char z) {
    return ( 0xff000000 & (w << 24) ) |
           ( 0x00ff0000 & (x << 16) ) |
           ( 0x0000ff00 & (y <<  8) ) |
           ( 0x000000ff & (z      ) );
}
#   define     MAKE_LONG(W,X,Y,Z)       make_long(W, X, Y, Z)
#   define     SHIFT_LONG0(X)           shift_long(X, 3)
#   define     SHIFT_LONG1(X)           shift_long(X, 2)
#   define     SHIFT_LONG2(X)           shift_long(X, 1)
#   define     SHIFT_LONG3(X)           shift_long(X)
#else
#   define     MAKE_LONG(W,X,Y,Z)  ( (long)( (long)(0xff000000 & ( ( (unsigned char)W) << 24) ) | \
                                             (long)(0x00ff0000 & ( ( (unsigned char)X) << 16) ) | \
                                             (long)(0x0000ff00 & ( ( (unsigned char)Y) <<  8) ) | \
                                             (long)(0x000000ff &   ( (unsigned char)Z)      ) ) )

#   define     SHIFT_LONG0(X)       ( (unsigned char)(0x000000ff & ( ( (unsigned long)X) >> 24) ) )
#   define     SHIFT_LONG1(X)       ( (unsigned char)(0x000000ff & ( ( (unsigned long)X) >> 16) ) )
#   define     SHIFT_LONG2(X)       ( (unsigned char)(0x000000ff & ( ( (unsigned long)X) >>  8) ) )
#   define     SHIFT_LONG3(X)       ( (unsigned char)(0x000000ff & ( ( (unsigned long)X)      ) ) )
#endif  /* defined(_USE_MACROIN_INLINE_FUNCTION) */
