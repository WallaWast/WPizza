namespace WPizza.Domain.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public CategoryDto Category { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
