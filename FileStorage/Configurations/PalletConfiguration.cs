using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageContex.Configurations
{
    public class PalletConfiguration: IEntityTypeConfiguration<Pallet>
    {
        private const int integerPart = 8;
        private const int fractationPart = 3;

        public void Configure(EntityTypeBuilder<Pallet> builder)
        {
            var numericType = $"NUMERIC({integerPart},{fractationPart})";

            builder.HasKey(x=>x.Id);

            builder
                .Property(x => x.Height)
                .HasColumnType(numericType)
                .HasPrecision(integerPart,fractationPart);

            builder
               .Property(x => x.Width)
               .HasColumnType(numericType)
               .HasPrecision(integerPart, fractationPart);

            builder
               .Property(x => x.Depth)
               .HasColumnType(numericType)
               .HasPrecision(integerPart, fractationPart);

            builder
               .Property(x => x.Volume)
               .HasColumnType(numericType)
               .HasPrecision(integerPart, fractationPart);
        }
    }
}
