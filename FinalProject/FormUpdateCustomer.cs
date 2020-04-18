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
    public partial class FormUpdateCustomer : Form
    {
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void buttonBackToCustomerMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Customer Options form
            FormCategoryOptions categoryForm = new FormCategoryOptions();

            //  Show Customer Options form
            categoryForm.ShowDialog();
        }
    }
}
