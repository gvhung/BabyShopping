using System.Web.Mvc;
using BabyShop.DataTransferObjects;

namespace BabyShopping.Web.Controllers
{
    [HandleError]
    public class HomeController : BaseController
    {
        public ActionResult UserLogin(User user)
        {
            Session["Error"] = null;
            //List<DataError> error = null;
            //if (UserService.ValidateUser(user, out error))
            //{
              //  SetLoginSession(user);
              //  ViewData["AddToCartItems"]  = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
                //return RedirectToAction("CheckOut", new RouteValueDictionary(new { controller = "Shop", action = "CheckOut" }));
           // }
            //Session["Error"] = ToJSON(error);
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Login(User user)
        {
            return View();
        }

        public ActionResult Index()
        {
            //ViewData["AddToCartItems"]  = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult Register(User user)
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewData["AddToCartItems"]  = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
            return View();
        }
    }
}