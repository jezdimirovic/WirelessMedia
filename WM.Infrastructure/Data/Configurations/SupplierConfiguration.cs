using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using WM.Core.Entities;

namespace WM.Infrastructure.Data.Configurations
{
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(t => t.Id);
            builder
                .Property(t => t.Name)
                .HasMaxLength(50);

            builder
                .Property(t => t.AddressLine)
                .HasMaxLength(100);
            builder
                .Property(t => t.County)
                .HasMaxLength(50);
            builder
                .Property(t => t.City)
                .HasMaxLength(50);
            builder
                .Property(t => t.Description)
                .HasMaxLength(255);

            SeedTable(builder);
        }

        private void SeedTable(EntityTypeBuilder<Supplier> builder)
        {
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier
                {
                    Id = 1,
                    Name = "Supplier 1"
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Supplier 2"
                }
            };

            builder.HasData(suppliers);
        }
    }
}