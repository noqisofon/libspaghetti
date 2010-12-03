using System;
using System.Text;


namespace spaghetti.util {


    /// <summary>
    /// ������� Base64 �ɃG���R�[�h�A�f�R�[�h���郁�\�b�h��񋟂��܂��B
    /// </summary>
    public static class Base64 {
        /// <summary>
        /// ������� Base64 �ŃG���R�[�h���܂��B
        /// </summary>
        /// <param name="original_text">�G���R�[�h������������B</param>
        /// <returns>Base64 �ŃG���R�[�h���ꂽ������B</returns>
        public static string encode64(string original_text) {
            return encode64( original_text, Encoding.Default );
        }
        /// <summary>
        /// ������� Base64 �ŃG���R�[�h���܂��B
        /// </summary>
        /// <param name="original_text"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string encode64(string original_text, Encoding encoding) {
            return Convert.ToBase64String( encoding.GetBytes( original_text ) );
        }


        /// <summary>
        /// Base64 �ŃG���R�[�h���ꂽ��������f�R�[�h���܂��B
        /// </summary>
        /// <param name="encoded_text">Base64 �ŃG���R�[�h���ꂽ������B</param>
        /// <returns>�f�R�[�h���ꂽ������B</returns>
        public static string decode64(string encoded_text) {
            return decode64( encoded_text, Encoding.Default );
        }
        /// <summary>
        /// Base64 �ŃG���R�[�h���ꂽ��������f�R�[�h���܂��B
        /// </summary>
        /// <param name="encoded_text"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string decode64(string encoded_text, Encoding encoding) {
            return encoding.GetString( Convert.FromBase64String( encoded_text ) );
        }
    }


}
