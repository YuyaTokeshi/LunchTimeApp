using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗の登録や削除を行うフォーム
    /// </summary>
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム起動後、店舗リストとジャンルリストを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm_Load(object sender, EventArgs e)
        {  
            try
            {
                // 店舗リストの取得準備
                ShopListController shopListController = new ShopListController();
                List<ItemSet> shop = shopListController.GetShop();

                // ListBoxに表示名と値を格納する
                this.ShopListBox.DataSource = shop;
                this.ShopListBox.DisplayMember = "ItemDisp";
                this.ShopListBox.ValueMember = "ItemValue";

                // ジャンルリストの取得準備
                GetGenreController getGenreController = new GetGenreController();
                List<ItemSet> genreList = getGenreController.GetGenre();

                // ComboBoxに表示名と値を格納する
                this.GenreComboBox.DataSource = genreList;
                this.GenreComboBox.DisplayMember = "ItemDisp";
                this.GenreComboBox.ValueMember = "ItemValue";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 選択された店舗に削除フラグを立てる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 入力値の取得
                string shop = ShopListBox.SelectedValue.ToString();

                // 削除処理の実行
                DeleteShopController deleteShopController = new DeleteShopController();
                deleteShopController.DeleteShop(shop);

                // 実行結果の表示
                MessageBox.Show("対象の店舗が正常に削除されました。", "削除完了");

                // フォームの再読み込み
                ViewForm viewForm = new ViewForm();
                viewForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 入力された店舗名とジャンルをDBに格納する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            // 店舗名が入力されていない場合の例外スロー
            if (string.IsNullOrEmpty(this.ShopNameTextBox.Text))
            {
                MessageBox.Show("店舗名を入力してください。", "エラー");
                return;
            }

            // 入力されたジャンルと店舗名の取得
            string genreID = GenreComboBox.SelectedValue.ToString();
            string shopName = ShopNameTextBox.Text;

            // 登録処理の実行
            InsertShopController insertShopController = new InsertShopController();
            insertShopController.InsertShop(genreID, shopName);

            // 実行結果の表示
            MessageBox.Show("対象の店舗が正常に登録されました。", "登録完了");

            // フォームの再読み込み
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
            this.Close();
        }
    }

}
