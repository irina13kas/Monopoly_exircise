using FluentValidation;

namespace Application.Commands.BoxesCommands.BoxValidation
{
    public class DeleteBoxCommandValidator : AbstractValidator<DeleteBoxCommand>
    {
        public DeleteBoxCommandValidator() 
        { 
            RuleFor(deleteBoxCommand =>
                deleteBoxCommand.BoxId).NotEmpty().GreaterThan(0);
        }
    }
}
