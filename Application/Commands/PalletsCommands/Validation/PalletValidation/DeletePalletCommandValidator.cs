using FluentValidation;

namespace Application.Commands.PalletsCommands.Validation.PalletValidation
{
    public class DeletePalletCommandValidator : AbstractValidator<DeletePalletCommand>
    {
        public DeletePalletCommandValidator()
        {
            RuleFor(deletePalletCommand =>
                deletePalletCommand.PalletId).NotEqual(0).GreaterThan(0);
        }
    }
}
