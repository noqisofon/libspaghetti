using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace spaghetti.util {


    /// <summary>
    /// �ȒP�ȃ��K�[�N���X�ł��B
    /// </summary>
    public class Logger {
        /// <summary>
        /// 
        /// </summary>
        protected Logger(string filename) {
            this.logfile_ = new FileInfo( filename );
        }


        /// <summary>
        /// ���O���������݂܂��B
        /// </summary>
        /// <param name="text"></param>
        public void log(string text) {
            using ( FileStream stream = this.logfile_.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ) ) {

                using ( StreamWriter writer = new StreamWriter( stream ) ) {
                    writer.WriteLine( "{0:o} {1}", DateTime.Now, text );
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="param"></param>
        public void log(string format, params object[] param) {
            log( string.Format( format, param ) );
        }


        /// <summary>
        /// �A�v���P�[�V�����̏I����\�����߂ɉ��s���܂��B
        /// </summary>
        public void exitSession() {
            using ( FileStream stream = this.logfile_.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ) ) {

                using ( StreamWriter writer = new StreamWriter( stream ) ) {
                    writer.WriteLine();
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Logger getLogger(string filename) {
            Logger result_logger = null;

            if ( logger_pool.ContainsKey( filename ) )
                result_logger = logger_pool[filename];
            else {
                result_logger = new Logger( filename );

                logger_pool.Add( filename, result_logger );
            }
            return result_logger;

        }


        /// <summary>
        /// 
        /// </summary>
        private FileInfo logfile_;
        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, Logger> logger_pool = new Dictionary<string, Logger>();
    }


}
