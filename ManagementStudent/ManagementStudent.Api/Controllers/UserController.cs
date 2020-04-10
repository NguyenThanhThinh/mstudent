using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagementStudent.Api.Controllers
{
    [Route("api/user")]
    public class UserController : BaseController
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(Id);
        }
    }
}