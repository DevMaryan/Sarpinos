using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories.Interfaces
{
    public interface ISubscriptionRepository
    {
        void Add(Subscription subscription);
        Subscription GetByEmail(string email);
    }
}
