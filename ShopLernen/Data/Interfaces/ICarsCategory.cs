using System.Collections.Generic;
using ShopLernen.Data.Models;

namespace ShopLernen.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
