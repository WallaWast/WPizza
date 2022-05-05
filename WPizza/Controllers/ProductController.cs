using Microsoft.AspNetCore.Mvc;
using WPizza.Domain.Dto;
using WPizza.Services;

namespace WPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            return await _productService.GetAllProductsAsync();
        }
    }
}