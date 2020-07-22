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
    /// <summary>
    /// DB接続を行うModelの基底クラス
    /// </summary>
    class Model
    {
        protected SqlConnection connection;

        /// <summary>
        /// コンストラクタ
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
