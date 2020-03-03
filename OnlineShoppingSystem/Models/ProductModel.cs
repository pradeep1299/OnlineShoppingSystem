using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingSystem.Models
{
    public class ProductModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId
        {
            get;
            set;
        }
        public string productName
        {
            get;
            set;
        }
        public int productStock
        {
            get;
            set;
        }
        public int productCategoryId
        {
            get;
            set;
        }
        public double productPrice
        {
            get;
            set;
        }
        //public ProductModel()
        //{

        //}
        //public ProductModel(int id, string name, int stock, int categoryid, double price)
        //{
        //    this.productId = id;
        //    this.productName = name;
        //    this.productStock = stock;
        //    this.productCategoryId = categoryid;
        //    this.productPrice = price;
        //}
    }
}