using MediatR;
using DbStorageContext;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Application.Commands.Vm.PalletVm;
using Application.Commands.PalletsCommands;

namespace Application.Handlers.PalletHandler
{
    public class GetPalletListQueryHandler
        : IRequestHandler<GetPalletListCommand, PalletListVm>
    {
        private readonly StorageDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetPalletListQueryHandler(StorageDbContext dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<PalletListVm> Handle(GetPalletListCommand request, CancellationToken cancellationToken)
        {
            var palletQuery = await _dbContext.Pallets
                .ProjectTo<PalletLookupDto>(_mapper.ConfigurationProvider)
                .OrderBy(x => x.Id)
                .ToListAsync(cancellationToken);
            return new PalletListVm { Pallets = palletQuery };
        }
    }
}
