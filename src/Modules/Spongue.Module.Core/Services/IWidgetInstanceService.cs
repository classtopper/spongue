using System.Linq;
using Spongue.Module.Core.Models;

namespace Spongue.Module.Core.Services
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
