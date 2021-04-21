using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly SarpinosDbContext _dbContext;

        public SubscriptionRepository(SarpinosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Subscription subscription)
        {
            _dbContext.Subscriptions.Add(subscription);
            _dbContext.SaveChanges();
        }

        public Subscription GetByEmail(string email)
        {
            return _dbContext.Subscriptions.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
