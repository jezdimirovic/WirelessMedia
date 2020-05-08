using System.Threading.Tasks;
using WM.Web.ViewModels;

namespace WM.Web.Interfaces
{
    public interface IProductViewModelService
    {
        Task<ProductIndexViewModel> GetProductIndexViewModel();
    }
}
