using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LunchTimeApp
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームを起動後、DBよりジャンル名を取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChoiceForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetGenreController getGenreController = new GetGenreController();
                List<ItemSet> genreList = getGenreController.GetGenre();

                // 「お任せ！」の値と表示名をリストに追加
                genreList.Add(new ItemSet(0, "お任せ！"));

                // 作成したリストの値と表示名をコンボボックスに代入
                this.GenreComboBox.DataSource = genreList;
                this.GenreComboBox.DisplayMember = "ItemDisp";
                this.GenreComboBox.ValueMember = "ItemValue";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ResultFormを開き、取得した店舗のリストからランダムに1店舗表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultFormButton_Click(object sender, EventArgs e)
        {    
            string genre = GenreComboBox.SelectedValue.ToString();
            List<ItemSet> shop = null;

            try
            {
                // お任せを選んだ場合は全店舗のリスト
                if (genre == "0")
                {
                    ShopListController shopListController = new ShopListController();
                    shop = shopListController.GetShop();
                }
                else
                {
                    GetShopController getShopController = new GetShopController();
                    shop = getShopController.GetShop(genre);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Listの中からランダムに1店舗表示
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
            Random random = new Random();
            int i = random.Next(0, shop.Count);
            string shopResult = shop[i].ItemDisp.ToString();
            resultForm.ResultLabel.Text = shopResult;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}