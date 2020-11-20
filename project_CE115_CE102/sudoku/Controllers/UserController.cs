using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sudoku.Models;

namespace sudoku.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            _userRepository.AddUser(user);
            return Redirect("/Home/Index/");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            List<User> users = _userRepository.GetAllUsers();
            User match=user;
            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == user.Username && users[i].Password==user.Password)
                {
                    match = users[i];
                }
            }
            return Redirect("/Home/Index/" + match.UserId+"?userName="+match.Username+"&userEmail="+match.Email+"&userRole="+match.Role);
        }

        public IActionResult Profile(int id)
        {
            User user=_userRepository.GetUser(id);
            return View(user);
        }
    }
}