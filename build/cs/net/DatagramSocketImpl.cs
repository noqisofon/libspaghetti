using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    using spaghetti.io;


    /// <summary>
    /// 抽象デーダグラムおよびマルチキャストソケットを実装する基底クラスです。
    /// </summary>
    public abstract class DatagramSocketImpl {
        /// <summary>
        /// 
        /// </summary>
        public DatagramSocketImpl() {
        }


        /// <summary>
        /// デーダグラムソケットをローカルのポートおよびアドレスにバインドします。
        /// </summary>
        /// <param name="local_port"></param>
        /// <param name="local_address"></param>
        internal void bind(int local_port, IPAddress local_address) {
            bind( new IPEndPoint( local_address, local_port ) );
            this.localPort = local_port;
        }
        /// <summary>
        /// デーダグラムソケットをローカルのポートおよびアドレスにバインドします。
        /// </summary>
        /// <param name="local_point"></param>
        internal abstract void bind(IPEndPoint local_point);


        /// <summary>
        /// ソケットを閉じます。
        /// </summary>
        internal abstract void close();


        /// <summary>
        /// データグラムソケットをリモート接続先に接続します。
        /// </summary>
        /// <param name="remote_address"></param>
        /// <param name="remote_port"></param>
        internal void connect(IPAddress remote_address, int remote_port) {
            connect( new IPEndPoint( remote_address, remote_port ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="remote_point"></param>
        internal abstract void connect(IPEndPoint remote_point);


        /// <summary>
        /// リモート接続先からデーダグラムソケットを切り離します。
        /// </summary>
        internal abstract void disconnect();


        /// <summary>
        /// ソケットがバインドされていたら真を返します。
        /// </summary>
        internal abstract bool isBound {
            get;
        }


        /// <summary>
        /// ソケットが閉じられていれば真を返します。
        /// </summary>
        internal abstract bool isClosed {
            get;
        }


        /// <summary>
        /// ソケットが何れかのエンドポイントに接続されていれば真を返します。
        /// </summary>
        internal abstract bool isConnected {
            get;
        }


        /// <summary>
        /// SO_REUSEADDR が有効かどうかを調べます。
        /// </summary>
        internal abstract bool reuseAddress {
            get;
        }


        /// <summary>
        /// このソケットが接続されている先のエンドポイントを返します。
        /// </summary>
        internal abstract IPEndPoint remoteEndPoint {
            get;
        }


        /// <summary>
        /// このソケットがバインドされているエンドポイントを返します。
        /// </summary>
        internal abstract IPEndPoint localEndPoint {
            get;
        }


        /// <summary>
        /// このデータグラムソケットで使われる送信用バッファの長さをアクセスします。
        /// </summary>
        internal abstract int sendBufferSize {
            get;
            set;
        }


        /// <summary>
        /// このデータグラムソケットで使われる受信用バッファの長さにアクセスします。
        /// </summary>
        internal abstract int receiveBufferSize {
            get;
            set;
        }


        /// <summary>
        /// タイムアウト値にアクセスします。
        /// </summary>
        internal abstract int timeout {
            get;
            set;
        }


        /// <summary>
        /// このデータグラムソケットから送信されるパケットの IP データグラムヘッダーのトラフィッククラス
        /// またはサービス型にアクセスします。
        /// </summary>
        internal abstract int trafficClass {
            get;
            set;
        }


        /// <summary>
        /// ブロードバンドフラグにアクセスします。
        /// </summary>
        internal abstract bool broadband {
            get;
            set;
        }


        /// <summary>
        /// このソケットからのデータグラムパケットを受信します。
        /// </summary>
        /// <param name="packet"></param>
        internal abstract void receive(DatagramPacket packet);


        /// <summary>
        /// このソケットからデータグラムパケットを送信します。
        /// </summary>
        /// <param name="packet"></param>
        internal abstract int send(DatagramPacket packet);


        /// <summary>
        /// 
        /// </summary>
        internal FileDescriptor fileDescriptor {
            get { return this.fd_; }
            set { this.fd_ = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        internal int localPort {
            get { return this.local_port_; }
            set { this.local_port_ = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private FileDescriptor fd_;
        /// <summary>
        /// 
        /// </summary>
        private int local_port_;
    }


}
