using System.Threading.Tasks;

namespace Spongue.Module.Core.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}