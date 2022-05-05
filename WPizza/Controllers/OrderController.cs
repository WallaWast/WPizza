using Microsoft.AspNetCore.Mvc;
using WPizza.Domain.Dto;
using WPizza.Services;

namespace WPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDto>> Get()
        {
            return await _orderService.GetAllOrdersAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(int productId, int amount, int userId)
        {
            await _orderService.CreateOrderAsync(productId, amount, userId);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, int productId, int amount)
        {
            await _orderService.UpdateAsync(id, productId, amount);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _orderService.DeleteAsync(id);
            return Ok();
        }
    }
}