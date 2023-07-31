using Application.Commands.PalletsCommands.GetListWithPagination;
using Application.Commands.Vm.PalletVm;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.PalletHandler
{
    public class GetPalletListWithPaginationHandler : IRequestHandler<GetPalletListWithPaginationCommand, PalletListVm>
    {
        private readonly StorageDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetPalletListWithPaginationHandler(StorageDbContext dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<PalletListVm> Handle(GetPalletListWithPaginationCommand request, CancellationToken cancellationToken)
        {
            var palletQuery = await _dbContext.Pallets
                .ProjectTo<PalletLookupDto>(_mapper.ConfigurationProvider)
                .OrderBy(x => x.Id)
                .Skip(request.Offset)
                .Take(request.Limit)
                .ToListAsync();
            return new PalletListVm { Pallets = palletQuery };
        }

    }
}
