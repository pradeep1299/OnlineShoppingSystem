using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Collections.Generic;
using System;

namespace OnlineShoppingSystem_BL
{
    interface IProductBL
    {
        void AddProduct(Product product);
        IEnumerable<Product> ProductDetails();
        Product GetProductDetails(int ProductId);
        void ProductUpdate(Product product);
        void ProductDelete(Product product);
    }

    public class ProductBL
    {
        static ProductRespository productRespository = new ProductRespository();
        public void AddProduct(Product product)
        {
            productRespository.Add(product);
        }
        //public IEnumerable<ProductDetails> GetCustomer()
        //{
        //    return productRespository.GetProduct();
        //}

        public IEnumerable<Product> ProductDetails()
        {
            IEnumerable<Product> productDetails = new ProductRespository().GetProduct();
            return productDetails;
        }
        public Product GetProductDetails(int ProductId)
        {
            return productRespository.GetProductDetails(ProductId);
        }
        public void ProductUpdate(Product product)
        {
            ProductRespository.ProductUpdate(product);
        }
        public void ProductDelete(Product product)
        {
            productRespository.ProductDelete(product);
        }
    }
}
