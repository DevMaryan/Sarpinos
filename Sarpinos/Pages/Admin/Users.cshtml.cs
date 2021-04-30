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
    public class UsersModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public List<ApplicationUser> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public void OnGet()
        {
            Users = _userManager.Users.ToList();
            Roles = _roleManager.Roles.ToList();
        }

        public async Task<IActionResult> OnGetDeleteUser(string userid)
        {
            var user = await _userManager.FindByIdAsync(userid);
            await _userManager.DeleteAsync(user);
            return RedirectToPage();
        }

        public void OnGetUpdateUser(string userId)
        {
            RedirectToPage("UpdateUser", userId);
        }
    }
}
