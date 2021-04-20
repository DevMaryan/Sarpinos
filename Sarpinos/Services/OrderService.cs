using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using Sarpinos.Services.Interfaces;


namespace Sarpinos.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
           _orderRepository = orderRepository;
        }

        public void Create(Order newOrder)
        {
            _orderRepository.Add(newOrder);
        }
    }
}
