using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    ///
    /// </summary>
    internal class XmlDocumentBuilder : DocumentBuilder {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="context"></param>
        internal XmlDocumentBuilder(XmlReaderSettings settings, XmlParserContext context) {
            this.settings_ = settings;
            this.context_ = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override XmlDocument createDocument() {
            return new XmlDocument();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public override XmlDocument parse(TextReader source) {
            if ( source == null )
                throw new ArgumentNullException( "source" );

            XmlReader reader = XmlReader.Create( new XmlTextReader( source, this.context_.NameTable ),
                                                 this.settings_
                                                 );

            XmlDocumentParser parser = new XmlDocumentParser( createDocument() );

            return parser.parse( reader );
        }


        /// <summary>
        /// 
        /// </summary>
        private XmlReaderSettings settings_;
        /// <summary>
        /// 
        /// </summary>
        private XmlParserContext context_;
    }


}
