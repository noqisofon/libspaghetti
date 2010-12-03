using System;


namespace spaghetti.util {


    /// <summary>
    /// 2 つの異なる型を持てる構造体です。
    /// </summary>
    /// <typeparam name="T">1 つ目の型。</typeparam>
    /// <typeparam name="Y">2 つ目の型。</typeparam>
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


        #region IEquatable<pair<T,Y>> メンバ
        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(pair<T, Y> other) {
            return this.first.Equals( other.first )
                && this.second.Equals( other.second );
        }
        #endregion


        #region ICloneable メンバ
        /// <summary>
        /// 現在のインスタンスのコピーである新しいオブジェクトを作成します。
        /// </summary>
        /// <returns>このインスタンスのコピーである新しいオブジェクト。</returns>
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
