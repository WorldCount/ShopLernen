using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopLernen.Data.Models;

namespace ShopLernen.Data
{
    public static class DbObjects
    {

        public static void Initial(IApplicationBuilder builder)
        {
            AppDbContext context = builder
                .ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            Category[] categories = new[]
            {
                new Category {Name = "Электромобили", Desc = "Современный вид транспорта"},
                new Category {Name = "Классические автомобили", Desc = "Машины с ДВС"},
            };

            if (!context.Categories.Any())
                context.Categories.AddRange(categories);
            else
                categories = context.Categories.ToArray();

            if(!context.Cars.Any())
                context.Cars.AddRange(new Car[]
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
                        Category = categories.First()
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
                        Category = categories.Last()
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
                        Category = categories.Last()
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
                        Category = categories.Last()
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
                        Category = categories.First()
                    },
                });

            context.SaveChanges();
        }
    }
}
