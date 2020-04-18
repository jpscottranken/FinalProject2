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
    public partial class FormCategoryOptions : Form
    {
        public FormCategoryOptions()
        {
            InitializeComponent();
        }

        private void buttonInsertCategory_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of insertCategory form
            FormInsertCategory insertCategory = new FormInsertCategory();

            //  Show insertCategory form
            insertCategory.ShowDialog();
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of updateCategory form
            FormUpdateCategory updateCategory = new FormUpdateCategory();

            //  Show updateCategory form
            updateCategory.ShowDialog();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of deleteCategory form
            FormDeleteCategory deleteCategory = new FormDeleteCategory();

            //  Show deleteCategory form
            deleteCategory.ShowDialog();
        }

        private void buttonReturnToMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Customer Options form
            FormSODBMainScreen mainForm = new FormSODBMainScreen();

            //  Show Customer Options form
            mainForm.ShowDialog();
        }
    }
}
