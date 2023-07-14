using DataFluentAPI;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductLogic : IProductLogic
    {
        IProductRepo _repo;

        public ProductLogic(IProductRepo repo) 
        {
            _repo = repo;
        }

        public Product AddProduct(Product product)
        {
            return Mapper.Map(_repo.AddProduct(Mapper.Map(product)));
        }

        public IEnumerable<Product> GetProducts()
        {
            return Mapper.Map(_repo.GetAllProducts());
        }

        public IEnumerable<Product> GetProductById(int id)
        {
            return Mapper.Map(_repo.GetProductById(id));
        }

        public Product DeleteProduct(int id)
        {
            var _id = (from i in _repo.GetAllProducts() where  i.Id == id select i).FirstOrDefault();
            return Mapper.Map(_repo.DeleteProduct(id));
        }

        public Product UpdateProduct(int id,Product product)
        {
            var _id = (from i in _repo.GetAllProducts() where  i.Id == id select i).FirstOrDefault();
            if(_id != null)
            {
                _id.Name = product.Name;
                _id.Price = product.Price;
                _id.Description = product.Description;
                _id.CategoryId = product.CategoryId;
                _id = _repo.UpdateProduct(_id);
            }
            return Mapper.Map(_id);
        }
    }
}
