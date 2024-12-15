using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentMark.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string uname, string pword)
        {
           
            if (uname == "admin" && pword == "123")
            {
                Session["uname"] = "admin";
                return RedirectToAction("Personal", "Student");
            }

            // Display error message on failure
            ViewBag.ErrorMessage = "Invalid login attempt.";
            return View();
        }


        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        public ActionResult Register(string uname, string pword)
        {
           
            return RedirectToAction("Login");
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            
            return RedirectToAction("Login");
        }
    


        
    }
}