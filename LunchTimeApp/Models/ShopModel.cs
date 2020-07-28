using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LunchTimeApp
{
    /// <summary>
    /// 店舗リスト取得モデル
    /// </summary>
    class ShopModel : Model
    {
        /// <summary>
        /// DBより店舗名を取得するメソッド
        /// </summary>
        /// <param name="genre">選択されたジャンル</param>
        /// <returns>取得した店舗のデータテーブル</returns>
        public DataTable GetShop(string genre)
        {
            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = connection
                };

                // StringBuilder型を用いて見やすく改行された状態でSQLコマンドを入力する
                StringBuilder query = new StringBuilder();

                // テーブルを内部結合、選択されたジャンルに該当する店舗を抽出
                query.Append("SELECT SHOP_ID, SHOP_NAME ");
                query.Append("FROM ");
                query.Append("SHOP_TBL st, ");
                query.Append("GENRE_MASTER gm ");
                query.Append("WHERE st.GENRE_ID = gm.GENRE_ID ");
                query.Append("AND st.DELETE_FLG != 1");
                query.AppendFormat("AND gm.GENRE_ID = '{0}'", genre);

                // StringBuilder型からString型へ変更
                command.CommandText = query.ToString();
                DataSet shop = new DataSet();

                // 読み込んだデータをDataSet型shopへ代入
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // adapterにもInsert等がある為、Selectコマンドを入力
                    adapter.SelectCommand = new SqlCommand(query.ToString(), connection);
                    // Fill(DataSet型変数, DataTableにつけたい名前)
                    adapter.Fill(shop, "GETSHOP_TBL");
                }
                DataTable shopDT = shop.Tables["GETSHOP_TBL"];
                return shopDT;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
