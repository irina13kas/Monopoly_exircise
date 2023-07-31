using Application.Commands.Vm.PalletVm;
using MediatR;

namespace Application.Commands.PalletsCommands.GetListWithPagination
{
    public class GetPalletListWithPaginationCommand : IRequest<PalletListVm>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}
