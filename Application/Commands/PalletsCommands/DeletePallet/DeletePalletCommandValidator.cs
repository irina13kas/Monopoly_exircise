using FluentValidation;

namespace Application.Commands.PalletsCommands.DeletePallet
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
