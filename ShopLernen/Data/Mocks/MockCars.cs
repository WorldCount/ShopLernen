using System.Collections.Generic;
using System.Linq;
using ShopLernen.Data.Interfaces;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars => new List<Car>
        {
            new Car
                {
                    Name = "Tesla Model S",
                    ShortDesc = "Быстрый автомобиль",
                    LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    Image = "/img/Tesla_Model_S.jpg",
                    Price = 45000,
                    IsFavorite = true,
                    Available = true,
                    Category = _carsCategory.AllCategories.First()
                },
                new Car
                {
                    Name = "Ford Fiesta",
                    ShortDesc = "Тихий и спокойный",
                    LongDesc = "Удобынй автомобиль для городской жизни",
                    Image = "/img/Ford_Fiesta.jpg",
                    Price = 11000,
                    IsFavorite = false,
                    Available = true,
                    Category = _carsCategory.AllCategories.Last()
                },
                new Car
                {
                    Name = "BMW M3",
                    ShortDesc = "Дерзкий и стильный",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Image = "/img/BMW_M3.jpg",
                    Price = 65000,
                    IsFavorite = true,
                    Available = true,
                    Category = _carsCategory.AllCategories.Last()
                },
                new Car
                {
                    Name = "Mercedes C class",
                    ShortDesc = "Уютный и большой",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Image = "/img/Mercedes.jpeg",
                    Price = 40000,
                    IsFavorite = false,
                    Available = false,
                    Category = _carsCategory.AllCategories.Last()
                },
                new Car
                {
                    Name = "Nissan Leaf",
                    ShortDesc = "Бесшумный и экономный",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Image = "/img/Nissan_Leaf.png",
                    Price = 14000,
                    IsFavorite = true,
                    Available = true,
                    Category = _carsCategory.AllCategories.First()
                }
        };

        public IEnumerable<Car> GetFavoriteCars => new List<Car>();

        public Car GetCar(int carId)
        {
            return new Car();
        }
    }
}
