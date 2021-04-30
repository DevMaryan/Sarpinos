using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories.Interfaces
{
    public interface IMenuItemRepository
    {
        List<MenuItem> GetAll();

        MenuItem GetById(int id);
        MenuItem GetBySlug(string slug);
        void Create(MenuItem newMenuItem);
        void Delete(MenuItem the_item);
        void Update(MenuItem the_item);
    }
}
