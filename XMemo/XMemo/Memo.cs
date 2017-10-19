using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMemo
{
    public class Memo
    {
        #region プロパティ
        /// <summary>
        /// 作成日
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// 件名
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 本文
        /// </summary>
        public string Text { get; set; }
        #endregion
    }
}
