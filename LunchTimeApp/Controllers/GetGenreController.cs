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
