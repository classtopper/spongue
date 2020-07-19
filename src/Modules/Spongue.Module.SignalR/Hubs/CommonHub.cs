using Microsoft.Extensions.Logging;
using Spongue.Module.Core.Extensions;
using Spongue.Module.SignalR.RealTime;

namespace Spongue.Module.SignalR.Hubs
{
    public class CommonHub : OnlineClientHubBase
    {
        public CommonHub(IWorkContext workContext, IOnlineClientManager onlineClientManager) : base(workContext, onlineClientManager)
        {
        }

        public void Register()
        {
            Logger.LogDebug("A client is registered: " + Context.ConnectionId);
        }
    }
}
