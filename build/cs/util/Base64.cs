using System;
using System.Text;


namespace spaghetti.util {


    /// <summary>
    /// 文字列を Base64 にエンコード、デコードするメソッドを提供します。
    /// </summary>
    public static class Base64 {
        /// <summary>
        /// 文字列を Base64 でエンコードします。
        /// </summary>
        /// <param name="original_text">エンコードしたい文字列。</param>
        /// <returns>Base64 でエンコードされた文字列。</returns>
        public static string encode64(string original_text) {
            return encode64( original_text, Encoding.Default );
        }
        /// <summary>
        /// 文字列を Base64 でエンコードします。
        /// </summary>
        /// <param name="original_text"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string encode64(string original_text, Encoding encoding) {
            return Convert.ToBase64String( encoding.GetBytes( original_text ) );
        }


        /// <summary>
        /// Base64 でエンコードされた文字列をデコードします。
        /// </summary>
        /// <param name="encoded_text">Base64 でエンコードされた文字列。</param>
        /// <returns>デコードされた文字列。</returns>
        public static string decode64(string encoded_text) {
            return decode64( encoded_text, Encoding.Default );
        }
        /// <summary>
        /// Base64 でエンコードされた文字列をデコードします。
        /// </summary>
        /// <param name="encoded_text"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string decode64(string encoded_text, Encoding encoding) {
            return encoding.GetString( Convert.FromBase64String( encoded_text ) );
        }
    }


}
