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
    public partial class FormInsertOrderDetail : Form
    {
        public FormInsertOrderDetail()
        {
            InitializeComponent();
        }

        private void buttonBackToCustomerMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Order Options form
            FormOrderDetailOptions orderDetailForm = new FormOrderDetailOptions();

            //  Show Customer Options form
            orderDetailForm.ShowDialog();
        }
    }
}
