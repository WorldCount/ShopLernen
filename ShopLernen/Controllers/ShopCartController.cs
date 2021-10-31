using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopLernen.Data.Interfaces;
using ShopLernen.Data.Models;
using ShopLernen.ViewModels;

namespace ShopLernen.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            _carRepository = carRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            List<ShopCartItem> items = _shopCart.GetShopCartItems();
            _shopCart.ShopCartItems = items;

            ShopCartViewModel model = new ShopCartViewModel { ShopCart = _shopCart };

            return View(model);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            Car car = _carRepository.Cars.FirstOrDefault(c => c.Id == id);

            if(car != null)
                _shopCart.AddToCart(car);
            return RedirectToAction("Index");

        }
    }
}
