using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class CustomerViewModel
    {
        public int CustomerId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter the name")]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = " Space and numbers not allowed")]
        [StringLength(30, MinimumLength = 3)]
        public string CustomerName
        {
            get;
            set;
        }
        //[DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Enter the Mobile Number")]
        [RegularExpression(@"^[6789]\d{9}$", ErrorMessage = "Mobile Number is Invalid")]
        public long CustomerMobile
        {
            get;
            set;
        }
        [StringLength(50, MinimumLength = 13)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string CustomerEMail
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password must contains upper case, lower case, Numbers, or special character")]
        [StringLength(15, MinimumLength = 8)]
        public string CustomerPassword
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirmation Password is required!!")]
        [Compare("CustomerPassword", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword
        {
            get;
            set;
        }
        //public CustomerViewModel() { }
        //public CustomerViewModel(int id, string name, long mobile, string email, string password)
        //{
        //    this.CustomerId = id;
        //    this.CustomerName = name;
        //    this.CustomerMobile = mobile;
        //    this.CustomerEMail = email;
        //    this.CustomerPassword = password;
        //}
    }
}