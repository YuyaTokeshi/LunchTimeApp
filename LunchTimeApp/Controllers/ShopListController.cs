using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchTimeApp
{
    class ShopListController
    {
        public DataTable GetShop()
        {
            try
            {
                ShopListModel shopListModel = new ShopListModel();
                DataTable shop = shopListModel.GetShopList().Tables["SHOPLIST_TBL"];
                return shop;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception();
            }
        }
    }
}
