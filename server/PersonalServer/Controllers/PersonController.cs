using Microsoft.AspNetCore.Mvc;
using PersonalServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public Person Get()
        {
            return new Person()
            {
                Name = new Name() { First = "Hunter", Middle = "Craig", Last = "Brock" },
                CellPhoneNumber = "8506123487",
                EmailAddress = "hbrockster13@gmail.com",
                Id = new Guid()
            };
        }
        [HttpGet("name")]
        public JsonResult GetName()
        {
            return new JsonResult( new Name() { First = "Hunter", Middle = "Craig", Last = "Brock" });
        }
    }
}
