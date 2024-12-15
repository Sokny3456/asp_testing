using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentMark.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Personal() {
            return View();
        }
        [HttpPost]
        public ActionResult Personal(string sname, string contact, string address)
        {
            if (sname == "" || contact == "" || address == "")
            {
                ViewBag.msg = "Pleas enter all information";
                return View();
            }
            else {
                TempData["name"] = sname;
                TempData["address"] = address;
                TempData["contact"]= contact;
                return RedirectToAction("marks");
            }
            
        }
        public ViewResult Marks() { 
            return View();
        }
        [HttpPost]
        public ActionResult Marks(int theory = 0, int pracs = 0, int oral = 0) {
            if (theory < 0 || theory > 100 || pracs < 0 || pracs > 100 || oral < 0 || oral > 100)
            {
                ViewData["msg"] = "Invalid marks, please enter between 0-100";
                return View();
            }
            else {
                TempData["theory"] = theory;
                TempData["pracs"]= pracs;
                TempData["oral"]= oral;
                return RedirectToAction("DisplayResult");
            }

        }
        [Route("marksheet")]
        public ViewResult DisplayResult() {

            return View();
        }
    }
}