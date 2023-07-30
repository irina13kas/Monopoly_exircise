using Application.Common.Exceptions;
using AutoMapper;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Queries.GetPalletsList
{
    public class GetPalletDetailsQueryHandler
        : IRequestHandler<GetPalletDetailsQuery, PalletVm>
    {
        private readonly DbInitializer _dbContext;
        private readonly IMapper _mapper;

        public GetPalletDetailsQueryHandler(DbInitializer dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<PalletVm> Handle (GetPalletDetailsQuery request, CancellationToken cancellationToken)
        {
            var pallet = await _dbContext.Pallets
                .FirstOrDefaultAsync(pallet => pallet.Id == request.Id, cancellationToken);

            if (pallet==null)
            {
                throw new NotFoundException(nameof(Pallet), request.Id);
            }

            return _mapper.Map<PalletVm>(pallet);
        }
    }
}
