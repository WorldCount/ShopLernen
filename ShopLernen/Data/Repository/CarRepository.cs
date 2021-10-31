using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopLernen.Data.Interfaces;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> Cars => _appDbContext.Cars.Include(c => c.Category);

        public IEnumerable<Car> GetFavoriteCars => 
            _appDbContext.Cars.Where(c => c.IsFavorite).Include(c => c.Category);

        public Car GetCar(int carId) => _appDbContext.Cars.FirstOrDefault(c => c.Id == carId);
    }
}
