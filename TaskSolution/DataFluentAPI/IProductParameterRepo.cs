using DataFluentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFluentAPI
{
    public interface IProductParameterRepo
    {
        ProductParameter AddProductParameter(ProductParameter productParameter);
        ProductParameter DeleteProductParameter(int id);
        IEnumerable<ProductParameter> GetProductParameterById(int id);
        List<ProductParameter> GetAllProductParameters();
        ProductParameter UpdateProductParameter(ProductParameter productParameter);
    }
}
