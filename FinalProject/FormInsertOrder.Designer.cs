namespace FinalProject
{
    partial class FormInsertOrder
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
            this.buttonInsertRecord = new System.Windows.Forms.Button();
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
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(765, 56);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Order Insert Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelOrderDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDate.Location = new System.Drawing.Point(12, 199);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(179, 40);
            this.labelOrderDate.TabIndex = 2;
            this.labelOrderDate.Text = "Order Date:";
            this.labelOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrderDate.Click += new System.EventHandler(this.labelOrderDate_Click);
            // 
            // textBoxOrdeerDate
            // 
            this.textBoxOrdeerDate.Location = new System.Drawing.Point(197, 199);
            this.textBoxOrdeerDate.Multiline = true;
            this.textBoxOrdeerDate.Name = "textBoxOrdeerDate";
            this.textBoxOrdeerDate.Size = new System.Drawing.Size(580, 40);
            this.textBoxOrdeerDate.TabIndex = 9;
            this.textBoxOrdeerDate.TextChanged += new System.EventHandler(this.textBoxOrdeerDate_TextChanged);
            // 
            // labelOrderShipDate
            // 
            this.labelOrderShipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelOrderShipDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderShipDate.Location = new System.Drawing.Point(12, 265);
            this.labelOrderShipDate.Name = "labelOrderShipDate";
            this.labelOrderShipDate.Size = new System.Drawing.Size(179, 40);
            this.labelOrderShipDate.TabIndex = 8;
            this.labelOrderShipDate.Text = "Order Ship Date:";
            this.labelOrderShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrderShipDate.Click += new System.EventHandler(this.labelOrderShipDate_Click);
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
            this.labelCustoerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelCustoerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustoerID.Location = new System.Drawing.Point(12, 333);
            this.labelCustoerID.Name = "labelCustoerID";
            this.labelCustoerID.Size = new System.Drawing.Size(179, 40);
            this.labelCustoerID.TabIndex = 10;
            this.labelCustoerID.Text = "CustomerID:";
            this.labelCustoerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCustoerID.Click += new System.EventHandler(this.labelCustoerID_Click);
            // 
            // textBoxPCustomerID
            // 
            this.textBoxPCustomerID.Location = new System.Drawing.Point(197, 333);
            this.textBoxPCustomerID.Multiline = true;
            this.textBoxPCustomerID.Name = "textBoxPCustomerID";
            this.textBoxPCustomerID.Size = new System.Drawing.Size(580, 40);
            this.textBoxPCustomerID.TabIndex = 13;
            this.textBoxPCustomerID.TextChanged += new System.EventHandler(this.textBoxPCustomerID_TextChanged);
            // 
            // buttonInsertRecord
            // 
            this.buttonInsertRecord.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertRecord.Location = new System.Drawing.Point(96, 504);
            this.buttonInsertRecord.Name = "buttonInsertRecord";
            this.buttonInsertRecord.Size = new System.Drawing.Size(234, 99);
            this.buttonInsertRecord.TabIndex = 14;
            this.buttonInsertRecord.Text = "Insert Record";
            this.buttonInsertRecord.UseVisualStyleBackColor = true;
            this.buttonInsertRecord.Click += new System.EventHandler(this.buttonInsertRecord_Click);
            // 
            // FormInsertOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonInsertRecord);
            this.Controls.Add(this.textBoxPCustomerID);
            this.Controls.Add(this.textBoxOrderShipDate);
            this.Controls.Add(this.labelCustoerID);
            this.Controls.Add(this.textBoxOrdeerDate);
            this.Controls.Add(this.labelOrderShipDate);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBackToCustomerMainForm);
            this.Name = "FormInsertOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertOrder";
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
        private System.Windows.Forms.Button buttonInsertRecord;
    }
}