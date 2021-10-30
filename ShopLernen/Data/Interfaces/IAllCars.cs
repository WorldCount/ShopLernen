using System.Collections.Generic;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetFavoriteCars { get; }

        Car GetCar(int carId);
    }
}
