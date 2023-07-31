using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.PalletsCommands.Validation.PalletValidation
{
    public class UpdatePalletCommandValidator : AbstractValidator<UpdatePalletCommand>
    {
        public UpdatePalletCommandValidator()
        {
            RuleFor(updatePalletCommand =>
                updatePalletCommand.PalletId).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.PalletHeight).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.PalletWidth).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.PalletDepth).NotEmpty().GreaterThan(0);
        }
    }
}
