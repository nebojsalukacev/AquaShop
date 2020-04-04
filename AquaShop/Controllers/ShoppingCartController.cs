using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using AquaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ShopingCart shopingCart;
        public ShoppingCartController(IProductRepository productRepository, ShopingCart shopingCart)
        {
            this.productRepository = productRepository;
            this.shopingCart = shopingCart;
        }
        public IActionResult Index()
        {
            var items = shopingCart.GetShoppingCartItems();
            shopingCart.ShoppingCartItems = items;

            var scvm = new ShoppingCartViewModel()
            {
                ShopingCart = shopingCart,
                ShopingCartTotal = shopingCart.GetShoppingCartTotal()
            };
            return View(scvm);
        }
        public RedirectToActionResult AddToShopingCart(int id)
        {
            var selectedProduct = productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == id);

            if (selectedProduct != null)
            {
                shopingCart.AddToCart(selectedProduct, 1);
            }

            return RedirectToAction("Index");

        }
        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedProduct = productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == id);

            if (selectedProduct != null)
            {
                shopingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
