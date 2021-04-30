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

        public void Create(Offer newOffer)
        {
            _dbContext.Offers.Add(newOffer);
            _dbContext.SaveChanges();
        }

        public List<Offer> GetAllValid()
        {
            return _dbContext.Offers.Where(x => x.ValidTo.Date >= DateTime.Now.Date).ToList();
        }
    }
}
