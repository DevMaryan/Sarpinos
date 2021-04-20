using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Mappings;
using Sarpinos.Services.Interfaces;
using Sarpinos.ViewModels;

namespace Sarpinos.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService _orderService;

        public OrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public OrderViewModel Order { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var newOrder = Order.ToDomainModel();
            _orderService.Create(newOrder);
        }
    }
}
