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
    public class ExpeditionsController : Controller
    {
        private readonly SqlSpaceData _sqlService;
        public ExpeditionsController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Expedition> Get()
        {
            return _sqlService.GetExpeditions();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Expedition Get(int id)
        {
            return _sqlService.GetExpeditionById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Expedition Post(Expedition expedition)
        {
            if (_sqlService.AddExpedition(expedition) > 0)
            {
                return expedition;
            }
            return null;
        }

        // PUT api/<controller>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }*/

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public Expedition Delete(int id)
        {
            return _sqlService.DeleteExpedition(id);
        }
    }
}
