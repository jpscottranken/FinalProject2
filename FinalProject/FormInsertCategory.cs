using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormInsertCategory : Form
    {
        public FormInsertCategory()
        {
            InitializeComponent();
        }

        private void buttonBackToCategoryMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Category form
            FormCategoryOptions categoryForm = new FormCategoryOptions();

            //  Show Customer Options form
            categoryForm.ShowDialog();
        }
    }
}
