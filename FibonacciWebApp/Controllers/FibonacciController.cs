using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FibonacciWebApp.Controllers
{
    public class FibonacciController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int number)
        {
            List<int> fibonacciSequence = GenerateFibonacci(number);
            ViewBag.FibonacciSequence = fibonacciSequence;
            return View();
        }

        private List<int> GenerateFibonacci(int n)
        {
            List<int> sequence = new List<int>();
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                sequence.Add(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            return sequence;
        }
    }
}
