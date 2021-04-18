using Sarpinos.Models;
using Sarpinos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Mappings
{
    public static class DomainModelExtensions
    {
        public static OfferViewModel ToViewModel(this Offer entity)
        {
            return new OfferViewModel()
            {
                Title = entity.Title,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description,
                ValidTo = entity.ValidTo
            };
        }
    }
}
