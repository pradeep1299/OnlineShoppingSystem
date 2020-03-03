using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_BL;
using OnlineShoppingSystem_Entity;
using System.Web.Mvc;

namespace OnlineShoppingSystem.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(CustomerSignup signup)
        {
            CustomerBL customerBL = new CustomerBL();
            CustomerDetails customer = new CustomerDetails();
            if (ModelState.IsValid)
            {
                customer.customerId = signup.customerId;
                customer.customerName = signup.customerName;
                customer.customerMobile = signup.customerMobile;
                customer.customerEMail = signup.customerEMail;
                customer.customerPassword = signup.customerPassword;
                customer.role = "Customer";
                customerBL.AddCustomer(customer);
                //Response.Write("Registration Successfully");
                return RedirectToAction("Login", "SignIn");
                //return View();
            }
            return View();
        }
    }
}