using System;
using System.Net;


namespace spaghetti.net {


    /// <summary>
    /// データグラムパケットを表します。
    /// </summary>
    public sealed class DatagramPacket {
        /// <summary>
        /// 長さが length のパケットを受信、または送信するための DatagramPacket オブジェクトを構築します。
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="length"></param>
        public DatagramPacket(byte[] buf, int length)
            : this( buf, 0, length ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        public DatagramPacket(byte[] buf, int offset, int length)
            : this( buf, offset, length, new IPEndPoint( IPAddress.Any, 0 ) ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="length"></param>
        /// <param name="endpoint"></param>
        public DatagramPacket(byte[] buf, int length, IPEndPoint endpoint)
            : this( buf, 0, length, endpoint ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="length"></param>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public DatagramPacket(byte[] buf, int length, IPAddress address, int port)
            : this( buf, length, new IPEndPoint( address, port ) ) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="endpoint"></param>
        public DatagramPacket(byte[] buf, int offset, int length, IPEndPoint endpoint) {
            assignData( buf, offset, length );
            this.end_point_ = endpoint;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public DatagramPacket(byte[] buf, int offset, int length, IPAddress address, int port)
            : this( buf, offset, length, new IPEndPoint( address, port ) ) {
        }


        /// <summary>
        /// 
        /// </summary>
        public IPAddress address {
            get {
                return end_point_.Address;
            }
            set {
                end_point_.Address = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public int port {
            get {
                return end_point_.Port;
            }
            set {
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public IPEndPoint endPoint {
            get {
                return end_point_;
            }
            set {
                end_point_ = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public int length {
            get {
                return packet_length_;
            }
            set {
                packet_length_ = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte[] data {
            get {
                return buffer_;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="length"></param>
        public void assignData(byte[] buf, int length) {
            assignData( buf, 0, length );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        public void assignData(byte[] buf, int offset, int length) {
            // buf が null いとダメ。
            if ( buf == null )
                throw new ArgumentException( "buf" );
            // offset が負の値のときはダメ。
            if ( offset < 0 )
                throw new ArgumentException( "offset" );
            // length が負の値の時もダメ。
            if ( length < 0 )
                throw new ArgumentException( "length" );
            // バッファの長さよりオフセットの方が大きい時もダメ。
            if ( offset > buf.Length )
                throw new ArgumentOutOfRangeException( "offset",
                                                       offset,
                                                       "バッファのオフセットがバッファの長さを超えています。"
                                                       );

            if ( offset > 0 ) {
                if ( buf.Length < length ) {
                    length = buf.Length - offset;
                    this.packet_length_ = length;
                } else
                    this.packet_length_ = length - offset;

                this.buffer_ = new byte[this.packet_length_];

                Array.Copy( buf, offset, this.buffer_, 0, this.buffer_.Length );
            } else {
                this.buffer_ = buf;
                this.packet_length_ = length;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private IPEndPoint end_point_;
        /// <summary>
        /// 
        /// </summary>
        private byte[] buffer_;
        /// <summary>
        /// 
        /// </summary>
        private int packet_length_;
    }


}
