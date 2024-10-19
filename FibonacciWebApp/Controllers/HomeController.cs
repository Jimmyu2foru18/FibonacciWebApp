using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "The Fibonacci sequence is a series of numbers where each number is the sum " +
                "of the two preceding ones, typically starting with 0 and 1." +
                "\r\n\r\nThis application allows users to enter a number to specify how many " +
                "terms of the Fibonacci sequence they would like to generate.";

            return View();
        }
    }
}