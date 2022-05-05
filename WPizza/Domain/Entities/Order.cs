using System.ComponentModel.DataAnnotations.Schema;

namespace WPizza.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalValue { get; set; }
    }
}
