using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Models
{
    public class ShopingCart
    {
        private readonly AppDbContext appDbContext;
        public ShopingCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public string ShopingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShopingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var contex = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShopingCart(contex) { ShopingCartId = cartId };
        }
        public void AddToCart(Product product, int amount)
        {
            var shoppingCartItem = appDbContext.ShoppingCartItems.SingleOrDefault
                (s => s.Product.ProductId == product.ProductId && s.ShopingCartId == ShopingCartId/* && s.Amount == amount*/);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShopingCartId = ShopingCartId,
                    Product = product,
                    Amount = 1
                };
                appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            appDbContext.SaveChanges();

        }
        public int RemoveFromCart(Product product)
        {
            var shopingCartItem = appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Product.ProductId == product.ProductId && s.ShopingCartId == ShopingCartId);

            var localAmount = 0;

            //if (shopingCartItem != null)
            //{
                if (shopingCartItem.Amount > 1)
                {
                    shopingCartItem.Amount--;
                    localAmount = shopingCartItem.Amount;
                }
            //}
            else
            {
                appDbContext.ShoppingCartItems.Remove(shopingCartItem);
            }

            appDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = appDbContext.ShoppingCartItems.Where(s => s.ShopingCartId == ShopingCartId)
                                    .Include(i => i.Product).ToList());
        }
        public void ClearCart()
        {
            var cartItems = appDbContext.ShoppingCartItems.Where(s => s.ShopingCartId == ShopingCartId);

            appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = appDbContext.ShoppingCartItems.Where(s => s.ShopingCartId == ShopingCartId)
                        .Select(s => s.Product.Price * s.Amount).Sum();
            return total;
        }
    }
}
