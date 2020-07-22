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
    class ShopListModel:Model
    {
        public DataSet GetShopList()
        {
            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = connection
                };

                // StringBuilder型を用いて見やすく改行された状態でSQLコマンドを入力する
                StringBuilder query = new StringBuilder();

                // DBより店舗名データを取得
                query.Append("SELECT SHOP_ID, SHOP_NAME ");
                query.Append("FROM SHOP_TBL ");
                query.Append("WHERE DELETE_FLG != 1");

                // StringBuilder型からString型へ変更
                command.CommandText = query.ToString();
                DataSet shopList = new DataSet();

                // 読み込んだデータをgenreへ代入
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    //adapterにもInsert等がある為、Selectコマンドを入力
                    adapter.SelectCommand = new SqlCommand(query.ToString(), connection);
                    //Fill(DataSet型変数, DataTableにつけたい名前)
                    adapter.Fill(shopList, "SHOPLIST_TBL");
                }
                return shopList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
           
    }
}
