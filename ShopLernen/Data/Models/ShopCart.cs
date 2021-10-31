using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ShopLernen.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShopCartId { get; set; }
        public List<ShopCartItem> ShopCartItems { get; set; }

        public ShopCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public static ShopCart GetShopCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            AppDbContext context = service.GetService<AppDbContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            _appDbContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Car = car,
                Price = car.Price
            });

            _appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return _appDbContext.ShopCartItems
                .Where(s => s.ShopCartId == ShopCartId)
                .Include(s => s.Car)
                .ToList();
        }
    }
}
