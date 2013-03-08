using System.Collections.Generic;
using BabyShop.Models;
using BabyShop.Service.Validators;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.BusinessLayer.Manager;

namespace BabyShopping.Service
{
    public static class UserService
    {
        public static bool ValidateUser(UserModel user, out List<DataError> dataError)
        {
            bool IsValidate = false;
            dataError = null;
            UserDTO userDetail = new UserDTO();
            if (user.Validate(UseralidationType.LoginUser, out dataError))
            {
                UserManager userMgr = new UserManager();
                //userDetail = userMgr.ValidateUser(new UserDTO { MLoginRightsUserID = user.MLoginRightsUserID, MLoginRightsPassword = user.MLoginRightsPassword });
                userDetail = null;
                //if (userDetail != null)
                //{
                //    user.MLoginID = userDetail.MLoginID;
                //    IsValidate = true;
                //}
                //else
                //{
                //    IsValidate = false;
                //    dataError.Add(new DataError() { PropertyName = "Message", ErrorDescription = ErrorMessages.User.InValidCredential });
                //}
                return IsValidate;
            }
            return IsValidate;
        }

        public static UserModel GetUserDetails(int userId)
        {
            UserDTO user = new UserDTO();
            UserManager userMgr = new UserManager();
            
            //user = userMgr.GetUserDetails(userId);
            UserModel toReturn = new UserModel();

            if (user != null)
            {   
                //toReturn.MLoginID = user.MLoginID;
                //toReturn.MLoginFirstName = user.MLoginFirstName;
                //toReturn.MLoginLastName = user.MLoginLastName;
                //toReturn.MLoginAddress = user.MLoginAddress;
                //toReturn.MLoginState = user.MLoginState;
                //toReturn.MLoginCountry = user.MLoginCountry;
                //toReturn.MLoginCity = user.MLoginCity;
                //toReturn.MLoginZip = user.MLoginZip;
            }

            return toReturn;
        }

        public static bool CreateUser(UserModel user)
        {
            UserManager userMgr = new UserManager();
            bool status = false;

            UserDTO toReturn = new UserDTO();
            //toReturn.MLoginID = user.MLoginID;
            //toReturn.MLoginFirstName = user.MLoginFirstName;
            //toReturn.MLoginLastName = user.MLoginLastName;
            //toReturn.MLoginAddress = user.MLoginAddress;
            //toReturn.MLoginState = user.MLoginState;
            //toReturn.MLoginCountry = user.MLoginCountry;
            //toReturn.MLoginCity = user.MLoginCity;
            //toReturn.MLoginZip = user.MLoginZip;

            status = userMgr.CreateUser(toReturn);
            return status;
        }
    }
}