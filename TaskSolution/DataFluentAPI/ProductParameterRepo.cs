using DataFluentAPI.Entities;

namespace DataFluentAPI
{
    public class ProductParameterRepo : IProductParameterRepo
    {
        TaskContext _context;
        public ProductParameterRepo(TaskContext context)
        {
            _context = context;
        }

        public ProductParameter AddProductParameter(ProductParameter productParameter)
        {
            _context.Add(productParameter);
            _context.SaveChanges();
            return productParameter;
        }

        public ProductParameter DeleteProductParameter(int id)
        {
            var _id = _context.ProductParameters.Where(i => i.Id == id).FirstOrDefault();
            _context.ProductParameters.Remove(_id);
            _context.SaveChanges();
            return _id;
        }

        public IEnumerable<ProductParameter> GetProductParameterById(int id)
        {
            var _id = _context.ProductParameters.Where(i => i.ProductId == id);
            return _id;
        }

        public List<ProductParameter> GetAllProductParameters()
        {
            return _context.ProductParameters.ToList();
        }

        public ProductParameter UpdateProductParameter(ProductParameter productParameter)
        {
            _context.Update(productParameter);
            _context.SaveChanges();
            return productParameter;
        }
    }
}