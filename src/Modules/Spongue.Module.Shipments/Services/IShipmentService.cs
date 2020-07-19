using System.Collections.Generic;
using System.Threading.Tasks;
using Spongue.Infrastructure;
using Spongue.Module.Shipments.Models;

namespace Spongue.Module.Shipments.Services
{
    public interface IShipmentService
    {
        Task<IList<ShipmentItemVm>> GetShipmentItem(long orderId);

        Task<IList<ShipmentItemVm>> GetItemToShip(long orderId, long warehouseId);

        Task<Result> CreateShipment(Shipment shipment);
    }
}
