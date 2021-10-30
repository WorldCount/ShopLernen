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
                    Image = "https://telecomdaily.ru/upload/img/news/teaser/6012931a3ed77953922664.jpg",
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
                    Image = "https://cdn.motor1.com/images/mgl/28rKM/s3/ford-fiesta-st-2022.jpg",
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
                    Image = "https://kolesa-uploads.ru/-/952e7980-104e-41ca-8160-58f644bc7dcd/bmw-m3-new-front2-mini.jpg",
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
                    Image = "https://www.mercedes-benz.ru/passengercars/mercedes-benz-cars/models/c-class/saloon-w205/explore/offer/_jcr_content/backgroundimage.MQ6.12.20210630223843.jpeg",
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
                    Image = "https://nissan-vidi.com.ua/uploads/media/dc_car_gallery/0002/43/thumb_142929_dc_car_gallery_new_slider.png",
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
