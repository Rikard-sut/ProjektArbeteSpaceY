using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;
using SpaceyWebbApp.ViewModels;

namespace SpaceyWebbApp.Controllers
{
    /// <summary>
    /// Controller for adding expeditions.
    /// </summary>
    public class AddExpeditionsController : Controller
    {
        private readonly SqlSpaceData _sqlService;
        public AddExpeditionsController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Dessa två nedan Iactionresults är Create och baserade på Rocket respektive Destination. Dom behöver en respektive HTTPOST metod med.
        public IActionResult AddRocket()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRocket(Rocket rocket)
        {
            _sqlService.AddRocketToDb(rocket);
            return View();
        }
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _sqlService.AddDestinationtoDb(destination);
            return View();
        }
        public IActionResult AddExpedition()
        {
            /*var rockets = _sqlService.GetRockets();
            var destinations = _sqlService.GetDestinations();

            var expeditionViewModel = new ExpeditionViewModel(rockets, destinations);
            return View(expeditionViewModel);*/
            return View();
        }
        [HttpPost]
        public IActionResult AddExpedition(Expedition expedition)
        {
            return View();
        }
    }
}