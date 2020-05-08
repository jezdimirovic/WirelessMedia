using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Core.Interfaces;

namespace WM.Infrastructure.Data
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplContext applContext) : base(applContext)
        {
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return _context.Product
                .Include(x => x.Category)
                .Include(x => x.Manufacturer)
                .Include(x => x.Supplier)
                .ToListAsync();
        }

        // implementation


    }
}
