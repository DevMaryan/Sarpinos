using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Models;

namespace Sarpinos.Pages.Admin
{
    public class UsersRoles : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersRoles(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public List<IdentityRole> Roles { get; set; }
        public void OnGet()
        {
            Roles = _roleManager.Roles.ToList();
        }


        public async Task<IActionResult> OnGetDeleteRole(string RoleId)
        {
            var role = await _roleManager.FindByIdAsync(RoleId);
            await _roleManager.DeleteAsync(role);

            return RedirectToPage();
        }


    }
}

