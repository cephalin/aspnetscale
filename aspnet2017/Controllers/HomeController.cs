using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet2017.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            Session.Add("visited", "true");
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}