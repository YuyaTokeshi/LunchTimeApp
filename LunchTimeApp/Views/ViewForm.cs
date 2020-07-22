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

        private void ViewForm_Load(object sender, EventArgs e)
        {
            ShopListController shopListController = new ShopListController();
            DataTable shop = shopListController.GetShop();

            // 取得したDataTable型変数genreをListに代入
            List<ItemSet> src = new List<ItemSet>();
            foreach (DataRow row in shop.AsEnumerable())
            {
                src.Add(new ItemSet((int)row[0], row[1].ToString()));
            }

            this.ShopListBox.DataSource = src;
            this.ShopListBox.DisplayMember = "ItemDisp";
            this.ShopListBox.ValueMember = "ItemValue";
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
    }

}
