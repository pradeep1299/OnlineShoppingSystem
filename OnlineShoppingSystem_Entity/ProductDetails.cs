using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem_Entity
{
    public class ProductDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Product ID")]
        public int productId
        {
            get;
            set;
        }
        [Column("Name")]
        public string productName
        {
            get;
            set;
        }
        [Column("Avaliable Stock")]
        public int productStock
        {
            get;
            set;
        }
        [Column("Category ID")]
        public int productCategoryId
        {
            get;
            set;
        }
        [Column("Price")]
        public double productPrice
        {
            get;
            set;
        }
        public ProductDetails()
        {

        }
        public ProductDetails(int id,string name, int stock, int categoryid, double price)
        {
            this.productId = id;
            this.productName = name;
            this.productStock = stock;
            this.productCategoryId = categoryid;
            this.productPrice = price;
        }
    }
}
