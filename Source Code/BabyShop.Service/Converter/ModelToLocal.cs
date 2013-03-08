using BabyShop.Models;
using BabyShop.CommonLayer.DataTransferObjects;

namespace BabyShop.Service.Converter
{
   public static class ModelToLocal
    {
       public static ShoppingCartModel ToLocal(this ShoppingCartDTO productCart)
       {
           if (productCart != null)
           {
               ShoppingCartModel toReturn = new ShoppingCartModel();
               toReturn.ProductCategoryName = productCart.ProductCategoryName;
               toReturn.ShoppingCartProductPrice = productCart.ShoppingCartProductPrice;
               toReturn.ShoppingCartQuantity = productCart.ShoppingCartQuantity;
               toReturn.ProductImageURL = productCart.ProductImageURL;
               toReturn.ShoppingCartId = productCart.ShoppingCartId;
               toReturn.ShoppingCartProductKId = productCart.ShoppingCartProductKId;
               return toReturn;
           }
           return null;
       }
       public static UserModel ToLocal(this UserDTO user)
       {
           if (user != null)
           {
               UserModel toReturn = new UserModel();
               //toReturn.MLoginID = user.MLoginID;
               //toReturn.MLoginFirstName = user.MLoginFirstName;
               //toReturn.MLoginLastName = user.MLoginLastName;
               //toReturn.MLoginAddress = user.MLoginAddress;
               //toReturn.MLoginState = user.MLoginState;
               //toReturn.MLoginCountry = user.MLoginCountry;
               //toReturn.MLoginCity = user.MLoginCity;
               //toReturn.MLoginZip = user.MLoginZip;
               return toReturn;
           }
           return null;
       }
    }
}