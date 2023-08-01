using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Exceptions;

namespace Application.Commands.PalletsCommands.UpdatePallet
{
    public class UpdatePalletCommandHandler
        : IRequestHandler<UpdatePalletCommand>
    {
        private readonly StorageDbContext _dbContext;

        public UpdatePalletCommandHandler(StorageDbContext dbContext) =>
            _dbContext = dbContext;

        async Task IRequestHandler<UpdatePalletCommand>.Handle(UpdatePalletCommand request, CancellationToken cancellationToken)
        {
            var pallet =
                await _dbContext.Pallets.FirstOrDefaultAsync(pallet =>
                    pallet.Id == request.Id, cancellationToken);
            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.Id);
            }
            pallet.Height = request.Height;
            pallet.Width = request.Width;
            pallet.Depth = request.Depth;

            await _dbContext.SaveChangesAsync();
        }

    }
}
