using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories
{
    public class OffersRepository : IOffersRepository
    {
        private readonly SarpinosDbContext _dbContext;

        public OffersRepository(SarpinosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Offer> GetAllValid()
        {
            return _dbContext.Offers.Where(x => x.ValidTo.Date >= DateTime.Now.Date).ToList();
        }
    }
}
