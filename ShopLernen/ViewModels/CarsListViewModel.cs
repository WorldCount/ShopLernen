using System.Collections.Generic;
using ShopLernen.Data.Models;

namespace ShopLernen.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
