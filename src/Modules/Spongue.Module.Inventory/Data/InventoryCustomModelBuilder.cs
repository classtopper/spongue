using Microsoft.EntityFrameworkCore;
using Spongue.Infrastructure.Data;
using Spongue.Module.Inventory.Models;

namespace Spongue.Module.Inventory.Data
{
    public class InventoryCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(new Warehouse(1) { Name = "Default warehouse", AddressId = 1 });
        }
    }
}
