using Application.Commands.Vm.PalletVm;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.PalletsCommands.GetList
{
    public class GetPalletListCommand : IRequest<PalletListVm>
    {
    }
}
