using OnlineShoppingSystem_DAL;
using OnlineShoppingSystem_Entity;
using System.Collections.Generic;


namespace OnlineShoppingSystem_BL
{
    public class CategoryBL
    {
        static CategoryRespository categoryRespository = new CategoryRespository();
        public static void AddCategory(Category category)
        {
            categoryRespository.Add(category);
        }
        public static IEnumerable<Category> CategoryDetails()
        {
            IEnumerable<Category> category = new CategoryRespository().GetCategory();
            return category;
        }
        public static Category GetCategoryDetails(int categoryId)
        {
            return categoryRespository.GetCategoryDetail(categoryId);
        }
        public static void CategoryDelete(int categoryId)
        {
            categoryRespository.CategoryDelete(categoryId);
        }
    }
}
