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
    public class MenuItemModel : PageModel
    {
        private readonly IMenuItemService _menuItemService;
        public MenuItemModel(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [BindProperty]
        public MenuItemViewModel MenuItem {get;set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var newMenuItem = MenuItem.ToDomainModel();
                _menuItemService.Create(newMenuItem);
                return RedirectToPage("/Confirmation", "NewItemCreated");
            }
            return Page();
        }
    }
}
