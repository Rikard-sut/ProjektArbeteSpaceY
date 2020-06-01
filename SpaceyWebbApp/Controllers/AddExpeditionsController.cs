using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;

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
    }
}