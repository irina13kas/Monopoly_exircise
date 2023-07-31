using Application.Commands.BoxesCommands;
using FluentValidation;

namespace Application.Commands.BoxesCommands.BoxValidation
{
    public class CreateBoxCommandValidator : AbstractValidator<CreateBoxCommand>
    {
        //добавить проверку на соответствие параметров коробки в паллету
        public CreateBoxCommandValidator()
        {
            RuleFor(createBoxCommand =>
                createBoxCommand.BoxHeight).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.BoxWidth).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.BoxDepth).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
               createBoxCommand.BoxWeight).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.BoxExpiryDate).NotEmpty();
            RuleFor(createBoxCommand =>
                createBoxCommand.BoxDateOfProduction).NotNull()
                    .When(createBoxCommand => createBoxCommand.BoxExpiryDate == null);
            RuleFor(createBoxCommand => createBoxCommand.PalletId).NotNull().GreaterThan(0);
        }
    }
}
