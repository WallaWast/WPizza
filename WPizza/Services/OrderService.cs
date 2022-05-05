using WPizza.Data.Repositories;
using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        private readonly IProductRepository _productRepository;

        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _userRepository = userRepository;
        }

        public async Task CreateOrderAsync(int productId, int amount, int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);

            if (user == null)
                return;

            var product = await _productRepository.GetProductByIdAsync(productId);

            if (product == null)
                return;

            var orderProduct = new OrderProduct()
            {
                Price = product.Price * amount,
                Quantity = amount,
                ProductId = productId,
                Product = product
            };

            var order = new Order()
            {
                UserId = user.Id,
                User = user,
                OrderProducts = new List<OrderProduct> { orderProduct },
                TotalValue = orderProduct.Price
            };

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
