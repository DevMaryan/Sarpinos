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
    public class CreateOfferModel : PageModel
    {
        private readonly IOfferService _offerService;
        public CreateOfferModel(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [BindProperty]
        public OfferViewModel Offer { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var newOffer = Offer.ToDomainModel();
                _offerService.Create(newOffer);
                return RedirectToPage("/Confirmation", "NewOfferCreated");
            }
            return Page();
        }
    }
}
