using Application.Commands.BoxesCommands;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Exceptions;
namespace Application.Handlers.BoxHandler
{
    public class UpdateBoxCommandHandler : IRequestHandler<UpdateBoxCommand>
    {
        private readonly StorageDbContext _dbContext;

        public UpdateBoxCommandHandler(StorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBoxCommand request, CancellationToken cancellationToken)
        {
            var box = _dbContext.Boxes
                .FirstOrDefaultAsync(box => box.Id == request.BoxId, cancellationToken);
            if (box == null)
            {
                throw new NotFoundException(nameof(Box), request.BoxId);
            }

            return Unit.Value;
        }

        Task IRequestHandler<UpdateBoxCommand>.Handle(UpdateBoxCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
