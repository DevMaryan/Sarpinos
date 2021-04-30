using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories.Interfaces
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly SarpinosDbContext _dbContext;

        public MenuItemRepository(SarpinosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(MenuItem newMenuItem)
        {
            _dbContext.MenuItems.Add(newMenuItem);
            _dbContext.SaveChanges();
        }

        public void Delete(MenuItem the_item)
        {
            _dbContext.MenuItems.Remove(the_item);
            _dbContext.SaveChanges();
        }

        public List<MenuItem> GetAll()
        {
            return _dbContext.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return _dbContext.MenuItems.FirstOrDefault(x => x.Id == id);
        }

        public MenuItem GetBySlug(string slug)
        {
            return _dbContext.MenuItems.FirstOrDefault(x => x.Slug == slug);
        }

        public void Update(MenuItem the_item)
        {
            _dbContext.MenuItems.Update(the_item);
            _dbContext.SaveChanges();
        }
    }
}
