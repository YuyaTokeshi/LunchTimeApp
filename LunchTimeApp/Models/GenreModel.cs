using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LunchTimeApp
{
    class GenreModel:Model
    {
        public DataSet GetGenre()
        {
            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = connection
                };

                // StringBuilder型を用いて見やすく改行された状態でSQLコマンドを入力する
                StringBuilder query = new StringBuilder();

                // DB内ジャンルマスタよりデータを取得
                query.Append("SELECT ");
                query.Append("GENRE_ID ,");
                query.Append("GENRE_NAME ");
                query.Append("FROM ");
                query.Append("GENRE_MASTER");

                // StringBuilder型からString型へ変更
                command.CommandText = query.ToString();
                DataSet genre = new DataSet();

                // 読み込んだデータをgenreへ代入
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // adapterにもInsert等がある為、Selectコマンドを入力
                    adapter.SelectCommand = new SqlCommand(query.ToString(), connection);
                    // Fill(DataSet型変数, DataTableにつけたい名前)
                    adapter.Fill(genre, "GENRE_MASTER");
                }
                return genre;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
