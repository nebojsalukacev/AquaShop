using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Repositories
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public SqlProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.Include(p => p.Category);
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> PrefferedProducts =>
                                    context.Products.Where(p => p.IsPrefferedProduct).Include(c => c.Category);
    }
}
