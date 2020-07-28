using System;
using System.Windows.Forms;

namespace LunchTimeApp
{
    /// <summary>
    /// TOPのフォーム
    /// </summary>
    public partial class TopForm : Form
    {
        public TopForm()
        {
            InitializeComponent();
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
