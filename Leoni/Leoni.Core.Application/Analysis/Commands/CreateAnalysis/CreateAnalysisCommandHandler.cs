using Leoni.Infraestructure.Persistance.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leoni.Core.Application.Analysis.Commands.CreateAnalysis
{
    public class CreateAnalysisCommandHandler : IRequestHandler<CreateAnalysisCommand, Unit>
    {
        private IApplicationDbContext _dbContext { get; set; }

        public CreateAnalysisCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Unit> Handle(CreateAnalysisCommand request, CancellationToken cancellationToken)
        {
            var analysis = new Domain.Entities.Analysis
            {
                Name = request.Name,
                Description = request.Description,
            };

            throw new NotImplementedException();
        }
    }
}
