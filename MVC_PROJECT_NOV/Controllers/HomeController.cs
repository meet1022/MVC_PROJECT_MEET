using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT_NOV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["ControllerMsg"] = "This is from Home Controller";
            return View();
        }

        public ActionResult About()
        {
            string temp = Convert.ToString(TempData["ControllerMsg"]);
            //Not able to get value here. Value retained for one roundtrip only.
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("ContactUs")]   //It is used for attribute routing without mapping url in RouteConfig.cs.
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyPage()  //press rightclick on method name to create MyPage view
        {
            return View();
        }
    }
}