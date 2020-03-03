using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem_Entity
{
    public class CustomerDetails
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
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int customerId
        {
            get;
            set;
        }
        //[Required(ErrorMessage = "Enter the name")]
        //[RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = " Space and numbers not allowed")]
        //[StringLength(30, MinimumLength = 5)]
        [Column("Name")]
        public string customerName
        {
            get;
            set;
        }
        //[Required(ErrorMessage = "Enter the Mobile Number")]
        //[RegularExpression(@"^[6789]\d{9}$", ErrorMessage ="Mobile Number is Invalid")]
        [Column("Mobile")]
        public long customerMobile
        {
            get;
            set;
        }
        //[Required(ErrorMessage = "Enter your password")]
        //[RegularExpression(@"^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,}$", ErrorMessage = "Password must contains upper case, lower case, Numbers, and special character")]
        [Column("Password")]
        public string customerPassword
        {
            get;
            set;
        }
        //[Required(ErrorMessage = "Enter your E-mail address")]
        //[EmailAddress]
        [Column("E-mail Address")]
        public string customerEMail
        {
            get;
            set;
        }
        public string role
        {
            get;
            set;
        }
        //[Column ("Role")]
        //public string userRole
        //{
        //    get
        //    {
        //        return role;
        //    }
        //    set
        //    {
        //        value = role;
        //    }
        //}
        //[Required(ErrorMessage = "Confirmation Password is required!!")]
        //[Compare("customerPassword", ErrorMessage = "Password and Confirmation Password must match.")]
        //public string confirmPassword
        //{
        //    get;
        //}
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

        public CustomerDetails() { }
        public CustomerDetails(int id,string name,long mobile,string email,string password)
        {
            this.customerId = id;
            this.customerName = name;
            this.customerMobile = mobile;
            this.customerEMail = email;
            this.customerPassword = password;
        }
    }
}
