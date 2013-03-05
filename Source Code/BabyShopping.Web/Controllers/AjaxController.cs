using System.Web.Mvc;
using BabyShop.Models;
using BabyShopping.Service;
namespace BabyShopping.Web.Controllers
{
    public class AjaxController : BaseController
    {
        public JsonResult DeleteShoppingCart(int PCartKId)
        {
            return Json(ShoppingCartService.DeleteShoppingCart(PCartKId), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetShoppingCartItems()
        {
            return Json(ShoppingCartService.CountShoppingCartItems(GetShoppingCartId()), JsonRequestBehavior.AllowGet);
        }
        public JsonResult CreateUser(UserModel user)
        {
            return Json(UserService.CreateUser(user), JsonRequestBehavior.AllowGet);
        } 
    }
}