using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;
using SpaceyWebbApp.ViewModels;

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
        [HttpPost]
        public ActionResult SubmitCheckboxes(string[] seats)
        {
            var bookingView = new BookingViewModel(seats, expeditionId);
            return View("FinalBookingstage", bookingView); //HÄR SKA VI RETURNERA EN VIEW DÄR MAN MÅSTE SKRIVA IN NAMN FÖR VARJE PLATS.
        }

    }
}