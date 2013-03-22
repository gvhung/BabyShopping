using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;

namespace BabyShopping.Controllers
{
    public class FAQController : BaseController
    {
        //
        // GET: /FAQ/
        public ActionResult Index()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }
    }
}