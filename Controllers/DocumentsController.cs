using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Modals;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
        [HttpGet]
        public ActionResult<object> GetDocument()
        {
            var documents = _context.Documents.ToList();
            return documents;
        }

        [HttpDelete]
        [Route("deleteDocument/{documentId:int}")]
        public OkResult DeleteDocument(int documentId)
        {
            try
            {
                Document doc = _context.Documents.FirstOrDefault(doc => (doc.id == documentId));
                if (doc != null)
                {
                    _context.Documents.Remove(doc);
                    _context.SaveChanges();
                    Console.WriteLine("Successfully Deleted", documentId.ToString());
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Error while deleting the user:", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }

        [HttpPost]
        [Route("AddDocument")]
        public OkResult PostDocument(Document document)
        {
            try
            {
                _context.Documents.Add(new Document()
                {
                    id = document.id,
                    Customer_Name= document.Customer_Name,
                    isFlagged= document.isFlagged
                });
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("There is some error in Adding the user:", ex);
                throw;
            }
            return Ok();
        }

        [HttpPut]
        [Route("EditDocument")]
        public IActionResult EditDocumentDetails([FromForm]Document document)
        {
            try
            {
                _context.Documents.Update(document);
               _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Error while Updating the user:", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }
    }
}
