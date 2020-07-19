using Spongue.Infrastructure.Data;
using Spongue.Module.Reviews.Models;
using System.Linq;

namespace Spongue.Module.Reviews.Data
{
    public interface IReplyRepository : IRepository<Reply>
    {
        IQueryable<ReplyListItemDto> List();
    }
}
