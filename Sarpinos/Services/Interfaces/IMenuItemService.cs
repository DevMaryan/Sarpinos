using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Services.Interfaces
{
    public interface IMenuItemService
    {
        List<MenuItem> GetAll();

        MenuItem GetById(int id);
    }
}
