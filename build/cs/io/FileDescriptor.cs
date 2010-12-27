using System;
using System.Collections.Generic;


namespace spaghetti.io {


    using spaghetti.util.interop;


    /// <summary>
    /// �t�@�C���L�q�q��\���܂��B
    /// </summary>
    public class FileDescriptor {
        /// <summary>
        /// �����ȃt�@�C���L�q�q���\�z���܂��B
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
        /// �����I�ɂ��ׂẴV�X�e���o�b�t�@�[�Ɗ�{�ƂȂ�f�o�C�X�Ƃ̓��@�����܂��B
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
        /// �t�@�C���L�q�q�I�u�W�F�N�g���L�����ǂ����𔻒肵�܂��B
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
