using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    using extraio.channels;


    /// <summary>
    /// �f�[�^�O�����p�P�b�g�𑗎�M���邽�߂̃\�P�b�g��\���܂��B
    /// </summary>
    public class DatagramSocket {
        /// <summary>
        /// �f�[�^�O�����\�P�b�g���\�z���A���[�J���}�V����̎g�p�\�ȃ|�[�g�Ƀo�C���h���܂��B
        /// </summary>
        public DatagramSocket() {
        }
        /// <summary>
        /// �w�肳�ꂽ DatagramSocketImpl ���g�p���ăo�C���h����Ă��Ȃ��f�[�^�O�����\�P�b�g���쐬���܂��B
        /// </summary>
        /// <param name="implementor"></param>
        protected DatagramSocket(DatagramSocketImpl implementor) {
        }
        /// <summary>
        /// �w�肳�ꂽ���[�J���A�h���X�Ƀo�C���h���ꂽ�f�[�^�O�����\�P�b�g���쐬���܂��B
        /// </summary>
        /// <param name="port"></param>
        /// <param name="address"></param>
        public DatagramSocket(int port, IPAddress address) {
        }
        /// <summary>
        /// �w�肳�ꂽ���[�J���A�h���X�Ƀo�C���h���ꂽ�f�[�^�O�����\�P�b�g���쐬���܂��B
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
        /// ���̃f�[�^�O�����\�P�b�g�����̃A�h���X�A����у|�[�g�Ƀo�C���h���܂��B
        /// </summary>
        /// <param name="point"></param>
        public void bind(IPEndPoint point) {
            this.implementor_.bind( point );
        }


        /// <summary>
        /// ���̃f�[�_�O�����\�P�b�g����܂��B
        /// </summary>
        public void close() {
            this.implementor_.close();
        }


        /// <summary>
        /// �\�P�b�g�����̃\�P�b�g�̃����[�g�A�h���X�ɐڑ����܂��B
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public void connect(IPAddress address, int port) {
            this.implementor_.connect( address, port );
        }
        /// <summary>
        /// ���̃\�P�b�g�������[�g�\�P�b�g�A�h���X�ɐڑ����܂��B
        /// </summary>
        /// <param name="point"></param>
        public void connect(IPEndPoint point) {
            this.implementor_.connect( point );
        }


        /// <summary>
        /// �\�P�b�g��ؒf���܂��B
        /// </summary>
        public void disconnect() {
            this.implementor_.disconnect();
        }


        /// <summary>
        /// �u���[�h�o���h�t���O�ɃA�N�Z�X���܂��B
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
        /// ���̃f�[�^�O�����\�P�b�g�Ɋ֘A����ŗL�̃f�[�^�O�����`�����l���I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <remarks>���݂��Ȃ��ꍇ�Anull ��Ԃ��܂��B</remarks>
        public DatagramChannel channel {
            get {
                return null;
            }
        }


        /// <summary>
        /// ���̃\�P�b�g�̐ڑ���̃A�h���X��Ԃ��܂��B
        /// </summary>
        public IPAddress remoteAddress {
            get {
                return this.implementor_.remoteEndPoint.Address;
            }
        }


        /// <summary>
        /// �\�P�b�g�̃o�C���h��̃��[�J���A�h���X���擾���܂��B
        /// </summary>
        public IPAddress localAddress {
            get {
                return this.implementor_.localEndPoint.Address;
            }
        }


        /// <summary>
        /// ���̃\�P�b�g���o�C���h����Ă���G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        public IPEndPoint localEndPoint {
            get {
                return this.implementor_.localEndPoint;
            }
        }


        /// <summary>
        /// ���̃\�P�b�g�̂��߂̃|�[�g�ԍ��ɃA�N�Z�X���܂��B
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
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg�����M�p�o�b�t�@�̒����ɃA�N�Z�X���܂��B
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
        /// SO_REUSEADDR ���L�����ǂ����𒲂ׂ܂��B
        /// </summary>
        public bool reuseAddress {
            get {
                return this.implementor_.reuseAddress;
            }
        }


        /// <summary>
        /// ���̃\�P�b�g���ڑ�����Ă����̃G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        public IPEndPoint remoteEndPoint {
            get {
                return this.implementor_.remoteEndPoint;
            }
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg���鑗�M�p�o�b�t�@�̒������A�N�Z�X���܂��B
        /// </summary>
        public int sendBufferSize {
            get {
                return this.implementor_.sendBufferSize;
            }
        }


        /// <summary>
        /// �^�C���A�E�g�l�ɃA�N�Z�X���܂��B
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
        /// ���̃f�[�^�O�����\�P�b�g���瑗�M�����p�P�b�g�� IP �f�[�^�O�����w�b�_�[�̃g���t�B�b�N�N���X
        /// �܂��̓T�[�r�X�^�ɃA�N�Z�X���܂��B
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
        /// �\�P�b�g���o�C���h����Ă�����^��Ԃ��܂��B
        /// </summary>
        public bool isBound {
            get {
                return this.implementor_.isBound;
            }
        }


        /// <summary>
        /// �\�P�b�g�������Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        public bool isClosed {
            get {
                return this.implementor_.isClosed;
            }
        }


        /// <summary>
        /// �\�P�b�g�����ꂩ�̃G���h�|�C���g�ɐڑ�����Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        public bool isConnected {
            get {
                return this.implementor_.isConnected;
            }
        }


        /// <summary>
        /// ���̃\�P�b�g����̃f�[�^�O�����p�P�b�g����M���܂��B
        /// </summary>
        /// <param name="packet"></param>
        public void receive(DatagramPacket packet) {
            this.implementor_.receive( packet );
        }


        /// <summary>
        /// ���̃\�P�b�g����f�[�^�O�����p�P�b�g�𑗐M���܂��B
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
