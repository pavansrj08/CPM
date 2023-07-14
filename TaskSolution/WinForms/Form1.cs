using Microsoft.EntityFrameworkCore.Diagnostics;
using Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowProducts.Visible = false;
            AddProductParameter.Visible = false;
            showProductsToolStripMenuItem.Visible = false;
            AddProduct.Visible = false;
            showProductsToolStripMenuItem.Visible = false;
            AddCategory.Visible = false;
            showCategoriesToolStripMenuItem.Visible = false;
            ShowCategory.Visible = false;
        }

        private HttpClient client = new HttpClient();

        private async void ShowAllCategories_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7243/api/Category/GetAllCategories";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(responseBody);
                BindingSource source = new BindingSource();
                source.DataSource = categories;
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("API call Failed: " + response.StatusCode);
            }
        }

        private async void ShowAllProducts_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7243/api/Product/GetAllProducts";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseBody);
                BindingSource source = new BindingSource();
                source.DataSource = products;
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("API call Failed: " + response.StatusCode);
            }
        }

        private async void ShowAllCategories_Click_1(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7243/api/Category/GetAllCategories";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(responseBody);
                dataGridView1.DataSource = categories;
            }
            else
            {
                MessageBox.Show("API call Failed: " + response.StatusCode);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Catalog Management:)");
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool isProductTable = dataGridView1.Columns.Contains("Price");
                if (isProductTable)
                {
                    DeleteProduct();
                }
                else
                {
                    DeleteCategory();
                }
            }
        }

        private async void DeleteProduct()
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                    DataGridViewRow selectedRow = selectedCell.OwningRow;
                    Product product = new Product()
                    {
                        Id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString())
                    };
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:7243/");
                    HttpResponseMessage response = await client.DeleteAsync($"api/Product/DeleteProduct?id={id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Product Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReloadProduct();
        }

        private async void DeleteCategory()
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                    DataGridViewRow selectedRow = selectedCell.OwningRow;
                    Category category = new Category()
                    {
                        Id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString())
                    };
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:7243/");
                    HttpResponseMessage response = await client.DeleteAsync($"api/Category/DeleteCategory?id={id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Category Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReloadCategory();
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            bool isProductTable = dataGridView1.Columns.Contains("Price");
            bool isCategoryTable = !dataGridView1.Columns.Contains("Price");
            if (isProductTable)
            {
                Form3 form = new Form3("Update");
                form.ShowDialog();
                ReloadProduct();
            }
            else
            {
                Form2 form = new Form2("Update");
                form.ShowDialog();
                ReloadCategory();

            }
            selectedRow = null;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            bool isProductTable = dataGridView1.Columns.Contains("Price");
            bool isCategoryTable = !dataGridView1.Columns.Contains("Price");
            if (isProductTable)
            {
                Form3 form = new Form3("Update");
                form.ShowDialog();
                ReloadProduct();
            }
            else
            {
                Form2 form = new Form2("Add");
                form.ShowDialog();
                ReloadCategory();
            }
            selectedRow = null;

        }

        private async void ReloadProduct()
        {
            string apiUrl = "https://localhost:7243/api/Product/GetAllProducts";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseBody);
                BindingSource source = new BindingSource();
                source.DataSource = products;
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("API call Failed: " + response.StatusCode);
            }
        }
        private async void ReloadCategory()
        {
            string apiUrl = "https://localhost:7243/api/Category/GetAllCategories";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(responseBody);
                BindingSource source = new BindingSource();
                source.DataSource = categories;
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("API call Failed: " + response.StatusCode);
            }
        }

        public static DataGridViewRow selectedRow;

        private void MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }
    }
}