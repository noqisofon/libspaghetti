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
        /// ��� XmlDocumen �I�u�W�F�N�g���쐬���܂��B
        /// </summary>
        /// <returns>��� XmlDocumen �I�u�W�F�N�g�B</returns>
        public abstract XmlDocument createDocument();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public XmlDocument parse(string uri) {
            if ( uri == null )
                throw new ArgumentNullException( "uri" );
            if ( uri == string.Empty || !File.Exists( uri ) )
                throw new ArgumentException( "�w�肳�ꂽ URI �������ł��B", "uri" );

            return parse( new StreamReader( File.Open( uri, FileMode.Open, FileAccess.Read, FileShare.Read ) ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public XmlDocument parse(FileInfo file) {
            if ( file == null )
                throw new ArgumentNullException( "file" );
            if ( !file.Exists )
                throw new ArgumentException( "�w�肳�ꂽ�t�@�C�������݂��܂���B", "file" );

            return parse( new StreamReader( file.FullName ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public XmlDocument parse(Stream stream) {
            if ( stream == null )
                throw new ArgumentNullException( "stream" );
            if ( stream.CanRead )
                throw new ArgumentException( "�w�肳�ꂽ�X�g���[�����ǂݍ��݂��T�|�[�g���Ă��܂���B", "stream" );

            return parse( new StreamReader( stream ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public abstract XmlDocument parse(TextReader source);
    }


}
