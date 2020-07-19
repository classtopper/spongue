using System.Threading.Tasks;
using Spongue.Module.Core.Models;

namespace Spongue.Module.Core.Extensions
{
    public interface IWorkContext
    {
        Task<User> GetCurrentUser();
    }
}
