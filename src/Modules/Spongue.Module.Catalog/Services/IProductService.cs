using System.Threading.Tasks;
using Spongue.Module.Catalog.Models;

namespace Spongue.Module.Catalog.Services
{
    public interface IProductService
    {
        void Create(Product product);

        void Update(Product product);

        Task Delete(Product product);
    }
}
