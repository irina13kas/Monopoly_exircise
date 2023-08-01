using MediatR;

namespace Application.Commands.BoxesCommands.DeleteBox
{
    public class DeleteBoxCommand : IRequest
    {
        public int Id { get; set; }
    }
}
