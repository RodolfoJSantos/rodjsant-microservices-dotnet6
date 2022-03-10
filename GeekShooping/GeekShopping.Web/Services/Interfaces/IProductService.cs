using GeekShopping.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> FindAll();
        Task<ProductViewModel> FindById(long id);
        Task<ProductViewModel> Create(ProductViewModel model);
        Task<ProductViewModel> Update(ProductViewModel model);
        Task<bool> Delete(long id);
    }
}
