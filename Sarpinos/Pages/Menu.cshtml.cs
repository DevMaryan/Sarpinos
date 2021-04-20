using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Mappings;
using Sarpinos.Models;
using Sarpinos.Services.Interfaces;
using Sarpinos.ViewModels;

namespace Sarpinos.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService _menuItemService;

        public MenuModel(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        public List<MenuItemViewModel> MenuItems { get; set; }

        public void OnGet()
        {
            List<MenuItem> menuItems = _menuItemService.GetAll();
            MenuItems = menuItems.Select(x => x.ToViewModel()).ToList();
        }
    }
}
