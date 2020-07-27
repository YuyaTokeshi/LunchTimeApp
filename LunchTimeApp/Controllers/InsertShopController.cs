using System;
using System.Windows.Forms;

namespace LunchTimeApp
{
    class InsertShopController
    {
        /// <summary>
        /// 入力された店舗とジャンルをDBに登録する
        /// </summary>
        /// <param name="genreID"></param>
        /// <param name="shopName"></param>
        public void InsertShop(string genreID, string shopName)
        {
            try
            {
                InsertShopModel insertShopModel = new InsertShopModel();
                insertShopModel.InsertShop(genreID, shopName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
