using BabyShop.Data;
using BabyShop.Models;
using BabyShop.Service.Utility;

namespace BabyShop.Service.Converter
{
   public static class ModelToLocal
    {
       public static ShoppingCartModel ToLocal(this EShoppingCart productCart)
       {
           if (productCart != null)
           {
               ShoppingCartModel toReturn = new ShoppingCartModel();
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
       public static UserModel ToLocal(this EUser user)
       {
           if (user != null)
           {
               UserModel toReturn = new UserModel();
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