using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCValidations.Models;

namespace MVCValidations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Student stu)
        {
            if (ModelState.IsValid)
            {
                ViewBag.stu = stu;
                return View("SubmitData");
            }
            return View("Index");
        }
    }
}