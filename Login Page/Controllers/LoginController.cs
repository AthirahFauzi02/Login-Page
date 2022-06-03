using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login_Page.Models;

namespace Login_Page.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public List<User> PutValue()
        {
            var users = new List<User>
            
            {
                new User{username = "kiki",password = "abc123"}
            };
            return users;

        }

        public IActionResult Verify(User usr)
        {
            var a = PutValue();
            var b = a.Where(u => u.username.Equals(usr.username));
            var c = b.Where(p => p.password.Equals(usr.password));

            if (c.Count()== 1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed!";
                return View("Login");
            }
        }
    }
}
