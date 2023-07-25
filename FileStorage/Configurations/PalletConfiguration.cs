using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FileStorageContext.Configurations
{
    public class PalletConfiguration: IEntityTypeConfiguration<Pallet>
    {
        public void Configure(EntityTypeBuilder<Pallet> builder)
        {
            builder.HasKey(x=>x.Id);

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
            builder.Ignore(x => x.ExpiryDate);
        }
    }
}
