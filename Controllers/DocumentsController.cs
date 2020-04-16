using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly UserContext _context;
        public DocumentsController(UserContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("SaveDocument")]
        public IActionResult SaveDocument(Document document)
        {
            try
            {
                _context.Add(document);
                _context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine("Error Occured while saving the document", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }
    }
}