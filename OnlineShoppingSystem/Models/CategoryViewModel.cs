using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class CategoryViewModel
    {
        [Key]
        [Required(ErrorMessage = "Enter CategoryId")]
        public int CategoryId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter Category Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Numbers and special characters not allowed")]
        public string CategoryName
        {
            get;
            set;
        }
    }
}