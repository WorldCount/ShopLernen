using System.Collections.Generic;
using ShopLernen.Data.Interfaces;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
