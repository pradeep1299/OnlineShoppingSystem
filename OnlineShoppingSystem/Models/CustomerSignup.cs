using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class CustomerSignup
    {
        public int customerId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter the name")]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = " Space and numbers not allowed")]
        [StringLength(30, MinimumLength = 3)]
        public string customerName
        {
            get;
            set;
        }
        //[DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Enter the Mobile Number")]
        [RegularExpression(@"^[6789]\d{9}$", ErrorMessage = "Mobile Number is Invalid")]
        public long customerMobile
        {
            get;
            set;
        }
        [StringLength(50, MinimumLength = 13)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string customerEMail
        {
            get;
            set;
        }
        [StringLength(15, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,15}", ErrorMessage = "Password must contains upper case, lower case, Numbers, and special character")]
        public string customerPassword
        {
            get;
            set;
        }
        [StringLength(15, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirmation Password is required!!")]
        [Compare("customerPassword", ErrorMessage = "Password and Confirmation Password must match.")]
        public string confirmPassword
        {
            get;
            set;
        }
        public CustomerSignup() { }
        public CustomerSignup(int id, string name, long mobile, string email, string password)
        {
            this.customerId = id;
            this.customerName = name;
            this.customerMobile = mobile;
            this.customerEMail = email;
            this.customerPassword = password;
        }
    }
}