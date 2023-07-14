using DataFluentAPI.Entities;

namespace DataFluentAPI
{
    public class CategoryRepo : ICategoryRepo
    {
        TaskContext _context;
        public CategoryRepo(TaskContext context)
        {
            _context = context;
        }

        public Category AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category DeleteCategory(int id)
        {
            var _id = _context.Categories.Where(i => i.Id == id).FirstOrDefault();
            _context.Categories.Remove(_id);
            _context.SaveChanges();
            return _id;
        }

        public Category GetCategoryById(int id)
        {
            var _id = _context.Categories.Where(i => i.Id == id).FirstOrDefault();
            return _id;
        }

        public Category GetCategoryByName(string name)
        {
            var _name = _context.Categories.Where(i => i.Name == name).FirstOrDefault();
            return _name;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}