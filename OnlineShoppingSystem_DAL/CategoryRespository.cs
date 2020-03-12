using System.Collections.Generic;
using System.Linq;
using OnlineShoppingSystem_Entity;
using System.Data.Entity;
using System.Data.SqlClient;

namespace OnlineShoppingSystem_DAL
{
    public class CategoryRespository
    {
        public IEnumerable<Category> GetCategory()
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                return context.Categorys.ToList();
            }
        }
        public void Add(Category category)
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                SqlParameter sqlParameter = new SqlParameter("@CategoryName", category.CategoryName);
                int count = context.Database.ExecuteSqlCommand("Category_Insert @CategoryName", sqlParameter);
            }

            //using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            //{
            //    context.Entry(category).State = EntityState.Added;
            //    context.SaveChanges();
            //}
        }
        public Category GetCategoryDetail(int categoryId)
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                return context.Categorys.ToList().Where(id => id.CategoryId == categoryId).SingleOrDefault();
            }
        }
        public void CategoryDelete(int categoryId)
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                Category category = new Category();
                category = context.Categorys.Find(categoryId);
                context.Entry(category).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
