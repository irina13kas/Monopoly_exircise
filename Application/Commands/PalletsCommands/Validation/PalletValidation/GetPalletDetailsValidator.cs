using FluentValidation;

namespace Application.Commands.PalletsCommands.Validation.PalletValidation
{
    public class GetPalletDetailsValidator : AbstractValidator<GetPalletDetailsCommand>
    {
        public GetPalletDetailsValidator() 
        {
            RuleFor(pallet => pallet.Id).NotEmpty().GreaterThan(0);
        }
    }
}
