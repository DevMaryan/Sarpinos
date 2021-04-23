using Sarpinos.Models;
using System.Collections.Generic;

namespace Sarpinos.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order newOrder);
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
        void Delete(Order order);
    }
}
