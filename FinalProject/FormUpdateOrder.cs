﻿using System;
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
    public partial class FormUpdateOrder : Form
    {
        public FormUpdateOrder()
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
    }
}
