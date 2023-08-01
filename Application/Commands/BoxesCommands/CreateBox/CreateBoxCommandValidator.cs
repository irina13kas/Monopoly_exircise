using FluentValidation;

namespace Application.Commands.BoxesCommands.CreateBox
{
    public class CreateBoxCommandValidator : AbstractValidator<CreateBoxCommand>
    {
        private readonly DateTime TodayConst=DateTime.Today;
        public CreateBoxCommandValidator()
        {
            RuleFor(createBoxCommand =>
                createBoxCommand.Height).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.Width).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.Depth).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
               createBoxCommand.Weight).NotEmpty().GreaterThan(0);
            RuleFor(createBoxCommand =>
                createBoxCommand.ExpiryDate).NotEmpty();
            RuleFor(createBoxCommand =>
                createBoxCommand.DateOfProduction).NotNull()
                    .When(createBoxCommand => createBoxCommand.ExpiryDate == null).LessThan(DateOnly.FromDateTime(TodayConst));
            RuleFor(createBoxCommand => createBoxCommand.PalletId).NotNull().GreaterThan(0);
        }
    }
}
