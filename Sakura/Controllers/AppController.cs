using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sakura.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            Debug.WriteLine("The Index is running");

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contacts:";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public IActionResult Development()
        {
            ViewBag.Title = "In Development";
            return View();
        }

        public IActionResult Reviews()
        {
            ViewBag.Title = "Game Reviews";
            return View();
        }
    }
}
