using Microsoft.EntityFrameworkCore;

namespace FoodOrderAPIWebApp.Models
{
    public class FoodOrderAPIContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuProduct> MenuProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public FoodOrderAPIContext(DbContextOptions<FoodOrderAPIContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
