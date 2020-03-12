using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_BL;
using OnlineShoppingSystem_Entity;
using System;
using System.Web.Mvc;

namespace OnlineShoppingSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel login)
        {
            //string username;
            //username = (Request["Username"]).ToString();
            CustomerDetails user = new CustomerDetails();
            if (ModelState.IsValid)
            {
                try
                {
                    user.CustomerMobile = Convert.ToInt64(login.Username);
                }
                catch (FormatException)
                {
                    user.CustomerEMail = login.Username;
                }
                user.CustomerPassword = login.Password;
                user = ValidateLogin.validateSignIn(user);
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
                if (user == null)
                {
                    Response.Write("Username and Password is incorrect");
                }
                else if (user.Role == "Admin")
                {
                    return RedirectToAction("Index", "Product");
                }
                else if (user.Role == "Customer")
                {
                    return RedirectToAction("AdminIndex", "Admin");
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

            CustomerBL customerBL = new CustomerBL();
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
    }
}