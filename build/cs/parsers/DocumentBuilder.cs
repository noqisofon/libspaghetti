using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    /// XML ドキュメントから、XmlDocument オブジェクトを取得する処理を定義します。
    /// </summary>
    public abstract class DocumentBuilder {
        /// <summary>
        ///
        /// </summary>
        internal DocumentBuilder() {
        }


        /// <summary>
        /// 空の XmlDocumen オブジェクトを作成します。
        /// </summary>
        /// <returns>空の XmlDocumen オブジェクト。</returns>
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
                throw new ArgumentException( "指定された URI が無効です。", "uri" );

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
                throw new ArgumentException( "指定されたファイルが存在しません。", "file" );

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
                throw new ArgumentException( "指定されたストリームが読み込みをサポートしていません。", "stream" );

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
