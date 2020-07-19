using System.Collections.Generic;
using Spongue.Module.Core.Areas.Core.ViewModels;

namespace Spongue.Module.Cms.Areas.Cms.ViewModels
{
    public class SpaceBarWidgetForm : WidgetFormBase
    {
        public IList<SpaceBarWidgetSetting> Items = new List<SpaceBarWidgetSetting>();
    }
}
