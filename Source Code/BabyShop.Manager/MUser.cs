using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BabyShop.Data;
using BabyShop.DataAccess;

namespace BabyShop.Manager
{
   public class MUser
    {
        public EUser ValidateUser(EUser user)
        {
            AUser AU = new AUser();
            EUser uesrDetail = AU.ValidateUser(user);
            return uesrDetail;
        }

        public EUser GetUserDetails(int userId)
        {
            AUser AU = new AUser();
            EUser uesrDetail = AU.GetUserDetails(userId);
            return uesrDetail;
        }
        public bool CreateUser(EUser user)
        {
            bool status = false;
            AUser AU = new AUser();
            status = AU.CreateUser(user);
            return status;
        }
    }
}
