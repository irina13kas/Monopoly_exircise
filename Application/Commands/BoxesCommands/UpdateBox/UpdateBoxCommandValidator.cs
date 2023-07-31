using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.BoxesCommands.UpdateBox
{
    public class UpdateBoxCommandValidator : AbstractValidator<UpdateBoxCommand>
    {
        public UpdateBoxCommandValidator()
        {
            RuleFor(updateBoxCommand =>
                updateBoxCommand.BoxHeight).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.BoxWidth).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.BoxDepth).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
               updateBoxCommand.BoxWeight).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.BoxExpiryDate).NotEmpty();
            RuleFor(updateBoxCommand =>
                updateBoxCommand.BoxDateOfProduction).NotEmpty()
                    .When(updateBoxCommand => updateBoxCommand.BoxExpiryDate == null);
            RuleFor(updateBoxCommand => updateBoxCommand.PalletId).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand => updateBoxCommand.BoxId).NotEmpty().GreaterThan(0);
        }
    }
}
