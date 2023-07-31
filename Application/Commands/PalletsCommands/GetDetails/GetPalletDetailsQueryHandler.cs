using Application.Commands.Vm.PalletVm;
using Application.Common.Exceptions;
using AutoMapper;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.PalletsCommands.GetDetails
{
    public class GetPalletDetailsQueryHandler
        : IRequestHandler<GetPalletDetailsCommand, PalletVm>
    {
        private readonly StorageDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetPalletDetailsQueryHandler(StorageDbContext dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<PalletVm> Handle(GetPalletDetailsCommand request, CancellationToken cancellationToken)
        {
            var pallet = await _dbContext.Pallets
                .FirstOrDefaultAsync(pallet => pallet.Id == request.Id, cancellationToken);

            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.Id);
            }

            return _mapper.Map<PalletVm>(pallet);
        }
    }
}
