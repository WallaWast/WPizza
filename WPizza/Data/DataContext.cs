using Microsoft.EntityFrameworkCore;
using WPizza.Domain.Entities;

namespace WPizza.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

        public DbSet<Order> Orders => Set<Order>();
    }
}
