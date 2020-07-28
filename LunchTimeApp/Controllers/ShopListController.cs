using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    /// <summary>
    /// 全店舗のリストを取得するコントローラー
    /// </summary>
    class ShopListController
    {
        /// <summary>
        /// DBより全店舗のリストを取得するメソッド
        /// </summary>
        /// <returns>ItemSet型のList</returns>
        public List<ItemSet> GetShop()
        {
            try
            {
                ShopListModel shopListModel = new ShopListModel();
                DataTable shop = shopListModel.GetShopList();
                return shop.AsEnumerable()                                          // Enumerable型に変換
                    .Select(row => new ItemSet((int)row[0], row[1].ToString()))     // DataRow型の要素を取り出し、ItemSet型に詰め替え
                    .ToList();                                                      // List<ItemSet>型に変換
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}