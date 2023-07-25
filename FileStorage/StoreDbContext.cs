using Microsoft.EntityFrameworkCore;

namespace FileStorageContext
{
    public class ApplicationContext: DbContext
    {
        public virtual DbSet<Pallet> Pallets => Set<Pallet>();
        public virtual DbSet<Box> Boxes => Set<Box>();

        public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions)
        : base(contextOptions)
        { }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlite("Data Source=Pallets.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.Entity<Pallet>().HasData(DataGeneration.GeneratePallets());
            modelBuilder.Entity<Box>().HasData(DataGeneration.GenerateBoxes());
        }
    }
}
