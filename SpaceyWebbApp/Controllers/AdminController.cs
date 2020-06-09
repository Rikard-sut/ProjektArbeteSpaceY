using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;

namespace SpaceyWebbApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
    }
}