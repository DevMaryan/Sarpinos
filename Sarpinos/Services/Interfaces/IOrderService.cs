using Sarpinos.Models;
using System.Collections.Generic;

namespace Sarpinos.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(Order newOrder);
        List<Order> GetAll();
        void SetProcessed(int id);
        void DeleteOrder(int id);
        void SetDone(int id);
    }
}
