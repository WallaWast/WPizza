using WPizza.Domain.Entities;

namespace WPizza.Data.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);

        Task UpdateAsync(Product product);

        Task<List<Product>> GetAllProductsAsync();

        Task<Product?> GetProductByIdAsync(int id);

        Task DeleteAsync(Product product);
    }
}
