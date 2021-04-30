using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sarpinos.Models;
using Sarpinos.Repositories;

namespace Sarpinos.Pages.Admin
{
    public class OfferListModel : PageModel
    {
        private readonly Sarpinos.Repositories.SarpinosDbContext _context;

        public OfferListModel(Sarpinos.Repositories.SarpinosDbContext context)
        {
            _context = context;
        }

        public IList<Offer> Offer { get;set; }

        public async Task OnGetAsync()
        {
            Offer = await _context.Offers.ToListAsync();
        }
    }
}
