using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShopingCart ShopingCart { get; set; }
        public decimal ShopingCartTotal { get; set; }
    }
}
