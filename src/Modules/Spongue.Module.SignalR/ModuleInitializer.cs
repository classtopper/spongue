using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Spongue.Infrastructure.Modules;
using Spongue.Module.SignalR.Hubs;
using Spongue.Module.SignalR.RealTime;

namespace Spongue.Module.SignalR
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSignalR();
            serviceCollection.AddSingleton<IOnlineClientManager, OnlineClientManager>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSignalR(routes =>
            {
                routes.MapHub<CommonHub>("/signalr");
            });
        }
    }
}
