using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_BL;
using OnlineShoppingSystem_Entity;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShoppingSystem.Controllers
{
    public class AccountController : Controller
    {
        CustomerBL customerBL = new CustomerBL();
        CustomerDetails customer = new CustomerDetails();
        ProfileViewModel profileViewModel = new ProfileViewModel();
        CustomerViewModel customerViewModel = new CustomerViewModel();
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login)
        {
            //string username;
            //username = (Request["Username"]).ToString();
            if (ModelState.IsValid)
            {
                try
                {
                    customer.CustomerMobile = Convert.ToInt64(login.Username);
                }
                catch (FormatException)
                {
                    customer.CustomerEMail = login.Username;
                }
                customer.CustomerPassword = login.Password;
                customer = ValidateLogin.validateSignIn(customer);
                //string role = (ValidateLogin.validateSignIn(user.role)).ToString();
                //bool isvalid = ValidateLogin.validateSignIn(username,username, login.password);
                //if (isvalid)
                //{
                //    if ( == "Admin")
                //    {
                //        return RedirectToAction("AdminIndex", "Admin");
                //    }
                //}
                //    //Response.Write("Login Successfully");
                //else
                //    Response.Write("Username and Password is incorrect");
                //if (user == null)
                //{
                //    Response.Write("Username and Password is incorrect");
                //}
                //else if (user.Role == "Admin")
                //{
                //    return RedirectToAction("Index", "Product");
                //}
                //else if (user.Role == "Customer")
                //{
                //    return RedirectToAction("AdminIndex", "Admin");
                //}
                if (customer != null)
                {
                    FormsAuthentication.SetAuthCookie(customer.CustomerName, false);
                    var authticket = new FormsAuthenticationTicket(1, customer.CustomerName, DateTime.Now, DateTime.Now.AddMinutes(20), false, customer.Role);
                    string encryptedticket = FormsAuthentication.Encrypt(authticket);
                    var authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedticket);
                    HttpContext.Response.Cookies.Add(authcookie);
                    Session["Id"] = customer.CustomerId;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Response.Write("Username and Password is Incorrect");
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(CustomerViewModel signup)
        {
            CustomerDetails customer = new CustomerDetails();
            if (ModelState.IsValid)
            {
                customer = AutoMapper.Mapper.Map<CustomerViewModel, CustomerDetails>(signup);
                customerBL.AddCustomer(customer);
                //Response.Write("Registration Successfully");
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        public ActionResult LogOff()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Admin,Customer")]
        public new ActionResult Profile()
        {
            int UserAccountId = 0;
            if (Session["Id"] != null)
            {
                UserAccountId = (int)Session["Id"];
            }
            customer = customerBL.GetCustomerDetails(UserAccountId);
            profileViewModel = AutoMapper.Mapper.Map<CustomerDetails, ProfileViewModel>(customer);
            return View(profileViewModel);
        }
        [Authorize(Roles = "Admin,Customer")]
        [HttpGet]
        public ActionResult UpdateDetails(int id)
        {
            customer = customerBL.GetCustomerDetails(id);
            profileViewModel = AutoMapper.Mapper.Map<CustomerDetails, ProfileViewModel>(customer);
            return View(profileViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateDetails(ProfileViewModel profileViewModel)
        {
            if (ModelState.IsValid)
            {
                customer = AutoMapper.Mapper.Map<ProfileViewModel, CustomerDetails>(profileViewModel);
                customerBL.CustomerUpdate(customer);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        //[Authorize(Roles = "Admin,Customer")]
        //[HttpGet]
        //public ActionResult ChangePassword(int id)
        //{
        //    customer = customerBL.GetCustomerDetails(id);
        //    customerViewModel.CustomerPassword = customer.CustomerPassword;
        //    return View(customerViewModel.CustomerPassword);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult ChangePassword(CustomerViewModel customerViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        customer = AutoMapper.Mapper.Map<CustomerViewModel, CustomerDetails>(customerViewModel);
        //        customerBL.CustomerUpdate(customer);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View();
        //}
    }
}