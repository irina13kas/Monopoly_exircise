using FluentValidation;

namespace Application.Commands.BoxesCommands.GetList
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
