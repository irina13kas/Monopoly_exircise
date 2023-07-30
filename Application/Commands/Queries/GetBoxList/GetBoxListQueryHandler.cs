using AutoMapper;
using DbStorageContext;
using MediatR;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Queries.GetBoxList
{
    public class GetBoxListQueryHandler
        :IRequestHandler<GetBoxListQuery, BoxListVm>
    {
        private readonly DbInitializer _dbContext;
        private readonly IMapper _mapper;

        public GetBoxListQueryHandler(DbInitializer dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<BoxListVm> Handle(GetBoxListQuery request, CancellationToken cancellationToken)
        {
            var boxQuery = await _dbContext.Boxes
                .Where(box => box.PalletId == request.PalletId)
                .ProjectTo<BoxLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new BoxListVm { Boxes = boxQuery };
        }
    }
}
