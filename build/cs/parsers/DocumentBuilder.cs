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
        /// DOM オブジェクトツリーの構築に使用する空の XmlDocument オブジェクトを作成して返します。
        /// </summary>
        /// <returns>空の XmlDocumen オブジェクト。</returns>
        public abstract XmlDocument createDocument();


        /// <summary>
        ///  指定された URI の内容を XML ドキュメントとして解析し、新しい XmlDocument オブジェクトを返します。
        /// </summary>
        /// <param name="uri">構文解析対象のコンテンツの場所。</param>
        /// <returns>新しい XmlDocument オブジェクト。</returns>
        public XmlDocument parse(string uri) {
            if ( uri == null )
                throw new ArgumentNullException( "uri" );
            if ( uri == string.Empty )
                throw new ArgumentException( "指定された URI が無効です。", "uri" );
            if ( !File.Exists( uri ) )
                throw new FileNotFoundException( "指定されたパスは存在しません。", uri );

            return parse( new StreamReader( File.Open( uri, FileMode.Open, FileAccess.Read, FileShare.Read ) ) );
        }
        /// <summary>
        /// 指定されたファイルの内容を XML ドキュメントとして解析し、新しい XmlDocument オブジェクトを返します。
        /// </summary>
        /// <param name="file">構文解析対象のコンテンツを含むファイル。</param>
        /// <returns>新しい XmlDocument オブジェクト。</returns>
        public XmlDocument parse(FileInfo file) {
            if ( file == null )
                throw new ArgumentNullException( "file" );
            if ( !file.Exists )
                throw new FileNotFoundException( "指定されたファイルが存在しません。", file.FullName );

            return parse( new StreamReader( file.FullName ) );
        }
        /// <summary>
        /// 指定したストリームの内容を XML ドキュメントとして解析し、新しい XmlDocument オブジェクトを返します。
        /// </summary>
        /// <param name="stream">構文解析されるコンテンツを含む読み込みをサポートしたストリーム。</param>
        /// <returns>新しい XmlDocument オブジェクト。</returns>
        public XmlDocument parse(Stream stream) {
            if ( stream == null )
                throw new ArgumentNullException( "stream" );
            if ( stream.CanRead )
                throw new ArgumentException( "指定されたストリームが読み込みをサポートしていません。", "stream" );

            return parse( new StreamReader( stream ) );
        }
        /// <summary>
        /// 指定されたテキストリーダーの内容を XML ドキュメントとして解析し、新しい XmlDocument オブジェクトを返します。
        /// </summary>
        /// <param name="source">構文解析対象の TextReader。</param>
        /// <returns>新しい XmlDocument オブジェクト。</returns>
        public abstract XmlDocument parse(TextReader source);
    }


}
