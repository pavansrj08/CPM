using DataFluentAPI.Entities;

namespace BusinessLogic
{
    public class Mapper
    {

        public static Models.Category Map(Category category)
        {
            return new Models.Category()
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public static Category Map(Models.Category category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public static IEnumerable<Models.Category> Map(IEnumerable<Category> category)
        {
            return category.Select(Map);
        }

        public static Models.Product Map(Product product)
        {
            return new Models.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryId = product.CategoryId
            };
        }

        public static Product Map(Models.Product product)
        {
            return new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryId = product.CategoryId
            };
        }

        public static IEnumerable<Models.Product> Map(IEnumerable<Product> product)
        {
            return product.Select(Map);
        }

        public static Models.ProductParameter Map(ProductParameter parameter) 
        {
            return new Models.ProductParameter
            {
                Id = parameter.Id,
                Name = parameter.Name,
                Description = parameter.Description,
                ProductId = parameter.ProductId
            };
        }

        public static ProductParameter Map(Models.ProductParameter parameter)
        {
            return new ProductParameter()
            {
                Id = parameter.Id,
                Name = parameter.Name,
                Description = parameter.Description,
                ProductId = parameter.ProductId
            };
        }

        public static IEnumerable<Models.ProductParameter> Map(IEnumerable<ProductParameter> parameter)
        {
            return parameter.Select(Map);
        }
    }
}