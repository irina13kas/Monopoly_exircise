using MediatR;

namespace Application.Commands.PalletsCommands
{
    public class DeletePalletCommand : IRequest
    {
        public int PalletId { get; set; }
    }
}
