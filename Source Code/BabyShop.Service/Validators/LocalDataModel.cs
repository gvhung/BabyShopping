using System.Collections.Generic;
using BabyShop.Models;

namespace BabyShop.Service.Validators
{
    internal enum UseralidationType
    {
        LoginUser
    }

    public struct ErrorMessages
    {
        public struct User
        {
            public const string LOGINRIGHTSUSERID = "User Id can not be Empty.";
            public const string PASSWORD = "Password can not be Empty.";
            public const string InValidCredential = "Invalid User id or Password.";
            public const string InValidSignUp = "User already Exists.";
            public const string UPDATEPROFILERESULT = "Update Successfully..";
        }
    }

    internal static class LocalDataModel
    {
        internal static bool Validate(this UserModel user, UseralidationType validationType, out List<DataError> dataError)
        {
            dataError = new List<DataError>();
            switch (validationType)
            {
                case UseralidationType.LoginUser:
                    //if (string.IsNullOrEmpty(user.MLoginRightsUserID))
                    //{
                    //    dataError.Add(new DataError() { PropertyName = "MLoginRightsUserID", ErrorDescription = ErrorMessages.User.LOGINRIGHTSUSERID });
                    //}
                    //if (string.IsNullOrEmpty(user.MLoginRightsPassword))
                    //{
                    //    dataError.Add(new DataError() { PropertyName = "MLoginRightsPassword", ErrorDescription = ErrorMessages.User.PASSWORD });
                    //}
                    break;
                default:
                    break;
            }
            if (dataError.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}