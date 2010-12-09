using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    /// XML �h�L�������g����AXmlDocument �I�u�W�F�N�g���擾���鏈�����`���܂��B
    /// </summary>
    public abstract class DocumentBuilder {
        /// <summary>
        ///
        /// </summary>
        internal DocumentBuilder() {
        }


        /// <summary>
        /// DOM �I�u�W�F�N�g�c���[�̍\�z�Ɏg�p������ XmlDocument �I�u�W�F�N�g���쐬���ĕԂ��܂��B
        /// </summary>
        /// <returns>��� XmlDocumen �I�u�W�F�N�g�B</returns>
        public abstract XmlDocument createDocument();


        /// <summary>
        ///  �w�肳�ꂽ URI �̓��e�� XML �h�L�������g�Ƃ��ĉ�͂��A�V���� XmlDocument �I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <param name="uri">�\����͑Ώۂ̃R���e���c�̏ꏊ�B</param>
        /// <returns>�V���� XmlDocument �I�u�W�F�N�g�B</returns>
        public XmlDocument parse(string uri) {
            if ( uri == null )
                throw new ArgumentNullException( "uri" );
            if ( uri == string.Empty )
                throw new ArgumentException( "�w�肳�ꂽ URI �������ł��B", "uri" );
            if ( !File.Exists( uri ) )
                throw new FileNotFoundException( "�w�肳�ꂽ�p�X�͑��݂��܂���B", uri );

            return parse( new StreamReader( File.Open( uri, FileMode.Open, FileAccess.Read, FileShare.Read ) ) );
        }
        /// <summary>
        /// �w�肳�ꂽ�t�@�C���̓��e�� XML �h�L�������g�Ƃ��ĉ�͂��A�V���� XmlDocument �I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <param name="file">�\����͑Ώۂ̃R���e���c���܂ރt�@�C���B</param>
        /// <returns>�V���� XmlDocument �I�u�W�F�N�g�B</returns>
        public XmlDocument parse(FileInfo file) {
            if ( file == null )
                throw new ArgumentNullException( "file" );
            if ( !file.Exists )
                throw new FileNotFoundException( "�w�肳�ꂽ�t�@�C�������݂��܂���B", file.FullName );

            return parse( new StreamReader( file.FullName ) );
        }
        /// <summary>
        /// �w�肵���X�g���[���̓��e�� XML �h�L�������g�Ƃ��ĉ�͂��A�V���� XmlDocument �I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <param name="stream">�\����͂����R���e���c���܂ޓǂݍ��݂��T�|�[�g�����X�g���[���B</param>
        /// <returns>�V���� XmlDocument �I�u�W�F�N�g�B</returns>
        public XmlDocument parse(Stream stream) {
            if ( stream == null )
                throw new ArgumentNullException( "stream" );
            if ( stream.CanRead )
                throw new ArgumentException( "�w�肳�ꂽ�X�g���[�����ǂݍ��݂��T�|�[�g���Ă��܂���B", "stream" );

            return parse( new StreamReader( stream ) );
        }
        /// <summary>
        /// �w�肳�ꂽ�e�L�X�g���[�_�[�̓��e�� XML �h�L�������g�Ƃ��ĉ�͂��A�V���� XmlDocument �I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <param name="source">�\����͑Ώۂ� TextReader�B</param>
        /// <returns>�V���� XmlDocument �I�u�W�F�N�g�B</returns>
        public abstract XmlDocument parse(TextReader source);
    }


}
