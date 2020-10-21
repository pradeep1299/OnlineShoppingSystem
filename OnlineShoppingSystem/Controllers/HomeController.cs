using System.Web.Mvc;
using OnlineShoppingSystem_BL;
using OnlineShoppingSystem_Entity;

namespace OnlineShoppingSystem.Controllers
{
    [Authorize(Roles = "Admin,Customer")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product products = TempData["product"] as Product;
            return View(products);
        }
    }
}
