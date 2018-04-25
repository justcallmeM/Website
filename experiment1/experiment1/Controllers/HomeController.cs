using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using experiment1.Models;

namespace experiment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AboutMindaugas()
        {
            ViewData ["Message"] = "About Mindaugas.";

            return View();
            
        }

        public IActionResult GalleryMindaugas()
        {
            ViewData["Message"] = "Gallery Mindaugas.";

            return View();
        }

        public IActionResult NewsletterMindaugas()
        {
            ViewData["Message"] = "Newsletter.";

            return View();
        }

        public IActionResult AdminMindaugas()
        {
            ViewData["Message"] = "Admin.";

            return View();
        }

        public IActionResult AboutCristian()
        {
            ViewData["Message"] = "About Cristian";
            return View();
        }

        public IActionResult AdminCristian()
        {
            ViewData["Message"] = "Admin Cristian.";

            return View();
        }

        public IActionResult AboutJohanna()
        {
            ViewData["Message"] = "About Johanna";
            return View();
        }

        public IActionResult AdminJohanna()
        {
            ViewData["Message"] = "Admin Johanna.";

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
