using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Spongue.Infrastructure.Data;
using Spongue.Module.Cms.Models;
using Spongue.Module.Core.Events;

namespace Spongue.Module.Cms.Events
{
    public class EntityDeletingHandler : INotificationHandler<EntityDeleting>
    {
        private readonly IRepository<MenuItem> _menuItemRepository;

        public EntityDeletingHandler(IRepository<MenuItem> menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public Task Handle(EntityDeleting notification, CancellationToken cancellationToken)
        {
            var items = _menuItemRepository.Query().Where(x => x.EntityId == notification.EntityId).ToList();
            foreach(var item in items)
            {
                _menuItemRepository.Remove(item);
            }

            return Task.CompletedTask;
        }
    }
}
