using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Spongue.Infrastructure;
using Spongue.Infrastructure.Web;
using Spongue.Module.SampleData.Areas.SampleData.ViewModels;

namespace Spongue.Module.SampleData.Areas.SampleData.Components
{
    public class SampleDataFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var sampleContentFolder = Path.Combine(GlobalConfiguration.ContentRootPath, "Modules", "Spongue.Module.SampleData", "SampleContent");
            var directoryInfo = new DirectoryInfo(sampleContentFolder);
            var industries = directoryInfo.GetDirectories().Select(x => x.Name).ToList();
            var model = new SampleDataOption { AvailableIndustries = industries };
            return View(this.GetViewPath(), model);
        }
    }
}
