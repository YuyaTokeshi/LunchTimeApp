using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchTimeApp
{
    class GetShopController
    {
        public DataTable GetShop(string genre)
        {
            ShopModel shopModel = new ShopModel();
            DataSet ShopList = shopModel.GetShop(genre);

            DataTable shop = ShopList.Tables["GETSHOP_TBL"];
            return shop;
        }
    }
}
