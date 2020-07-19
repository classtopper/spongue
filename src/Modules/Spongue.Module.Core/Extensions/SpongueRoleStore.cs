using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Spongue.Module.Core.Data;
using Spongue.Module.Core.Models;

namespace Spongue.Module.Core.Extensions
{
    public class SpongueRoleStore: RoleStore<Role, SpongueDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public SpongueRoleStore(SpongueDbContext context) : base(context)
        {
        }
    }
}
