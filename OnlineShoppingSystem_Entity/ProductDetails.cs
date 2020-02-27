
namespace OnlineShoppingSystem_Entity
{
    public class ProductDetails
    {
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
        public ProductDetails(string name, int stock, int categoryid, double price)
        {
            this.productName = name;
            this.productStock = stock;
            this.productCategoryId = categoryid;
            this.productPrice = price;
        }
    }
}
