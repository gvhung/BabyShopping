using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;

namespace BabyShopping.Controllers
{
    public class FooterController : BaseController
    {
        //
        // GET: /Footer/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }
    }
}