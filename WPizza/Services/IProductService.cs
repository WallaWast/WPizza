using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product?> GetProductByIdAsync(int id);
    }
}
