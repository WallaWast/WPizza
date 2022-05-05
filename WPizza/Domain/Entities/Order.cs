using System.ComponentModel.DataAnnotations.Schema;

namespace WPizza.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public User? User { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalValue { get; set; }

        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
