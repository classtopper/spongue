using Spongue.Module.Core.Data;
using Spongue.Module.Core.Models;
using Spongue.Module.Reviews.Models;
using System.Linq;

namespace Spongue.Module.Reviews.Data
{
    public class ReplyRepository : Repository<Reply>, IReplyRepository
    {
        public ReplyRepository(SpongueDbContext context) : base(context)
        {
        }

        public IQueryable<ReplyListItemDto> List()
        {
            var items = from rv in Context.Set<Review>()
                         join e in Context.Set<Entity>()
                         on new { key1 = rv.EntityId, key2 = rv.EntityTypeId } equals new { key1 = e.EntityId, key2 = e.EntityTypeId }
                         join rp in Context.Set<Reply>()
                         on rv.Id equals rp.ReviewId
                         select new ReplyListItemDto
                         {
                             Id = rp.Id,
                             ReplierName = rp.ReplierName,
                             Comment = rp.Comment,
                             Status = rp.Status,
                             CreatedOn = rp.CreatedOn,
                             ReviewTitle = rv.Title,
                             EntityName = e.Name,
                             EntitySlug = e.Slug
                         };

            return items;
        }
    }
}
