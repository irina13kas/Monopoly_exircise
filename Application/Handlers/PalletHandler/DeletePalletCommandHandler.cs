using Application.Commands.PalletsCommands;
using Application.Common.Exceptions;
using DbStorageContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.PalletHandler
{
    public class DeletePalletCommandHandler: IRequestHandler<DeletePalletCommand>
    {
        private readonly StorageDbContext _dbContext;

        public DeletePalletCommandHandler(StorageDbContext dbInitializer)=>
            _dbContext = dbInitializer;

        public async Task<Unit> Handle(DeletePalletCommand request,
            CancellationToken cancellationToken)
        {
            var pallet = await _dbContext.Pallets
                .FindAsync(new object[] { request.PalletId }, cancellationToken);
            if (pallet == null)
            {
                throw new NotFoundException(nameof(Pallet), request.PalletId);
            }
            _dbContext.Pallets.Remove(pallet);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }

        Task IRequestHandler<DeletePalletCommand>.Handle(DeletePalletCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
