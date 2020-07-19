using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Spongue.Module.Core.Events;
using Spongue.Module.Core.Extensions;
using Spongue.Module.ProductComparison.Services;

namespace Spongue.Module.ProductComparison.Events
{
    public class UserSignedInHandler : INotificationHandler<UserSignedIn>
    {
        private readonly IWorkContext _workContext;
        private readonly IComparingProductService _comparingService;

        public UserSignedInHandler(IWorkContext workContext, IComparingProductService comparingService)
        {
            _workContext = workContext;
            _comparingService = comparingService;
        }

        public async Task Handle(UserSignedIn user, CancellationToken cancellationToken)
        {
            var guestUser = await _workContext.GetCurrentUser();
            _comparingService.MigrateComparingProduct(guestUser.Id, user.UserId);
        }
    }
}
