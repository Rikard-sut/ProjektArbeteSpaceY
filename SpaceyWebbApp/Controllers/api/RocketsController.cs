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
    [Route("api/[controller]")]
    public class RocketsController : Controller
    {
        private readonly SqlSpaceData _sqlService;
        public RocketsController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Rocket> Get()
        {
            return _sqlService.GetRockets();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Rocket Get(int id)
        {
            return _sqlService.GetRocketById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Rocket Post(Rocket rocket)
        {
            if(_sqlService.AddRocket(rocket) > 0)
            {
                return rocket;
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
        public Rocket Delete(int id)
        {
            return _sqlService.DeleteRocket(id);
        }
    }
}
