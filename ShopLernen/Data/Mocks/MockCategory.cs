using System.Collections.Generic;
using ShopLernen.Data.Interfaces;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {Name = "Электромобили", Desc = "Современный вид транспорта"},
                new Category {Name = "Классические автомобили", Desc = "Машины с ДВС"},
            };
    }
}
