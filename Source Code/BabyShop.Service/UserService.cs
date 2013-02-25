namespace BabyShopping.Service
{
    public static class UserService
    {
        //public static bool ValidateUser(User user, out List<DataError> dataError)
        //{
        //    bool IsValidate = false;
        //    dataError = null;
        //    EUser userDetail = new EUser();
        //    if (user.Validate(UseralidationType.LoginUser, out dataError))
        //    {
        //        BabyShopServiceContractClient proxy = new BabyShopServiceContractClient();
        //        userDetail = proxy.ValidateUser(new EUser { MLoginRightsUserID = user.MLoginRightsUserID, MLoginRightsPassword = user.MLoginRightsPassword });
        //        if (userDetail != null)
        //        {
        //            user.MLoginID = userDetail.MLoginID;
        //            IsValidate = true;
        //        }
        //        else
        //        {
        //            IsValidate = false;
        //            dataError.Add(new DataError() { PropertyName = "Message", ErrorDescription = ErrorMessages.User.InValidCredential });
        //        }
        //        return IsValidate;
        //    }
        //    return IsValidate;
        //}

        //public static User GetUserDetails(int userId)
        //{
        //    BabyShopServiceContractClient proxy = new BabyShopServiceContractClient();
        //    EUser userDetail = new EUser();
        //    userDetail = proxy.GetUserDetails(userId);
        //    if (userDetail != null)
        //    {
        //        return userDetail.ToLocal();
        //    }
        //    return null;
        //}

        //public static bool CreateUser(User user)
        //{
            //ServiceFactory.InitializeServiceFactory("http://localhost/BabyShopService/BabyShopService.svc");
            //bool status = false;
            //status = ServiceFactory.ServiceClient.CreateUser(user.ToModel());
            //return status;
       // }
    }
}