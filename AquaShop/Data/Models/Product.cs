using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public bool InStock { get; set; }
        public bool IsPrefferedProduct { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
