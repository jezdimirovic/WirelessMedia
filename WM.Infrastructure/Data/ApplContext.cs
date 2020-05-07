using Microsoft.EntityFrameworkCore;
using WM.Core.Entities;

namespace WM.Infrastructure.Data
{
    public class ApplContext : DbContext
    {
        public ApplContext(DbContextOptions<ApplContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

    }
}
