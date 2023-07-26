using DbStorageContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Model.Interfaces;

namespace DbStorageContext.Context
{
    public class BoxDbContext : DbContext, IBoxDbContext
    {
        public DbSet<Box> Boxes { get; set; }
        public BoxDbContext(DbContextOptions<BoxDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BoxConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
