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
        }


        /// <summary>
        /// �\�P�b�g�����̃\�P�b�g�̃����[�g�A�h���X�ɐڑ����܂��B
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public void connect(IPAddress address, int port) {
        }
        /// <summary>
        /// ���̃\�P�b�g�������[�g�\�P�b�g�A�h���X�ɐڑ����܂��B
        /// </summary>
        /// <param name="point"></param>
        public void connect(IPEndPoint point) {
        }


        /// <summary>
        /// �\�P�b�g��ؒf���܂��B
        /// </summary>
        public void disconnect() {
        }


        /// <summary>
        /// �u���[�h�o���h�t���O�ɃA�N�Z�X���܂��B
        /// </summary>
        public bool broadband {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ɋ֘A����ŗL�̃f�[�^�O�����`�����l���I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <remarks>���݂��Ȃ��ꍇ�Anull ��Ԃ��܂��B</remarks>
        public DatagramChannel channel {
            get {

            }
        }


        /// <summary>
        /// ���̃\�P�b�g�̐ڑ���̃A�h���X��Ԃ��܂��B
        /// </summary>
        public IPAddress remoteAddress {
            get {

            }
        }


        /// <summary>
        /// �\�P�b�g�̃o�C���h��̃��[�J���A�h���X���擾���܂��B
        /// </summary>
        public IPAddress localAddress {
            get {
            }
        }


        /// <summary>
        /// ���̃\�P�b�g���o�C���h����Ă���G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        public IPEndPoint localEndPoint {
            get {
            }
        }


        /// <summary>
        /// ���̃\�P�b�g�̂��߂̃|�[�g�ԍ��ɃA�N�Z�X���܂��B
        /// </summary>
        public int port {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg�����M�p�o�b�t�@�̒����ɃA�N�Z�X���܂��B
        /// </summary>
        public int receiveBufferSize {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// SO_REUSEADDR ���L�����ǂ����𒲂ׂ܂��B
        /// </summary>
        public bool reuseAddress {
            get {
            }
        }


        /// <summary>
        /// ���̃\�P�b�g���ڑ�����Ă����̃G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        public IPEndPoint remoteEndPoint {
            get {
            }
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg���鑗�M�p�o�b�t�@�̒������A�N�Z�X���܂��B
        /// </summary>
        public int sendBufferSize {
            get {
            }
        }


        /// <summary>
        /// �^�C���A�E�g�l�ɃA�N�Z�X���܂��B
        /// </summary>
        public int timeout {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g���瑗�M�����p�P�b�g�� IP �f�[�^�O�����w�b�_�[�̃g���t�B�b�N�N���X
        /// �܂��̓T�[�r�X�^�ɃA�N�Z�X���܂��B
        /// </summary>
        public int trafficClass {
            get {
            }
            set {
            }
        }


        /// <summary>
        /// �\�P�b�g���o�C���h����Ă�����^��Ԃ��܂��B
        /// </summary>
        public bool isBound {
            get {

            }
        }


        /// <summary>
        /// �\�P�b�g�������Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        public bool isClosed {
            get {

            }
        }


        /// <summary>
        /// �\�P�b�g�����ꂩ�̃G���h�|�C���g�ɐڑ�����Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        public bool isConnected {
            get {
            }
        }


        /// <summary>
        /// ���̃\�P�b�g����̃f�[�^�O�����p�P�b�g����M���܂��B
        /// </summary>
        /// <param name="packet"></param>
        public void receive(DatagramPacket packet) {
        }


        /// <summary>
        /// ���̃\�P�b�g����f�[�^�O�����p�P�b�g�𑗐M���܂��B
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
        /// �����Ă��邩�ǂ����B
        /// </summary>
        private bool is_closed_;
        /// <summary>
        /// �ڑ����Ă��邩�ǂ����B
        /// </summary>
        private bool is_connected_;


        /// <summary>
        /// 
        /// </summary>
        private static DatagramSocketImplFactory factory;
    }


}
