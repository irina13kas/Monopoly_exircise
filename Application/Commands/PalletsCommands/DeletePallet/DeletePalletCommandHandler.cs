using Application.Common.Exceptions;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.PalletsCommands.DeletePallet
{
    public class DeletePalletCommandHandler : IRequestHandler<DeletePalletCommand>
    {
        private readonly StorageDbContext _dbContext;

        public DeletePalletCommandHandler(StorageDbContext dbInitializer) =>
            _dbContext = dbInitializer;

        async Task IRequestHandler<DeletePalletCommand>.Handle(DeletePalletCommand request,
            CancellationToken cancellationToken)
        {
            var pallet = await _dbContext.Pallets
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.Id);
            }
            _dbContext.Pallets.Remove(pallet);

            await _dbContext.SaveChangesAsync();
        }
    }
}
