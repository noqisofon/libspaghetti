using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.net {


    using spaghetti.io;


    /// <summary>
    /// ���ۃf�[�_�O��������у}���`�L���X�g�\�P�b�g������������N���X�ł��B
    /// </summary>
    public abstract class DatagramSocketImpl {
        /// <summary>
        /// 
        /// </summary>
        public DatagramSocketImpl() {
        }


        /// <summary>
        /// �f�[�_�O�����\�P�b�g�����[�J���̃|�[�g����уA�h���X�Ƀo�C���h���܂��B
        /// </summary>
        /// <param name="local_port"></param>
        /// <param name="local_address"></param>
        internal void bind(int local_port, IPAddress local_address) {
            bind( new IPEndPoint( local_address, local_port ) );
            this.localPort = local_port;
        }
        /// <summary>
        /// �f�[�_�O�����\�P�b�g�����[�J���̃|�[�g����уA�h���X�Ƀo�C���h���܂��B
        /// </summary>
        /// <param name="local_point"></param>
        internal abstract void bind(IPEndPoint local_point);


        /// <summary>
        /// �\�P�b�g����܂��B
        /// </summary>
        internal abstract void close();


        /// <summary>
        /// �f�[�^�O�����\�P�b�g�������[�g�ڑ���ɐڑ����܂��B
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
        /// �����[�g�ڑ��悩��f�[�_�O�����\�P�b�g��؂藣���܂��B
        /// </summary>
        internal abstract void disconnect();


        /// <summary>
        /// �\�P�b�g���o�C���h����Ă�����^��Ԃ��܂��B
        /// </summary>
        internal abstract bool isBound {
            get;
        }


        /// <summary>
        /// �\�P�b�g�������Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        internal abstract bool isClosed {
            get;
        }


        /// <summary>
        /// �\�P�b�g�����ꂩ�̃G���h�|�C���g�ɐڑ�����Ă���ΐ^��Ԃ��܂��B
        /// </summary>
        internal abstract bool isConnected {
            get;
        }


        /// <summary>
        /// SO_REUSEADDR ���L�����ǂ����𒲂ׂ܂��B
        /// </summary>
        internal abstract bool reuseAddress {
            get;
        }


        /// <summary>
        /// ���̃\�P�b�g���ڑ�����Ă����̃G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        internal abstract IPEndPoint remoteEndPoint {
            get;
        }


        /// <summary>
        /// ���̃\�P�b�g���o�C���h����Ă���G���h�|�C���g��Ԃ��܂��B
        /// </summary>
        internal abstract IPEndPoint localEndPoint {
            get;
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg���鑗�M�p�o�b�t�@�̒������A�N�Z�X���܂��B
        /// </summary>
        internal abstract int sendBufferSize {
            get;
            set;
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g�Ŏg�����M�p�o�b�t�@�̒����ɃA�N�Z�X���܂��B
        /// </summary>
        internal abstract int receiveBufferSize {
            get;
            set;
        }


        /// <summary>
        /// �^�C���A�E�g�l�ɃA�N�Z�X���܂��B
        /// </summary>
        internal abstract int timeout {
            get;
            set;
        }


        /// <summary>
        /// ���̃f�[�^�O�����\�P�b�g���瑗�M�����p�P�b�g�� IP �f�[�^�O�����w�b�_�[�̃g���t�B�b�N�N���X
        /// �܂��̓T�[�r�X�^�ɃA�N�Z�X���܂��B
        /// </summary>
        internal abstract int trafficClass {
            get;
            set;
        }


        /// <summary>
        /// �u���[�h�o���h�t���O�ɃA�N�Z�X���܂��B
        /// </summary>
        internal abstract bool broadband {
            get;
            set;
        }


        /// <summary>
        /// ���̃\�P�b�g����̃f�[�^�O�����p�P�b�g����M���܂��B
        /// </summary>
        /// <param name="packet"></param>
        internal abstract void receive(DatagramPacket packet);


        /// <summary>
        /// ���̃\�P�b�g����f�[�^�O�����p�P�b�g�𑗐M���܂��B
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
