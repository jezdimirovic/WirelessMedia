using System.Collections.Generic;
using System.Threading.Tasks;
using WM.Core.Entities;

namespace WM.Core.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }
}
