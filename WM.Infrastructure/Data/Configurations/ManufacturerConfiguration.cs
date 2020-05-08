using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using WM.Core.Entities;

namespace WM.Infrastructure.Data.Configurations
{
    internal class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable("Manufacturer");
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

        private void SeedTable(EntityTypeBuilder<Manufacturer> builder)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>
            {
                new Manufacturer
                {
                    Id = 1,
                    Name = "Proizvodjac 1",
                    City = "Apatin"
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "Proizvodjac 2",
                    City = "Beograd"
                },
                new Manufacturer
                {
                    Id = 3,
                    Name = "Proizvodjac 3",
                    City = "Beograd"
                }
            };

            builder.HasData(manufacturers);
        }
    }
}
