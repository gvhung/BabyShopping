using System.Collections.Generic;
using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;
using BabyShop.Models;

namespace BabyShopping.Controllers
{
    public class ProductController : BaseController
    {
        public ActionResult Index(ProductModel product)
        {
            var productCartMgr = new ProductCartManager();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());
            ViewBag.ProductId = product.Id;
            ViewBag.Price = product.Price;
            ViewBag.ProductName = product.Name;
            ViewBag.Description = product.Description;
            var productManager = new ProductManager();
            var productImages = productManager.GetProductImagesById(product.Id);
            return View("ProductDetail", productImages);

        }
        public ActionResult Product()
        {
            var productCartMgr = new ProductCartManager();
            var productManager = new ProductManager();

            IList<ProductModel> productModels = productManager.GetallProducts();
            ViewBag.ItemsCount = productCartMgr.CountCartItems(GetShoppingCartId());

            return View(productModels);
        }

    }
}