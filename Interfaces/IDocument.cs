using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public class IDocument
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
