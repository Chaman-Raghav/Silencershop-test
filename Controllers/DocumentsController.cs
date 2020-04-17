using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess;
using WebApplication1.Interfaces;
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

        [HttpGet]
        [Route("GetDocument/{documentId:int}")]
        public IDocument GetDocuments(int documentId)
        {
            var document = _context.Documents.FirstOrDefault(document => document.Id == documentId);
            var stream = new MemoryStream(document.Image);
            IFormFile file = new FormFile(stream, 0, document.Image.Length, "name", "fileName");
            IDocument returnDocument =  new IDocument
            {
                Name = document.Name,
                Image = file
            };
            return returnDocument;
        }

        [HttpPost]
        public async Task<OkResult> PostDocument([FromForm]IDocument document)
        {
            var ImageInBytes = new byte[document.Image.Length];
            if (document.Image.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await document.Image.CopyToAsync(stream);
                    ImageInBytes = stream.ToArray();
                }
            }
            try
            {
                _context.Documents.Add(new Document { 
                    Name= document.Name,
                    Image = ImageInBytes
                });
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("There is some error in fetching the Document:", ex.InnerException.Message);
                throw;
            }
            return Ok();
        }
    }
}