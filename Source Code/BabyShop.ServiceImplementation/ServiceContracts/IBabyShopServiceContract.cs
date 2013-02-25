// -----------------------------------------------------------------------
// <copyright file="IBabyShoppingServiceContract.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace BabyShop.ServiceImplementation.ServiceContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using BabyShop.Data;

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
        EUser ValidateUser(EUser user);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        EUser GetUserDetails(int userId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool CreateUser(EUser user);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool InsertProductCart(EShoppingCart product);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        List<EShoppingCart> GetShoppingCartIteim(string CartId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteShoppingCart(int productCartId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int CountShoppingCartItems(string userId);
    }
}