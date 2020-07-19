using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Spongue.Infrastructure;
using Spongue.Infrastructure.Modules;
using Spongue.Module.Cms.Events;
using Spongue.Module.Cms.Services;
using Spongue.Module.Core.Events;

namespace Spongue.Module.Cms
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<EntityDeleting>, EntityDeletingHandler>();
            services.AddTransient<IPageService, PageService>();

            GlobalConfiguration.RegisterAngularModule("spongueAdmin.cms");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
