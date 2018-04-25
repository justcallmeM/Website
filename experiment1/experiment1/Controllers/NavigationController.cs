using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace experiment1.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult Navigation()
        {
            return View();
        }
    }
}