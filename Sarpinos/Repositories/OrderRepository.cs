using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;

namespace Sarpinos.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SarpinosDbContext _dbContext;

        public OrderRepository(SarpinosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Order newOrder)
        {
            _dbContext.Orders.Add(newOrder);
            _dbContext.SaveChanges();
        }
    }
}
