using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("RegisterIndex");
        }

        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string email, string password)
        {
           
            ViewData["fullName"] = firstName + " " + lastName;
            ViewData["email"] = email;
            ViewData["password"] = password;
            return View();
        }
    }
}