using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class OrderStatus : BaseOrderStatus
    {
        public OrderStatus() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
