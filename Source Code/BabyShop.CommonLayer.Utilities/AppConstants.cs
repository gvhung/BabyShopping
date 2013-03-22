// -----------------------------------------------------------------------
// <copyright file="AppConstants.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace BabyShop.CommonLayer.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Summary description for AppConstants
    /// </summary>
    public class AppConstants
    {
        //This constant is used to hold the key name of the initial parameter for injecting service URL
        public const string SERVICE_URL = "ServiceURL";
        public const string CONNECTION_STRING = "ConnectionString";

        #region Stored Procedure Name

        public const string COUNTCARTITEMS = "sp_CountCartItems";
        public const string INSERTPRODUCTCART = "sp_InsertProductCart";
        public const string GETPRODUCTCARTDETAILS = "sp_GetProductCartDetail";
        public const string GETPRODUCTS = "sp_GetProducts";
        public const string DELETECARTITEM = "sp_DeleteShoppingCart";
        public const string VALIDATEUSER = "sp_UserValidate";
        public const string GETUSERDETAILS = "sp_GetUserDetails";
        public const string UPDATEQUANTITYINCART = "sp_UpdateQuantityInCart";

        #endregion

        #region State Management Variables

        public const string CARTSESSIONKEY = "CartId";

        #endregion
    }
}