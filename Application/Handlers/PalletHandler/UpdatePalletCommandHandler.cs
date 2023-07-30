using Application.Commands.PalletsCommands;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Exceptions;

namespace Application.Handlers.PalletHandler
{
    public class UpdatePalletCommandHandler
        : IRequestHandler<UpdatePalletCommand>
    {
        private readonly DbInitializer _dbContext;

        public UpdatePalletCommandHandler(DbInitializer dbContext) =>
            _dbContext = dbContext;

        public async Task<Unit> Handle(UpdatePalletCommand request, CancellationToken cancellationToken)
        {
            //проверить, что, если палета уже создана, то добавлять ее второй раз не надо
            var pallet =
                await _dbContext.Pallets.FirstOrDefaultAsync(pallet =>
                    pallet.Id == request.PalletId, cancellationToken);
            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.PalletId);
            }
            pallet.Height = request.PalletHeight;
            pallet.Width = request.PalletWidth;
            pallet.Depth = request.PalletDepth;

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }

        Task IRequestHandler<UpdatePalletCommand>.Handle(UpdatePalletCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
