using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.extraio.channels {


    using spaghetti.extraio.channels.providers;


    /// <summary>
    /// データグラム型ソケットの選択可能なチャネルです。
    /// </summary>
    public abstract class DatagramChannel {
        /// <summary>
        /// プロバイダーを受け取って DatagramChannel オブジェクトを作成します。
        /// </summary>
        /// <param name="provider"></param>
        protected DatagramChannel(SelectorProvider provider) {
        }


        /// <summary>
        /// このチャンネルのソケットを接続します。
        /// </summary>
        /// <param name="remote"></param>
        /// <returns></returns>
        public abstract DatagramChannel connect(IPEndPoint remote);


        /// <summary>
        /// このチャンネルのソケットの接続を切断します。
        /// </summary>
        /// <returns></returns>
        public abstract DatagramChannel disconnect();


        /// <summary>
        /// このチャンネルのソケットが接続されていたら真を返します。
        /// </summary>
        public bool isConnected {
            get {
            }
        }


        /// <summary>
        /// データグラムチャンネルを開きます。
        /// </summary>
        /// <returns></returns>
        static public DatagramChannel open() {
            return new DatagramChannel(new SelectorProvider());
        }


        /// <summary>
        /// このチャンネルからデータグラムを読み込みます。
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public abstract int read(byte[] dest);
        /// <summary>
        /// このチャンネルからデータグラムを読み込みます。
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public abstract int read(byte[] dest, int offset, int length);


        /// <summary>
        /// このチャンネルからデータグラムを受信します。
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public abstract int receive(byte[] dest);


        /// <summary>
        /// このチャンネルからデータグラムを送信します。
        /// </summary>
        /// <param name="src"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public abstract int send(byte[] src, IPEndPoint target);


        /// <summary>
        /// このチャンネルのサポートされている操作を識別するコードを返します。
        /// </summary>
        public int validOptions {
            get {
            }
        }


        /// <summary>
        /// このチャンネルへデータグラムを書き込みます。
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public abstract int write(byte[] src);
        /// <summary>
        /// このチャンネルへデータグラムを書き込みます。
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public abstract int write(byte[] src, int offset, int length);
    }


}
