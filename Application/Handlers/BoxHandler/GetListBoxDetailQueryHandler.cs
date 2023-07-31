using Application.Commands.BoxesCommands;
using Application.Commands.Vm.BoxVm;
using Application.Common.Exceptions;
using AutoMapper;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.BoxHandler
{
    public class GetListBoxDetailQueryHandler
        : IRequestHandler<GetBoxDetailsCommand, BoxVm>
    {
        private readonly StorageDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetListBoxDetailQueryHandler(StorageDbContext dbContext, IMapper mapper)
        {
            (_dbContext, _mapper) = (dbContext, mapper);
        }

        public async Task<BoxVm> Handle(GetBoxDetailsCommand request, CancellationToken cancellationToken)
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
