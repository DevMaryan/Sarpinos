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
        public static MenuItemViewModel ToViewModel(this MenuItem entity)
        {
            return new MenuItemViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                Price = entity.Price,
                Currency = entity.Currency,
                Slug = entity.Slug,
            };
        }
    }
}
