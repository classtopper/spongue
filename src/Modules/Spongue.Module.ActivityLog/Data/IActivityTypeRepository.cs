using System.Linq;
using Spongue.Infrastructure.Data;
using Spongue.Module.ActivityLog.Models;

namespace Spongue.Module.ActivityLog.Data
{
    public interface IActivityTypeRepository : IRepository<Activity>
    {
        IQueryable<MostViewEntityDto> List();
    }
}
