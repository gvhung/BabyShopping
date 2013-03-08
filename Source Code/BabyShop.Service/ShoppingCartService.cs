using System;
using System.Collections.Generic;
using BabyShop.BusinessLayer.Manager;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.Models;

namespace BabyShopping.Service
{
    public class ShoppingCartService
    {
        public static bool InsertProductShoppingCart(ShoppingCartModel cart)
        {
            bool status = false;
            ProductCartManager productMgr = new ProductCartManager();

            ShoppingCartDTO toReturn = new ShoppingCartDTO();
            toReturn.ShoppingCartProductKId = cart.ShoppingCartProductKId;
            toReturn.ShoppingCartQuantity = cart.ShoppingCartQuantity;
            toReturn.ShoppingCartProductPrice = cart.ShoppingCartProductPrice;
            toReturn.ShoppingCartId = cart.ShoppingCartId;

            //status = productMgr.InsertProductCart(toReturn);
            return status;
        }

        public static IList<ShoppingCartModel> GetShoppingCartIteim(Guid cartId)
        {
            ProductCartManager productMgr = new ProductCartManager();
            //IList<ShoppingCartDTO> productCartList = productMgr.GetShoppingCartIteim(cartId);
            IList<ShoppingCartModel> shoppingCartList = new List<ShoppingCartModel>();

            //if (productCartList != null)
            //{
            //    foreach (ShoppingCartDTO productCart in productCartList)
            //    {
            //        ShoppingCartModel toReturn = new ShoppingCartModel();
            //        toReturn.ProductCategoryName = productCart.ProductCategoryName;
            //        toReturn.ShoppingCartProductPrice = productCart.ShoppingCartProductPrice;
            //        toReturn.ShoppingCartQuantity = productCart.ShoppingCartQuantity;
            //        toReturn.ProductImageURL = productCart.ProductImageURL;
            //        toReturn.ShoppingCartId = productCart.ShoppingCartId;
            //        toReturn.ShoppingCartProductKId = productCart.ShoppingCartProductKId;
            //        shoppingCartList.Add(toReturn);
            //    }
            //}
            return shoppingCartList;
        }

        public static bool DeleteShoppingCart(int PCartKId)
        {   
            ProductCartManager productCart = new ProductCartManager();
            bool status = false;
            status = productCart.DeleteShoppingCart(PCartKId);
            return status;
        }

        public static int CountShoppingCartItems(Guid cartId)
        {
            ProductCartManager productCart = new ProductCartManager();
            int CartIterm = productCart.CountCartItems(cartId);
            return CartIterm;
        }
    }
}