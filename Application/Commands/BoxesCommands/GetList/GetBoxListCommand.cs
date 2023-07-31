using Application.Commands.Vm.BoxVm;
using MediatR;

namespace Application.Commands.BoxesCommands.GetList
{
    public class GetBoxListCommand : IRequest<BoxListVm>
    {
        public int PalletId { get; set; }
    }
}
