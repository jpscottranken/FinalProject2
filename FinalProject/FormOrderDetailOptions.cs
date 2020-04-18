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
    public partial class FormOrderDetailOptions : Form
    {
        public FormOrderDetailOptions()
        {
            InitializeComponent();
        }

        private void buttonInsertOrderDetail_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of OrderDetailInsert Options form
            FormInsertOrderDetail insertOrderDetail = new FormInsertOrderDetail();

            //  Show Customer Options form
            insertOrderDetail.ShowDialog();
        }

        private void buttonUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of OrderDetailUpdate Options form
            FormUpdateOrderDetail updateOrderDetail = new FormUpdateOrderDetail();

            //  Show Customer Options form
            updateOrderDetail.ShowDialog();
        }

        private void buttonDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of OrderDetailDelete Options form
            FormDeleteOrderDetail deleteOrderDetail = new FormDeleteOrderDetail();

            //  Show Customer Options form
            deleteOrderDetail.ShowDialog();
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
