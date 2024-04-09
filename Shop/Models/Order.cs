namespace Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerID{ get; set; }

        public Customer? Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }=new List<OrderDetail>();
    }
}