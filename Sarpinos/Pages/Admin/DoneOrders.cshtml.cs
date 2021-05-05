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
    public class DoneOrders : PageModel
    {
        private readonly IOrderService _orderService;

        public DoneOrders(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<OrdersListViewModel> OrdersList { get; set; }

        public void OnGet()
        {
            var orders = _orderService.GetAll().Where(x => x.Status == Models.OrderStatus.Done);

            OrdersList = orders.Select(x => x.ToOrderListViewModel()).ToList();
        }

        public IActionResult OnGetSetProcessed(int id)
        {
            _orderService.SetProcessed(id);
            return RedirectToPage();
        }
        public IActionResult OnGetSetDone(int id)
        {
            _orderService.SetDone(id);
            return RedirectToPage();
        }
        //var orders = _orderService.GetAll().Where(x => x.Status == Models.OrderStatus.Done);
        public IActionResult OnGetDeleteOrder(int id)
        {
            _orderService.DeleteOrder(id);
            return RedirectToPage();
        }
    }
}