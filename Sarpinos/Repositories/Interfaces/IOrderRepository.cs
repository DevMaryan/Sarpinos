using Sarpinos.Models;

namespace Sarpinos.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order newOrder);
    }
}
