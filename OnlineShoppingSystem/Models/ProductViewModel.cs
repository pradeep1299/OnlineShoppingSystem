using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingSystem.Models
{
    public class ProductViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId
        {
            get;
            set;
        }
        [Required (ErrorMessage = "Product Name is Required")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters not allowed")]
        public string ProductName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Available stock is Required")]
        public int ProductStock
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Product Price is Required")]
        public double ProductPrice
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