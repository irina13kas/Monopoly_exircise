using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FileStorageContext.Configurations
{
    public class BoxConfiguration: IEntityTypeConfiguration<Box>
    {
        public void Configure(EntityTypeBuilder<Box> builder)
        {

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Height)
                .IsRequired();

            builder
                .Property(x => x.Width)
                .IsRequired();

            builder
                .Property(x => x.Depth)
                .IsRequired();

            builder.Ignore(x => x.Volume);

            builder
               .Property(x => x.Weight)
                .IsRequired();


            builder
                .HasOne(b => b.Pallet)
                .WithMany(p => p.Boxes)
                .HasForeignKey(b => b.PalletId) ;
        }
    }
}
