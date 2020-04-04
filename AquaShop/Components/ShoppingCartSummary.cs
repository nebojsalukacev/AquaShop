using AquaShop.Data.Models;
using AquaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShopingCart shopingCart;
        public ShoppingCartSummary(ShopingCart shopingCart)
        {
            this.shopingCart = shopingCart;
        }

        public IViewComponentResult Invoke()
        {
            var item = shopingCart.GetShoppingCartItems();
            shopingCart.ShoppingCartItems = item;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShopingCart = shopingCart,
                ShopingCartTotal = shopingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
