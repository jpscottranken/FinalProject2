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
    public partial class FormCustomerOptions : Form
    {
        public FormCustomerOptions()
        {
            InitializeComponent();
        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of InsertCustomer form
            FormInsertCustomer insertCustomerForm = new FormInsertCustomer();

            //  Show Customer Options form
            insertCustomerForm.ShowDialog();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of UpdateCustomer form
            FormUpdateCustomer updateCustomerForm = new FormUpdateCustomer();

            //  Show Customer Options form
            updateCustomerForm.ShowDialog();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of DeletetCustomer form
            FormDeleteCustomer deleteCustomerForm = new FormDeleteCustomer();

            //  Show Customer Options form
            deleteCustomerForm.ShowDialog();
        }

        private void buttonReturnToMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Main form
            FormSODBMainScreen mainForm = new FormSODBMainScreen();

            //  Show Customer Options form
            mainForm.ShowDialog();
        }
    }
}
