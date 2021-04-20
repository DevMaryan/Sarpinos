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
    }
}
