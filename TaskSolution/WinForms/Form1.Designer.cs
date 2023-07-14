namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ShowAllProducts = new ToolStripMenuItem();
            AddProduct = new ToolStripMenuItem();
            AddProductParameter = new ToolStripMenuItem();
            showProductsToolStripMenuItem = new ToolStripMenuItem();
            ShowAllCategories = new ToolStripMenuItem();
            AddCategory = new ToolStripMenuItem();
            showCategoriesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            categoryControllerBindingSource = new BindingSource(components);
            productControllerBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowProducts = new ComboBox();
            ShowCategory = new ComboBox();
            ADD = new Button();
            Update = new Button();
            Delete = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryControllerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productControllerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 255);
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowAllProducts, ShowAllCategories });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(60, 24);
            fileToolStripMenuItem.Text = "&Menu";
            // 
            // ShowAllProducts
            // 
            ShowAllProducts.DropDownItems.AddRange(new ToolStripItem[] { AddProduct, AddProductParameter, showProductsToolStripMenuItem });
            ShowAllProducts.Name = "ShowAllProducts";
            ShowAllProducts.Size = new Size(152, 26);
            ShowAllProducts.Text = "&Product";
            ShowAllProducts.Click += ShowAllProducts_Click;
            // 
            // AddProductParameter
            // 
            AddProductParameter.Name = "AddProductParameter";
            AddProductParameter.Size = new Size(171, 26);
            // 
            // showProductsToolStripMenuItem
            // 
            showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
            showProductsToolStripMenuItem.Size = new Size(171, 26);
            // 
            // ShowAllCategories
            // 
            ShowAllCategories.DropDownItems.AddRange(new ToolStripItem[] { AddCategory, showCategoriesToolStripMenuItem });
            ShowAllCategories.Name = "ShowAllCategories";
            ShowAllCategories.Size = new Size(152, 26);
            ShowAllCategories.Text = "&Category";
            ShowAllCategories.Click += ShowAllCategories_Click_1;
            // 
            // showCategoriesToolStripMenuItem
            // 
            showCategoriesToolStripMenuItem.Name = "showCategoriesToolStripMenuItem";
            showCategoriesToolStripMenuItem.Size = new Size(180, 26);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(12, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ShowProducts
            // 
            ShowProducts.Location = new Point(0, 0);
            ShowProducts.Name = "ShowProducts";
            ShowProducts.Size = new Size(121, 28);
            ShowProducts.TabIndex = 7;
            // 
            // ShowCategory
            // 
            ShowCategory.Location = new Point(0, 0);
            ShowCategory.Name = "ShowCategory";
            ShowCategory.Size = new Size(121, 28);
            ShowCategory.TabIndex = 6;
            // 
            // ADD
            // 
            ADD.BackColor = Color.FromArgb(128, 255, 128);
            ADD.Location = new Point(438, 441);
            ADD.Name = "ADD";
            ADD.Size = new Size(94, 29);
            ADD.TabIndex = 3;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(128, 128, 255);
            Update.Location = new Point(598, 441);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(749, 441);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 491);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(ADD);
            Controls.Add(ShowCategory);
            Controls.Add(ShowProducts);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Product Catalog Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryControllerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productControllerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ShowCategories;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private BindingSource categoryControllerBindingSource;
        private BindingSource productControllerBindingSource;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowAllProducts;
        private ToolStripMenuItem AddProduct;
        private ToolStripMenuItem AddProductParameter;
        private ComboBox ShowProducts;
        private ToolStripMenuItem showProductsToolStripMenuItem;
        private ComboBox ShowCategory;
        private ToolStripMenuItem ShowAllCategories;
        private ToolStripMenuItem AddCategory;
        private ToolStripMenuItem showCategoriesToolStripMenuItem;
        private Button ADD;
        private Button Update;
        private Button Delete;
    }
}