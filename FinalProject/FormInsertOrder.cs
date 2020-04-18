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
    public partial class FormInsertOrder : Form
    {
        public FormInsertOrder()
        {
            InitializeComponent();
        }

        private void buttonBackToCustomerMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Order Options form
            FormOrderOptions orderForm = new FormOrderOptions();

            //  Show Customer Options form
            orderForm.ShowDialog();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOrdeerDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOrderShipDate_Click(object sender, EventArgs e)
        {

        }

        private void labelCustoerID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
