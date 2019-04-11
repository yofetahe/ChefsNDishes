using Microsoft.EntityFrameworkCore;

namespace ChefNDishes.Models
{

    public class ChefNDishesContext : DbContext
    {
        public ChefNDishesContext(DbContextOptions options) : base(options) {}
        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Chef> Chefs { get; set; }
    }


}