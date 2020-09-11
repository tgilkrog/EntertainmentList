using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewLayer.Controllers
{
    public class UserController : Controller
    {
        readonly ControlLayer.UserController uCtr = new ControlLayer.UserController();
        public ActionResult UserDetails()
        {
            return View(uCtr.GetUserByID(Convert.ToInt32(Session["userID"])));
        }

        public ActionResult UserLogin()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return View("UserLogin");
        }

        [HttpPost]
        public ActionResult UserDetails(string username, string password)
        {
            var userDetail = uCtr.UserLogin(username, password);

            if (userDetail.UserName != null)
            {
                Session["userID"] = userDetail.UserID;
                Session["userName"] = userDetail.UserName;
                return View(uCtr.UserLogin(username, password));
            }

            else
            {
                return View("UserLogin");
            }
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(string username, string password, string email)
        {
            uCtr.CreateUser(username, password, email);
            return View("UserLogin");
        }
    }
}