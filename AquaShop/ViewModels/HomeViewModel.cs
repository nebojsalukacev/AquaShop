using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> PrefferedProducts { get; set; }
    }
}
