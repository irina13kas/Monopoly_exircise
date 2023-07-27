using MediatR;

namespace Application.Commands.BoxesCommands
{
    public class DeleteBoxCommand : IRequest
    {
        public int BoxId { get; set; }
    }
}
