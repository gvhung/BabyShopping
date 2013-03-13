using System.Web.Mvc;

namespace BabyShopping.Controllers
{
    public class FooterController : Controller
    {
        //
        // GET: /Footer/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }
    }
}