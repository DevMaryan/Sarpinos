using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sarpinos.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGetOrderCompleted()
        {
            Message = "Thank you for choosing us. Enjoy your meal!";
        }

        public void OnGetSubscriptionCompleted()
        {
            Message = "Thank you, for your subscription. \nStay tuned for more offers and products";
        }
    }
}
