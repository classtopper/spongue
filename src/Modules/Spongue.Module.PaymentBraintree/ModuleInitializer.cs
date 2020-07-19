using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Spongue.Infrastructure;
using Spongue.Infrastructure.Modules;
using Spongue.Module.PaymentBraintree.Services;

namespace Spongue.Module.PaymentBraintree
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBraintreeConfiguration, BraintreeConfiguration>();

            GlobalConfiguration.RegisterAngularModule("spongueAdmin.paymentBraintree");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
