using System.Collections.Generic;

namespace Spongue.Module.Catalog.Areas.Catalog.ViewModels
{
    public class SpongueProductWidgetComponentVm
    {
        public long Id { get; set; }

        public string WidgetName { get; set; }

        public SpongueProductWidgetSetting Setting { get; set; }

        public IList<ProductThumbnail> Products { get; set; } = new List<ProductThumbnail>();
    }
}
