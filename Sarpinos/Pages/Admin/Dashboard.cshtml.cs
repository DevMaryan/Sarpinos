using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Services.Interfaces;

namespace Sarpinos.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        private readonly IOrderService _orderService;

        public DashboardModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public object ViewBag { get; private set; }

        public void OnGet()
        {

            int OrdersCount = _orderService.GetAll().Count;
        }
    }
}
