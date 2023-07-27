using MediatR;

namespace Application.Commands.Queries.GetPalletsList
{
    public class GetPalletDetailsQuery : IRequest<PalletVm>
    {
        public int Id { get; set; }
    }
}
