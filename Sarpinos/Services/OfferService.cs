using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sarpinos.Services.Interfaces;
using Sarpinos.Repositories.Interfaces;

namespace Sarpinos.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOffersRepository _offersRepository;

        public OfferService(IOffersRepository offersRepository)
        {
            _offersRepository = offersRepository;
        }

        public List<Offer> GetAllValid()
        {
            return _offersRepository.GetAllValid();
        }
    }
}
