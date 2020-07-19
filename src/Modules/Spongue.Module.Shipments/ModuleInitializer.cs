using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using Spongue.Infrastructure.Modules;
using Spongue.Module.Orders.Events;
using Spongue.Module.Shipments.Events;
using Spongue.Module.Shipments.Services;
using Spongue.Infrastructure;

namespace Spongue.Module.Shipments
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<OrderDetailGot>, OrderDetailGotHandler>();
            services.AddTransient<IShipmentService, ShipmentService>();

            GlobalConfiguration.RegisterAngularModule("spongueAdmin.shipment");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
