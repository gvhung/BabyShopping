using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BabyShop.BusinessLayer.Manager;
using BabyShop.Models;

namespace BabyShopping.Controllers
{
    public class ShopController : BaseController
    {
        private Guid shoppingCartId;
        readonly ProductCartManager productCartManager = new ProductCartManager();
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart(ProductCartModel productCart)
        {
            IList<ProductCartModel> productCartModelList;

            shoppingCartId = base.GetShoppingCartId();

            if (productCart.ProductId > 0)
            {
                productCartModelList = productCartManager.GetCartItems(shoppingCartId);
                ProductCartModel productCartModel = productCartModelList.FirstOrDefault(x => x.ProductId == productCart.ProductId);
                if (productCartModel == null)
                {
                    productCart.CartId = shoppingCartId;
                    bool status = productCartManager.InsertProductCart(productCart);
                }
            }

            productCartModelList = productCartManager.GetCartItems(shoppingCartId);
            ViewBag.ItemsCount = productCartManager.CountCartItems(shoppingCartId);

            return View(productCartModelList);
        }

        [HttpPost]
        public ActionResult PopulateGrid()
        {
            shoppingCartId = base.GetShoppingCartId();
            return RedirectToAction("ShoppingCart", productCartManager.GetCartItems(shoppingCartId).FirstOrDefault());
        }

        public ActionResult DeleteItemInShoppingCart(int productCartId)
        {
            shoppingCartId = base.GetShoppingCartId();

            var productCartManager = new ProductCartManager();
            this.productCartManager.DeleteShoppingCart(productCartId);
            ViewBag.ItemsCount = productCartManager.CountCartItems(shoppingCartId);

            return View("ShoppingCart", productCartManager.GetCartItems(shoppingCartId));
        }

        [HttpPost]
        public ActionResult UpdateQuantityInCart(int productCartId, int quantity)
        {
            shoppingCartId = base.GetShoppingCartId();

            var productCartModel = new ProductCartModel();
            productCartModel.Id = productCartId;
            productCartModel.Quantity = quantity;

            var productCartManager = new ProductCartManager();
            productCartManager.UpdateQuantityInCart(productCartModel);
            return RedirectToAction("ShoppingCart", productCartManager.GetCartItems(shoppingCartId).FirstOrDefault());
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