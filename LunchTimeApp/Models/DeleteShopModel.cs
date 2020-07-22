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
    class DeleteShopModel:Model
    {
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