using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("user")]
        public ViewResult User()
        {
            User user = new User()
            {
                FirstName = "Trevor",
                LastName = "Krechko"
            };

            return View("User", user);
        }
    }
}