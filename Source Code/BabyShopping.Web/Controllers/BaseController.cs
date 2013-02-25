using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BabyShop.DataTransferObjects;

namespace BabyShopping.Web.Controllers
{
    public class BaseController : Controller
    {
        public const string CartSessionKey = "CartId";
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
        public void SetLoginSession(User user)
        {
            Session["IsLoggedIn"] = true;
            Session["userId"] = user.MLoginID;
            Response.Cookies.Add(new HttpCookie("Baby_userid", user.MLoginRightsUserID.ToString()));
            Response.Cookies.Add(new HttpCookie("Baby_username", user.MLoginFirstName + " " + user.MLoginLastName));

        }
        public int GetLoggedInUserId()
        {
            return Convert.ToInt32(Session["userId"].ToString());
        }
        public string GetShoppingCartId()
        {
            if (HttpContext.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.User.Identity.Name))
                {
                    HttpContext.Session[CartSessionKey] = HttpContext.User.Identity.Name;
                }
                else
                {                    // Generate a new random GUID using System.Guid class.                         
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Session[CartSessionKey].ToString();
        }
    }
}
