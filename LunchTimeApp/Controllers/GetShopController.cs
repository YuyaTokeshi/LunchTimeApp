using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    class GetShopController
    {
        public List<ItemSet> GetShop(string genre)
        {
            try
            {
                ShopModel shopModel = new ShopModel();
                DataSet ShopList = shopModel.GetShop(genre);

                DataTable shop = ShopList.Tables["GETSHOP_TBL"];
                List<ItemSet> shopList = shop.AsEnumerable().Select(row => new ItemSet((int)row[0], row[1].ToString())).ToList<ItemSet>();
                return shopList;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
