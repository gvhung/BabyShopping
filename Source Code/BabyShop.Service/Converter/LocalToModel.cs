using BabyShop.DataTransferObjects;
using BabyShop.Service.BabyShopWebService;
using BabyShop.Service.Utility;

namespace BabyShop.Service.Converter
{
    public static class LocalToModel
    {
        public static EShoppingCart ToModel(this ShoppingCart cart)
        {
            if (cart != null)
            {
                EShoppingCart toReturn = new EShoppingCart();
                toReturn.ShoppingCartProductKId = cart.ShoppingCartProductKId;
                toReturn.ShoppingCartQuantity = cart.ShoppingCartQuantity;
                toReturn.ShoppingCartProductPrice = cart.ShoppingCartProductPrice;
                toReturn.ShoppingCartId = cart.ShoppingCartId;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public static EUser ToModel(this User user)
        {
            if (user != null)
            {
                EUser toReturn = new EUser();
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