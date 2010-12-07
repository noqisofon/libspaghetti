using System;
using System.Collections.Generic;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    ///
    /// </summary>
    class XmlDocumentBuilderFactory : DocumentBuilderFactory {
        /// <summary>
        /// 
        /// </summary>
        internal XmlDocumentBuilderFactory() {
            this.manager_ = new XmlNamespaceManager( new NameTable() );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override DocumentBuilder createDocumentBuilder() {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.NameTable = this.manager_.NameTable;

            XmlParserContext context = new XmlParserContext( this.manager_.NameTable,
                                                             this.manager_,
                                                             "ja",
                                                             XmlSpace.Default
                                                             );

            return new XmlDocumentBuilder( settings, context );
        }


        /// <summary>
        /// 
        /// </summary>
        private XmlNamespaceManager manager_;
    }


}
