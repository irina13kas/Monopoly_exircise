using AutoMapper;
using DbStorageContext;
using MediatR;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Application.Commands.Vm.BoxVm;
using Application.Commands.BoxesCommands;

namespace Application.Handlers.BoxHandler
{
    public class GetBoxListQueryHandler
        : IRequestHandler<GetBoxListCommand, BoxListVm>
    {
        private readonly StorageDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBoxListQueryHandler(StorageDbContext dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<BoxListVm> Handle(GetBoxListCommand request, CancellationToken cancellationToken)
        {
            var boxQuery = await _dbContext.Boxes
                .Where(box => box.PalletId == request.PalletId)
                .ProjectTo<BoxLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new BoxListVm { Boxes = boxQuery };
        }
    }
}
