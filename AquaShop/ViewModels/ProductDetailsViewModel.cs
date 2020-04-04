using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        public string PageTitle { get; set; }
    }
}
