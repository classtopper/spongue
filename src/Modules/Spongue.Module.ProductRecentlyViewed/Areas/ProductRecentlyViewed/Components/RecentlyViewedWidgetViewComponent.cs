using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Spongue.Infrastructure.Web;
using Spongue.Module.Core.Areas.Core.ViewModels;
using Spongue.Module.Core.Services;
using Spongue.Module.ProductRecentlyViewed.Areas.ProductRecentlyViewed.ViewModels;

namespace Spongue.Module.ProductRecentlyViewed.Areas.ProductRecentlyViewed.Components
{
    public class RecentlyViewedWidgetViewComponent: ViewComponent
    {
        private IMediaService _mediaService;

        public RecentlyViewedWidgetViewComponent(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new RecentlyViewedWidgetViewComponentVm
            {
                Id = widgetInstance.Id,
                ItemCount = JsonConvert.DeserializeObject<int>(widgetInstance.Data)
            };

            return View(this.GetViewPath(), model);
        }

    }
}
