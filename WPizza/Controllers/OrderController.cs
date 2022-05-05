using Microsoft.AspNetCore.Mvc;
using WPizza.Domain.Entities;
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
        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderService.GetAllOrdersAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(decimal price)
        {
            var order = new Order()
            {
                TotalValue = price
            };

            await _orderService.CreateOrderAsync(order);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, decimal orderValue)
        {
            await _orderService.UpdateAsync(id, orderValue);
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