using Sarpinos.Models;
using Sarpinos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Mappings
{
    public static class ViewModelExtensions
    {
        public static Order ToDomainModel(this OrderViewModel viewModel)
        {
            return new Order
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                Phone = viewModel.Phone,
                Address = viewModel.Address,
                Message = viewModel.Message
            };
        }

        public static MenuItem ToDomainModel(this MenuItemViewModel viewModel)
        {
            return new MenuItem
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                ImageUrl = viewModel.ImageUrl,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Currency = viewModel.Currency,
                DateCreated = viewModel.DateCreated,
                Slug = viewModel.Slug,
            };
        }
        public static Offer ToDomainModel(this OfferViewModel viewModel)
        {
            return new Offer
            {
                Title = viewModel.Title,
                ImageUrl = viewModel.ImageUrl,
                Description = viewModel.Description,
                ValidTo = viewModel.ValidTo,
                DateCreated = viewModel.DateCreated,

            };
        }
        public static MenuItem ToDomainModel(this MenuItemUpdateViewModel viewModel)
        {
            return new MenuItem
            {
                Name = viewModel.Name,
                ImageUrl = viewModel.ImageUrl,
                Description = viewModel.Description,
                Price = viewModel.Price,
            };
        }
    }
}


