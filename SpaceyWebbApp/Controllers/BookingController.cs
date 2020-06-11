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
        [HttpPost]
        public ActionResult SubmitCheckboxes(string[] seats)
        {
            // tags is an array of the selected checkbox values for you to process

            // return them to the Index view for display
            return View("FinalBookingstage", seats); //HÄR SKA VI RETURNERA EN VIEW DÄR MAN MÅSTE SKRIVA IN NAMN FÖR VARJE PLATS.
        }

    }
}