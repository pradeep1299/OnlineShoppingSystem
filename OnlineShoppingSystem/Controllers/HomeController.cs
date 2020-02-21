using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_DAL;
using System.Web.Mvc;

namespace OnlineShoppingSystem.Controllers
{
    public class HomeController : Controller
    {
        CustomerRespository customerRespository = new CustomerRespository();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerEntity customer)
        {
            customerRespository.Add(customer);
            if (ModelState.IsValid)
            {
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
        public ActionResult Login(CustomerEntity customer)
        {
            return View();
        }
    }
}
