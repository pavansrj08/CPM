using DataFluentAPI.Entities;

namespace DataFluentAPI
{
    public class ProductRepo : IProductRepo
    {
        TaskContext _context;

        public ProductRepo(TaskContext context)
        {
            _context = context;
        }

        public Product AddProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product DeleteProduct(int id)
        {
            var _id = _context.Products.Where(i  => i.Id == id).FirstOrDefault();
            _context.Products.Remove(_id);
            _context.SaveChanges();
            return _id;
        }

        public IEnumerable<Product> GetProductById(int id) 
        {
            var _id = _context.Products.Where(i =>i.CategoryId == id);
            return _id;
        }

        

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return product;
        }


    }
}
