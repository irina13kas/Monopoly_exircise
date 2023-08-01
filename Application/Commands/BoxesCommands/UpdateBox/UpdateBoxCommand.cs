using MediatR;

namespace Application.Commands.BoxesCommands.UpdateBox
{
    public class UpdateBoxCommand : IRequest
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }
    }
}
