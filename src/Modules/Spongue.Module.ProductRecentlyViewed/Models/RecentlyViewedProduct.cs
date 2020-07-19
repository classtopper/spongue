using System;
using Spongue.Infrastructure.Models;

namespace Spongue.Module.ProductRecentlyViewed.Models
{
    public class RecentlyViewedProduct : EntityBase
    {
        public long UserId { get; set; }

        public long ProductId { get; set; }

        public DateTimeOffset LatestViewedOn { get; set; }
    }
}
