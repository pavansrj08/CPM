using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WinForms
{
    public partial class Form3 : Form
    {
        string status;
        HttpClient client = new HttpClient();
        public Form3(string status)
        {
            InitializeComponent();
            this.status = status;
        }
        private async void Submit_Click(object sender, EventArgs e)
        {
            if (status == "Add")
                AddProduct();
            else
                UpdateCategory();
        }

        private async void AddProduct()
        {
            try
            {
                Product newProduct = new Product()
                {
                    Name = ProductName.Text,
                    Price = decimal.ToInt32(ProductPrice.Value),
                    Description = ProductDescription.Text,
                    CategoryId = decimal.ToInt32(CategoryId.Value)
                };
                var endPoint = ConfigurationManager.ConnectionStrings["AddProduct"].ConnectionString;
                HttpResponseMessage response = client.PostAsJsonAsync(endPoint, newProduct).Result;
                ResultStatus(response, "Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpdateCategory()
        {
            int id = Convert.ToInt32(Form1.selectedRow.Cells[0].Value);
            try
            {
                Product newproduct = new Product()
                {
                    Id = id,
                    Name = ProductName.Text,
                    Price = Convert.ToInt32(ProductPrice.Value),
                    Description = ProductDescription.Text,
                    CategoryId = Convert.ToInt32(CategoryId.Value)
                };
                var endPoint = ConfigurationManager.ConnectionStrings["UpdateProduct"].ConnectionString;
                HttpResponseMessage response = await client.PutAsync(endPoint+id, JsonContent.Create(newproduct));
                ResultStatus(response, "Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearInputFields()
        {
            ProductName.Text = string.Empty;
            ProductPrice.Text = string.Empty;
            ProductDescription.Text = string.Empty;
            CategoryId.Text = string.Empty;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form1.selectedRow != null)
            {
                Submit.Text = "Update";
                ProductName.Text = Form1.selectedRow.Cells[1].Value.ToString();
                ProductPrice.Value = Convert.ToInt32(Form1.selectedRow.Cells[2].Value);
                ProductDescription.Text = Form1.selectedRow.Cells[3].Value.ToString();
                CategoryId.Value = Convert.ToInt32(Form1.selectedRow.Cells[4].Value);
            }
            else
            {
                Submit.Text = "Add";
                ProductName.Text = string.Empty;
                ProductPrice.Value = 0;
                ProductDescription.Text = string.Empty;
                CategoryId.Value = 0;
            }
        }

        private void ResultStatus(HttpResponseMessage response, string operation)
        {
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Product {operation} Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Product is not {operation}.");
            }
        }
    }
}
