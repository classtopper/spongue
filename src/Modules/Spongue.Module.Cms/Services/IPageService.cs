using System.Threading.Tasks;
using Spongue.Module.Cms.Models;

namespace Spongue.Module.Cms.Services
{
    public interface IPageService
    {
        Task Create(Page page);

        Task Update(Page page);

        Task Delete(Page page);
    }
}
