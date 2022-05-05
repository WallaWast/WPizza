namespace WPizza.Domain.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }

        public UserDto User { get; set; } = null!;

        public decimal TotalValue { get; set; }

        public List<OrderProductDto> OrderProducts { get; set; } = new List<OrderProductDto>();
    }
}
