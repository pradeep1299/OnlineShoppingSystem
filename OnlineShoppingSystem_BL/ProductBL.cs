using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Collections.Generic;
using System;

namespace OnlineShoppingSystem_BL
{
    public class ProductBL
    {
        static ProductRespository productRespository = new ProductRespository();
        public static void AddProduct(ProductDetails product)
        {
            productRespository.Add(product);
        }
        //public IEnumerable<ProductDetails> GetCustomer()
        //{
        //    return productRespository.GetProduct();
        //}

        public static IEnumerable<ProductDetails> ProductDetails()
        {
            IEnumerable<ProductDetails> productDetails = new ProductRespository().GetProduct();
            return productDetails;
        }
        public ProductDetails GetProductDetails(int idProduct)
        {
            return productRespository.GetProductDetails(idProduct);
        }
        public static void ProductDelete(ProductDetails product)
        {
            productRespository.ProductDelete(product);
        }
    }
}
