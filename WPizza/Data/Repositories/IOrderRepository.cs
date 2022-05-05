using WPizza.Domain.Entities;

namespace WPizza.Data.Repositories
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);

        Task UpdateAsync(Order order);

        Task<List<Order>> GetAllOrdersAsync();

        Task<Order?> GetOrderByIdAsync(int id);

        Task DeleteAsync(Order order);
    }
}
