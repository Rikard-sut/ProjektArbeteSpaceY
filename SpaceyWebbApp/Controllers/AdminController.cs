using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaceyWebbApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if(IsLoggedIn())
            {
                return View();
            }
            return Redirect("/login");
        }

        public IActionResult Rockets()
        {
            return View();
        }

        public IActionResult Expedition()
        {
            return View();
        }

        public IActionResult AddRocket()
        {
            return View();
        }

        public IActionResult AddDestination()
        {
            return View();
        }

        public IActionResult AddExpedition()
        {
            return View();
        }

        public bool IsLoggedIn()
        {
            return true;
        }
    }
}