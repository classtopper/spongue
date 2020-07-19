using System.Linq;
using Spongue.Module.Catalog.Models;

namespace Spongue.Module.ProductRecentlyViewed.Data
{
    public interface IRecentlyViewedProductRepository
    {
        IQueryable<Product> GetRecentlyViewedProduct(long userId);
    }
}
