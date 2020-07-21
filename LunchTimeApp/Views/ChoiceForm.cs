using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchTimeApp
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        public void ChoiceForm_Load(object sender, EventArgs e)
        {
            GetGenreController getGenreController = new GetGenreController();
            DataTable genre = getGenreController.GetGenre();
            //取得したDataTableをLINQでリスト型へ変更、[1]列目のみ取得してコンボボックスへ表示
            this.GenreComboBox.DataSource = genre.AsEnumerable().Select(m => m.ItemArray[1]).ToList();
        }
    }
}
