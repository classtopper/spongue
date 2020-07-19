using Spongue.Module.Inventory.Models;
using System.Threading.Tasks;

namespace Spongue.Module.Inventory.Services
{
    public interface IStockService
    {
        Task AddAllProduct(Warehouse warehouse);

        Task UpdateStock(StockUpdateRequest stockUpdateRequest);
    }
}
