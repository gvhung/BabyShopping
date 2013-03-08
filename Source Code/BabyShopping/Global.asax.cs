using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using BabyShop.CommonLayer.Mapper;
using BabyShop.CommonLayer.Unity;
using BabyShop.CommonLayer.UnityExtension;
using BabyShop.CommonLayer.Utilities;
using Microsoft.Practices.Unity;

namespace BabyShopping
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            //Initializes unity container and registers interface with service classes 
            BabyShopUnityContainerExtension.InitializeContainer();

            //Creates mapping between Data transfer objects and persistence layer
            BabyShopUnityContainer.Container.Resolve<IMapObject>().CreateMap();

            string serviceURL = ConfigurationManager.AppSettings[AppConstants.SERVICE_URL].ToString();
            ServiceFactory.InitializeServiceFactory(serviceURL);

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}