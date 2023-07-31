using MediatR;

namespace Application.Commands.BoxesCommands.CreateBox
{
    public class CreateBoxCommand : IRequest<int>
    {
        public decimal BoxHeight { get; set; }
        public decimal BoxWidth { get; set; }
        public decimal BoxDepth { get; set; }
        public decimal BoxWeight { get; set; }
        public DateOnly? BoxExpiryDate { get; set; }
        public DateOnly? BoxDateOfProduction { get; set; }
        public int PalletId { get; set; }
    }
}
