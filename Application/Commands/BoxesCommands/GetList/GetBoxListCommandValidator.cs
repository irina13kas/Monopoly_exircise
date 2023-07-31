using FluentValidation;

namespace Application.Commands.BoxesCommands.BoxValidation
{
    public class GetBoxListCommandValidator : AbstractValidator<GetBoxListCommand>
    {
        public GetBoxListCommandValidator()
        { 
            RuleFor(box =>
                box.PalletId).NotEmpty().GreaterThan(0);
        }
    }
}
