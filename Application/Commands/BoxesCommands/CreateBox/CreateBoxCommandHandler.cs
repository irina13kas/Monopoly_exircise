﻿using DbStorageContext;
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
                Height = request.BoxHeight,
                Width = request.BoxWidth,
                Depth = request.BoxDepth,
                Weight = request.BoxWeight,
                ExpiryDate = request.BoxExpiryDate,
                DateOfProduction = request.BoxExpiryDate,
                PalletId = request.PalletId,
            };
            await _dbContext.AddAsync(box, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return box.Id;
        }
    }
}
