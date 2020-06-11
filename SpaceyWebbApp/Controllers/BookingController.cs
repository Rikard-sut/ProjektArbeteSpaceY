using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;

namespace SpaceyWebbApp.Controllers
{
    public class BookingController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookPage()
        {
            return View();
        }
       
    }
}