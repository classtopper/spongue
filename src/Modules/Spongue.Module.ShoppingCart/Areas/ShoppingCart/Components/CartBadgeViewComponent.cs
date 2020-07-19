using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spongue.Infrastructure.Web;
using Spongue.Module.Core.Extensions;
using Spongue.Module.Core.Services;
using Spongue.Module.ShoppingCart.Areas.ShoppingCart.ViewModels;
using Spongue.Module.ShoppingCart.Services;

namespace Spongue.Module.ShoppingCart.Areas.ShoppingCart.Components
{
    public class CartBadgeViewComponent : ViewComponent
    {
        private ICartService _cartService;
        private IWorkContext _workContext;
        private ICurrencyService _currencyService;

        public CartBadgeViewComponent(ICartService cartService, IWorkContext workContext, ICurrencyService currencyService)
        {
            _cartService = cartService;
            _workContext = workContext;
            _currencyService = currencyService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = await _cartService.GetActiveCartDetails(currentUser.Id);
            if(cart == null)
            {
                cart = new CartVm(_currencyService);
            }
            
            return View(this.GetViewPath(), cart.Items.Count);
        }
    }
}
