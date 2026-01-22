using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Spongue.Infrastructure.Modules;
using Spongue.Module.Core;
using Spongue.Module.Core.Events;
using Spongue.Module.Notifications.Data;
using Spongue.Module.Notifications.Events;
using Spongue.Module.Notifications.Jobs;
using Spongue.Module.Notifications.Notifiers;
using Spongue.Module.Notifications.Services;
using Spongue.Module.SignalR.RealTime;
using NotificationPublisherService =
    Spongue.Module.Notifications.Services.INotificationPublisher;
namespace Spongue.Module.Notifications
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationRepository, NotificationRepository>();

            services.AddSingleton<INotificationDefinitionManager, NotificationDefinitionManager>();
            services.AddSingleton<IOnlineClientManager, OnlineClientManager>();
            services.AddSingleton<IRealTimeNotifier, SignalRRealTimeNotifier>();

            services.AddTransient<INotificationDistributer, NotificationDistributer>();
            services.AddTransient<NotificationPublisherService, NotificationPublisher>();
            services.AddTransient<INotificationSubscriptionManager, NotificationSubscriptionManager>();
            services.AddTransient<IUserNotificationManager, UserNotificationManager>();

            services.AddTransient<ITestNotifier, TestNotifier>();
            services.AddTransient<INotificationHandler<UserSignedIn>, UserSignedInHandler>();
            services.AddTransient<NotificationDistributionJob>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.AddSettingDefinitionItems(SettingDefinitions.DefaultItems());
            app.AddNotificationDefinitionItems(NotificationDefinitions.DefaultItems());
        }
    }
}
