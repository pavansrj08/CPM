using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace BusinessLogic
{
    public interface IProductLogic
    {
        Product AddProduct(Product product);
        IEnumerable<Product> GetProducts();

        IEnumerable<Product> GetProductById(int id);

        Product DeleteProduct(int id);

        Product UpdateProduct(int id, Product product);
    }
}
