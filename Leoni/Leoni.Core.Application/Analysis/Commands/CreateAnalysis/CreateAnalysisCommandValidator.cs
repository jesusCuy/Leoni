using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leoni.Core.Application.Analysis.Commands.CreateAnalysis
{
    public class CreateAnalysisCommandValidator : AbstractValidator<CreateAnalysisCommand>
    {
        public CreateAnalysisCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(128);

            RuleFor(x => x.Description)
                .MaximumLength(450);
        }
    }
}
