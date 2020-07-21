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
    public partial class TopForm : Form
    {
        public TopForm()
        {
            InitializeComponent();
        }
        private void TopForm_Load(object sender, EventArgs e)
        {

        }
        private void ChoiceFormButton_Click(object sender, EventArgs e)
        {
            ChoiceForm choiceForm = new ChoiceForm();
            choiceForm.Show();
        }
        private void ViewFormButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
