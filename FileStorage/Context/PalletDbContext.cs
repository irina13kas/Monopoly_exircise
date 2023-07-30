using DbStorageContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Model.Interfaces;

namespace DbStorageContext.Context
{
    public class PalletDbContext : DbContext, IPalletDbContext
    {
        public DbSet<Pallet> Pallets { get; set; }

        public PalletDbContext(DbContextOptions<PalletDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PalletConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
