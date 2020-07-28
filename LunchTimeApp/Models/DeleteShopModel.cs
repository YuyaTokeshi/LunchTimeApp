using System;
using System.Data.SqlClient;
using System.Text;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗削除クラス
    /// </summary>
    class DeleteShopModel : Model
    {
        /// <summary>
        /// 選択された店舗に削除フラグを立てるメソッド
        /// </summary>
        /// <param name="shop">選択された店舗</param>
        public void DeleteShop(string shop)
        {
            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = connection
                };

                // StringBuilder型を用いて見やすく改行された状態でSQLコマンドを入力する
                StringBuilder query = new StringBuilder();

                // 選択された店舗にDELETE_FLGを立てる
                query.Append("UPDATE SHOP_TBL ");
                query.Append("SET DELETE_FLG = 1 ");
                query.AppendFormat("WHERE SHOP_ID = {0}",shop);

                // StringBuilder型からString型へ変更
                command.CommandText = query.ToString();

                // SQL文の実行
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}