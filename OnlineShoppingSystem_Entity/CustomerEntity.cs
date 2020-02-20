using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem_Entity
{
    public class CustomerEntity
    {
        //public enum Gender
        //{
        //    Male,
        //    Female
        //}
        //public enum Category
        //{
        //    Mobile_Phones,
        //    Fashion,
        //    Toys,
        //    Fitness,
        //    Electronics
        //}
        [Required(ErrorMessage = "Enter the name")]
        [RegularExpression(@"(\S\D)+", ErrorMessage = " Space and numbers not allowed")]
        [StringLength(30, MinimumLength = 5)]
        public string customerName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter the Mobile Number")]
        public long customerMobile
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter your password")]
        public string customerPassword
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Enter your E-mail address")]
        public string customerEMail
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Confirmation Password is required!!")]
        [Compare("customerPassword", ErrorMessage = "Password and Confirmation Password must match.")]
        public string confirmPassword
        {
            get;
            set;
        }
        //public Gender gender
        //{
        //    get;
        //    set;
        //}
        //public Category category
        //{
        //    get;
        //    set;
        //}

        public CustomerEntity() { }
        public CustomerEntity(string name,long mobile,string email,string password)
        {
            this.customerName = name;
            this.customerMobile = mobile;
            this.customerEMail = email;
            this.customerPassword = password;
        }
    }
}
