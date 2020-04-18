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
    public partial class FormProductOptions : Form
    {
        public FormProductOptions()
        {
            InitializeComponent();
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of insertProduct form
            FormInsertProduct insertProduct = new FormInsertProduct();

            //  Show insertProduct form
            insertProduct.ShowDialog();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of insertProduct form
            FormUpdateProduct updateProduct = new FormUpdateProduct();

            //  Show insertProduct form
            updateProduct.ShowDialog();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of deleteProduct form
            FormDeleteProduct deleteProduct = new FormDeleteProduct();

            //  Show insertProduct form
            deleteProduct.ShowDialog();
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
