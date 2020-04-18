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
    public partial class FormDeleteCategory : Form
    {
        public FormDeleteCategory()
        {
            InitializeComponent();
        }

        private void buttonReturnToCategoryForm_Click(object sender, EventArgs e)
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
