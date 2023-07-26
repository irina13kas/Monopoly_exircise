using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DbStorageContext
{
    public class StoreDbContext: DbContext
    {
        private string connectionString = Path.GetFullPath(Path.Combine(@"..\..\..\..\")) + @"FileStorage\Pallets.db";
        
        public virtual DbSet<Pallet> Pallets => Set<Pallet>();
        public virtual DbSet<Box> Boxes => Set<Box>();

        public StoreDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

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
