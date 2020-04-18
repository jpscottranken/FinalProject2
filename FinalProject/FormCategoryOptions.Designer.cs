namespace FinalProject
{
    partial class FormCategoryOptions
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
            this.buttonInsertCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonReturnToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInsertCategory
            // 
            this.buttonInsertCategory.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertCategory.Location = new System.Drawing.Point(88, 178);
            this.buttonInsertCategory.Name = "buttonInsertCategory";
            this.buttonInsertCategory.Size = new System.Drawing.Size(241, 122);
            this.buttonInsertCategory.TabIndex = 0;
            this.buttonInsertCategory.Text = "Insert  Category";
            this.buttonInsertCategory.UseVisualStyleBackColor = true;
            this.buttonInsertCategory.Click += new System.EventHandler(this.buttonInsertCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCategory.Location = new System.Drawing.Point(393, 178);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(241, 122);
            this.buttonUpdateCategory.TabIndex = 1;
            this.buttonUpdateCategory.Text = "Update Category";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(88, 354);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(241, 122);
            this.buttonDeleteCategory.TabIndex = 2;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonReturnToMainForm
            // 
            this.buttonReturnToMainForm.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToMainForm.Location = new System.Drawing.Point(393, 354);
            this.buttonReturnToMainForm.Name = "buttonReturnToMainForm";
            this.buttonReturnToMainForm.Size = new System.Drawing.Size(241, 122);
            this.buttonReturnToMainForm.TabIndex = 3;
            this.buttonReturnToMainForm.Text = "Return To Main Form";
            this.buttonReturnToMainForm.UseVisualStyleBackColor = true;
            this.buttonReturnToMainForm.Click += new System.EventHandler(this.buttonReturnToMainForm_Click);
            // 
            // FormCategoryOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonReturnToMainForm);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonUpdateCategory);
            this.Controls.Add(this.buttonInsertCategory);
            this.Name = "FormCategoryOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is the Category Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonReturnToMainForm;
    }
}