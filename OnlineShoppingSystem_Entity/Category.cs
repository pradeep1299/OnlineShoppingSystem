using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OnlineShoppingSystem_Entity
{
    public class Category
    {
        [Key]
        [Index(IsUnique = true)]
        public int CategoryId
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string CategoryName
        {
            get;
            set;
        }
        public Category() { }
        public Category(int id, string name)
        {
            this.CategoryId = id;
            this.CategoryName = name;
        }
    }
    

}
