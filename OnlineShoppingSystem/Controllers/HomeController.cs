using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Web.Mvc;
using System.Collections.Generic;
//using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers
{
    public class HomeController : Controller
    {
        CustomerRespository customerRespository = new CustomerRespository();
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
        public ActionResult Create(CustomerDetails customer)
        {
            //CustomerDetails customer = new CustomerDetails();
            if (ModelState.IsValid)
            {
                customerRespository.Add(customer);
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
