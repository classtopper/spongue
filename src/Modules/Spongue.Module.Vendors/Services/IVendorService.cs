using System.Threading.Tasks;
using Spongue.Module.Core.Models;

namespace Spongue.Module.Vendors.Services
{
    public interface IVendorService
    {
        Task Create(Vendor brand);

        Task Update(Vendor brand);

        Task Delete(long id);

        Task Delete(Vendor brand);
    }
}
