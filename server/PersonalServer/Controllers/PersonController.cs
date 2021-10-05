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
                Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec congue urna vitae nibh rhoncus, non ornare orci fringilla. Duis vel pharetra felis. Sed feugiat sed neque eu efficitur. Vestibulum mattis lorem a nisi fringilla, a sagittis sem gravida. Mauris aliquam pulvinar malesuada. Integer facilisis velit non luctus ornare. Sed et aliquet massa. Etiam ante tellus, euismod quis laoreet non, scelerisque sit amet leo. Integer nibh odio, aliquet eu nisi a, facilisis rhoncus massa. Nam vitae rhoncus lectus, eget lacinia sem. Fusce ut iaculis tortor. Nunc fringilla consectetur sollicitudin.",
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
