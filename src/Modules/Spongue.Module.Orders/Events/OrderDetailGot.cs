using MediatR;
using Spongue.Module.Orders.Areas.Orders.ViewModels;

namespace Spongue.Module.Orders.Events
{
    public class OrderDetailGot : INotification
    {
        public OrderDetailVm OrderDetailVm { get; set; }
    }
}
