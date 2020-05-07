using WM.Core.Entities;
using WM.Core.Interfaces;

namespace WM.Core.Services
{
    public interface IProductService
    {

    }

    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
