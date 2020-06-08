using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceyWebbApp.Models;

namespace SpaceyWebbApp.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SqlSpaceData _sqlService;
        public UsersController(SqlSpaceData sqlSpaceData)
        {
            this._sqlService = sqlSpaceData;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _sqlService.GetUsers();
        }

        [HttpPost]
        public bool Login(User user)
        {
            return user.LoggedIn = _sqlService.LoginUser(user);
        }
    }
}