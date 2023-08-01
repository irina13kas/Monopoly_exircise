using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.PalletsCommands.UpdatePallet
{
    public class UpdatePalletCommandValidator : AbstractValidator<UpdatePalletCommand>
    {
        public UpdatePalletCommandValidator()
        {
            RuleFor(updatePalletCommand =>
                updatePalletCommand.Id).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.Height).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.Width).NotEmpty().GreaterThan(0);
            RuleFor(updatePalletCommand =>
                updatePalletCommand.Depth).NotEmpty().GreaterThan(0);
        }
    }
}
