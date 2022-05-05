using WPizza.Domain.Dto;

namespace WPizza.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int productId, int amount, int userId);

        Task<List<OrderDto>> GetAllOrdersAsync();

        Task<OrderDto?> GetOrderByIdAsync(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, int productId, int amount);
    }
}
