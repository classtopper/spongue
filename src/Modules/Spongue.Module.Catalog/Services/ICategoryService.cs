using System.Threading.Tasks;
using System.Collections.Generic;
using Spongue.Module.Catalog.Areas.Catalog.ViewModels;
using Spongue.Module.Catalog.Models;

namespace Spongue.Module.Catalog.Services
{
    public interface ICategoryService
    {
        Task<IList<CategoryListItem>> GetAll();

        Task Create(Category category);

        Task Update(Category category);

        Task Delete(Category category);
    }
}
