using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public OrderStatus() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
