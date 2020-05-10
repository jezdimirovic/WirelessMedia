using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WM.Web.Interfaces;
using WM.Web.ViewModels;

namespace WM.Web.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly WM.Core.Interfaces.IProductService _coreService;

        public ProductViewModelService(WM.Core.Interfaces.IProductService coreService)
        {
            _coreService = coreService;
        }

        public async Task<ProductIndexViewModel> GetProductIndexViewModel()
        {
            var products = await _coreService.GetProductsAsync();
            var vm = new ProductIndexViewModel();

            vm.ProductViewModels = products.Select(p => new ProductViewModel { 
                Id = p.Id, 
                Name = p.Name,
                Price = p.Price,
                ManufacturerName = p.Manufacturer?.Name,
                CategoryName = p.Category.Name,
                SupplierName = p.Supplier?.Name
            });

            return vm;
        }

        public async Task<ProductIndexViewModel> GetProductIndexViewModelFromJson(string contentRootPath)
        {
            var file = Path.Combine(contentRootPath, "wwwroot", "data", "data.json");
            var vm = new ProductIndexViewModel();

            if (File.Exists(file))
            {
                using (FileStream fs = File.OpenRead(file))
                {
                    vm.ProductViewModels = await JsonSerializer.DeserializeAsync<List<ProductViewModel>>(fs);
                }
            }

            return vm;
        }
    }
}
