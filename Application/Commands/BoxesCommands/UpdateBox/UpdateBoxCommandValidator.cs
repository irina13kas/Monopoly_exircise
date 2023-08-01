using FluentValidation;

namespace Application.Commands.BoxesCommands.UpdateBox
{
    public class UpdateBoxCommandValidator : AbstractValidator<UpdateBoxCommand>
    {
        private readonly DateTime TodayConst = DateTime.Today;

        public UpdateBoxCommandValidator()
        {
            RuleFor(updateBoxCommand =>
                updateBoxCommand.Height).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.Width).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.Depth).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
               updateBoxCommand.Weight).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand =>
                updateBoxCommand.ExpiryDate).NotEmpty();
            RuleFor(createBoxCommand =>
               createBoxCommand.DateOfProduction).NotNull()
                   .When(createBoxCommand => createBoxCommand.ExpiryDate == null).LessThan(DateOnly.FromDateTime(TodayConst));
            RuleFor(updateBoxCommand => updateBoxCommand.PalletId).NotEmpty().GreaterThan(0);
            RuleFor(updateBoxCommand => updateBoxCommand.Id).NotEmpty().GreaterThan(0);
        }
    }
}
