namespace FinalProject
{
    partial class FormDeleteCategory
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
            this.labelzTitle = new System.Windows.Forms.Label();
            this.buttonReturnToCategoryForm = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxTheCategoryDescription = new System.Windows.Forms.ComboBox();
            this.labelTheCategoryDescription = new System.Windows.Forms.Label();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.labelCategoryDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelzTitle
            // 
            this.labelzTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelzTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelzTitle.Location = new System.Drawing.Point(12, 34);
            this.labelzTitle.Name = "labelzTitle";
            this.labelzTitle.Size = new System.Drawing.Size(765, 56);
            this.labelzTitle.TabIndex = 0;
            this.labelzTitle.Text = "Category Delete Form";
            this.labelzTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturnToCategoryForm
            // 
            this.buttonReturnToCategoryForm.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.buttonReturnToCategoryForm.Location = new System.Drawing.Point(437, 514);
            this.buttonReturnToCategoryForm.Name = "buttonReturnToCategoryForm";
            this.buttonReturnToCategoryForm.Size = new System.Drawing.Size(234, 99);
            this.buttonReturnToCategoryForm.TabIndex = 12;
            this.buttonReturnToCategoryForm.Text = "Return To Category Form";
            this.buttonReturnToCategoryForm.UseVisualStyleBackColor = true;
            this.buttonReturnToCategoryForm.Click += new System.EventHandler(this.buttonReturnToCategoryForm_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(96, 514);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(234, 99);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxTheCategoryDescription
            // 
            this.comboBoxTheCategoryDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTheCategoryDescription.FormattingEnabled = true;
            this.comboBoxTheCategoryDescription.Location = new System.Drawing.Point(197, 125);
            this.comboBoxTheCategoryDescription.Name = "comboBoxTheCategoryDescription";
            this.comboBoxTheCategoryDescription.Size = new System.Drawing.Size(580, 39);
            this.comboBoxTheCategoryDescription.TabIndex = 10;
            // 
            // labelTheCategoryDescription
            // 
            this.labelTheCategoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTheCategoryDescription.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheCategoryDescription.Location = new System.Drawing.Point(12, 125);
            this.labelTheCategoryDescription.Name = "labelTheCategoryDescription";
            this.labelTheCategoryDescription.Size = new System.Drawing.Size(179, 40);
            this.labelTheCategoryDescription.TabIndex = 9;
            this.labelTheCategoryDescription.Text = "Category Desc.";
            this.labelTheCategoryDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(197, 199);
            this.textBoxCategoryDescription.Multiline = true;
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(580, 40);
            this.textBoxCategoryDescription.TabIndex = 8;
            this.textBoxCategoryDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCategoryDescription.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryDescription.Location = new System.Drawing.Point(12, 199);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(179, 40);
            this.labelCategoryDescription.TabIndex = 7;
            this.labelCategoryDescription.Text = "Category Desc.";
            this.labelCategoryDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonReturnToCategoryForm);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxTheCategoryDescription);
            this.Controls.Add(this.labelTheCategoryDescription);
            this.Controls.Add(this.textBoxCategoryDescription);
            this.Controls.Add(this.labelCategoryDescription);
            this.Controls.Add(this.labelzTitle);
            this.Name = "FormDeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelzTitle;
        private System.Windows.Forms.Button buttonReturnToCategoryForm;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxTheCategoryDescription;
        private System.Windows.Forms.Label labelTheCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.Label labelCategoryDescription;
    }
}