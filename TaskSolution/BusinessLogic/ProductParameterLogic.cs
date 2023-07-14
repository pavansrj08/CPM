using DataFluentAPI;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductParameterLogic : IProductParameterLogic
    {
        IProductParameterRepo _repo;
        public ProductParameterLogic(IProductParameterRepo repo)
        {
            _repo = repo;
        }

        public ProductParameter AddProductParameter(ProductParameter parameter)
        {
            return Mapper.Map(_repo.AddProductParameter(Mapper.Map(parameter)));
        }

        public ProductParameter DeleteProductParameter(int id)
        {
            var _id = (from i in _repo.GetAllProductParameters() where i.Id == id select i).FirstOrDefault();
            return Mapper.Map(_repo.DeleteProductParameter(id));
        }

        public IEnumerable<ProductParameter> GetProductParameterById(int id)
        {
            return Mapper.Map(_repo.GetProductParameterById(id));
        }

        public IEnumerable<ProductParameter> GetProductParameters()
        {
            return Mapper.Map(_repo.GetAllProductParameters());
        }

        public ProductParameter UpdateProductParameter(int id, ProductParameter parameter)
        {
            var _id = (from i in _repo.GetAllProductParameters() where i.Id == id select i).FirstOrDefault();
            if (_id != null)
            {
                _id.Name = parameter.Name;
                _id.Description = parameter.Description;
                _id.ProductId = parameter.ProductId;
                _id = _repo.UpdateProductParameter(_id);
            }
            return Mapper.Map(_id);
        }
    }
}
