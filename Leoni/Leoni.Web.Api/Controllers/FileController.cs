using Leoni.Core.Application.Files.Commands.UploadFile;
using Leoni.Core.Application.Files.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Leoni.Web.Api.Controllers
{
    [ApiController]
    [Route("file")]
    public class FileController : CoreController
    {
        private readonly IMediator _mediator;
        public FileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Post([FromForm] FileDto file)
        {
            await _mediator.Send(new UploadFileCommand { File = file });

            return Ok();
        }
    }
}
