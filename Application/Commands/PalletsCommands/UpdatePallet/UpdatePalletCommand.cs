using MediatR;

namespace Application.Commands.PalletsCommands
{
    public class UpdatePalletCommand: IRequest
    {
        public int PalletId { get; set; }
        public decimal PalletHeight { get; set; }
        public decimal PalletWidth { get; set; }
        public decimal PalletDepth { get; set; }
    }
}
