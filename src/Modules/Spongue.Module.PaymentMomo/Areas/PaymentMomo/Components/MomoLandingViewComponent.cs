using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Spongue.Infrastructure.Data;
using Spongue.Infrastructure.Web;
using Spongue.Module.PaymentMomo.Models;
using Spongue.Module.PaymentMomo.ViewModels;
using Spongue.Module.Payments.Models;

namespace Spongue.Module.PaymentMomo.Areas.PaymentMomo.Components
{
    public class MomoLandingViewComponent : ViewComponent
    {
        private readonly IRepositoryWithTypedId<PaymentProvider, string> _paymentProviderRepository;

        public MomoLandingViewComponent(IRepositoryWithTypedId<PaymentProvider, string> paymentProviderRepository)
        {
            _paymentProviderRepository = paymentProviderRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var momoProvider = await _paymentProviderRepository.Query().FirstOrDefaultAsync(x => x.Id == PaymentProviderHelper.MomoPaymentProviderId);
            var momoSetting = JsonConvert.DeserializeObject<MomoPaymentConfigForm>(momoProvider.AdditionalSettings);

            var model = new MomoCheckoutForm();
            model.PaymentFee = momoSetting.PaymentFee;

            return View(this.GetViewPath(), model);
        }
    }
}
