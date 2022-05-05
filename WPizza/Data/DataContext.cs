using Microsoft.EntityFrameworkCore;
using WPizza.Domain.Entities;

namespace WPizza.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Pizza"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Vegetarian"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Beverage"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Desserts"
                }
            );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   Name = "Cheese Pizza",
                   CategoryId = 1,
                   Description = "Creamy white garlic sauce, mozzarella, and Freshslice cheddar.",
                   Price = 3
               },
               new Product()
               {
                   Id = 2,
                   Name = "Water (500 ml)",
                   CategoryId = 3,
                   Price = 1.5M
               },
               new Product()
               {
                   Id = 3,
                   Name = "Baklava",
                   CategoryId = 4,
                   Description = "Delicious, rich and sweet filo pastry dessert with nuts.",
                   Price = 3.49M
               },
               new Product()
               {
                   Id = 4,
                   Name = "Coke",
                   CategoryId = 3,
                   Price = 2
               },
               new Product()
               {
                   Id = 5,
                   Name = "Market Salad",
                   CategoryId = 2,
                   Description = "Field greens, quinoa, feta cheese, dried cranberries, beet slaw, strawberries, carrots, balsamic vinaigrette.",
                   Price = 12.7M
               }
               );

            modelBuilder.Entity<User>().HasData(
               new User()
               {
                   Id = 1,
                   Name = "Wallace Torres",
                   Address = "12345 Mains St.",
                   Phone = "+1 222-333-4444"
               },
               new User()
               {
                   Id = 2,
                   Name = "Andreza Carvalho",
                   Address = "12345 Mains St.",
                   Phone = "+1 222-333-5555"
               }
               );
        }

        public DbSet<Order> Orders => Set<Order>();

        public DbSet<Category> Categories => Set<Category>();

        public DbSet<Product> Products => Set<Product>();

        public DbSet<User> Users => Set<User>();
    }
}
