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
            List<ItemSet> src = new List<ItemSet>();
            foreach (DataRow row in genre.AsEnumerable())
            {
                src.Add(new ItemSet((int)row[0], row[1].ToString()));
            }

            this.GenreComboBox.DataSource = src;
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
            resultForm.Show();
            string genre = GenreComboBox.SelectedValue.ToString();    
            GetShopController getShopController = new GetShopController();
            DataTable shop = getShopController.GetShop(genre);

            // 取得したDataTableをListに格納する
            List<string> shopList = shop.AsEnumerable().Select(row => row[0].ToString()).ToList<string>();
            
            // DBにデータが無かった時の例外スロー
            if(shopList.Count == 0)
            {
                MessageBox.Show("リストがありません。","エラー");
            }
            else
            {
                // Listの中からランダムに1店舗表示
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