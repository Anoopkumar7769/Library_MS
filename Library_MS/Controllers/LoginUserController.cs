using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_MS.Models;

namespace Library_MS.Controllers
{
    public class LoginUserController : Controller
    {
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(loginuser user)
        {
            using (testEntities db = new testEntities())
            {
                var userDetail = db.loginusers.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    user.LoginErrorMessage = "Wrong UserName or Password";
                    return View("Index", user);
                }
                else
                {
                    Session["UserID"] = user.UserID;
                    Session["UserName"] = user.UserName;
                    return RedirectToAction("Index","Home");
                }
            }
           
        }
        public ActionResult Signup()
        {
            return View();
        }


        public ActionResult LogOut()
        {
            int UserID = (int) Session["UserID"];
            Session.Abandon();
            return RedirectToAction("Index","LoginUser");
        }
        
    }
}