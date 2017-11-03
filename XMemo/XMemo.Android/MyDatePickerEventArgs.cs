using System;

namespace XMemo.Droid
{
    class MyDatePickerEventArgs : EventArgs
    {
        public DateTime SelectedDate { get; private set; }

        #region コンストラクタ
        public MyDatePickerEventArgs(DateTime selected)
        {
            SelectedDate = selected;
        }
        #endregion
    }
}