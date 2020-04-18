namespace FinalProject
{
    partial class FormUpdateOrderDetail
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
            this.labelOrderID = new System.Windows.Forms.Label();
            this.textBoxOrdeerID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelQuotedPrice = new System.Windows.Forms.Label();
            this.textBoxQuotedPrice = new System.Windows.Forms.TextBox();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.labelQuantityOrdered = new System.Windows.Forms.Label();
            this.textBoxQuantityOrdered = new System.Windows.Forms.TextBox();
            this.comboBoxTheOrderID = new System.Windows.Forms.ComboBox();
            this.labelTheOrderID = new System.Windows.Forms.Label();
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
            this.labelTitle.Text = "OrderDetail Update Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrderID
            // 
            this.labelOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelOrderID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(12, 199);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(179, 40);
            this.labelOrderID.TabIndex = 2;
            this.labelOrderID.Text = "Order ID:";
            this.labelOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOrdeerID
            // 
            this.textBoxOrdeerID.Location = new System.Drawing.Point(197, 199);
            this.textBoxOrdeerID.Multiline = true;
            this.textBoxOrdeerID.Name = "textBoxOrdeerID";
            this.textBoxOrdeerID.Size = new System.Drawing.Size(580, 40);
            this.textBoxOrdeerID.TabIndex = 9;
            // 
            // labelProductID
            // 
            this.labelProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelProductID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(12, 265);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(179, 40);
            this.labelProductID.TabIndex = 8;
            this.labelProductID.Text = "Product ID:";
            this.labelProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(197, 265);
            this.textBoxProductID.Multiline = true;
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(580, 40);
            this.textBoxProductID.TabIndex = 11;
            // 
            // labelQuotedPrice
            // 
            this.labelQuotedPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelQuotedPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuotedPrice.Location = new System.Drawing.Point(12, 333);
            this.labelQuotedPrice.Name = "labelQuotedPrice";
            this.labelQuotedPrice.Size = new System.Drawing.Size(179, 40);
            this.labelQuotedPrice.TabIndex = 10;
            this.labelQuotedPrice.Text = "Quoted Price:";
            this.labelQuotedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuotedPrice
            // 
            this.textBoxQuotedPrice.Location = new System.Drawing.Point(197, 333);
            this.textBoxQuotedPrice.Multiline = true;
            this.textBoxQuotedPrice.Name = "textBoxQuotedPrice";
            this.textBoxQuotedPrice.Size = new System.Drawing.Size(580, 40);
            this.textBoxQuotedPrice.TabIndex = 13;
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
            // labelQuantityOrdered
            // 
            this.labelQuantityOrdered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelQuantityOrdered.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityOrdered.Location = new System.Drawing.Point(12, 401);
            this.labelQuantityOrdered.Name = "labelQuantityOrdered";
            this.labelQuantityOrdered.Size = new System.Drawing.Size(179, 40);
            this.labelQuantityOrdered.TabIndex = 15;
            this.labelQuantityOrdered.Text = "Qty Ordered:";
            this.labelQuantityOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuantityOrdered
            // 
            this.textBoxQuantityOrdered.Location = new System.Drawing.Point(197, 401);
            this.textBoxQuantityOrdered.Multiline = true;
            this.textBoxQuantityOrdered.Name = "textBoxQuantityOrdered";
            this.textBoxQuantityOrdered.Size = new System.Drawing.Size(580, 40);
            this.textBoxQuantityOrdered.TabIndex = 16;
            // 
            // comboBoxTheOrderID
            // 
            this.comboBoxTheOrderID.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.comboBoxTheOrderID.FormattingEnabled = true;
            this.comboBoxTheOrderID.Location = new System.Drawing.Point(197, 129);
            this.comboBoxTheOrderID.Name = "comboBoxTheOrderID";
            this.comboBoxTheOrderID.Size = new System.Drawing.Size(580, 39);
            this.comboBoxTheOrderID.TabIndex = 18;
            // 
            // labelTheOrderID
            // 
            this.labelTheOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelTheOrderID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheOrderID.Location = new System.Drawing.Point(12, 129);
            this.labelTheOrderID.Name = "labelTheOrderID";
            this.labelTheOrderID.Size = new System.Drawing.Size(179, 40);
            this.labelTheOrderID.TabIndex = 17;
            this.labelTheOrderID.Text = "Order ID::";
            this.labelTheOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.comboBoxTheOrderID);
            this.Controls.Add(this.labelTheOrderID);
            this.Controls.Add(this.textBoxQuantityOrdered);
            this.Controls.Add(this.labelQuantityOrdered);
            this.Controls.Add(this.buttonUpdateRecord);
            this.Controls.Add(this.textBoxQuotedPrice);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelQuotedPrice);
            this.Controls.Add(this.textBoxOrdeerID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBackToCustomerMainForm);
            this.Name = "FormUpdateOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateOrderDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToCustomerMainForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxOrdeerID;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label labelQuotedPrice;
        private System.Windows.Forms.TextBox textBoxQuotedPrice;
        private System.Windows.Forms.Button buttonUpdateRecord;
        private System.Windows.Forms.Label labelQuantityOrdered;
        private System.Windows.Forms.TextBox textBoxQuantityOrdered;
        private System.Windows.Forms.ComboBox comboBoxTheOrderID;
        private System.Windows.Forms.Label labelTheOrderID;
    }
}