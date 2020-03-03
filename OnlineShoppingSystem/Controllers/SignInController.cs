using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_BL;
using System.Web.Mvc;
using System;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            string username;
            username = (Request["Username"]).ToString();
            CustomerDetails user = new CustomerDetails();
            if (ModelState.IsValid)
            {
                try
                {
                    user.customerMobile = Convert.ToInt64(login.username);
                }
                catch(FormatException)
                {
                    user.customerEMail = login.username;
                }
                user.customerPassword = login.password;
                string role = ValidateLogin.validateSignIn(user);
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
                if (role == "Admin")
                {
                    return RedirectToAction("AdminIndex", "Admin");
                }
                else if (role == "Customer")
                {
                    return RedirectToAction("AdminIndex", "Admin");
                }
                else
                {
                    Response.Write("Username and Password is incorrect");
                }
            }
            return View();
        }
    }
}