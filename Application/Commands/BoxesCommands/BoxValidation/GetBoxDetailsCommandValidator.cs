using FluentValidation;

namespace Application.Commands.BoxesCommands.BoxValidation
{
    public class GetBoxDetailsCommandValidator : AbstractValidator<GetBoxDetailsCommand>
    {
        public GetBoxDetailsCommandValidator()
        { 
            RuleFor(box =>
                box.Id).NotEmpty().GreaterThan(0);
            RuleFor(box =>
                box.PalletId).NotEmpty().GreaterThan(0);
        }
    }
}
