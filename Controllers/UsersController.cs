using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess;
using Microsoft.AspNetCore.Authorization;
using WebApplication1.Modals;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;
        public UsersController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<object> GetUser()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}