using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem_Entity
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Product ID")]
        public int ProductId
        {
            get;
            set;
        }
        [Column("Name")]
        public string ProductName
        {
            get;
            set;
        }
        [Column("Avaliable Stock")]
        public int ProductStock
        {
            get;
            set;
        }   
        [Column("Category ID")]
        public int CategoryId
        {
            get;
            set;
        }
        public Category Category
        {
            get;
            set;
        }
        [Column("Price")]
        public double ProductPrice
        {
            get;
            set;
        }
        public Product()
        {

        }
        public Product(int id,string name, int stock, int categoryid, double price)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductStock = stock;
            this.CategoryId = categoryid;
            this.ProductPrice = price;
        }
    }
}
