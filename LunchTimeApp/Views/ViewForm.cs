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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 店舗のリスト、ジャンルのリストを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm_Load(object sender, EventArgs e)
        {  
            // 店舗リストの取得準備
            ShopListController shopListController = new ShopListController();
            DataTable shop = shopListController.GetShop();

            // 取得したDataTable型変数genreをListに代入
            List<ItemSet> shopList = new List<ItemSet>();
            foreach (DataRow row in shop.AsEnumerable())
            {
                shopList.Add(new ItemSet((int)row[0], row[1].ToString()));
            }

            // ListBoxに表示名と値を格納する
            this.ShopListBox.DataSource = shopList;
            this.ShopListBox.DisplayMember = "ItemDisp";
            this.ShopListBox.ValueMember = "ItemValue";


            // ジャンルリストの取得準備
            GetGenreController getGenreController = new GetGenreController();
            DataTable genre = getGenreController.GetGenre();

            // 取得したDataTable型変数genreをListに代入
            List<ItemSet> genreList = new List<ItemSet>();
            foreach (DataRow row in genre.AsEnumerable())
            {
                genreList.Add(new ItemSet((int)row[0], row[1].ToString()));
            }

            this.GenreComboBox.DataSource = genreList;
            this.GenreComboBox.DisplayMember = "ItemDisp";
            this.GenreComboBox.ValueMember = "ItemValue";

        }

        // Listに使用するプロパティのクラス
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

        /// <summary>
        /// 選択された店舗に削除フラグを立てる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string shop = ShopListBox.SelectedValue.ToString();
            DeleteShopController deleteShopController = new DeleteShopController();
            deleteShopController.DeleteShop(shop);
            MessageBox.Show("対象の店舗が正常に削除されました。","削除完了");
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
            this.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string genreID = GenreComboBox.SelectedValue.ToString();
            string shopName = ShopNameTextBox.Text;
            InsertShopController insertShopController = new InsertShopController();
            insertShopController.InsertShop(genreID, shopName);
            MessageBox.Show("対象の店舗が正常に登録されました。", "登録完了");
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
            this.Close();
        }
    }

}
