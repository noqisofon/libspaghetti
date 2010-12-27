using System;
using System.Collections.Generic;
using System.Text;


namespace spaghetti.extraio.channels {


    /// <summary>
    /// SelectableChannel �� Selector �ɓo�^����Ă��邱�Ƃ������g�[�N���ł��B
    /// </summary>
    public class SelectionKey {
        /// <summary>
        /// 
        /// </summary>
        public static readonly int OP_ACCEPT  = 0x0001;
        /// <summary>
        /// 
        /// </summary>
        public static readonly int OP_CONNECT = 0x0002;
        /// <summary>
        /// 
        /// </summary>
        public static readonly int OP_READ    = 0x0004;
        /// <summary>
        /// 
        /// </summary>
        public static readonly int OP_WRITE   = 0x0008;
    }


}
