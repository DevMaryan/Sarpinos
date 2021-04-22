using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using Sarpinos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public List<MenuItem> GetAll()
        {
            return _menuItemRepository.GetAll();
        }

        public MenuItem GetById(int id)
        {
            return _menuItemRepository.GetById(id);
        }

        public MenuItem GetBySlug(string slug)
        {
            return _menuItemRepository.GetBySlug(slug);
        }
    }
}
