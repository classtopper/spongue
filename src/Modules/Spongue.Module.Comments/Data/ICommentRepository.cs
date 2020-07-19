using System.Linq;
using Spongue.Infrastructure.Data;
using Spongue.Module.Comments.Models;

namespace Spongue.Module.Comments.Data
{
    public interface ICommentRepository : IRepository<Comment>
    {
        IQueryable<CommentListItemDto> List();
    }
}