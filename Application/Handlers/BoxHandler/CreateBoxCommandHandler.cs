using Application.Commands.BoxesCommands;
using Application.Commands.PalletsCommands;
using DbStorageContext;
using MediatR;

namespace Application.Handlers.BoxHandler
{
    public class CreateBoxCommandHandler
        : IRequestHandler<CreateBoxCommand, int>
    {
        private readonly DbInitializer _dbContext;

        public CreateBoxCommandHandler(DbInitializer dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateBoxCommand request, CancellationToken cancellationToken)
        {
            var box = new Box
            {
                Height = request.BoxHeight,
                Width = request.BoxWidth,
                Depth = request.BoxDepth,
                Weight = request.BoxWeight,
                // тут должно заполняться хотя бы одно поле
                ExpiryDate = request.BoxExpiryDate,
                DateOfProduction = request.BoxExpiryDate,
            };
            await _dbContext.AddAsync(box);
            await _dbContext.SaveChangesAsync();
            return box.Id;
        }
    }
}
