using MediatR;

namespace Leoni.Core.Application.Analysis.Commands
{
    public class CreateAnalysisCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
