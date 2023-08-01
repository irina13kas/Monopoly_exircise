using MediatR;

namespace Application.Commands.PalletsCommands.UpdatePallet
{
    public class UpdatePalletCommand : IRequest
    {
        public int Id { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
    }
}
