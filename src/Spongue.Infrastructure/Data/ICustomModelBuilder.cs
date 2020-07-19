using Microsoft.EntityFrameworkCore;

namespace Spongue.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
