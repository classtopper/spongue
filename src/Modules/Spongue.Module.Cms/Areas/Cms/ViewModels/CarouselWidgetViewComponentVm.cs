using System.Collections.Generic;

namespace Spongue.Module.Cms.Areas.Cms.ViewModels
{
    public class CarouselWidgetViewComponentVm
    {
        public long Id { get; set; }

        public int DataInterval { get; set; } = 3000;

        public IList<CarouselWidgetViewComponentItemVm> Items { get; set; } = new List<CarouselWidgetViewComponentItemVm>();
    }
}
