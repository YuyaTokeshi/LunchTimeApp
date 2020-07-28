using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LunchTimeApp
{
    /// <summary>
    /// DB接続を行うModelの基底クラス
    /// </summary>
    class Model
    {
        protected SqlConnection connection;

        /// <summary>
        /// DB接続を行うコンストラクタ
        /// </summary>
        public Model()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Connect();
        }

        /// <summary>
        /// DB接続を行うメソッド
        /// </summary>
        private void Connect()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
