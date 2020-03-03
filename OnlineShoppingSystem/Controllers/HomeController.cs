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
    }
}
