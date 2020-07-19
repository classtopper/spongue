using Microsoft.EntityFrameworkCore;
using Spongue.Infrastructure.Data;
using Spongue.Module.Notifications.Models;

namespace Spongue.Module.Notifications.Data
{
    public class NotificationsCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserNotification>().ToTable("Notifications_UserNotification");
        }
    }
}
