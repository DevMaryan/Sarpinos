using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sarpinos.Pages.Admin
{
    public class CreateRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public CreateRoleModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public IdentityRole Roles { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                var newRole = new IdentityRole();
                var theName = Request.Form["Name"];
                newRole.Name = theName;
                newRole.Id = Guid.NewGuid().ToString();
                await _roleManager.CreateAsync(newRole);
                Console.WriteLine($"{newRole.Id} {newRole.Name}");
            }

            return RedirectToPage("Dashboard");
        }
    }
}
