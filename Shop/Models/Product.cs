using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }=new List<OrderDetail>();
    }
}