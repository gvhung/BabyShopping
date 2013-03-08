using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.Models;
using BabyShop.Service.Utility;

namespace BabyShop.Service.Converter
{
    public static class LocalToModel
    {
        public static ShoppingCartDTO ToModel(this ShoppingCartModel cart)
        {
            if (cart != null)
            {
                ShoppingCartDTO toReturn = new ShoppingCartDTO();
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
        public static UserDTO ToModel(this UserModel user)
        {
            if (user != null)
            {
                UserDTO toReturn = new UserDTO();
                //toReturn.MLoginID = user.MLoginID;
                //toReturn.MLoginFirstName = user.MLoginFirstName.NullToEmpty();
                //toReturn.MLoginLastName = user.MLoginLastName.NullToEmpty();
                //toReturn.MLoginAddress = user.MLoginAddress.NullToEmpty();
                //toReturn.MLoginState = user.MLoginState.NullToEmpty();
                //toReturn.MLoginCountry = user.MLoginCountry.NullToEmpty();
                //toReturn.MLoginCity = user.MLoginCity.NullToEmpty();
                //toReturn.MLoginZip = user.MLoginZip.NullToEmpty();
                return toReturn;
            }
            return null;
        }
    }
}