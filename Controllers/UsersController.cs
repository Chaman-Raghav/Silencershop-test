﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess;
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

        [HttpPost]
        [Route("AddUser")]
        public OkResult PostUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine("There is some error in Adding the user:", ex);
                throw;
            }
            return Ok();
        }

        [HttpDelete]
        [Route("deleteUser/{userId:int}")]
        public OkResult DeleteUser(int userId)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(user => (user.Id == userId));
                if(user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine("Error while deleting the user:", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }
        [HttpPut]
        [Route("EditUser")]
        public IActionResult EditUserDetails(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine("Error while Updating the user:", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }

    }
}