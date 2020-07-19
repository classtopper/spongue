using System.Collections.Generic;
using Spongue.Module.ShippingPrices.Services;
using Spongue.Module.ShoppingCart.Areas.ShoppingCart.ViewModels;

namespace Spongue.Module.Orders.Areas.Orders.ViewModels
{
    public class OrderTaxAndShippingPriceVm
    {
        public bool IsProductPriceIncludedTax { get; set; }

        public IList<ShippingPrice> ShippingPrices { get; set; }

        public string SelectedShippingMethodName { get; set; }

        public CartVm Cart { get; set; }
    }
}
