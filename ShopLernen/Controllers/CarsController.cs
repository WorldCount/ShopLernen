using Microsoft.AspNetCore.Mvc;
using ShopLernen.Data.Interfaces;
using ShopLernen.ViewModels;

namespace ShopLernen.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";

            CarsListViewModel carsListViewModel = new CarsListViewModel
            {
                AllCars = _allCars.Cars, CurrentCategory = "Автомобили"
            };

            return View(carsListViewModel);
        }
    }
}
