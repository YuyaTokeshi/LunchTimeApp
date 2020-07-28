using LunchTimeApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗名を取得するコントローラー
    /// </summary>
    class GetShopController
    {
        /// <summary>
        /// DBより店舗名を取得するメソッド
        /// </summary>
        /// <param name="genre">選択されたジャンル</param>
        /// <returns>ItemSet型のList</returns>
        public List<ItemSet> GetShop(string genre)
        {
            try
            {
                ShopModel shopModel = new ShopModel();
                DataTable ShopList = shopModel.GetShop(genre);

                // DataTableをList<ItemSet>に格納して返す
                return ShopList.AsEnumerable().Select(row => new ItemSet((int)row[0], row[1].ToString())).ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
