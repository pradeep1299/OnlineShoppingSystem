using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username is required")]
        //[Display(Name ="Username")]
        public string Username
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Password
        {
            get;
            set;
        }
        //public LoginViewModel() { }
        //public LoginViewModel(string name, string key)
        //{
        //    name = Username;
        //    key = Password;
        //}
    }
}