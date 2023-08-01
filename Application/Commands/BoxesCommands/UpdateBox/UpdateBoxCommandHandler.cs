using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Exceptions;

namespace Application.Commands.BoxesCommands.UpdateBox
{
    public class UpdateBoxCommandHandler : IRequestHandler<UpdateBoxCommand>
    {
        private readonly StorageDbContext _dbContext;

        public UpdateBoxCommandHandler(StorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task IRequestHandler<UpdateBoxCommand>.Handle(UpdateBoxCommand request, CancellationToken cancellationToken)
        {
            var box = await _dbContext.Boxes
                .FirstOrDefaultAsync(box => box.Id == request.Id, cancellationToken);
            if (box == null)
            {
                throw new NotFoundException(nameof(Box), request.Id);
            }
            if (!CheckParametrs(box.Height, box.Width, box.PalletId))
            {
                throw new ArgumentException("Box's parametrs bigger than pallet");
            }
            await _dbContext.SaveChangesAsync();
        }

        private bool CheckParametrs(decimal height, decimal width, int palletId)
        {
            var pallet = _dbContext.Pallets.FirstOrDefault(p => p.Id == palletId);
            if (pallet == null)
            {
                throw new NullReferenceException("No such pallet");
            }
            if (pallet.Height >= height && pallet.Width <= width || pallet.Width <= height && pallet.Height <= width)
            {
                return true;
            }
            return false;
        }
    }
}
