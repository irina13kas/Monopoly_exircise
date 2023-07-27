using MediatR;

namespace Application.Commands.PalletsCommands
{
    public class CreatePalletCommand : IRequest<int>
    {
        public decimal PalletHeight { get; set; }
        public decimal PalletWidth { get; set;}
        public decimal PalletDepth { get; set; }
    }
}
