using Microsoft.AspNetCore.Identity;
using Spongue.Infrastructure.Models;
using System.Collections.Generic;

namespace Spongue.Module.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
