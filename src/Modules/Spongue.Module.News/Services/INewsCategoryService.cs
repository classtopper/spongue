using System.Threading.Tasks;
using Spongue.Module.News.Models;

namespace Spongue.Module.News.Services
{
    public interface INewsCategoryService
    {
        Task Create(NewsCategory category);

        Task Update(NewsCategory category);

        Task Delete(long id);

        Task Delete(NewsCategory category);
    }
}
