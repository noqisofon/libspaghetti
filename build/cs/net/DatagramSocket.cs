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
        }


        /// <summary>
        /// ソケットをこのソケットのリモートアドレスに接続します。
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public void connect(IPAddress address, int port) {
        }
        /// <summary>
        /// このソケットをリモートソケットアドレスに接続します。
        /// </summary>
        /// <param name="point"></param>
        public void connect(IPEndPoint point) {
        }


        /// <summary>
        /// ソケットを切断します。
        /// </summary>
        public void disconnect() {
        }


        /// <summary>
        /// ブロードバンドフラグにアクセスします。
        /// </summary>
        public bool broadband {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// このデータグラムソケットに関連する固有のデータグラムチャンネルオブジェクトを返します。
        /// </summary>
        /// <remarks>存在しない場合、null を返します。</remarks>
        public DatagramChannel channel {
            get {

            }
        }


        /// <summary>
        /// このソケットの接続先のアドレスを返します。
        /// </summary>
        public IPAddress remoteAddress {
            get {

            }
        }


        /// <summary>
        /// ソケットのバインド先のローカルアドレスを取得します。
        /// </summary>
        public IPAddress localAddress {
            get {
            }
        }


        /// <summary>
        /// このソケットがバインドされているエンドポイントを返します。
        /// </summary>
        public IPEndPoint localEndPoint {
            get {
            }
        }


        /// <summary>
        /// このソケットのためのポート番号にアクセスします。
        /// </summary>
        public int port {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// このデータグラムソケットで使われる受信用バッファの長さにアクセスします。
        /// </summary>
        public int receiveBufferSize {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// SO_REUSEADDR が有効かどうかを調べます。
        /// </summary>
        public bool reuseAddress {
            get {
            }
        }


        /// <summary>
        /// このソケットが接続されている先のエンドポイントを返します。
        /// </summary>
        public IPEndPoint remoteEndPoint {
            get {
            }
        }


        /// <summary>
        /// このデータグラムソケットで使われる送信用バッファの長さをアクセスします。
        /// </summary>
        public int sendBufferSize {
            get {
            }
        }


        /// <summary>
        /// タイムアウト値にアクセスします。
        /// </summary>
        public int timeout {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// このデータグラムソケットから送信されるパケットの IP データグラムヘッダーのトラフィッククラス
        /// またはサービス型にアクセスします。
        /// </summary>
        public int trafficClass {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// ソケットがバインドされていたら真を返します。
        /// </summary>
        public bool isBound {
            get {

            }
        }


        /// <summary>
        /// ソケットが閉じられていれば真を返します。
        /// </summary>
        public bool isClosed {
            get {

            }
        }


        /// <summary>
        /// ソケットが何れかのエンドポイントに接続されていれば真を返します。
        /// </summary>
        public bool isConnected {
            get {
            }
        }


        /// <summary>
        /// このソケットからのデータグラムパケットを受信します。
        /// </summary>
        /// <param name="packet"></param>
        public void receive(DatagramPacket packet) {
        }


        /// <summary>
        /// このソケットからデータグラムパケットを送信します。
        /// </summary>
        /// <param name="packet"></param>
        public void send(DatagramPacket packet) {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        public static void setDatagramSocketImplFactory(DatagramSocketImplFactory factory) {
        }


        /// <summary>
        /// 
        /// </summary>
        private Socket socket_;
        /// <summary>
        /// 閉じられているかどうか。
        /// </summary>
        private bool is_closed_;
        /// <summary>
        /// 接続しているかどうか。
        /// </summary>
        private bool is_connected_;


        /// <summary>
        /// 
        /// </summary>
        private static DatagramSocketImplFactory factory;
    }


}
