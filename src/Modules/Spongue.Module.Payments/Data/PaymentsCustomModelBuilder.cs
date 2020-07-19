using Microsoft.EntityFrameworkCore;
using Spongue.Infrastructure.Data;
using Spongue.Module.Payments.Models;

namespace Spongue.Module.Payments.Data
{
    public class PaymentsCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentProvider>().ToTable("Payments_PaymentProvider");
        }
    }
}
