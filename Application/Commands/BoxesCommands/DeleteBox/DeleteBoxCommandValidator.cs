using FluentValidation;

namespace Application.Commands.BoxesCommands.DeleteBox
{
    public class DeleteBoxCommandValidator : AbstractValidator<DeleteBoxCommand>
    {
        public DeleteBoxCommandValidator()
        {
            RuleFor(deleteBoxCommand =>
                deleteBoxCommand.Id).NotEmpty().GreaterThan(0);
        }
    }
}
