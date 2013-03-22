using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;

namespace BabyShopping.Controllers
{
    public class AboutController : BaseController
    {
        //
        // GET: /About/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OurStandards()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult Claudia()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }
    }
}