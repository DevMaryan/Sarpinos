using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Mappings;
using Sarpinos.Services.Interfaces;
using Sarpinos.ViewModels;

namespace Sarpinos.Pages.Admin
{
    public class InKitchen : PageModel
    {
        private readonly IOrderService _orderService;

        public InKitchen(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<OrdersListViewModel> OrdersList { get; set; }

        public void OnGet()
        {
            var orders = _orderService.GetAll().Where(x => x.Status == Models.OrderStatus.Processed);

            OrdersList = orders.Select(x => x.ToOrderListViewModel()).ToList();
        }

    }
}


