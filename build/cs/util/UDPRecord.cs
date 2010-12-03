using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.util {


    /// <summary>
    ///
    /// </summary>
    public struct UDPRecord {
        /// <summary>
        /// 
        /// </summary>
        public UdpClient client;
        /// <summary>
        /// 
        /// </summary>
        public IPEndPoint endpoint;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="_endpoint"></param>
        public UDPRecord(UdpClient _client, IPEndPoint _endpoint) {
            this.client = _client;
            this.endpoint = _endpoint;
        }
    }


}
