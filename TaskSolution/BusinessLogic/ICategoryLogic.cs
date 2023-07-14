using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace BusinessLogic
{
    public interface ICategoryLogic
    {
        Category AddCategory(Category category);
        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);


        Category DeleteCategory(int id);

        Category UpdateCategory(int id, Category category);





    }
}
