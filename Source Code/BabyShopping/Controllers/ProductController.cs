using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;
using BabyShop.Models;

namespace BabyShopping.Controllers
{
    public class ProductController : BaseController
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult ProductDetail(ProductModel productDetails)
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View(productDetails);
        }
    }
}