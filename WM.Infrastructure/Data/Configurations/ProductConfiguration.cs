using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using WM.Core.Entities;

namespace WM.Infrastructure.Data
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(t => t.Id);
            builder
                .Property(t => t.Name)
                .HasMaxLength(50);
            builder
                .Property(t => t.Price)
                .HasColumnType("decimal(8,2)");

            SeedTable(builder);
        }

        private void SeedTable(EntityTypeBuilder<Product> builder)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Nik toceno 0.5",
                    Price = 130,
                    CategoryId = 4,
                    ManufacturerId = 1,
                    SupplierId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Jelen toceno 0.5",
                    Price = 130,
                    CategoryId = 4,
                    ManufacturerId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Domaca kafa",
                    Price = 110,
                    CategoryId = 3,
                    ManufacturerId = 2
                },
                new Product
                {
                    Id = 4,
                    Name = "Cappuccino",
                    Price = 130,
                    CategoryId = 3,
                    ManufacturerId = 2
                },
                new Product
                {
                    Id = 5,
                    Name = "Budweiser 0.5",
                    Price = 140,
                    CategoryId = 5,
                    ManufacturerId = 3
                },
                new Product
                {
                    Id = 6,
                    Name = "Tuborg 0.5",
                    Price = 140,
                    CategoryId = 5,
                    ManufacturerId = 3
                },
                new Product
                {
                    Id = 7,
                    Name = "Breskva 0.2",
                    Price = 140,
                    CategoryId = 6,
                    ManufacturerId = 3
                },
                new Product
                {
                    Id = 8,
                    Name = "Sumsko voce 0.2",
                    Price = 140,
                    CategoryId = 6,
                    ManufacturerId = 3
                }
            };

            builder.HasData(products);
        }
    }
}