using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sarpinos.Models;
using Sarpinos.Repositories;

namespace Sarpinos.Pages.Admin
{
    public class UpdateUserModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly Sarpinos.Repositories.SarpinosDbContext _context;
        public UpdateUserModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SarpinosDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;

        }
        public ApplicationUser theUser { get; set; }
        public IActionResult OnGet(string userId)
        {
            if (userId == null)
            {
                return NotFound();
            }

            var the_User = _context.Users.FirstOrDefault(x => x.Id == userId);

            if (the_User == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPostUpdateUser(string userId)
        {

            //var the_User = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            var the_User = _context.Users.FirstOrDefault(x => x.Id == userId);
            _context.SaveChangesAsync();

            return Page();
        }


    }
}
