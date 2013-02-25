using BabyShop.DataTransferObjects;
using BabyShop.Service.BabyShopWebService;
using BabyShop.Service.Utility;

namespace BabyShop.Service.Converter
{
   public static class ModelToLocal
    {
       public static ShoppingCart ToLocal(this EShoppingCart productCart)
       {
           if (productCart != null)
           {
               ShoppingCart toReturn = new ShoppingCart();
               toReturn.ProductCategoryName = productCart.ProductCategoryName.NullToEmpty();
               toReturn.ShoppingCartProductPrice = productCart.ShoppingCartProductPrice;
               toReturn.ShoppingCartQuantity = productCart.ShoppingCartQuantity;
               toReturn.ProductImageURL = productCart.ProductImageURL.NullToEmpty();
               toReturn.ShoppingCartId = productCart.ShoppingCartId;
               toReturn.ShoppingCartProductKId = productCart.ShoppingCartProductKId;
               return toReturn;
           }
           return null;
       }
       public static User ToLocal(this EUser user)
       {
           if (user != null)
           {
               User toReturn = new User();
               toReturn.MLoginID = user.MLoginID;
               toReturn.MLoginFirstName = user.MLoginFirstName.NullToEmpty();
               toReturn.MLoginLastName = user.MLoginLastName.NullToEmpty();
               toReturn.MLoginAddress = user.MLoginAddress.NullToEmpty();
               toReturn.MLoginState = user.MLoginState.NullToEmpty();
               toReturn.MLoginCountry = user.MLoginCountry.NullToEmpty();
               toReturn.MLoginCity = user.MLoginCity.NullToEmpty();
               toReturn.MLoginZip = user.MLoginZip.NullToEmpty();
               return toReturn;
           }
           return null;
       }
    }
}