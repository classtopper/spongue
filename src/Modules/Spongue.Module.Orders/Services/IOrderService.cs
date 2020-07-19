using System.Threading.Tasks;
using Spongue.Infrastructure;
using Spongue.Module.Core.Models;
using Spongue.Module.Orders.Areas.Orders.ViewModels;
using Spongue.Module.Orders.Models;

namespace Spongue.Module.Orders.Services
{
    public interface IOrderService
    {
        Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, OrderStatus orderStatus = OrderStatus.New);

        Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, string shippingMethod, Address billingAddress, Address shippingAddress, OrderStatus orderStatus = OrderStatus.New);

        void CancelOrder(Order order);

        Task<decimal> GetTax(long cartId, string countryId, long stateOrProvinceId, string zipCode);

        Task<OrderTaxAndShippingPriceVm> UpdateTaxAndShippingPrices(long cartId, TaxAndShippingPriceRequestVm model);
    }
}
