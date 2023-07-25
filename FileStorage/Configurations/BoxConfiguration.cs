using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FileStorageContext.Configurations
{
    public class BoxConfiguration: IEntityTypeConfiguration<Box>
    {
        private const int integerPart = 8;
        private const int fractationPart = 3;

        public void Configure(EntityTypeBuilder<Box> builder)
        {
            var numericType = $"NUMERIC({integerPart},{fractationPart})";

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Height)
                .HasColumnType(numericType)
                .HasPrecision(integerPart, fractationPart);

            builder
                .Property(x => x.Width)
                .HasColumnType(numericType)
                .HasPrecision(integerPart, fractationPart);

            builder
                .Property(x => x.Depth)
                .HasColumnType(numericType)
                .HasPrecision(integerPart, fractationPart);

            builder.Ignore(x => x.Volume);

            builder
               .Property(x => x.Weight)
               .HasColumnType(numericType)
               .HasPrecision(integerPart, fractationPart);

            builder.Ignore(x => x.DateOfProdaction);
            builder.Ignore(x => x.ExpiryDate);

            builder
                .HasOne(b => b.Pallet)
                .WithMany(p => p.Boxes)
                .HasForeignKey(b => b.PalletId) ;
        }
    }
}
