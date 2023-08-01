using Application.Commands.Vm.PalletVm;
using MediatR;

namespace Application.Commands.PalletsCommands.GetDetails
{
    public class GetPalletDetailsCommand : IRequest<PalletVm>
    {
        public int Id { get; set; }
    }
}
