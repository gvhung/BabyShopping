using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabyShopping.Controllers
{
    public class AboutController : BaseController
    {
        //
        // GET: /About/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OurStandards()
        {
            return View();
        }

        public ActionResult Claudia()
        {
            return View();
        }
    }
}