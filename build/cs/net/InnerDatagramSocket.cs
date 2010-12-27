using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    /// <summary>
    /// 
    /// </summary>
    internal class InnerDatagramSocket : DatagramSocketImpl {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="local_point"></param>
        internal override void bind(IPEndPoint local_point) {
            this.socket_.Bind( local_point );
            this.is_bound_ = true;
        }


        /// <summary>
        /// 
        /// </summary>
        internal override void close() {
            if ( this.is_closed_ ) {
                this.socket_.Close();
                this.is_closed_ = true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="remote_point"></param>
        internal override void connect(IPEndPoint remote_point) {
            this.socket_.Connect( remote_point );
        }


        /// <summary>
        /// 
        /// </summary>
        internal override void disconnect() {
            this.socket_.Disconnect( resuse_socket_ );
            this.is_connected_ = false;
        }


        /// <summary>
        /// 
        /// </summary>
        internal override bool isBound {
            get { return this.is_bound_; }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override bool isClosed {
            get { return this.is_closed_; }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override bool isConnected {
            get { return this.is_connected_; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="packet"></param>
        internal override void receive(DatagramPacket packet) {
            this.socket_.Receive( packet.data );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="packet"></param>
        internal override int send(DatagramPacket packet) {
            return this.socket_.Send( packet.data, packet.length, this.flags_ );
        }


        /// <summary>
        /// 
        /// </summary>
        internal override bool reuseAddress {
            get { return this.resuse_socket_; }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override IPEndPoint remoteEndPoint {
            get { return this.remote_point_; }
        }


        /// <summary>
        /// このソケットがバインドされているエンドポイントを返します。
        /// </summary>
        internal override IPEndPoint localEndPoint {
            get {
                return this.local_point_;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override int sendBufferSize {
            get { return this.socket_.SendBufferSize; }
            set { this.socket_.SendBufferSize = value; }
        }


        /// <summary>
        /// このデータグラムソケットで使われる受信用バッファの長さにアクセスします。
        /// </summary>
        internal override int receiveBufferSize {
            get { return this.socket_.ReceiveBufferSize; }
            set { this.socket_.ReceiveBufferSize = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override int timeout {
            get {
                return this.timeout_;
            }
            set {
                this.timeout_ = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override int trafficClass {
            get {
                return this.traffic_class_;
            }
            set {
                this.traffic_class_ = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        internal override bool broadband {
            get {
                return this.broadband_;
            }
            set {
                this.broadband_ = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private Socket socket_ = null;
        /// <summary>
        /// 
        /// </summary>
        private IPEndPoint local_point_ = null;
        /// <summary>
        /// 
        /// </summary>
        private IPEndPoint remote_point_ = null;
        /// <summary>
        /// 閉じられているかどうか。
        /// </summary>
        private bool is_closed_ = false;
        /// <summary>
        /// バインドされているかどうか。
        /// </summary>
        private bool is_bound_ = false;
        /// <summary>
        /// 接続しているかどうか。
        /// </summary>
        private bool is_connected_ = false;
        /// <summary>
        /// 
        /// </summary>
        private bool resuse_socket_ = false;
        /// <summary>
        /// 
        /// </summary>
        private int timeout_ = 3;
        /// <summary>
        /// 
        /// </summary>
        private int traffic_class_ = 0;
        /// <summary>
        /// 
        /// </summary>
        private bool broadband_ = false;
        /// <summary>
        /// 
        /// </summary>
        private SocketFlags flags_ = SocketFlags.None;

    }


}
