using System;
using System.Collections.Generic;
using System.Text;


namespace spaghetti.net {


    /// <summary>
    ///
    /// </summary>
    public interface DatagramSocketImplFactory {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DatagramSocketImpl createDatagramSocketImpl();
    }


}
