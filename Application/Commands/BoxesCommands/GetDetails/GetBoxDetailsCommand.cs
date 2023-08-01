using Application.Commands.Vm.BoxVm;
using MediatR;

namespace Application.Commands.BoxesCommands.GetDetails
{
    public class GetBoxDetailsCommand : IRequest<BoxVm>
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
    }
}
