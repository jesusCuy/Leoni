using Leoni.Core.Application.Files.Models;
using MediatR;

namespace Leoni.Core.Application.Files.Commands.UploadFile
{
    public class UploadFileCommand : IRequest<string>
    {
        public FileDto File { get; set; }
    }
}
