using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMemo
{
    public class MemoHolder
    {
        #region プロパティ
        public static MemoHolder Current => new MemoHolder();

        public Memo Memo { get; set; }
        #endregion
    }
}
