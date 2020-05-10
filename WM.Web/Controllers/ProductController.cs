using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WM.Web.Interfaces;

namespace WM.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductViewModelService _productService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductViewModelService productService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _productService.GetProductIndexViewModel();
            return View(vm);
        }

        public async Task<IActionResult> Json()
        {
            var vm = await _productService.GetProductIndexViewModelFromJson(_webHostEnvironment.ContentRootPath);
            return View(vm);
        }
    }
}