using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leoni.Core.Application.Files.Commands.UploadFile
{
    public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, string>
    {
        public async Task<string> Handle(UploadFileCommand command, CancellationToken cancellationToken)
        {
            if (command.File is null)
            {
                throw new Exception("Null file");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", command.File.Name);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await command.File.Content.CopyToAsync(stream);
            }

            return path;
        }
    }
}
