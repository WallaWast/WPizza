using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(Order order);

        Task<List<Order>> GetAllOrdersAsync();

        Task<Order?> GetOrderByIdAsync(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, decimal value);
    }
}
