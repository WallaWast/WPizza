using Microsoft.EntityFrameworkCore;
using WPizza.Domain.Entities;

namespace WPizza.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order order)
        {
            _context.Orders.Add(order);
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var orders = await _context.Orders
                                        .Include(o => o.User)
                                        .Include(o => o.OrderProducts)
                                        .ThenInclude(op => op.Product)
                                        .ThenInclude(p => p.Category)
                                        .ToListAsync();

            return orders;
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            return order;
        }

        public async Task DeleteAsync(Order order)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
