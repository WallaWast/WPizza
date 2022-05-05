namespace WPizza.Domain.Dto
{
    public class OrderProductDto
    {
        public ProductDto Product { get; set; } = null!;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
