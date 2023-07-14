namespace WinForms
{
    partial class Form3
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
            Price = new Label();
            Description = new Label();
            CId = new Label();
            ProductName = new TextBox();
            ProductDescription = new TextBox();
            CategoryId = new NumericUpDown();
            ProductPrice = new NumericUpDown();
            Submit = new Button();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoryId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPrice).BeginInit();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(42, 127);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(42, 189);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 1;
            Price.Text = "Price";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(42, 251);
            Description.Name = "Description";
            Description.Size = new Size(85, 20);
            Description.TabIndex = 2;
            Description.Text = "Description";
            // 
            // CId
            // 
            CId.AutoSize = true;
            CId.Location = new Point(42, 68);
            CId.Name = "CId";
            CId.Size = new Size(82, 20);
            CId.TabIndex = 3;
            CId.Text = "CategoryId";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(207, 124);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(230, 27);
            ProductName.TabIndex = 4;
            // 
            // ProductDescription
            // 
            ProductDescription.Location = new Point(207, 244);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(230, 27);
            ProductDescription.TabIndex = 5;
            // 
            // CategoryId
            // 
            CategoryId.Location = new Point(207, 61);
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(230, 27);
            CategoryId.TabIndex = 6;
            // 
            // ProductPrice
            // 
            ProductPrice.Location = new Point(207, 182);
            ProductPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(230, 27);
            ProductPrice.TabIndex = 7;
            // 
            // Submit
            // 
            Submit.Location = new Point(274, 294);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 8;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(416, 327);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 368);
            Controls.Add(Cancel);
            Controls.Add(Submit);
            Controls.Add(ProductPrice);
            Controls.Add(CategoryId);
            Controls.Add(ProductDescription);
            Controls.Add(ProductName);
            Controls.Add(CId);
            Controls.Add(Description);
            Controls.Add(Price);
            Controls.Add(Name);
            Text = "AddProduct";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryId).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label Price;
        private Label Description;
        private Label CId;
        private TextBox ProductName;
        private TextBox ProductDescription;
        private NumericUpDown CategoryId;
        private NumericUpDown ProductPrice;
        private Button Submit;
        private Button Cancel;
    }
}