using System;


namespace spaghetti.util {


    /// <summary>
    /// 2 �̈قȂ�^�����Ă�\���̂ł��B
    /// </summary>
    /// <typeparam name="T">1 �ڂ̌^�B</typeparam>
    /// <typeparam name="Y">2 �ڂ̌^�B</typeparam>
    [Serializable]
    public struct pair<T, Y> : ICloneable, IEquatable<pair<T, Y>> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public pair(T first, Y second) {
            this.first_ = first;
            this.second_ = second;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        public pair(pair<T, Y> other) {
            this.first_ = other.first_;
            this.second_ = other.second_;
        }


        /// <summary>
        /// 
        /// </summary>
        public T first {
            get { return first_; }
            set { first_ = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        public Y second {
            get { return second_; }
            set { second_ = value; }
        }


        #region IEquatable<pair<T,Y>> �����o
        /// <summary>
        /// ���݂̃I�u�W�F�N�g���A�����^�̕ʂ̃I�u�W�F�N�g�Ɠ��������ǂ����������܂��B
        /// </summary>
        /// <param name="other">���̃I�u�W�F�N�g�Ɣ�r����I�u�W�F�N�g�B</param>
        /// <returns>���݂̃I�u�W�F�N�g�� other �p�����[�^�Ɠ������ꍇ�� true�B����ȊO�̏ꍇ�� false�B</returns>
        public bool Equals(pair<T, Y> other) {
            return this.first.Equals( other.first )
                && this.second.Equals( other.second );
        }
        #endregion


        #region ICloneable �����o
        /// <summary>
        /// ���݂̃C���X�^���X�̃R�s�[�ł���V�����I�u�W�F�N�g���쐬���܂��B
        /// </summary>
        /// <returns>���̃C���X�^���X�̃R�s�[�ł���V�����I�u�W�F�N�g�B</returns>
        public object Clone() {
            return new pair<T, Y>( this );
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return string.Format( "({0} . {1})", this.first_, this.second_ );
        }


        /// <summary>
        /// 
        /// </summary>
        private T first_;
        /// <summary>
        /// 
        /// </summary>
        private Y second_;
    }


}
