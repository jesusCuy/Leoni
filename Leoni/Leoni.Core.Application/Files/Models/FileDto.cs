using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leoni.Core.Application.Files.Models
{
    public class FileDto
    {
        public string Name { get; set; }
        public IFormFile Content { get; set; }
    }
}
