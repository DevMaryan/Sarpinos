using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

        public void Delete(Order order)
        {
            _dbContext.Remove(order);
            _dbContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order order)
        {
            _dbContext.Update(order);
            _dbContext.SaveChanges();
        }
    }
}
