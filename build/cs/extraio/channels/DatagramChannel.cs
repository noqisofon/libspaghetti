using System;
using System.Net;
using System.Net.Sockets;


namespace spaghetti.extraio.channels {


    using spaghetti.extraio.channels.providers;


    /// <summary>
    /// �f�[�^�O�����^�\�P�b�g�̑I���\�ȃ`���l���ł��B
    /// </summary>
    public abstract class DatagramChannel {
        /// <summary>
        /// �v���o�C�_�[���󂯎���� DatagramChannel �I�u�W�F�N�g���쐬���܂��B
        /// </summary>
        /// <param name="provider"></param>
        protected DatagramChannel(SelectorProvider provider) {
        }


        /// <summary>
        /// ���̃`�����l���̃\�P�b�g��ڑ����܂��B
        /// </summary>
        /// <param name="remote"></param>
        /// <returns></returns>
        public abstract DatagramChannel connect(IPEndPoint remote);


        /// <summary>
        /// ���̃`�����l���̃\�P�b�g�̐ڑ���ؒf���܂��B
        /// </summary>
        /// <returns></returns>
        public abstract DatagramChannel disconnect();


        /// <summary>
        /// ���̃`�����l���̃\�P�b�g���ڑ�����Ă�����^��Ԃ��܂��B
        /// </summary>
        public bool isConnected {
            get {
            }
        }


        /// <summary>
        /// �f�[�^�O�����`�����l�����J���܂��B
        /// </summary>
        /// <returns></returns>
        static public DatagramChannel open() {
            return new DatagramChannel(new SelectorProvider());
        }


        /// <summary>
        /// ���̃`�����l������f�[�^�O������ǂݍ��݂܂��B
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public abstract int read(byte[] dest);
        /// <summary>
        /// ���̃`�����l������f�[�^�O������ǂݍ��݂܂��B
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public abstract int read(byte[] dest, int offset, int length);


        /// <summary>
        /// ���̃`�����l������f�[�^�O��������M���܂��B
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public abstract int receive(byte[] dest);


        /// <summary>
        /// ���̃`�����l������f�[�^�O�����𑗐M���܂��B
        /// </summary>
        /// <param name="src"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public abstract int send(byte[] src, IPEndPoint target);


        /// <summary>
        /// ���̃`�����l���̃T�|�[�g����Ă��鑀������ʂ���R�[�h��Ԃ��܂��B
        /// </summary>
        public int validOptions {
            get {
            }
        }


        /// <summary>
        /// ���̃`�����l���փf�[�^�O�������������݂܂��B
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public abstract int write(byte[] src);
        /// <summary>
        /// ���̃`�����l���փf�[�^�O�������������݂܂��B
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public abstract int write(byte[] src, int offset, int length);
    }


}
