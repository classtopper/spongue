using Microsoft.EntityFrameworkCore;
using Spongue.Infrastructure.Data;
using Spongue.Module.Shipments.Models;

namespace Spongue.Module.Shipments.Data
{
    public class ShipmentCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>(s =>
            {
                s.HasOne(x => x.CreatedBy)
               .WithMany()
               .HasForeignKey(x => x.CreatedById)
               .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Shipment>(s =>
            {
                s.HasOne(x => x.Order)
               .WithMany()
               .HasForeignKey(x => x.OrderId)
               .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Shipment>(s =>
            {
                s.HasOne(x => x.Warehouse)
               .WithMany()
               .HasForeignKey(x => x.WarehouseId)
               .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
