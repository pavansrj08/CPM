using DataFluentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFluentAPI
{
    public interface ICategoryRepo
    {
        Category AddCategory(Category category);
        Category DeleteCategory(int id);
        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);

        List<Category> GetAllCategories();
        Category UpdateCategory(Category category);
    }
}
