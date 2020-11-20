using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sudoku.Models;

namespace sudoku.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int Id,string userName,string userEmail,string userRole)
        {
            User user = null;
            if (userName != "") {
                user = new User()
                {
                    UserId = Id,
                    Username = userName,
                    Email = userEmail,
                    Role = userRole
                };
                //return View(user);
            }
            return View(user);
        }

        public IActionResult Manual()
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
