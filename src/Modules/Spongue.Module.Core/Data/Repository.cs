using Spongue.Infrastructure.Data;
using Spongue.Infrastructure.Models;

namespace Spongue.Module.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
       where T : class, IEntityWithTypedId<long>
    {
        public Repository(SpongueDbContext context) : base(context)
        {
        }
    }
}
