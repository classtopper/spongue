using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Spongue.Infrastructure.Helpers;
using Spongue.Module.Notifications.Models;

namespace Spongue.Module.Notifications.Areas.Notifications.ViewModels
{
    public class TestNotificationVm
    {
        public string Severity { get; set; }

        public string Message { get; set; }

        public long UserId { get; set; }

        public List<SelectListItem> OnlineUsers { get; set; }

        public List<SelectListItem> Severities { get; set; }

        public TestNotificationVm()
        {
            Severities = EnumHelper.ToDictionary(typeof(NotificationSeverity)).Select(s => new SelectListItem(s.Key.ToString(), s.Value)).ToList();
        }
    }
}
