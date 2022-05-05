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
                }                ,
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
        }

        public DbSet<Order> Orders => Set<Order>();

        public DbSet<Category> Categories => Set<Category>();
    }
}
