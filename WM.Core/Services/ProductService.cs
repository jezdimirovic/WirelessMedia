using System.Collections.Generic;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Core.Interfaces;

namespace WM.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }
    }
}
