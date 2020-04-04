using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Repositories
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;
        public SqlCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Category> GetCategories() => context.Categories;
      
    }
}
