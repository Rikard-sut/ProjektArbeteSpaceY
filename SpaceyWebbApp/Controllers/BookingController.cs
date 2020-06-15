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
        private readonly SqlSpaceData _sqlService;
        public BookingController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitCheckboxes(string[] seats, string expeditionId)
        {
            var expedition = _sqlService.GetExpeditionById(Convert.ToInt32(expeditionId));
            var bookingView = new BookingViewModel(seats, expedition);
            return View("FinalBookingstage", bookingView); //HÄR SKA VI RETURNERA EN VIEW DÄR MAN MÅSTE SKRIVA IN NAMN FÖR VARJE PLATS   
        }
        [HttpPost]
        public ActionResult FinalBookingstage(BookingViewModel bookingInfo)
        {
            _sqlService.AddCustomers(bookingInfo.Customers);
            return View("BookingConfirmation", bookingInfo); //Redirecta TILL CONFIRMATION här annars fet crash.
        }

    }
}