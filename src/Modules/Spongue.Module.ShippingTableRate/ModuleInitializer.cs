using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Spongue.Infrastructure.Modules;
using Spongue.Module.ShippingPrices.Services;
using Spongue.Module.ShippingTableRate.Services;
using Spongue.Infrastructure;

namespace Spongue.Module.ShippingTableRate
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShippingPriceServiceProvider, TableRateShippingServiceProvider>();

            GlobalConfiguration.RegisterAngularModule("spongueAdmin.shipping-tablerate");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
