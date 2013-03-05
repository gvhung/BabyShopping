using System;
using BabyShop.Data;
using BabyShop.Manager;
using BabyShop.Models;
using System.Collections.Generic;
namespace BabyShopping.Service
{
    public class ShoppingCartService
    {
        public static bool InsertProductShoppingCart(ShoppingCartModel cart)
        {
            bool status = false;
            MProductCart productMgr = new MProductCart();

            EShoppingCart toReturn = new EShoppingCart();
            toReturn.ShoppingCartProductKId = cart.ShoppingCartProductKId;
            toReturn.ShoppingCartQuantity = cart.ShoppingCartQuantity;
            toReturn.ShoppingCartProductPrice = cart.ShoppingCartProductPrice;
            toReturn.ShoppingCartId = cart.ShoppingCartId;

            status = productMgr.InsertProductCart(toReturn);
            return status;
        }

        public static IList<ShoppingCartModel> GetShoppingCartIteim(string cartId)
        {
            MProductCart productMgr = new MProductCart();
            IList<EShoppingCart> productCartList = productMgr.GetShoppingCartIteim(cartId);
            IList<ShoppingCartModel> shoppingCartList = new List<ShoppingCartModel>();

            if (productCartList != null)
            {
                foreach (EShoppingCart productCart in productCartList)
                {
                    ShoppingCartModel toReturn = new ShoppingCartModel();
                    toReturn.ProductCategoryName = productCart.ProductCategoryName;
                    toReturn.ShoppingCartProductPrice = productCart.ShoppingCartProductPrice;
                    toReturn.ShoppingCartQuantity = productCart.ShoppingCartQuantity;
                    toReturn.ProductImageURL = productCart.ProductImageURL;
                    toReturn.ShoppingCartId = productCart.ShoppingCartId;
                    toReturn.ShoppingCartProductKId = productCart.ShoppingCartProductKId;
                    shoppingCartList.Add(toReturn);
                }
            }
            return shoppingCartList;
        }

        public static bool DeleteShoppingCart(int PCartKId)
        {   
            MProductCart productCart = new MProductCart();
            bool status = false;
            status = productCart.DeleteShoppingCart(PCartKId);
            return status;
        }

        public static int CountShoppingCartItems(string cartId)
        {
            MProductCart productCart = new MProductCart();
            int CartIterm = productCart.CountShoppingCartItems(cartId);
            return CartIterm;
        }
    }
}