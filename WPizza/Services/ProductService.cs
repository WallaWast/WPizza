using WPizza.Data.Repositories;
using WPizza.Domain.Dto;

namespace WPizza.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();

            return products.Select(product => new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Category = new CategoryDto()
                {
                    Name = product.Category.Name,
                    Id = product.Category.Id
                },
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price
            }).ToList(); ;
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)
                return null;

            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Category = new CategoryDto()
                {
                    Name = product.Category.Name,
                    Id = product.Category.Id
                },
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price
            };

            return productDto;
        }
    }
}
