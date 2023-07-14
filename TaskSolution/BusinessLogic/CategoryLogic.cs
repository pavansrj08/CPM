using DataFluentAPI;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryLogic : ICategoryLogic
    {
        ICategoryRepo _repo;

        public CategoryLogic(ICategoryRepo repo)
        {
            _repo = repo;
        }
        public Category AddCategory(Category category)
        {
            return Mapper.Map(_repo.AddCategory(Mapper.Map(category)));
        }

        public Category DeleteCategory(int id)
        {
            var _id = (from i in  _repo.GetAllCategories().Where(c => c.Id == id) select i).FirstOrDefault();
            return Mapper.Map(_repo.DeleteCategory(id));
        }

        public IEnumerable<Category> GetCategories()
        {
            return Mapper.Map(_repo.GetAllCategories());
        }

        public Category GetCategoryById(int id)
        {
            return Mapper.Map(_repo.GetCategoryById(id));
        }

        public Category GetCategoryByName(string name)
        {
            return Mapper.Map(_repo.GetCategoryByName(name));
        }

        public Category UpdateCategory(int id, Category category)
        {
            var _id = (from i in _repo.GetAllCategories() where i.Id == id select i).FirstOrDefault();
            if (_id != null)
            {
                _id.Name = category.Name;
                _id = _repo.UpdateCategory(_id);
            }
            return Mapper.Map(_id);
        }
    }
}
