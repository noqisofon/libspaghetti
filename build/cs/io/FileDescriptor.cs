using System;
using System.Collections.Generic;


namespace spaghetti.io {


    using spaghetti.util.interop;


    /// <summary>
    /// ファイル記述子を表します。
    /// </summary>
    public class FileDescriptor {
        /// <summary>
        /// 無効なファイル記述子を構築します。
        /// </summary>
        public FileDescriptor()
            : this( IntPtr.Zero ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fd"></param>
        internal FileDescriptor(IntPtr fd) {
            this.fd_ = fd;
        }


        /// <summary>
        /// 強制的にすべてのシステムバッファーと基本となるデバイスとの動機を取ります。
        /// </summary>
        public void sync() {
        }


        /// <summary>
        /// 
        /// </summary>
        public static FileDescriptor stdout {
            get {
                IntPtr original_fd = Handles.GetStdHandle( (int)STANDARD_HANEDLES.STD_OUTPUT_HANDLE );
                FileDescriptor ret_fd = null;
                if ( !descritors.ContainsKey( original_fd ) ) {
                    ret_fd = new FileDescriptor( original_fd );
                    descritors.Add( original_fd, ret_fd );
                } else
                    ret_fd = descritors[original_fd];

                return ret_fd;
            }
        }


        /// <summary>
        /// ファイル記述子オブジェクトが有効かどうかを判定します。
        /// </summary>
        public bool valid {
            get {
                return true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private IntPtr fd_;


        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<IntPtr, FileDescriptor> descritors = new Dictionary<IntPtr, FileDescriptor>();
    }


}
