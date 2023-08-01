using Application.Common.Exceptions;
using DbStorageContext;
using MediatR;

namespace Application.Commands.BoxesCommands.DeleteBox
{
    public class DeleteBoxCommandHandler : IRequestHandler<DeleteBoxCommand>
    {
        private readonly StorageDbContext _dbContext;

        public DeleteBoxCommandHandler(StorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task IRequestHandler<DeleteBoxCommand>.Handle(DeleteBoxCommand request, CancellationToken cancellationToken)
        {
            var box = await _dbContext.Boxes
                .FindAsync(new object[] { request.Id }, cancellationToken);
            if (box == null)
            {
                throw new NotFoundException(nameof(Box), request.Id);
            }

            _dbContext.Boxes.Remove(box);
            await _dbContext.SaveChangesAsync();
        }
    }
}
