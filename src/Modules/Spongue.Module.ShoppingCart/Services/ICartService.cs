using System.Linq;
using System.Threading.Tasks;
using Spongue.Infrastructure;
using Spongue.Module.Pricing.Services;
using Spongue.Module.ShoppingCart.Areas.ShoppingCart.ViewModels;
using Spongue.Module.ShoppingCart.Models;

namespace Spongue.Module.ShoppingCart.Services
{
    public interface ICartService
    {
        Task<Result> AddToCart(long customerId, long productId, int quantity);

        Task<Result> AddToCart(long customerId, long createdById, long productId, int quantity);

        IQueryable<Cart> Query();

        Task<Cart> GetActiveCart(long customerId);

        Task<Cart> GetActiveCart(long customerId, long createdById);

        Task<CartVm> GetActiveCartDetails(long customerId);

        Task<CartVm> GetActiveCartDetails(long customerId, long createdById);

        Task<CouponValidationResult> ApplyCoupon(long cartId, string couponCode);

        Task MigrateCart(long fromUserId, long toUserId);

        Task UnlockCart(Cart cart);
    }
}
