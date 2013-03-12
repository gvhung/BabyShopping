﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BabyShop.Models;
using BabyShop.BusinessLayer.Manager;

namespace BabyShopping.Controllers
{
    public class ShopController : BaseController
    {
        private Guid shoppingCartId;
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart(ProductCartModel productCart)
        {
            IList<ProductCartModel> productCartModelList = null;
            ProductCartManager productCartMgr = new ProductCartManager();
             shoppingCartId = base.GetShoppingCartId();

            if (productCart.ProductId > 0)
            {
                 productCartModelList = productCartMgr.GetCartItems(shoppingCartId);
                ProductCartModel productCartModel = productCartModelList.FirstOrDefault(x => x.ProductId == productCart.ProductId);
                if (productCartModel == null)
                {
                    productCart.CartId = shoppingCartId;
                    bool status = productCartMgr.InsertProductCart(productCart);
                }
            }

            productCartModelList = productCartMgr.GetCartItems(shoppingCartId);
            ViewBag.ItemsCount = productCartMgr.CountCartItems(shoppingCartId);

            return View(productCartModelList);
        }

        public ActionResult DeleteShoppingCart(int productCartId)
        {
            shoppingCartId = base.GetShoppingCartId();
            ProductCartManager productCartMgr = new ProductCartManager();
            bool status = productCartMgr.DeleteShoppingCart(productCartId);
            ViewBag.ItemsCount = productCartMgr.CountCartItems(shoppingCartId);
            return View("ShoppingCart", productCartMgr.GetCartItems(shoppingCartId));
        }

        public ActionResult TermCondition()
        {
            return View();
        }

        public ActionResult CheckOut()
        {
            UserManager userMgr = new UserManager();
            UserModel userModel = userMgr.GetUserDetails(GetLoggedInUserId());
            return View(userModel);
        }

        public ActionResult ChangeAddress()
        {
            return View();
        }
    }
}