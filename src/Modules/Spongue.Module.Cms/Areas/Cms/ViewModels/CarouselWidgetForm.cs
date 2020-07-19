using System.Collections.Generic;
using Spongue.Module.Core.Areas.Core.ViewModels;

namespace Spongue.Module.Cms.Areas.Cms.ViewModels
{
    public class CarouselWidgetForm : WidgetFormBase
    {
        public IList<CarouselWidgetItemForm> Items { get; set; } = new List<CarouselWidgetItemForm>();
    }
}
