using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Collections.Generic;
using System;

namespace OnlineShoppingSystem_BL
{
    public class ProductBL
    {
        static ProductRespository productRespository = new ProductRespository();
        public static void AddProduct(Product product)
        {
            productRespository.Add(product);
        }
        //public IEnumerable<ProductDetails> GetCustomer()
        //{
        //    return productRespository.GetProduct();
        //}

        public static IEnumerable<Product> ProductDetails()
        {
            IEnumerable<Product> productDetails = new ProductRespository().GetProduct();
            return productDetails;
        }
        public Product GetProductDetails(int ProductId)
        {
            return productRespository.GetProductDetails(ProductId);
        }
        public static void ProductUpdate(Product product)
        {
            ProductRespository.ProductUpdate(product);
        }
        public static void ProductDelete(Product product)
        {
            productRespository.ProductDelete(product);
        }
    }
}
