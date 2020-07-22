using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchTimeApp
{
    class InsertShopModel:Model
    {
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
