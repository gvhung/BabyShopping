﻿using System.Web.Mvc;
using BabyShop.Models;
using BabyShopping.Service;
namespace BabyShopping.Web.Controllers
{
    public class ProductController : BaseController
    {
        //
        // GET: /Product/

        public ActionResult BabyProduct()
        {
            ViewData["AddToCartItems"] = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
            return View();
        }

        public ActionResult ProductDetail(ProductModel product)
        {
            ViewData["productName"] = product.ProductCategoryName;
            ViewData["image"] = product.ProductImageURL;
            ViewData["price"] = product.ProductPrice;
            ViewData["ProductId"] = product.ProductKId;
            ViewData["AddToCartItems"] = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
            return View();
        }
    }
}