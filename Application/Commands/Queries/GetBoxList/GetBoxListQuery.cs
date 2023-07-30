using MediatR;

namespace Application.Commands.Queries.GetBoxList
{
    public class GetBoxListQuery: IRequest<BoxListVm>
    {
        public int PalletId { get; set; }
    }
}
