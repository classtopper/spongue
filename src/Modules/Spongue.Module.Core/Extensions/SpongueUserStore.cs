using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Spongue.Module.Core.Data;
using Spongue.Module.Core.Models;

namespace Spongue.Module.Core.Extensions
{
    public class SpongueUserStore : UserStore<User, Role, SpongueDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>,IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public SpongueUserStore(SpongueDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
