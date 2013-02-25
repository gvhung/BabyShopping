// -----------------------------------------------------------------------
// <copyright file="BabyShoppingService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace BabyShop.ServiceImplementation
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel.Activation;
    using BabyShop.Data;
    using BabyShop.Manager;
    using BabyShop.ServiceImplementation.ServiceContracts;

    /// <summary>
    /// This class is used to provide services for the system module and associated screens
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BabyShopService : IBabyShopServiceContract
    {
        public EUser ValidateUser(EUser user)
        {
            MUser MU = new MUser();
            EUser uesrDetail = MU.ValidateUser(user);
            return uesrDetail;
        }

        public bool CreateUser(EUser user)
        {
            bool status = false;
            MUser MU = new MUser();
            try
            {
                status = MU.CreateUser(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public EUser GetUserDetails(int userId)
        {
            MUser MU = new MUser();
            EUser uesrDetail = MU.GetUserDetails(userId);
            return uesrDetail;
        }

        public bool InsertProductCart(EShoppingCart product)
        {
            MProductCart MN = new MProductCart();
            bool status = false;
            try
            {
                status = MN.InsertProductCart(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public List<EShoppingCart> GetShoppingCartIteim(string CartId)
        {
            MProductCart MN = new MProductCart();
            List<EShoppingCart> productCartList = MN.GetShoppingCartIteim(CartId);
            return productCartList;
        }

        public bool DeleteShoppingCart(int productCartId)
        {
            MProductCart MN = new MProductCart();
            bool status = false;
            status = MN.DeleteShoppingCart(productCartId);
            return status;
        }

        public int CountShoppingCartItems(string userId)
        {
            MProductCart MN = new MProductCart();
            int cartCount = 0;
            cartCount = MN.CountShoppingCartItems(userId);
            return cartCount;
        }
    }
}