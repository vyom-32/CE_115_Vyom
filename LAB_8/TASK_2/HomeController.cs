using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using task2.Models;

namespace task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test1()
        {
            int n1 = 9, n2 = 3, sum = 0;
            sum = n1 + n2;
            ViewBag.n1 = n1.ToString();
            ViewBag.n2 = n2.ToString();
            ViewBag.sum = sum.ToString();

            return View();
        }
        [HttpGet]
        public IActionResult Test2()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Test2")]
        public IActionResult Test3()
        {
            int n1 = Int32.Parse(HttpContext.Request.Form["n1"].ToString());
            int n2 = Int32.Parse(HttpContext.Request.Form["n2"].ToString());
            int sum = n1 + n2;

            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.sum = sum;
            return View("Test2");
        }


        public IActionResult user_registration()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
