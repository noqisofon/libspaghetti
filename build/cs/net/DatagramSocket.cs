using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    using extraio.channels;


    /// <summary>
    /// データグラムパケットを送受信するためのソケットを表します。
    /// </summary>
    public class DatagramSocket {
        /// <summary>
        /// データグラムソケットを構築し、ローカルマシン上の使用可能なポートにバインドします。
        /// </summary>
        public DatagramSocket() {
        }
        /// <summary>
        /// 指定された DatagramSocketImpl を使用してバインドされていないデータグラムソケットを作成します。
        /// </summary>
        /// <param name="implementor"></param>
        protected DatagramSocket(DatagramSocketImpl implementor) {
        }
        /// <summary>
        /// 指定されたローカルアドレスにバインドされたデータグラムソケットを作成します。
        /// </summary>
        /// <param name="port"></param>
        /// <param name="address"></param>
        public DatagramSocket(int port, IPAddress address) {
        }
        /// <summary>
        /// 指定されたローカルアドレスにバインドされたデータグラムソケットを作成します。
        /// </summary>
        /// <param name="point"></param>
        public DatagramSocket(IPEndPoint point) {
        }


        /// <summary>
        /// 
        /// </summary>
        ~DatagramSocket() {
        }


        /// <summary>
        /// このデータグラムソケットを特定のアドレス、およびポートにバインドします。
        /// </summary>
        /// <param name="point"></param>
        public void bind(IPEndPoint point) {
            this.implementor_.bind( point );
        }


        /// <summary>
        /// このデーダグラムソケットを閉じます。
        /// </summary>
        public void close() {
            this.implementor_.close();
        }


        /// <summary>
        /// ソケットをこのソケットのリモートアドレスに接続します。
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public void connect(IPAddress address, int port) {
            this.implementor_.connect( address, port );
        }
        /// <summary>
        /// このソケットをリモートソケットアドレスに接続します。
        /// </summary>
        /// <param name="point"></param>
        public void connect(IPEndPoint point) {
            this.implementor_.connect( point );
        }


        /// <summary>
        /// ソケットを切断します。
        /// </summary>
        public void disconnect() {
            this.implementor_.disconnect();
        }


        /// <summary>
        /// ブロードバンドフラグにアクセスします。
        /// </summary>
        public bool broadband {
            get {
                return this.implementor_.broadband;
            }
            set {
                this.implementor_.broadband = value;
            }
        }


        /// <summary>
        /// このデータグラムソケットに関連する固有のデータグラムチャンネルオブジェクトを返します。
        /// </summary>
        /// <remarks>存在しない場合、null を返します。</remarks>
        public DatagramChannel channel {
            get {
                return null;
            }
        }


        /// <summary>
        /// このソケットの接続先のアドレスを返します。
        /// </summary>
        public IPAddress remoteAddress {
            get {
                return this.implementor_.remoteEndPoint.Address;
            }
        }


        /// <summary>
        /// ソケットのバインド先のローカルアドレスを取得します。
        /// </summary>
        public IPAddress localAddress {
            get {
                return this.implementor_.localEndPoint.Address;
            }
        }


        /// <summary>
        /// このソケットがバインドされているエンドポイントを返します。
        /// </summary>
        public IPEndPoint localEndPoint {
            get {
                return this.implementor_.localEndPoint;
            }
        }


        /// <summary>
        /// このソケットのためのポート番号にアクセスします。
        /// </summary>
        public int port {
            get {
                return this.port;
            }
            set {
                this.port = value;
            }
        }


        /// <summary>
        /// このデータグラムソケットで使われる受信用バッファの長さにアクセスします。
        /// </summary>
        public int receiveBufferSize {
            get {
                return this.implementor_.receiveBufferSize;
            }
            set {
                this.implementor_.receiveBufferSize = value;
            }
        }


        /// <summary>
        /// SO_REUSEADDR が有効かどうかを調べます。
        /// </summary>
        public bool reuseAddress {
            get {
                return this.implementor_.reuseAddress;
            }
        }


        /// <summary>
        /// このソケットが接続されている先のエンドポイントを返します。
        /// </summary>
        public IPEndPoint remoteEndPoint {
            get {
                return this.implementor_.remoteEndPoint;
            }
        }


        /// <summary>
        /// このデータグラムソケットで使われる送信用バッファの長さをアクセスします。
        /// </summary>
        public int sendBufferSize {
            get {
                return this.implementor_.sendBufferSize;
            }
        }


        /// <summary>
        /// タイムアウト値にアクセスします。
        /// </summary>
        public int timeout {
            get {
                return this.implementor_.timeout;
            }
            set {
                this.implementor_.timeout = value;
            }
        }


        /// <summary>
        /// このデータグラムソケットから送信されるパケットの IP データグラムヘッダーのトラフィッククラス
        /// またはサービス型にアクセスします。
        /// </summary>
        public int trafficClass {
            get {
                return this.implementor_.trafficClass;
            }
            set {
                this.implementor_.trafficClass = value;
            }
        }


        /// <summary>
        /// ソケットがバインドされていたら真を返します。
        /// </summary>
        public bool isBound {
            get {
                return this.implementor_.isBound;
            }
        }


        /// <summary>
        /// ソケットが閉じられていれば真を返します。
        /// </summary>
        public bool isClosed {
            get {
                return this.implementor_.isClosed;
            }
        }


        /// <summary>
        /// ソケットが何れかのエンドポイントに接続されていれば真を返します。
        /// </summary>
        public bool isConnected {
            get {
                return this.implementor_.isConnected;
            }
        }


        /// <summary>
        /// このソケットからのデータグラムパケットを受信します。
        /// </summary>
        /// <param name="packet"></param>
        public void receive(DatagramPacket packet) {
            this.implementor_.receive( packet );
        }


        /// <summary>
        /// このソケットからデータグラムパケットを送信します。
        /// </summary>
        /// <param name="packet"></param>
        public void send(DatagramPacket packet) {
            this.implementor_.send( packet );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="new_factory"></param>
        public static void setDatagramSocketImplFactory(DatagramSocketImplFactory new_factory) {
            factory = new_factory;
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private DatagramSocketImpl implementor_ = null;


        /// <summary>
        /// 
        /// </summary>
        private static DatagramSocketImplFactory factory;
    }


}
