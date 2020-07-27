using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            GetGenreController getGenreController = new GetGenreController();
            DataTable genre = getGenreController.GetGenre();

            // 取得したDataTable型変数genreをListに代入
            List<ItemSet> genreList = new List<ItemSet>();
            foreach (DataRow row in genre.AsEnumerable())
            {
                genreList.Add(new ItemSet((int)row[0], row[1].ToString()));
            }

            genreList.Add(new ItemSet(0, "お任せ！"));
            // 作成したリストの値と表示名をコンボボックスに代入
            this.GenreComboBox.DataSource = genreList;
            this.GenreComboBox.DisplayMember = "ItemDisp";
            this.GenreComboBox.ValueMember = "ItemValue";
        }

        /// <summary>
        /// ResultFormを開き、取得した店舗のリストからランダムに1店舗表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultFormButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            string genre = GenreComboBox.SelectedValue.ToString();

            DataTable shop;
            
            // お任せを選んだ場合は全店舗のリスト
            if(genre == "0")
            {
                ShopListController shopListController = new ShopListController();
                shop = shopListController.GetShop();
            }
            else
            {
                GetShopController getShopController = new GetShopController();
                shop = getShopController.GetShop(genre);
            }

            // 取得したDataTableをListに格納する
            List<string> shopList = shop.AsEnumerable().Select(row => row[1].ToString()).ToList<string>();
            
            // DBにデータが無かった時の例外スロー
            if(shopList.Count == 0)
            {
                MessageBox.Show("リストがありません。","エラー");
            }
            else
            {
                // Listの中からランダムに1店舗表示
                resultForm.Show();
                Random random = new Random();
                int i = random.Next(0, shopList.Count);
                string shopResult = shopList[i];
                resultForm.ResultLabel.Text = shopResult;
            }
        }
        public class ItemSet
        {
            public int ItemValue { get; set; }
            public string ItemDisp { get; set; }
            public ItemSet(int v, String s)
            {
                ItemValue = v;
                ItemDisp = s;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}