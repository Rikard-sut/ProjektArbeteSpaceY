using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceyWebbApp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class DestinationsController : Controller
    {
        private readonly SqlSpaceData _sqlService;
        public DestinationsController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Destination> Get()
        {
            return _sqlService.GetDestinations();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Destination Get(int id)
        {
            return _sqlService.GetDestinationById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Destination Post(Destination destination)
        {
            if (_sqlService.AddDestination(destination) > 0)
            {
                return destination;
            }
            return null;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public Destination Delete(int id)
        {
            return _sqlService.DeleteDestination(id);
        }
    }
}
