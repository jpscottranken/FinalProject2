﻿namespace FinalProject
{
    partial class FormUpdateCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackToCustomerMainForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.comboBoxFullName = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxAreaCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackToCustomerMainForm
            // 
            this.buttonBackToCustomerMainForm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToCustomerMainForm.Location = new System.Drawing.Point(437, 504);
            this.buttonBackToCustomerMainForm.Name = "buttonBackToCustomerMainForm";
            this.buttonBackToCustomerMainForm.Size = new System.Drawing.Size(234, 99);
            this.buttonBackToCustomerMainForm.TabIndex = 10;
            this.buttonBackToCustomerMainForm.Text = "Back To Customer Main Form";
            this.buttonBackToCustomerMainForm.UseVisualStyleBackColor = true;
            this.buttonBackToCustomerMainForm.Click += new System.EventHandler(this.buttonBackToCustomerMainForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(765, 56);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Customer Update Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 199);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(179, 40);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "FIrst Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelLastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(397, 199);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(179, 40);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(197, 199);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(194, 40);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(582, 199);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(194, 40);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(197, 265);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(580, 40);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 265);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(179, 40);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRecord.Location = new System.Drawing.Point(96, 504);
            this.buttonUpdateRecord.Name = "buttonUpdateRecord";
            this.buttonUpdateRecord.Size = new System.Drawing.Size(234, 99);
            this.buttonUpdateRecord.TabIndex = 9;
            this.buttonUpdateRecord.Text = "Update Record";
            this.buttonUpdateRecord.UseVisualStyleBackColor = true;
            this.buttonUpdateRecord.Click += new System.EventHandler(this.buttonUpdateRecord_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelCustomerName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(12, 125);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(179, 40);
            this.labelCustomerName.TabIndex = 12;
            this.labelCustomerName.Text = "Customer Name:";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFullName
            // 
            this.comboBoxFullName.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.comboBoxFullName.FormattingEnabled = true;
            this.comboBoxFullName.Location = new System.Drawing.Point(197, 125);
            this.comboBoxFullName.Name = "comboBoxFullName";
            this.comboBoxFullName.Size = new System.Drawing.Size(580, 39);
            this.comboBoxFullName.TabIndex = 0;
            this.comboBoxFullName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFullName_SelectedIndexChanged);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(401, 397);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(194, 40);
            this.textBoxPhoneNumber.TabIndex = 8;
            this.textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZip.Location = new System.Drawing.Point(487, 333);
            this.textBoxZip.Multiline = true;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(194, 40);
            this.textBoxZip.TabIndex = 6;
            this.textBoxZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(401, 333);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(68, 40);
            this.textBoxState.TabIndex = 5;
            this.textBoxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAreaCode
            // 
            this.textBoxAreaCode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAreaCode.Location = new System.Drawing.Point(197, 397);
            this.textBoxAreaCode.Multiline = true;
            this.textBoxAreaCode.Name = "textBoxAreaCode";
            this.textBoxAreaCode.Size = new System.Drawing.Size(194, 40);
            this.textBoxAreaCode.TabIndex = 7;
            this.textBoxAreaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(197, 333);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(194, 40);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "City/State/Zip:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxAreaCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFullName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.buttonUpdateRecord);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBackToCustomerMainForm);
            this.Name = "FormUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToCustomerMainForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonUpdateRecord;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.ComboBox comboBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxAreaCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label2;
    }
}