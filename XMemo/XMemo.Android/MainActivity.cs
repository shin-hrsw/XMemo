using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XMemo.Droid
{
	[Activity (Label = "XMemo.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        private EditText date;
        private EditText subject;
        private EditText memo;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

            // テキストの参照を取得しておく
            this.date = FindViewById<EditText>(Resource.Id.DateText);
            this.subject = FindViewById<EditText>(Resource.Id.SubjectText);
            this.memo = FindViewById<EditText>(Resource.Id.MemoText);

            // テキスト変更時のイベント設定
            // 入力された内容をMemoクラスに保持する
            this.subject.TextChanged += (s, e) =>
            {
                MemoHolder.Current.Memo.Subject = this.subject.Text;
            };
            this.memo.TextChanged += (s, e) =>
            {
                MemoHolder.Current.Memo.Text = this.memo.Text;
            };

            var m = new Memo();
            m.Date = DateTime.Now;
            m.Subject = string.Empty;
            m.Text = string.Empty;
            MemoHolder.Current.Memo = m;

            Display();
		}

        private void Display()
        {
            var m = MemoHolder.Current.Memo;
            this.date.Text = m.Date.ToString("yyyy/MM/dd");
            this.subject.Text = m.Subject;
            this.memo.Text = m.Text;
        }
	}
}


