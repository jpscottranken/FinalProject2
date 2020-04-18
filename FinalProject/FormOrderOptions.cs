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
    public partial class FormOrderOptions : Form
    {
        public FormOrderOptions()
        {
            InitializeComponent();
        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of InsertOrder form
            FormInsertOrder insertOrderForm = new FormInsertOrder();

            //  Show Customer Options form
            insertOrderForm.ShowDialog();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of UpdateOrder form
            FormUpdateOrder updateOrderForm = new FormUpdateOrder();

            //  Show Customer Options form
            updateOrderForm.ShowDialog();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            //  Hide the current form
            this.Hide();

            //  Create new instance of DeleteOrder form
            FormDeleteOrder deleteOrderForm = new FormDeleteOrder();

            //  Show Customer Options form
            deleteOrderForm.ShowDialog();
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
