using MediatR;

namespace Application.Commands.BoxesCommands.CreateBox
{
    public class CreateBoxCommand : IRequest<int>
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }
        public int PalletId { get; set; }
    }
}
