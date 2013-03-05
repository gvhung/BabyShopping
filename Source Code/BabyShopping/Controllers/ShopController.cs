using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BabyShop.Models;

namespace BabyShopping.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart(ProductCartModel productCart)
        {
            return View();
        }
    }
}