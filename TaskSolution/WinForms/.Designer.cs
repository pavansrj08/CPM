namespace WinForms
{
    partial class UpdateCategory
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
            Name = new Label();
            CategoryName = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(213, 166);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(359, 163);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(145, 27);
            CategoryName.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.Location = new Point(390, 269);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // UpdateCaegory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(CategoryName);
            Controls.Add(Name);
            Text = "UpdateCaegory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private TextBox CategoryName;
        private Button Submit;
    }
}