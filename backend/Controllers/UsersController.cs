using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var users= new DbContexts.DbUsers();

           return await users.Users.ToListAsync<User>();
        }
    }
}
