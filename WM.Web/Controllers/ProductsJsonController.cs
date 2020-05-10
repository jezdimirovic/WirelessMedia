using Microsoft.AspNetCore.Mvc;

namespace WM.Web.Controllers
{
    public class ProductsJsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}