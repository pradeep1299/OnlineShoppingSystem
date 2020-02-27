using OnlineShoppingSystem_Entity;
using System.Web.Mvc;
using System.Collections.Generic;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_BL;

namespace OnlineShoppingSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //IEnumerable<CustomerDetails> customer = customerRespository.ReturnCustomerDetails();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
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
                customerBL.AddCustomer(customer);
                Response.Write("Registration Successfully");
                return View();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(CustomerDetails customer)
        {
            return View();
        }
    }
}
