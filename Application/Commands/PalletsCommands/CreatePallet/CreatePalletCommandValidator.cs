using FluentValidation;

namespace Application.Commands.PalletsCommands.CreatePallet
{
    public class CreatePalletCommandValidator : AbstractValidator<CreatePalletCommand>
    {
        public CreatePalletCommandValidator()
        {
            RuleFor(createPalletCommand =>
                createPalletCommand.PalletHeight).NotEmpty().GreaterThan(0);
            RuleFor(createPalletCommand =>
                createPalletCommand.PalletWidth).NotEmpty().GreaterThan(0);
            RuleFor(createPalletCommand =>
                createPalletCommand.PalletDepth).NotEmpty().GreaterThan(0);
        }
    }
}
