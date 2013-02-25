﻿using System;
using System.Web.Mvc;
using BabyShop.DataTransferObjects;

namespace BabyShopping.Web.Controllers
{
    public class ShopController : BaseController
    {
        public ActionResult ShoppingCart(ProductCart productCart)
        {
            ViewData["Data"] = null;
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartProductPrice = Convert.ToDecimal(productCart.ProductCartPrice);
            cart.ShoppingCartProductKId = Convert.ToInt32(productCart.ProductCartProductKId);
            cart.ShoppingCartQuantity = Convert.ToInt32(productCart.ProductCartQuantity);
            cart.ShoppingCartId = GetShoppingCartId();
            //bool status = false;
            //status = ShoppingCartService.InsertProductShoppingCart(cart);
            //if (status)
            //{
              //  ViewData["Data"] = ToJSON(ShoppingCartService.GetShoppingCartIteim(GetShoppingCartId()));
                //ViewData["AddToCartItems"]  = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
            //}
            return View();
        }

        public ActionResult CheckOut()
        {
        //    ViewData["AddToCartItems"]  = ShoppingCartService.CountShoppingCartItems(GetShoppingCartId());
          //  ViewData["UserDetail"] = ToJSON(UserService.GetUserDetails(GetLoggedInUserId()));
            //HttpContext.Session.Abandon();
            //HttpContext.Session.Clear();
            return View();
        }

        public ActionResult ChangeAddress()
        {
            return View();
        }

        public ActionResult TermCondition()
        {
            return View();
        }
    }
}