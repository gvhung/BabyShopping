using System;
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
        ProductCartManager productCartMgr = new ProductCartManager();
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart(ProductCartModel productCart)
        {
            IList<ProductCartModel> productCartModelList = null;
            
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

        [HttpPost]
        public ActionResult PopulateGrid()
        {
            shoppingCartId = base.GetShoppingCartId();
            return View("ShoppingCart", productCartMgr.GetCartItems(shoppingCartId));
        }

        public ActionResult DeleteItemInShoppingCart(int productCartId)
        {
            shoppingCartId = base.GetShoppingCartId();

            ProductCartManager productCartMgr = new ProductCartManager();
            bool status = productCartMgr.DeleteShoppingCart(productCartId);
            ViewBag.ItemsCount = productCartMgr.CountCartItems(shoppingCartId);

            return View("ShoppingCart", productCartMgr.GetCartItems(shoppingCartId));
        }

        [HttpPost]
        public ActionResult UpdateQuantityInCart(int productCartId, int quantity)
        {
            shoppingCartId = base.GetShoppingCartId();

            ProductCartModel productCartModel = new ProductCartModel();
            productCartModel.Id = productCartId;
            productCartModel.Quantity = quantity;

            ProductCartManager productCartMgr = new ProductCartManager();
            bool status = productCartMgr.UpdateQuantityInCart(productCartModel);
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