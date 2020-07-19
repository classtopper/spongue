using Microsoft.AspNetCore.Mvc;
using Spongue.Infrastructure.Web;

namespace Spongue.Module.PaymentCoD.Areas.PaymentCoD.Components
{
    public class CoDLandingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(this.GetViewPath());
        }
    }
}
