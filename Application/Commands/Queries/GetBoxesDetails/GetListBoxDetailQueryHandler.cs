using Application.Common.Exceptions;
using AutoMapper;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Queries.GetBoxesList
{
    public class GetListBoxDetailQueryHandler
        : IRequestHandler<GetBoxDetailsQuery, BoxVm>
    {
        private readonly DbInitializer _dbContext;
        private readonly IMapper _mapper;

        public GetListBoxDetailQueryHandler(DbInitializer dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<BoxVm> Handle(GetBoxDetailsQuery request, CancellationToken cancellationToken)
        {
            var box = await _dbContext.Boxes
                .FirstOrDefaultAsync(box => box.Id == request.Id, cancellationToken);

            if (box == null)
            {
                throw new NotFoundException(nameof(Box), request.Id);
            }

            return _mapper.Map<BoxVm>(box);
        }
    }
}
