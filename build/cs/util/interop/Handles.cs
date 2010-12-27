using System;
using System.Runtime.InteropServices;


namespace spaghetti.util.interop {


    /// <summary>
    ///
    /// </summary>
    public class Handles {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nStdHandle"></param>
        /// <returns></returns>
        [DllImport( "kernel32.dll", SetLastError = true )]
        public static extern IntPtr GetStdHandle(int nStdHandle);
    }


}
