using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;
using BabyShop.Models;
using System.Web.Routing;

namespace BabyShopping.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {   
            return View();
        }

        public ActionResult UserLogin(UserModel userModel)
        {
            UserManager userMgr = new UserManager();
            userModel = userMgr.ValidateUser(userModel.UserName, userModel.Password);

            if (userModel.Id > 0)
            {
                SetLoginSession(userModel);
                return RedirectToAction("CheckOut", new RouteValueDictionary(new { controller = "Shop", action = "CheckOut" }));
            }
            return RedirectToAction("Login", "Home");
        }
    }
}