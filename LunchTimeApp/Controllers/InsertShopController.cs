using System;
using System.Windows.Forms;

namespace LunchTimeApp
{
    /// <summary>
    /// 入力された店舗名とジャンルをDBに登録するコントローラー
    /// </summary>
    class InsertShopController
    {
        /// <summary>
        /// 入力された店舗とジャンルをDBに登録するメソッド
        /// </summary>
        /// <param name="genreID">入力されたジャンルのID</param>
        /// <param name="shopName">入力された店舗名</param>
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
