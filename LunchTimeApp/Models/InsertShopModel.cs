using System;
using System.Data.SqlClient;
using System.Text;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗登録モデル
    /// </summary>
    class InsertShopModel : Model
    {
        /// <summary>
        /// 入力された店舗とジャンルをDBに登録する
        /// </summary>
        /// <param name="genreID">入力された店舗のID</param>
        /// <param name="shopName">入力された店舗の名前</param>
        public void InsertShop(string genreID, string shopName)
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
                query.Append("INSERT ");
                query.Append("INTO SHOP_TBL(GENRE_ID,SHOP_NAME) ");
                query.AppendFormat("VALUES({0},'{1}')",genreID, shopName);

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
