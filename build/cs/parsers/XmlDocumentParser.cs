using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    ///
    /// </summary>
    public class XmlDocumentParser {
        /// <summary>
        ///
        /// </summary>
        /// <param name="document"></param>
        public XmlDocumentParser(XmlDocument document) {
            this.document_ = document;
        }


        /// <summary>
        /// reader を使用して XML ドキュメントとして構文解析します。
        /// </summary>
        /// <param name="reader">XML ドキュメントのリードイテレータ。</param>
        /// <returns>解析後の XmlDocument オブジェクト。</returns>
        public XmlDocument parse(XmlReader reader) {
            if ( reader == null )
                throw new ArgumentNullException( "reader" );

            XmlNode current;
            XmlAttribute attribute;

            Stack<XmlNode> node_stack = new Stack<XmlNode>();

            node_stack.Push( this.document_ );
            while ( reader.Read() ) {
                if ( reader.NodeType == XmlNodeType.Whitespace )
                    continue;

                switch ( reader.NodeType ) {
                    case XmlNodeType.XmlDeclaration:
                        if ( reader.HasAttributes ) {
                            this.document_.AppendChild( this.document_.CreateXmlDeclaration( reader.GetAttribute( "version" ),
                                                                                             reader.GetAttribute( "encoding" ),
                                                                                             "no"
                                                                                             )
                                                        );
                        }
                        break;

                    case XmlNodeType.Element:
                        node_stack.Push( this.document_.CreateElement( reader.Name ) );

                        if ( reader.HasAttributes ) {
                            current = node_stack.Peek();

                            for ( int i = 0; i < reader.AttributeCount; ++i ) {
                                reader.MoveToAttribute( i );

                                attribute = this.document_.CreateAttribute( reader.Name );
                                attribute.Value = reader.Value;

                                current.Attributes.Append( attribute );
                            }
                        }

                        if ( reader.IsEmptyElement ) {
                            foldElement( node_stack );
                        }
                        break;

                    case XmlNodeType.Text:
                        current = node_stack.Peek();
                        current.AppendChild( this.document_.CreateTextNode( reader.Value ) );
                        break;

                    case XmlNodeType.EndElement:
                        foldElement( node_stack );
                        break;
                }
            }
            return this.document_;
        }


        /// <summary>
        /// スタックからノードを 2 つ取り出して畳み込みます。
        /// </summary>
        /// <param name="stack"></param>
        private void foldElement(Stack<XmlNode> stack) {
            XmlNode current, parent;

            if ( stack.Count > 1 ) {
                current = stack.Pop();
                parent = stack.Pop();

                parent.AppendChild( current );
                //Console.WriteLine( "append {0} to {1}", parent.Name, current.Name );
                stack.Push( parent );
            }
        }


        /// <summary>
        ///
        /// </summary>
        private XmlDocument document_;
    }


}
