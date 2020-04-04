using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly IOrderRepository orderRepository;
        private readonly ShopingCart shopingCart;
        public OrderController(IOrderRepository orderRepository, ShopingCart shopingCart, AppDbContext appDbContext)
        {
            this.orderRepository = orderRepository;
            this.shopingCart = shopingCart;
            this.appDbContext = appDbContext;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Checkout(Order order)
        {
            var ord = new Order();
            TryUpdateModelAsync(ord);

            var item = shopingCart.GetShoppingCartItems();
            shopingCart.ShoppingCartItems = item;

            if (shopingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your shopping cart is empty, add some product first");
            }
            else if (ModelState.IsValid)
            {
                //orderRepository.CreateOrder(order);
                appDbContext.Orders.Add(order);
                appDbContext.SaveChanges();

                orderRepository.CreateOrder(order);
                shopingCart.ClearCart();
                return RedirectToAction("CheckoutComplete", new { id = order.OrderId });
            }

            return View(order);
        }


        public IActionResult CheckoutComplete(int id)
        {
            bool isValid = appDbContext.Orders.Any(o => o.OrderId == id);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
            //ViewBag.CheckoutCompleteMessage = "Thanks for your complete order!";
            //return View();
        }
    }
}
