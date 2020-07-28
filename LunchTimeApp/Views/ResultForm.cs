using System;
using System.Windows.Forms;

namespace LunchTimeApp
{
    /// <summary>
    /// 取得した店舗の中からランダムに1店舗表示するフォーム
    /// </summary>
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 表示された店舗をGoogleで検索する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string shop = ResultLabel.Text;
            string shopURL = String.Format("https://www.google.com/search?q={0}", shop);
            System.Diagnostics.Process.Start(shopURL);
        }
    }
}
