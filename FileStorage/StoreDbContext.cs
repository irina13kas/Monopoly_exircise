using Microsoft.EntityFrameworkCore;

namespace FileStorageContex
{
    public class StoreDbContext: DbContext
    {
        public virtual DbSet<Pallet> Pallets => Set<Pallet>();
        public virtual DbSet<Box> Boxes => Set<Box>();

/*        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            options.Sqlite("Filename=Pallets.db");
        }*/

        public StoreDbContext()
        {
            Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Environment.CurrentDirectory,"Pallets.db");
            Console.WriteLine($"Using {path} database file.");
            optionsBuilder.UseSqlite("Filename=Pallets.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<Pallet>().HasData(DataGeneration.GeneratePallets());
            modelBuilder.Entity<Pallet>().HasData(DataGeneration.GeneratePallets());
        }
    }
}
