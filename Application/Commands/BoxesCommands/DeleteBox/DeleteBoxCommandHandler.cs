using Application.Commands.BoxesCommands.DeleteBox;
using Application.Common.Exceptions;
using DbStorageContext;
using MediatR;

namespace Application.Handlers.BoxHandler
{
    public class DeleteBoxCommandHandler: IRequestHandler<DeleteBoxCommand>
    {
        private readonly StorageDbContext _dbContext;

        public DeleteBoxCommandHandler(StorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBoxCommand request, CancellationToken cancellationToken)
        {
            var box = await _dbContext.Boxes
                .FindAsync(new object[] { request.BoxId},cancellationToken);
            if (box == null)
            {
                throw new NotFoundException(nameof(Box),request.BoxId);
            }

            _dbContext.Boxes.Remove(box);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }

        Task IRequestHandler<DeleteBoxCommand>.Handle(DeleteBoxCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
