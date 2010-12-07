using System;
using System.Collections.Generic;
using System.Xml;


namespace spaghetti.util {


    /// <summary>
    /// XML �̕�����\������AXmlDocument �I�u�W�F�N�g���쐬���܂��B
    /// </summary>
    [Obsolete( "XMLDocumentConvertor �N���X�͍���T�|�[�g����܂���Bparsers ���O��Ԃ̃N���X���g�p���Ă��������B" )]
    public class XMLDocumentConvertor {
        /// <summary>
        ///
        /// </summary>
        public XMLDocumentConvertor() {
            this.settings_ = new XmlReaderSettings();
            this.settings_.NameTable = new NameTable();

            XmlNamespaceManager manager = new XmlNamespaceManager( this.settings_.NameTable );
            this.context_ = new XmlParserContext( this.settings_.NameTable,
                                                  manager,
                                                  "ja",
                                                  XmlSpace.Default
                                                  );
        }


        /// <summary>
        /// XML �������_���I XML �\���ɕϊ����ĕԂ��܂��B
        /// </summary>
        /// <param name="xml_text_representation"></param>
        /// <returns></returns>
        public XmlDocument convert(string xml_text_representation) {
            XmlReader reader = create_xml_reader( xml_text_representation );

            return convert_xml_document( reader );
        }


        /// <summary>
        /// XmlReader �I�u�W�F�N�g���쐬���ĕԂ��܂��B
        /// </summary>
        /// <param name="xml_text_representation"></param>
        /// <returns></returns>
        private XmlReader create_xml_reader(string xml_text_representation) {
            XmlReader reader = XmlReader.Create( new XmlTextReader( xml_text_representation,
                                                                    XmlNodeType.Document,
                                                                    this.context_
                                                                    ),
                                                 this.settings_
                                                 );

            return reader;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private XmlDocument convert_xml_document(XmlReader reader) {
            XmlDocument document = new XmlDocument();
            XmlNode current;
            XmlAttribute attribute;
            Stack<XmlNode> node_stack = new Stack<XmlNode>();

            node_stack.Push( document );
            while ( reader.Read() ) {
                if ( reader.NodeType == XmlNodeType.Whitespace )
                    continue;

                switch ( reader.NodeType ) {
                    case XmlNodeType.XmlDeclaration:
                        if ( reader.HasAttributes ) {
                            document.AppendChild( document.CreateXmlDeclaration( reader.GetAttribute( "version" ),
                                                                                 reader.GetAttribute( "encoding" ),
                                                                                 "no"
                                                                                 )
                                                  );
                        }
                        break;

                    case XmlNodeType.Element:
                        node_stack.Push( document.CreateElement( reader.Name ) );

                        if ( reader.HasAttributes ) {
                            current = node_stack.Peek();

                            for ( int i = 0; i < reader.AttributeCount; ++i ) {
                                reader.MoveToAttribute( i );

                                attribute = document.CreateAttribute( reader.Name );
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
                        current.AppendChild( document.CreateTextNode( reader.Value ) );
                        break;

                    case XmlNodeType.EndElement:
                        foldElement( node_stack );
                        break;
                }
            }
            return document;
        }


        /// <summary>
        /// �X�^�b�N����m�[�h�� 2 ���o���ď�ݍ��݂܂��B
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
        XmlReaderSettings settings_;
        /// <summary>
        /// 
        /// </summary>
        XmlParserContext context_;
    }


}
