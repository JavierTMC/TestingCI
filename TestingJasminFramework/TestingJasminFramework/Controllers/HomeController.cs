using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingJasminFramework.Controllers
{
    public class HomeController : Controller
    {
        TestingDuplicates td = new TestingDuplicates();

        public ActionResult Index()
        {
            int a = 5; a += 6;
            int b = 5; b += 6;

            return View();
        }

        public ActionResult About()
        {
            td.PrintText("Your application description page.");
            td.PrintText("javier");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    class TestingDuplicates
    {
        public string PrintText(string text)
        {
            return text;
        }
    }
}