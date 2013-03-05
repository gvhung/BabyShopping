using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using BabyShop.Utilities;

namespace BabyShopping.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Parameter defaults
                new[] { "BabyShopping.Web.Controllers"}
            );
        }

        protected void Application_Start()
        {
            // Code that runs on application startup
            //string serviceURL = ConfigurationManager.AppSettings[AppConstants.SERVICE_URL].ToString();
            //ServiceFactory.InitializeServiceFactory(serviceURL);

            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
        }
    }
}