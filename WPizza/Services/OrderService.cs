using WPizza.Data.Repositories;
using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task CreateOrderAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var orders = await _orderRepository.GetAllOrdersAsync();

            return orders;
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);

            return order;
        }

        public async Task UpdateAsync(int id, decimal value)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);

            if (order != null)
            {
                order.TotalValue = value;
                await _orderRepository.UpdateAsync(order);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);

            if (order != null)
            {
                await _orderRepository.DeleteAsync(order);
            }
        }

    }
}
