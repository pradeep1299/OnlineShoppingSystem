using OnlineShoppingSystem_Entity;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShoppingSystem_DAL
{
    public class ProductRespository
    {
        OnlineShoppingDB_Context context = new OnlineShoppingDB_Context();

        public IEnumerable<ProductDetails> GetProduct()
        {
            return context.ProductDB.ToList();
        }
        public void Add(ProductDetails product)
        {
            context.ProductDB.Add(product);
            context.SaveChanges();
        }
        public ProductDetails GetProductDetails(int idProduct)
        {
            return context.ProductDB.Where(id => id.productId == idProduct).SingleOrDefault();
        }
        public void ProductDelete(ProductDetails product)
        {
            context.ProductDB.Attach(product);
            context.ProductDB.Remove(product);
            context.SaveChanges();
        }
    }
}
