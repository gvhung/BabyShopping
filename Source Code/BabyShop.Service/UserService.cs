using System.Collections.Generic;
using BabyShop.Models;
using BabyShop.Service.Validators;
using BabyShop.Data;
using BabyShop.Manager;
namespace BabyShopping.Service
{
    public static class UserService
    {
        public static bool ValidateUser(UserModel user, out List<DataError> dataError)
        {
            bool IsValidate = false;
            dataError = null;
            EUser userDetail = new EUser();
            if (user.Validate(UseralidationType.LoginUser, out dataError))
            {
                MUser userMgr = new MUser();
                userDetail = userMgr.ValidateUser(new EUser { MLoginRightsUserID = user.MLoginRightsUserID, MLoginRightsPassword = user.MLoginRightsPassword });
                if (userDetail != null)
                {
                    user.MLoginID = userDetail.MLoginID;
                    IsValidate = true;
                }
                else
                {
                    IsValidate = false;
                    dataError.Add(new DataError() { PropertyName = "Message", ErrorDescription = ErrorMessages.User.InValidCredential });
                }
                return IsValidate;
            }
            return IsValidate;
        }

        public static UserModel GetUserDetails(int userId)
        {
            EUser user = new EUser();
            MUser userMgr = new MUser();
            
            user = userMgr.GetUserDetails(userId);
            UserModel toReturn = new UserModel();

            if (user != null)
            {   
                toReturn.MLoginID = user.MLoginID;
                toReturn.MLoginFirstName = user.MLoginFirstName;
                toReturn.MLoginLastName = user.MLoginLastName;
                toReturn.MLoginAddress = user.MLoginAddress;
                toReturn.MLoginState = user.MLoginState;
                toReturn.MLoginCountry = user.MLoginCountry;
                toReturn.MLoginCity = user.MLoginCity;
                toReturn.MLoginZip = user.MLoginZip;
            }

            return toReturn;
        }

        public static bool CreateUser(UserModel user)
        {
            MUser userMgr = new MUser();
            bool status = false;

            EUser toReturn = new EUser();
            toReturn.MLoginID = user.MLoginID;
            toReturn.MLoginFirstName = user.MLoginFirstName;
            toReturn.MLoginLastName = user.MLoginLastName;
            toReturn.MLoginAddress = user.MLoginAddress;
            toReturn.MLoginState = user.MLoginState;
            toReturn.MLoginCountry = user.MLoginCountry;
            toReturn.MLoginCity = user.MLoginCity;
            toReturn.MLoginZip = user.MLoginZip;

            status = userMgr.CreateUser(toReturn);
            return status;
        }
    }
}