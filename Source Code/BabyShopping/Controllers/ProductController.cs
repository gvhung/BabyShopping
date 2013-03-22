using System.Collections.Generic;
using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;
using BabyShop.Models;

namespace BabyShopping.Controllers
{
    public class ProductController : BaseController
    {
        public ActionResult Product()
        {
            var productCartMgr = new ProductCartManager();
            var productManager = new ProductManager();

            IList<ProductModel> productModels = productManager.GetallProducts();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            
            return View(productModels);
        }

        public ActionResult ProductDetail(ProductModel productDetails)
        {
            var productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            return View(productDetails);
        }
    }
}