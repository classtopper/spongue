using System.Threading.Tasks;
using Spongue.Module.Core.Models;
using Spongue.Module.Orders.Models;

namespace Spongue.Module.Orders.Services
{
    public interface IOrderEmailService
    {
        Task SendEmailToUser(User user, Order order);
    }
}
