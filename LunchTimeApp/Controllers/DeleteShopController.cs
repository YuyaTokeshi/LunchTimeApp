using System;
using System.Windows.Forms;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗削除コントローラークラス
    /// </summary>
    class DeleteShopController
    {
        /// <summary>
        /// 選択された店舗に削除フラグを立てるメソッド
        /// </summary>
        /// <param name="shop">選択された店舗</param>
        public void DeleteShop(string shop)
        {
            try
            {
                DeleteShopModel deleteShopModel = new DeleteShopModel();
                deleteShopModel.DeleteShop(shop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}