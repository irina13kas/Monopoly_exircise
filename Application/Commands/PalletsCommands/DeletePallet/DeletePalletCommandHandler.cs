using Application.Common.Exceptions;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.PalletsCommands.DeletePallet
{
    public class DeletePalletCommandHandler : IRequestHandler<DeletePalletCommand>
    {
        private readonly StorageDbContext _dbContext;

        public DeletePalletCommandHandler(StorageDbContext dbContext) =>
            _dbContext = dbContext;

        async Task IRequestHandler<DeletePalletCommand>.Handle(DeletePalletCommand request,
            CancellationToken cancellationToken)
        {
            var pallet = await _dbContext.Pallets
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            var boxesToRemove = await _dbContext.Boxes.Where(b => b.PalletId == pallet.Id).ToListAsync();
            _dbContext.Boxes.RemoveRange(boxesToRemove);
            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.Id);
            }
            _dbContext.Pallets.Remove(pallet);

            await _dbContext.SaveChangesAsync();
        }
    }
}
