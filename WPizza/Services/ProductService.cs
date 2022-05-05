using WPizza.Data.Repositories;
using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var orders = await _productRepository.GetAllProductsAsync();

            return orders;
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var order = await _productRepository.GetProductByIdAsync(id);

            return order;
        }
    }
}
