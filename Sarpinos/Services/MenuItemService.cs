using Sarpinos.Models;
using Sarpinos.Repositories.Interfaces;
using Sarpinos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public void Create(MenuItem newMenuItem)
        {
            newMenuItem.DateCreated = DateTime.Now;


            string the_name = newMenuItem.Name;
            string slug_created = GenerateSlug(the_name);

            var checkIfSlugExists = _menuItemRepository.GetBySlug(slug_created);
            if(checkIfSlugExists == null)
            {
                newMenuItem.Slug = slug_created;
            }
            else
            {
                Guid guid = Guid.NewGuid();
                newMenuItem.Slug = slug_created + "-" + guid;
            }
            newMenuItem.Currency = "USD";
            _menuItemRepository.Create(newMenuItem);
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
        private static string GenerateSlug(string phrase)
        {
            string str = phrase.ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens
            return str;
        }

        public void Delete(MenuItem the_item)
        {
            _menuItemRepository.Delete(the_item);
        }

        public void Update(MenuItem the_item)
        {
            _menuItemRepository.Update(the_item);
        }
    }
}
