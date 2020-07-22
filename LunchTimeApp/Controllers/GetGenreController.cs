using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchTimeApp
{
    class GetGenreController
    {
        public GetGenreController()
        {
        }

        /// <summary>
        /// 取得したDataSetをDataTable型に変更して戻す。
        /// </summary>
        /// <returns></returns>
        public DataTable GetGenre()
        {
            try
            {
                GenreModel genreModel = new GenreModel();
                DataTable genre = genreModel.GetGenre().Tables["GENRE_MASTER"];
                return genre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception();
            }
        }
    }
}
