using Spongue.Infrastructure.Data;
using Spongue.Module.Reviews.Models;
using System.Linq;

namespace Spongue.Module.Reviews.Data
{
    public interface IReviewRepository : IRepository<Review>
    {
        IQueryable<ReviewListItemDto> List();
    }
}