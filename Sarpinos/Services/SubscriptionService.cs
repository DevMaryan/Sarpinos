using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using Sarpinos.Services.Interfaces;

namespace Sarpinos.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository subscriptionRepository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            this.subscriptionRepository = subscriptionRepository;
        }

        public void Create(string email)
        {
            var existingSubscription = subscriptionRepository.GetByEmail(email);

            if (existingSubscription == null)
            {
                var newSubscription = new Subscription()
                {
                    Email = email,
                    DateCreated = DateTime.Now
                };

                subscriptionRepository.Add(newSubscription);
            }
        }
    }
}
