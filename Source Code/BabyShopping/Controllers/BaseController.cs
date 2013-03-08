#region Using directives

using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BabyShop.CommonLayer.Utilities;
using BabyShop.Models;

#endregion

namespace BabyShopping.Controllers
{
    public class BaseController : Controller
    {
        public static string ToJSON(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        public static string ToJSON(object obj, int recursionDepth)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }

        public void SetLoginSession(UserModel userModel)
        {
            Session["IsLoggedIn"] = true;
            Session["UserId"] = userModel.Id;
            Response.Cookies.Add(new HttpCookie("UserId", userModel.Id.ToString()));
            Response.Cookies.Add(new HttpCookie("Username", userModel.FirstName + " " + userModel.LastName));
        }

        public int GetLoggedInUserId()
        {
            return Convert.ToInt32(Session["UserId"]);
        }

        public Guid GetShoppingCartId()
        {
            if (HttpContext.Session[AppConstants.CARTSESSIONKEY] == null)
            {
                // Generate a new random GUID using System.Guid class.                         
                Guid tempCartId = Guid.NewGuid();
                HttpContext.Session[AppConstants.CARTSESSIONKEY] = tempCartId;
            }
            return new Guid(HttpContext.Session[AppConstants.CARTSESSIONKEY].ToString());
        }
    }
}