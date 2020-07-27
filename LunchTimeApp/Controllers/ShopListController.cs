using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    class ShopListController
    {
        public List<ItemSet> GetShop()
        {
            try
            {
                ShopListModel shopListModel = new ShopListModel();
                DataTable shop = shopListModel.GetShopList().Tables["SHOPLIST_TBL"];
                List<ItemSet> shopList = 
                    shop.AsEnumerable()                                          // Enumerable型に変換
                    .Select(row => new ItemSet((int)row[0], row[1].ToString()))  // DataRow型の要素を取り出し、ItemSet型に詰め替え
                    .ToList<ItemSet>();                                          // List<ItemSet>型に変換
                return shopList;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}