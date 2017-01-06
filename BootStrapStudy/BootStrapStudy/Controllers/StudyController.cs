using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrapStudy.Controllers
{
    public class StudyController : Controller
    {
         public ActionResult Index()
        {
            int a = 1;

            ViewBag.a = a;
            return View();
        }

        public ActionResult example()
        {
            return View();

        }
        public ActionResult example2()
        {
            return View();

        }
        public ActionResult example3()
        {
            return View();

        }

    }
}