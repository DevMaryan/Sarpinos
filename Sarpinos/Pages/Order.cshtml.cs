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
        private readonly ISubscriptionService _subscriptionService;

        public OrderModel(IOrderService orderService, ISubscriptionService subscriptionService)
        {
            _orderService = orderService;
            _subscriptionService = subscriptionService;
        }

        [BindProperty]
        public OrderViewModel Order { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var newOrder = Order.ToDomainModel();
                _orderService.Create(newOrder);
                return RedirectToPage("Confirmation", "OrderCompleted");
            }
            return Page();
        }


        // Subscription
        public IActionResult OnPostSubscribe(string email)
        {
            _subscriptionService.Create(email);

            return RedirectToPage("Confirmation", "SubscriptionCompleted");
        }
    }
}
