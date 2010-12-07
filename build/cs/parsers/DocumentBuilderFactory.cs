using System;
using System.Collections.Generic;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    /// もう少し簡単に XML ドキュメントから DOM オブジェクトツリーを作成するファクトリ API を定義します。
    /// </summary>
    public abstract class DocumentBuilderFactory {
        /// <summary>
        /// 新しい DocumentBuilderFactory オブジェクトを作成します。
        /// </summary>
        /// <returns></returns>
        public static DocumentBuilderFactory createInstance() {
            return new XmlDocumentBuilderFactory();
        }


        /// <summary>
        /// 現在設定されているパラメータを利用して DocumentBuilder オブジェクトを作成します。
        /// </summary>
        /// <returns></returns>
        public abstract DocumentBuilder createDocumentBuilder();


        /// <summary>
        /// 
        /// </summary>
        protected DocumentBuilderFactory() {
        }
    }


}
