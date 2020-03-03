using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Username is required")]
        //[Display(Name ="Username")]
        public string username
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string password
        {
            get;
            set;
        }
        public LoginModel() { }
        public LoginModel(string name, string key)
        {
            name = username;
            key = password;
        }
    }
}