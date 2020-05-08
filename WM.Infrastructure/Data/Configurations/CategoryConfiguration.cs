using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using WM.Core.Entities;

namespace WM.Infrastructure.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(t => t.Id);
            builder
                .Property(t => t.Name)
                .HasMaxLength(50);

            builder
                .Property(t => t.Description)
                .HasMaxLength(255);

            SeedTable(builder);
        }

        private void SeedTable(EntityTypeBuilder<Category> builder)
        {
            List<Category> list = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Drink"
                },
                new Category
                {
                    Id = 2,
                    Name = "Food"
                },
                new Category
                {
                    Id = 3,
                    Name = "Cofee"
                },
                new Category
                {
                    Id = 4,
                    Name = "Beer draft"
                },
                new Category
                {
                    Id = 5,
                    Name = "Beer bottle"
                },
                new Category
                {
                    Id = 6,
                    Name = "Juice"
                }
            };

            builder.HasData(list);
        }
    }
}
