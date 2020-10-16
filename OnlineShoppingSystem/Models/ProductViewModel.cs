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
        [RegularExpression(@"^\d{2}$", ErrorMessage = "Stock Greater than 10 or Less than 100")]
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
        [RegularExpression(@"^\d{0,6}(\.\d{1,4})?$", ErrorMessage = "Please Enter Your Correct Product Price")]
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