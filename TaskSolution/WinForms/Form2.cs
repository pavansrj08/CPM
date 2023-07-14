using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WinForms
{
    public partial class Form2 : Form
    {
        string status;
        HttpClient client = new HttpClient();
        public Form2(string status)
        {
            InitializeComponent();
            this.status = status;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            if (status == "Add")
                AddCategory();
            else
                UpdateCategory();
        }

        private async void AddCategory()
        {
            Category newcategory = new Category()
            {
                Name = CategoryName.Text
            };
            var endPoint = ConfigurationManager.ConnectionStrings["AddCategory"].ConnectionString;
            HttpResponseMessage response = client.PostAsJsonAsync(endPoint, newcategory).Result;
            ResultStatus(response,"Added");
        }

        private async void UpdateCategory()
        {
            int id = Convert.ToInt32(Form1.selectedRow.Cells[0].Value);
            try
            {
                Category newCategory = new Category()
                {
                    Id = id,
                    Name = CategoryName.Text,
                };
                var endPoint = ConfigurationManager.ConnectionStrings["UpdateCategory"].ConnectionString;
                HttpResponseMessage response = await client.PutAsync(endPoint+id, JsonContent.Create(newCategory));
                ResultStatus(response, "Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.selectedRow != null)
            {
                Submit.Text = "Update";
                CategoryName.Text = Form1.selectedRow.Cells[1].Value.ToString();
            }
            else
            {
                Submit.Text = "Add";
                CategoryName.Text = string.Empty;
            }
        }

        private void ResultStatus(HttpResponseMessage response,string operation)
        {
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Category {operation} Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Category is not {operation}");
            }
        }
    }
}
