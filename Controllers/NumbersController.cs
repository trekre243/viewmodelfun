using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class NumbersController : Controller
    {
        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] nums = new int[] {4,2,6,2,4,7};
            return View("Numbers", nums);
        }
    }
}