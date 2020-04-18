namespace FinalProject
{
    partial class FormUpdateOrder
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
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.textBoxOrdeerDate = new System.Windows.Forms.TextBox();
            this.labelOrderShipDate = new System.Windows.Forms.Label();
            this.textBoxOrderShipDate = new System.Windows.Forms.TextBox();
            this.labelCustoerID = new System.Windows.Forms.Label();
            this.textBoxPCustomerID = new System.Windows.Forms.TextBox();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBackToCustomerMainForm
            // 
            this.buttonBackToCustomerMainForm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToCustomerMainForm.Location = new System.Drawing.Point(437, 504);
            this.buttonBackToCustomerMainForm.Name = "buttonBackToCustomerMainForm";
            this.buttonBackToCustomerMainForm.Size = new System.Drawing.Size(234, 99);
            this.buttonBackToCustomerMainForm.TabIndex = 0;
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
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Order Update Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelOrderDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDate.Location = new System.Drawing.Point(12, 199);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(179, 40);
            this.labelOrderDate.TabIndex = 2;
            this.labelOrderDate.Text = "Order Date:";
            this.labelOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOrdeerDate
            // 
            this.textBoxOrdeerDate.Location = new System.Drawing.Point(197, 199);
            this.textBoxOrdeerDate.Multiline = true;
            this.textBoxOrdeerDate.Name = "textBoxOrdeerDate";
            this.textBoxOrdeerDate.Size = new System.Drawing.Size(580, 40);
            this.textBoxOrdeerDate.TabIndex = 9;
            // 
            // labelOrderShipDate
            // 
            this.labelOrderShipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelOrderShipDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderShipDate.Location = new System.Drawing.Point(12, 265);
            this.labelOrderShipDate.Name = "labelOrderShipDate";
            this.labelOrderShipDate.Size = new System.Drawing.Size(179, 40);
            this.labelOrderShipDate.TabIndex = 8;
            this.labelOrderShipDate.Text = "Order Ship Date:";
            this.labelOrderShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOrderShipDate
            // 
            this.textBoxOrderShipDate.Location = new System.Drawing.Point(197, 265);
            this.textBoxOrderShipDate.Multiline = true;
            this.textBoxOrderShipDate.Name = "textBoxOrderShipDate";
            this.textBoxOrderShipDate.Size = new System.Drawing.Size(580, 40);
            this.textBoxOrderShipDate.TabIndex = 11;
            // 
            // labelCustoerID
            // 
            this.labelCustoerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelCustoerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustoerID.Location = new System.Drawing.Point(12, 333);
            this.labelCustoerID.Name = "labelCustoerID";
            this.labelCustoerID.Size = new System.Drawing.Size(179, 40);
            this.labelCustoerID.TabIndex = 10;
            this.labelCustoerID.Text = "CustomerID:";
            this.labelCustoerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPCustomerID
            // 
            this.textBoxPCustomerID.Location = new System.Drawing.Point(197, 333);
            this.textBoxPCustomerID.Multiline = true;
            this.textBoxPCustomerID.Name = "textBoxPCustomerID";
            this.textBoxPCustomerID.Size = new System.Drawing.Size(580, 40);
            this.textBoxPCustomerID.TabIndex = 13;
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRecord.Location = new System.Drawing.Point(96, 504);
            this.buttonUpdateRecord.Name = "buttonUpdateRecord";
            this.buttonUpdateRecord.Size = new System.Drawing.Size(234, 99);
            this.buttonUpdateRecord.TabIndex = 14;
            this.buttonUpdateRecord.Text = "Update Record";
            this.buttonUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // labelOrderID
            // 
            this.labelOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelOrderID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(12, 130);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(179, 40);
            this.labelOrderID.TabIndex = 15;
            this.labelOrderID.Text = "Order ID:";
            this.labelOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(197, 130);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(580, 39);
            this.comboBoxOrderID.TabIndex = 16;
            // 
            // FormUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.comboBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.buttonUpdateRecord);
            this.Controls.Add(this.textBoxPCustomerID);
            this.Controls.Add(this.textBoxOrderShipDate);
            this.Controls.Add(this.labelCustoerID);
            this.Controls.Add(this.textBoxOrdeerDate);
            this.Controls.Add(this.labelOrderShipDate);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBackToCustomerMainForm);
            this.Name = "FormUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToCustomerMainForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxOrdeerDate;
        private System.Windows.Forms.Label labelOrderShipDate;
        private System.Windows.Forms.TextBox textBoxOrderShipDate;
        private System.Windows.Forms.Label labelCustoerID;
        private System.Windows.Forms.TextBox textBoxPCustomerID;
        private System.Windows.Forms.Button buttonUpdateRecord;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.ComboBox comboBoxOrderID;
    }
}