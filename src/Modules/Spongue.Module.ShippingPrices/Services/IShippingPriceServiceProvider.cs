using System.Threading.Tasks;
using Spongue.Module.Shipping.Models;

namespace Spongue.Module.ShippingPrices.Services
{
    public interface IShippingPriceServiceProvider
    {
        Task<GetShippingPriceResponse> GetShippingPrices(GetShippingPriceRequest request, ShippingProvider provider);
    }
}
