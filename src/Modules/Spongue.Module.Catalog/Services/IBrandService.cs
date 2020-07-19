using System.Threading.Tasks;
using Spongue.Module.Catalog.Models;

namespace Spongue.Module.Catalog.Services
{
    public interface IBrandService
    {
        Task Create(Brand brand);

        Task Update(Brand brand);

        Task Delete(long id);

        Task Delete(Brand brand);
    }
}
