using System.Collections.Generic;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class OrderStatus : BaseOrderStatus
    {
        public OrderStatus() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
