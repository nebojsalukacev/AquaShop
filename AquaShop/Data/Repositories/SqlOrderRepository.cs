using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Repositories
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopingCart shoppingCart;
        public SqlOrderRepository(AppDbContext appDbContext, ShopingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            //appDbContext.Orders.Add(order);
            decimal orderTotal = 0;

            var shopingCartItems = shoppingCart.ShoppingCartItems;
            foreach (var item in shopingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    Price = item.Product.Price,
                    ProductId = item.Product.ProductId,
                    OrderId = order.OrderId
                };
                orderTotal += (item.Product.Price * item.Amount);
                appDbContext.OrderDetails.Add(orderDetail);
            }
            order.OrderTotal = orderTotal;

            appDbContext.SaveChanges();
            //return order.OrderId;
        }
    }
}
