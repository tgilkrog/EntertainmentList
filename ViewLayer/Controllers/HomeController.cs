using ModelLayer;
using ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewLayer.Controllers
{
    public class HomeController : Controller
    {
        readonly ControlLayer.UserController uCtr = new ControlLayer.UserController();
        public ActionResult Index()
        {
            
            return View(uCtr.GetUserByID(1));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}