using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WM.Web.Interfaces;

namespace WM.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductViewModelService _productService;
        public ProductController(IProductViewModelService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _productService.GetProductIndexViewModel();
            return View(vm);
        }
    }
}