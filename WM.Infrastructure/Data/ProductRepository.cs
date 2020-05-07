using WM.Core.Entities;
using WM.Core.Interfaces;

namespace WM.Infrastructure.Data
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplContext applContext) : base(applContext)
        {
        }

        // implementation
    }
}
