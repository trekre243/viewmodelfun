using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet("users")]
        public ViewResult Users()
        {
            User user1 = new User()
            {
                FirstName = "Trevor",
                LastName = "Krechko"
            };

            User user2 = new User()
            {
                FirstName = "John",
                LastName = "Smith"
            };

            User user3 = new User()
            {
                FirstName = "Herbert",
                LastName = "Hoover"
            };


            List<User> users = new List<User> { user1, user2, user3 };
            return View("Users", users);
        }
    }
}