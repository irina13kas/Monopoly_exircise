using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Queries.GetPallets
{
    public class PalletListVm
    {
        public IList<PalletLookupDto> Pallets { get; set; }
    }
}
