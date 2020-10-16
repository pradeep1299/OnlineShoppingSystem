using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineShoppingSystem_DAL
{
    public class ProductRespository
    {
        //static OnlineShoppingDB_Context context = new OnlineShoppingDB_Context();

        public IEnumerable<Product> GetProduct()
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                return context.Products.Include("Category").ToList();
            }
        }
        public void Add(Product product)
        {
            using(OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                context.Entry(product).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public Product GetProductDetails(int idProduct)
        {
            using(OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                return context.Products.ToList().Where(id => id.ProductId == idProduct).SingleOrDefault();
            }
        }
        public static void ProductUpdate(Product product)
        {
            using (OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                //product = context.ProductDB.FirstOrDefault(prod => prod.productId == product.productId);
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void ProductDelete(Product product)
        {
            using(OnlineShoppingDB_Context context = new OnlineShoppingDB_Context())
            {
                product = context.Products.Find(product.ProductId);
                context.Entry(product).State = EntityState.Deleted;
                context.SaveChanges();
            }
            //context.ProductDB.Attach(product);  
        }
    }
}
