using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShoppingSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AddCustomer",
                url: "signup/customer",
                defaults: new { controller = "Account", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LoginCustomer",
                url: "login/customer",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
