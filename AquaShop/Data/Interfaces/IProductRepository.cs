using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        public IEnumerable<Product> PrefferedProducts { get; }
    }
}
