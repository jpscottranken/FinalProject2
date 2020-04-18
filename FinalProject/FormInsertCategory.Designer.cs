namespace FinalProject
{
    partial class FormInsertCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCategoryDescription = new System.Windows.Forms.Label();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.buttonInsertRecord = new System.Windows.Forms.Button();
            this.buttonBackToCategoryMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Insert Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelCategoryDescription.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.labelCategoryDescription.Location = new System.Drawing.Point(12, 199);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(179, 40);
            this.labelCategoryDescription.TabIndex = 1;
            this.labelCategoryDescription.Text = "Category Desc.";
            this.labelCategoryDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(197, 199);
            this.textBoxCategoryDescription.Multiline = true;
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(580, 40);
            this.textBoxCategoryDescription.TabIndex = 2;
            // 
            // buttonInsertRecord
            // 
            this.buttonInsertRecord.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertRecord.Location = new System.Drawing.Point(96, 504);
            this.buttonInsertRecord.Name = "buttonInsertRecord";
            this.buttonInsertRecord.Size = new System.Drawing.Size(234, 99);
            this.buttonInsertRecord.TabIndex = 3;
            this.buttonInsertRecord.Text = "Insert Record";
            this.buttonInsertRecord.UseVisualStyleBackColor = true;
            // 
            // buttonBackToCategoryMainForm
            // 
            this.buttonBackToCategoryMainForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToCategoryMainForm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToCategoryMainForm.Location = new System.Drawing.Point(437, 504);
            this.buttonBackToCategoryMainForm.Name = "buttonBackToCategoryMainForm";
            this.buttonBackToCategoryMainForm.Size = new System.Drawing.Size(234, 99);
            this.buttonBackToCategoryMainForm.TabIndex = 4;
            this.buttonBackToCategoryMainForm.Text = "Return To Category Form";
            this.buttonBackToCategoryMainForm.UseVisualStyleBackColor = true;
            this.buttonBackToCategoryMainForm.Click += new System.EventHandler(this.buttonBackToCategoryMainForm_Click);
            // 
            // FormInsertCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.buttonBackToCategoryMainForm;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonBackToCategoryMainForm);
            this.Controls.Add(this.buttonInsertRecord);
            this.Controls.Add(this.textBoxCategoryDescription);
            this.Controls.Add(this.labelCategoryDescription);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.Button buttonInsertRecord;
        private System.Windows.Forms.Button buttonBackToCategoryMainForm;
    }
}