using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTimeApp
{
    class InsertShopController
    {
        public void InsertShop(string genreID, string shopName)
        {
            InsertShopModel insertShopModel = new InsertShopModel();
            insertShopModel.InsertShop(genreID,shopName);
        }
    }
}
