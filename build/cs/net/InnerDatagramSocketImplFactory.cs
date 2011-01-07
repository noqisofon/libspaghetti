using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    /// <summary>
    ///
    /// </summary>
    internal class InnerDatagramSocketImplFactory : DatagramSocketImplFactory {
        /// <summary>
        /// 
        /// </summary>
        public InnerDatagramSocketImplFactory()
            : this( AddressFamily.InterNetwork, ProtocolType.IPv4 ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="address_family"></param>
        /// <param name="protocol_type"></param>
        public InnerDatagramSocketImplFactory(AddressFamily address_family, ProtocolType protocol_type) {
            this.address_family_ = address_family;
            this.protocol_type_ = protocol_type;
        }


        #region DatagramSocketImplFactory ÉÅÉìÉo
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DatagramSocketImpl createDatagramSocketImpl() {
            return new InnerDatagramSocket( address_family_, protocol_type_ );
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        private AddressFamily address_family_;
        /// <summary>
        /// 
        /// </summary>
        private ProtocolType protocol_type_;
    }


}
