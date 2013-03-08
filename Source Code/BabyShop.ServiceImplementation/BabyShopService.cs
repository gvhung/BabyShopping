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
    using BabyShop.ServiceImplementation.ServiceContracts;
    using BabyShop.CommonLayer.DataTransferObjects;
    using BabyShop.BusinessLayer.Manager;

    /// <summary>
    /// This class is used to provide services for the system module and associated screens
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BabyShopService : IBabyShopServiceContract
    {
        public UserDTO ValidateUser(UserDTO user)
        {
            UserManager MU = new UserManager();
            //UserDTO uesrDetail = MU.ValidateUser(user);
            //return uesrDetail;
            return null;
        }

        public bool CreateUser(UserDTO user)
        {
            bool status = false;
            UserManager MU = new UserManager();
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

        public UserDTO GetUserDetails(int userId)
        {
            UserManager MU = new UserManager();
            //UserDTO uesrDetail = MU.GetUserDetails(userId);
            return null; //uesrDetail;
        }

        public bool InsertProductCart(ShoppingCartDTO product)
        {
            ProductCartManager MN = new ProductCartManager();
            bool status = false;
            try
            {
                //status = MN.InsertProductCart(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public List<ShoppingCartDTO> GetShoppingCartIteim(Guid CartId)
        {
            ProductCartManager MN = new ProductCartManager();
            //List<ShoppingCartDTO> productCartList = MN.GetShoppingCartIteim(CartId);
            return null;
        }

        public bool DeleteShoppingCart(int productCartId)
        {
            ProductCartManager MN = new ProductCartManager();
            bool status = false;
            status = MN.DeleteShoppingCart(productCartId);
            return status;
        }

        public int CountCartItems(Guid cartId)
        {
            ProductCartManager productCartMgr = new ProductCartManager();
            return productCartMgr.CountCartItems(cartId);
        }
    }
}