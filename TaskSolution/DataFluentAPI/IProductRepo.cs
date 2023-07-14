using DataFluentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFluentAPI
{
    public interface IProductRepo
    {
        Product AddProduct(Product product);
        Product DeleteProduct(int id);
        IEnumerable<Product> GetProductById(int id);
        List<Product> GetAllProducts();
        Product UpdateProduct(Product product);
    }
}
