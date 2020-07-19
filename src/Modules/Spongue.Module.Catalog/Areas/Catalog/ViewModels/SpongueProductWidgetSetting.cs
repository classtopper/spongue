using System.Collections.Generic;

namespace Spongue.Module.Catalog.Areas.Catalog.ViewModels
{
    public class SpongueProductWidgetSetting
    {
        public IList<ProductLinkVm> Products { get; set; } = new List<ProductLinkVm>();
    }
}
