using Microsoft.EntityFrameworkCore;

namespace DbStorageContext
{
    public class StorageDbContext: DbContext, IStorageDbContext
    {
        private string connectionString = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\")) + @"FileStorage\Pallets.db";
        
        public virtual DbSet<Pallet> Pallets { get; set; }
        public virtual DbSet<Box> Boxes { get; set; }

        public StorageDbContext()
        {
            Database.EnsureCreated();
        }

        public StorageDbContext(DbContextOptions<StorageDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string filePath = connectionString;
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists || fileInfo.Length==0)
            {
                File.Create(filePath).Close();
            }            
            optionsBuilder.UseSqlite($"Filename = {connectionString}");
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
