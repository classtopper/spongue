using System.Collections.Generic;
using Spongue.Module.Core.Models;
using Spongue.Module.Shipping.Models;

namespace Spongue.Module.ShippingPrices.Services
{
    public class GetShippingPriceRequest
    {
        public Address ShippingAddress { get; set; }

        public Address WarehouseAddress { get; set; }

        public IList<ShippingItem> ShippingItem { get; set; } = new List<ShippingItem>();

        public decimal OrderAmount { get; set; }
    }
}
