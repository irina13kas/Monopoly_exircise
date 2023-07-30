using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Queries.GetBoxesList
{
    public class GetBoxDetailsQuery : IRequest<BoxVm>
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
    }
}
