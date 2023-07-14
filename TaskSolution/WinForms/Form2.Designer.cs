namespace WinForms
{
    partial class Form2
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
            Category = new Label();
            CategoryName = new TextBox();
            Submit = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(38, 67);
            Category.Name = "Category";
            Category.Size = new Size(69, 20);
            Category.TabIndex = 1;
            Category.Text = "Category";
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(156, 64);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(250, 27);
            CategoryName.TabIndex = 8;
            // 
            // Submit
            // 
            Submit.Location = new Point(237, 121);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 14;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(336, 168);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 15;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 209);
            Controls.Add(Cancel);
            Controls.Add(Submit);
            Controls.Add(CategoryName);
            Controls.Add(Category);
            Name = "Form2";
            Text = "AddProduct";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoryId;
        private Label Category;
        private TextBox CategoryName;
        private Button Submit;
        private Button Cancel;
    }
}