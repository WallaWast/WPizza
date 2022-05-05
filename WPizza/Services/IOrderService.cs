using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int productId, int amount, int userId);

        Task<List<Order>> GetAllOrdersAsync();

        Task<Order?> GetOrderByIdAsync(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, decimal value);
    }
}
