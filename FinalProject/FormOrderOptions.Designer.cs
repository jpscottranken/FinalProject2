namespace FinalProject
{
    partial class FormOrderOptions
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
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
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
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteOrder.Location = new System.Drawing.Point(88, 354);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(241, 122);
            this.buttonDeleteOrder.TabIndex = 2;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrder.Location = new System.Drawing.Point(393, 178);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(241, 122);
            this.buttonUpdateOrder.TabIndex = 1;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertOrder.Location = new System.Drawing.Point(88, 178);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(241, 122);
            this.buttonInsertOrder.TabIndex = 0;
            this.buttonInsertOrder.Text = "Insert Order";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // FormOrderOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonReturnToMainForm);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.buttonInsertOrder);
            this.Name = "FormOrderOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is the Orders Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMainForm;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonInsertOrder;
    }
}