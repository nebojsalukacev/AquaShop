using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
