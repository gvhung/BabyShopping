// -----------------------------------------------------------------------
// <copyright file="IBabyShoppingServiceContract.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace BabyShop.ServiceImplementation.ServiceContracts
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using BabyShop.CommonLayer.DataTransferObjects;

    /// <summary>
    /// Interface for definig the service contracts for presentation layer
    /// These contacts are being used by the client layer to intract with the AMS system
    /// </summary>
    /// <remarks></remarks>
    [ServiceContract]
    public interface IBabyShopServiceContract
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        UserDTO ValidateUser(UserDTO user);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        UserDTO GetUserDetails(int userId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool CreateUser(UserDTO user);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool InsertProductCart(ShoppingCartDTO product);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        List<ShoppingCartDTO> GetShoppingCartIteim(Guid CartId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteShoppingCart(int productCartId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int CountCartItems(Guid cartId);
    }
}