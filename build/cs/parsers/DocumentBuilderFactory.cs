using System;
using System.Collections.Generic;
using System.Xml;


namespace spaghetti.parsers {


    /// <summary>
    /// ���������ȒP�� XML �h�L�������g���� DOM �I�u�W�F�N�g�c���[���쐬����t�@�N�g�� API ���`���܂��B
    /// </summary>
    public abstract class DocumentBuilderFactory {
        /// <summary>
        /// �V���� DocumentBuilderFactory �I�u�W�F�N�g���쐬���܂��B
        /// </summary>
        /// <returns></returns>
        public static DocumentBuilderFactory createInstance() {
            return new XmlDocumentBuilderFactory();
        }


        /// <summary>
        /// ���ݐݒ肳��Ă���p�����[�^�𗘗p���� DocumentBuilder �I�u�W�F�N�g���쐬���܂��B
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
