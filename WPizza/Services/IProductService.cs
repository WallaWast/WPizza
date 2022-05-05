using WPizza.Domain.Dto;

namespace WPizza.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();

        Task<ProductDto?> GetProductByIdAsync(int id);
    }
}
