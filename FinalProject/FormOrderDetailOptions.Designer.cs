namespace FinalProject
{
    partial class FormOrderDetailOptions
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
            this.buttonReturnToMainForm = new System.Windows.Forms.Button();
            this.buttonDeleteOrderDetail = new System.Windows.Forms.Button();
            this.buttonUpdateOrderDetail = new System.Windows.Forms.Button();
            this.buttonInsertOrderDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturnToMainForm
            // 
            this.buttonReturnToMainForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturnToMainForm.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToMainForm.Location = new System.Drawing.Point(393, 354);
            this.buttonReturnToMainForm.Name = "buttonReturnToMainForm";
            this.buttonReturnToMainForm.Size = new System.Drawing.Size(241, 122);
            this.buttonReturnToMainForm.TabIndex = 3;
            this.buttonReturnToMainForm.Text = "Return To Main Form";
            this.buttonReturnToMainForm.UseVisualStyleBackColor = true;
            this.buttonReturnToMainForm.Click += new System.EventHandler(this.buttonReturnToMainForm_Click);
            // 
            // buttonDeleteOrderDetail
            // 
            this.buttonDeleteOrderDetail.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteOrderDetail.Location = new System.Drawing.Point(88, 354);
            this.buttonDeleteOrderDetail.Name = "buttonDeleteOrderDetail";
            this.buttonDeleteOrderDetail.Size = new System.Drawing.Size(241, 122);
            this.buttonDeleteOrderDetail.TabIndex = 2;
            this.buttonDeleteOrderDetail.Text = "Delete Order Detail";
            this.buttonDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.buttonDeleteOrderDetail.Click += new System.EventHandler(this.buttonDeleteOrderDetail_Click);
            // 
            // buttonUpdateOrderDetail
            // 
            this.buttonUpdateOrderDetail.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrderDetail.Location = new System.Drawing.Point(393, 178);
            this.buttonUpdateOrderDetail.Name = "buttonUpdateOrderDetail";
            this.buttonUpdateOrderDetail.Size = new System.Drawing.Size(241, 122);
            this.buttonUpdateOrderDetail.TabIndex = 1;
            this.buttonUpdateOrderDetail.Text = "Update OrderDetail";
            this.buttonUpdateOrderDetail.UseVisualStyleBackColor = true;
            this.buttonUpdateOrderDetail.Click += new System.EventHandler(this.buttonUpdateOrderDetail_Click);
            // 
            // buttonInsertOrderDetail
            // 
            this.buttonInsertOrderDetail.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertOrderDetail.Location = new System.Drawing.Point(88, 178);
            this.buttonInsertOrderDetail.Name = "buttonInsertOrderDetail";
            this.buttonInsertOrderDetail.Size = new System.Drawing.Size(241, 122);
            this.buttonInsertOrderDetail.TabIndex = 0;
            this.buttonInsertOrderDetail.Text = "Insert Order Detail";
            this.buttonInsertOrderDetail.UseVisualStyleBackColor = true;
            this.buttonInsertOrderDetail.Click += new System.EventHandler(this.buttonInsertOrderDetail_Click);
            // 
            // FormOrderDetailOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonReturnToMainForm);
            this.Controls.Add(this.buttonDeleteOrderDetail);
            this.Controls.Add(this.buttonUpdateOrderDetail);
            this.Controls.Add(this.buttonInsertOrderDetail);
            this.Name = "FormOrderDetailOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is the Order Details Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMainForm;
        private System.Windows.Forms.Button buttonDeleteOrderDetail;
        private System.Windows.Forms.Button buttonUpdateOrderDetail;
        private System.Windows.Forms.Button buttonInsertOrderDetail;
    }
}