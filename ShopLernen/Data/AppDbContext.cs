using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopLernen.Data.Models;

namespace ShopLernen.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
