using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sarpinos.Services.Interfaces;
using Sarpinos.ViewModels;
using Sarpinos.Mappings;

namespace Sarpinos.Pages.Admin
{
    public class MenuItemListModel : PageModel
    {
        private readonly IMenuItemService _menuService;
        public MenuItemListModel(IMenuItemService menuService)
        {
            _menuService = menuService;
        }
        public List<MenuItemListViewModel> MenuList { get; set; }

        public void OnGet()
        {
            var menu_list = _menuService.GetAll();
            MenuList = menu_list.Select(x => x.ToMenuListViewModel()).ToList();
        }
        public IActionResult OnGetDeleteMenuItem(int itemId)
        {
            var the_item = _menuService.GetById(itemId);
            _menuService.Delete(the_item);
            return RedirectToPage("MenuItemList");
        }
    }
}
