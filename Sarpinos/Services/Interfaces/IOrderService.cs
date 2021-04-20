using Sarpinos.Models;

namespace Sarpinos.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(Order newOrder);
    }
}
