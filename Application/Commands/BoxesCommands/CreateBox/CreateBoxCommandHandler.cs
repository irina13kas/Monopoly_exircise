using DbStorageContext;
using MediatR;

namespace Application.Commands.BoxesCommands.CreateBox
{
    public class CreateBoxCommandHandler
        : IRequestHandler<CreateBoxCommand, int>
    {
        private readonly StorageDbContext _dbContext;

        public CreateBoxCommandHandler(StorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateBoxCommand request, CancellationToken cancellationToken)
        {
            var box = new Box
            {
                Height = request.Height,
                Width = request.Width,
                Depth = request.Depth,
                Weight = request.Weight,
                ExpiryDate = request.ExpiryDate,
                DateOfProduction = request.ExpiryDate,
                PalletId = request.PalletId,
            };
            if (!CheckParametrs(box.Height, box.Width, box.PalletId))
            {
                throw new ArgumentException("Box's parametrs bigger than pallet");
            }
            await _dbContext.AddAsync(box, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return box.Id;
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
