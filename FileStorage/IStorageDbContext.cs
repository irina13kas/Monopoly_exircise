using Microsoft.EntityFrameworkCore;

namespace DbStorageContext
{
    internal interface IStorageDbContext
    {
        public DbSet<Pallet> Pallets { get; set; }
        public DbSet<Box> Boxes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
