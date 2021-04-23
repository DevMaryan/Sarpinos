using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using Sarpinos.Services.Interfaces;
using System.Collections.Generic;

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

        public void DeleteOrder(int id)
        {
            Order order = _orderRepository.GetById(id);

            if (order != null)
            {
                _orderRepository.Delete(order);
            }
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void SetProcessed(int id)
        {
            Order order = _orderRepository.GetById(id);

            if (order != null)
            {
                order.Status = OrderStatus.Processed;
                _orderRepository.Update(order);
            }
        }
    }
}
