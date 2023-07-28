using MediatR;
using DbStorageContext;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Application.Commands.Queries.GetPallets
{
    public class GetPalletListQueryHandler
        :IRequestHandler<GetPalletListQuery, PalletListVm>
    {
        private readonly DbInitializer _dbContext;
        private readonly IMapper _mapper;

        public GetPalletListQueryHandler(DbInitializer dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<PalletListVm> Handle(GetPalletListQuery request, CancellationToken cancellationToken)
        {
            var palletQuery = await _dbContext.Pallets
                .ProjectTo<PalletLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new PalletListVm { Pallets = palletQuery };
        }
    }
}
