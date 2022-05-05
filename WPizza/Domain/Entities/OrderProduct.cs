using System.ComponentModel.DataAnnotations.Schema;

namespace WPizza.Domain.Entities
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public Product Product { get; set; } = null!;

        public int ProductId { get; set; }

        public Order Order { get; set; } = null!;

        public int OrderId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
