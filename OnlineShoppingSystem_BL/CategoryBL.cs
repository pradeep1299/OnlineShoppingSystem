using OnlineShoppingSystem_DAL;
using OnlineShoppingSystem_Entity;
using System.Collections.Generic;


namespace OnlineShoppingSystem_BL
{
    interface ICategoryBL
    {
        void AddCategory(Category category);
        IEnumerable<Category> CategoryDetails();
        Category GetCategoryDetails(int categoryId);
        void CategoryDelete(int categoryId);
    }
    public class CategoryBL : ICategoryBL
    {
        static CategoryRespository categoryRespository = new CategoryRespository();
        public void AddCategory(Category category)
        {
            categoryRespository.Add(category);
        }
        public IEnumerable<Category> CategoryDetails()
        {
            IEnumerable<Category> category = new CategoryRespository().GetCategory();
            return category;
        }
        public Category GetCategoryDetails(int categoryId)
        {
            return categoryRespository.GetCategoryDetail(categoryId);
        }
        public void CategoryDelete(int categoryId)
        {
            categoryRespository.CategoryDelete(categoryId);
        }
    }
}
