using Microsoft.EntityFrameworkCore;
using Spongue.Infrastructure.Data;
using Spongue.Module.Payments.Models;

namespace Spongue.Module.PaymentCoD.Data
{
    public class PaymentCoDCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentProvider>().HasData(
                new PaymentProvider("CoD") { Name = "Cash On Delivery", LandingViewComponentName = "CoDLanding", ConfigureUrl = "payments-cod-config", IsEnabled = true, AdditionalSettings = null }
            );
        }
    }
}
