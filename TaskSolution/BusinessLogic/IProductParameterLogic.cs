using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IProductParameterLogic
    {
        ProductParameter AddProductParameter(ProductParameter parameter);
        IEnumerable<ProductParameter> GetProductParameters();

        IEnumerable<ProductParameter> GetProductParameterById(int id);

        ProductParameter DeleteProductParameter(int id);

        ProductParameter UpdateProductParameter(int id, ProductParameter parameter);
    }
}
